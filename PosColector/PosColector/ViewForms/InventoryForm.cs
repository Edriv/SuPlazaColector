using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

using PosColector.DAO;
using PosColector.Entities;

namespace PosColector.ViewForms
{
    public partial class InventoryForm : Form
    {
        private List<inventario_articulo> inventoryDetail;

        private Guid id_captura { get; set; }

        private Guid id_inventario { get; set; }

        private Guid id_proveedor { get; set; }

        private pedido order { get; set; }

        private articulo item { get; set; }

        public InventoryForm()
        {
            InitializeComponent();
        }

		private void PurchasesForm_Load(object sender, EventArgs e)
		{
			((ListControl)cboInventory).DataSource = new inventarioDAO().getInventories();
		}

		private void cmdStart_Click(object sender, EventArgs e)
		{
			try
			{
				if (cboInventory.SelectedIndex != 0)
				{
					id_captura = Guid.NewGuid();
					id_inventario = ((inventario)cboInventory.SelectedItem).id_inventario;
					id_proveedor = ((inventario)cboInventory.SelectedItem).id_proveedor;
					inventoryDetail = new List<inventario_articulo>();
					cmdAdd.Enabled = true;
					cmdStart.Enabled = false;
					txtBarCode.Focus();
					return;
				}
				throw new Exception("Debe elegir un Proveedor");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
						break;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void txtBarCode_KeyPress(object sender, KeyPressEventArgs e)
		{
			try
			{
				if (e.KeyChar == '\r')
				{
					if (id_inventario.Equals(default(Guid)))
					{
						throw new Exception("Debe elegir un Proveedor e iniciar captura");
					}
					item = new articuloDAO().getArticuloByProveedor(txtBarCode.Text.Trim(), id_proveedor);
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
				MessageBox.Show(ex.Message, "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
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
					inventoryDetail.Add(new inventarioDAO().insert(new inventario_articulo
					{
						id_captura = id_captura,
						id_inventario = id_inventario,
						item = item,
						cantidad = decimal.Parse(txtCantidad.Text.Trim()),
						medida = (unidad_articulo)cboUM.SelectedItem
					}));
					showOrderDetail();
					newInput();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void showOrderDetail()
		{
			lstOrderDetail.Items.Clear();
			foreach (inventario_articulo item in inventoryDetail)
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
			id_inventario = default(Guid);
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
					txtCantidad.Text = ((txtCantidad.Text.Trim().Length == 0) ? "-" : Math.Abs(decimal.Parse(txtCantidad.Text) * -1m).ToString("G9"));
					break;
				case Keys.Return:
					cmdAdd_Click(sender, e);
					break;
			}
		}

		private void mnuExitPurchase_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void PurchasesForm_Closing(object sender, CancelEventArgs e)
		{
			if (MessageBox.Show("Desea salir?", "Inventario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
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
