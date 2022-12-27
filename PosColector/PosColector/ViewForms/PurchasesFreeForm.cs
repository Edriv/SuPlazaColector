using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using PosColector.DAO;
using PosColector.Entities;

namespace PosColector.ViewForms
{
    public partial class PurchasesFreeForm : Form
    {
        private List<order_detail> orderDetail;

        private Guid id_compra { get; set; }

        private pedido order { get; set; }

        private articulo item { get; set; }

        public PurchasesFreeForm()
        {
            InitializeComponent();
        }

		private void PurchasesForm_Load(object sender, EventArgs e)
		{
		}

		private void cmdStart_Click(object sender, EventArgs e)
		{
			try
			{
				id_compra = Guid.NewGuid();
				new compraDAO().insert(compraDAO.Purchase.Free, new compra
				{
					id_compra = id_compra,
					fecha_compra = DateTime.Now
				});
				orderDetail = new List<order_detail>();
				cmdAdd.Enabled = true;
				cmdStart.Enabled = false;
				txtBarCode.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
					if (id_compra.Equals(default(Guid)))
					{
						throw new Exception("Debe iniciar la captura");
					}
					item = new articuloDAO().getArticulo(txtBarCode.Text.Trim(), 1);
					if (item == null)
					{
						throw new Exception("El artículo no existe");
					}
					txtDescription.Text = item.descripcion;
					((ListControl)cboUM).DataSource = new articuloDAO().getUnidadesMedida(item.cod_asociado);
					txtCantidad.Focus();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void cmdAdd_Click(object sender, EventArgs e)
		{
			try
			{
				if (cmdAdd.Enabled)
				{
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
					orderDetail.Add(new compra_articuloDAO().insert(new compra_articulo
					{
						id_compra = id_compra,
						item = item,
						cantidad = decimal.Parse(txtCantidad.Text.Trim()),
						precio_compra = item.precio_compra,
						medida = (unidad_articulo)cboUM.SelectedItem
					}));
					showOrderDetail();
					newInput();
				}
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
			txtDescription.Text = "";
			txtCantidad.Text = "";
			((ListControl)cboUM).DataSource = null;
			txtBarCode.Focus();
		}

		private void ResetForm()
		{
			cmdAdd.Enabled = false;
			cmdStart.Enabled = true;
			txtBarCode.Text = "";
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
	}
}
