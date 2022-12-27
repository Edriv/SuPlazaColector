using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using PosColector.DAO;
using PosColector.Entities;

namespace PosColector.ViewForms
{
    public partial class PurchasesForm : Form
    {
        private List<order_detail> orderDetail;

        private Guid id_compra { get; set; }

        private pedido order { get; set; }

        private articulo item { get; set; }

        public PurchasesForm()
        {
            InitializeComponent();
        }

		private void PurchasesForm_Load(object sender, EventArgs e)
		{
			((ListControl)cboOrder).DataSource = new pedidoDAO().getListPedidosAut();
		}

		private void cmdStart_Click(object sender, EventArgs e)
		{
			try
			{
				if (cboOrder.SelectedIndex == 0)
				{
					throw new Exception("Debe elegir un pedido.");
				}
				id_compra = Guid.NewGuid();
				new compraDAO().insert(compraDAO.Purchase.ByOrder, new compra
				{
					id_compra = id_compra,
					id_pedido = ((pedido)cboOrder.SelectedItem).id_pedido,
					fecha_compra = DateTime.Now,
					id_proveedor = ((pedido)cboOrder.SelectedItem).id_proveedor
				});
				orderDetail = new List<order_detail>();
				cmdAdd.Enabled = true;
				cmdStart.Enabled = false;
				cboOrder.Enabled = false;
				txtBarCode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (cboOrder.SelectedIndex != 0)
			{
				txtProvider.Text = ((pedido)cboOrder.SelectedItem).razon_social;
			}
			else
			{
				ResetForm();
			}
		}

		private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
		{
			try
			{
				switch (e.KeyCode)
				{
					case Keys.F5:
						if (lstOrderDetail.Items.Count > 0)
						{
							txtBarCode.Text = lstOrderDetail.Items[lstOrderDetail.Items.Count - 1].Text;
						}
						break;
					case Keys.F10:
						if (lstOrderDetail.Items.Count <= 0)
						{
							throw new Exception("No hay registros por eliminar");
						}
						new compra_articuloDAO().deleteLastItemPurchase(id_compra);
						orderDetail.RemoveAt(orderDetail.Count - 1);
						lstOrderDetail.Items.RemoveAt(lstOrderDetail.Items.Count - 1);
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (e.KeyChar == '\r')
				{
					if (cboOrder.SelectedIndex == 0)
					{
						throw new Exception("Debe elegir un pedido.");
					}
					_ = id_compra;
					bool flag = 0 == 0;
					order = (pedido)cboOrder.SelectedItem;
					item = new pedido_articuloDAO().getArticuloPedido(txtBarCode.Text.Trim(), order, 1);
					if (item == null)
					{
						throw new Exception("El artículo no existe para el pedido actual");
					}
					if (!(item.cant_pedida > 0m) && MessageBox.Show("El Articulo no fue Pedido. Desea agregarlo?", "Articulo no Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.No)
					{
						txtBarCode.Text = "";
						return;
					}
					unidad_medida unidadMedida = new unidad_medidaDAO().getUnidadMedida(item.cod_asociado);
					txtCantidadPedida.Text = item.por_surtir.ToString("G9") + " " + unidadMedida.descripcion;
					txtDescription.Text = item.descripcion;
					((ListControl)cboUM).DataSource = new pedido_articuloDAO().getUnidadesMedida(item);
					txtCantidad.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				txtBarCode.Text = "";
			}
		}

		private void cmdAdd_Click(object sender, EventArgs e)
		{
			try
			{
				decimal num = 0m;
				decimal num2 = 0m;
				if (!cmdAdd.Enabled)
				{
					return;
				}
				if (item == null)
				{
					txtBarCode.Focus();
					throw new Exception("Debe ingresar un código");
				}
				if (txtCantidad.Text.Trim().Length == 0)
				{
					txtCantidad.Focus();
					throw new Exception("Debe ingresar una cantidad");
				}
				num = decimal.Parse(txtCantidad.Text.Trim());
				num2 = totalPedido(item.cod_barras.Trim(), (unidad_articulo)cboUM.SelectedItem, item);
				if (num > num2)
				{
					if (MessageBox.Show(string.Format("Excedido por {0}. ¿Desea agregar la cantidad?", (num - num2).ToString("G9")), "Excedente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes)
					{
						newInput();
						return;
					}
					if (new SecureForm().ShowDialog() != DialogResult.OK)
					{
						txtCantidad.SelectAll();
						throw new Exception("Cantidad no autorizada");
					}
				}
				orderDetail.Add(new compra_articuloDAO().insertPurchase(new compra_articulo
				{
					id_compra = id_compra,
					item = item,
					cantidad = num,
					precio_compra = item.precio_compra,
					medida = (unidad_articulo)cboUM.SelectedItem
				}));
				showOrderDetail();
				newInput();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void showOrderDetail()
		{
			lstOrderDetail.Items.Clear();
			foreach (order_detail item in orderDetail)
			{
				lstOrderDetail.Items.Add(new ListViewItem(new string[4]
				{
				item.cod_barras,
				item.descripcion,
				item.cant_cja.ToString("G9"),
				item.cant_pza.ToString("G9")
				}));
			}
		}

		private void newInput()
		{
			item = null;
			txtBarCode.Text = "";
			txtCantidadPedida.Text = "";
			txtDescription.Text = "";
			txtCantidad.Text = "";
			((ListControl)cboUM).DataSource = null;
			txtBarCode.Focus();
		}

		private decimal totalPedido(string barCode, unidad_articulo ua, articulo item)
		{
			if (orderDetail.Where((order_detail o) => o.cod_barras.Equals(barCode)).FirstOrDefault() != null)
			{
				return item.por_surtir - (from o in orderDetail
										  where o.cod_barras.Equals(barCode)
										  group o by o.cod_barras into og
										  select new
										  {
											  tot = og.Sum((order_detail o) => o.cant_pza)
										  }).FirstOrDefault().tot / ua.cantidad_um;
			}
			return item.por_surtir;
		}

		private void ResetForm()
		{
			cboOrder.SelectedIndex = 0;
			cmdAdd.Enabled = false;
			cmdStart.Enabled = true;
			cboOrder.Enabled = true;
			txtProvider.Text = "";
			txtBarCode.Text = "";
			txtCantidadPedida.Text = "";
			txtDescription.Text = "";
			txtCantidad.Text = "";
			((ListControl)cboUM).DataSource = null;
			lstOrderDetail.Items.Clear();
			id_compra = default(Guid);
		}

		private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (((ListControl)cboUM).DataSource != null)
			{
				if (((unidad_articulo)cboUM.SelectedItem).descripcion.Equals("Kg") || ((unidad_articulo)cboUM.SelectedItem).descripcion.Equals("Gms"))
				{
					e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != '.' && e.KeyChar != '\b';
				}
				else
				{
					e.Handled = !char.IsNumber(e.KeyChar) && e.KeyChar != '\b';
				}
			}
			else
			{
				e.Handled = true;
			}
		}

		private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyCode)
			{
				case Keys.F1:
					if (txtCantidad.Text.Equals(""))
					{
						txtCantidad.Text = "-";
					}
					else if (txtCantidad.Text.Length > 1)
					{
						txtCantidad.Text = "-" + txtCantidad.Text.Replace("-", "");
					}
					break;
				case Keys.Return:
					cmdAdd_Click(sender, e);
					return;
			}
			txtCantidad.Focus();
			txtCantidad.SelectionStart = txtCantidad.Text.Length;
		}

		private void mnuExitPurchase_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void PurchasesForm_Closing(object sender, CancelEventArgs e)
		{
			if (MessageBox.Show("Desea salir?", "Compra abierta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
			{
				e.Cancel = false;
			}
			else
			{
				e.Cancel = true;
			}
		}

		private void label2_ParentChanged(object sender, EventArgs e)
		{
		}

		private void txtProvider_TextChanged(object sender, EventArgs e)
		{
		}

		private void label3_ParentChanged(object sender, EventArgs e)
		{
		}

		private void txtBarCode_TextChanged(object sender, EventArgs e)
		{
		}

		private void label4_ParentChanged(object sender, EventArgs e)
		{
		}
	}
}
