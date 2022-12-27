using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using PosColector.DAO;
using PosColector.Entities;

namespace PosColector.ViewForms
{
    public partial class ShowInventoryForm : Form
    {
        private List<inventario_articulo> inventoryDetail;

        public ShowInventoryForm()
        {
            InitializeComponent();
        }

		private void PurchasesForm_Load(object sender, EventArgs e)
		{
			((ListControl)cboInventory).DataSource = new inventarioDAO().getInventories();
		}

		private void cboInventory_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cboInventory.SelectedIndex > 0)
				{
					inventoryDetail = new inventarioDAO().getInventoryDetail(((inventario)cboInventory.SelectedItem).id_inventario);
					if (inventoryDetail == null)
					{
						throw new Exception("No hay registros para éste Inventario");
					}
					showDetail();
				}
				else
				{
					ResetForm();
				}
				cmdDeleteInventory.Enabled = cboInventory.SelectedIndex > 0;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void showDetail()
		{
			lstOrderDetail.Items.Clear();
			decimal num = 0.0m;
			foreach (inventario_articulo item in inventoryDetail)
			{
				lstOrderDetail.Items.Add(new ListViewItem(new string[4]
				{
				item.cod_barras,
				item.descripcion,
				item.cant_cja.ToString("G9"),
				item.cant_pza.ToString("G9")
				}));
				num += item.cant_pza;
			}
			txtDescription.Text = num.ToString("F2");
		}

		private void ResetForm()
		{
			txtDescription.Text = "0.00";
			lstOrderDetail.Items.Clear();
			inventoryDetail = null;
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

		private void cmdDeleteInventory_Click(object sender, EventArgs e)
		{
			try
			{
				if (cboInventory.SelectedIndex > 0 && MessageBox.Show("Desea eliminar el inventario?", "Inventarios", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
				{
					new inventarioDAO().deleteInventory(((inventario)cboInventory.SelectedItem).id_inventario);
					((ListControl)cboInventory).DataSource = new inventarioDAO().getInventories();
					ResetForm();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Eliminación de Inventarios", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}
	}
}
