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
    public partial class ShowPurchasesForm : Form
    {
        public enum PurchaseMethod
        {
            ByOrder,
            Free
        }

        public string option { get; set; }

        public ShowPurchasesForm()
        {
            InitializeComponent();
        }

		public ShowPurchasesForm(PurchaseMethod p)
		{
			InitializeComponent();
			switch (p)
			{
				case PurchaseMethod.ByOrder:
					cboOrder.Visible = true;
					txtProvider.Visible = true;
					label1.Visible = true;
					label2.Visible = true;
					lstOrderDetail.Location.Offset(3, 52);
					lstOrderDetail.Height = 217;
					((ListControl)cboOrder).DataSource = new pedidoDAO().getListPedidosCap();
					option = "Compra por Pedido";
					break;
				case PurchaseMethod.Free:
					cboOrder.Visible = false;
					txtProvider.Visible = false;
					label1.Visible = false;
					label2.Visible = false;
					lstOrderDetail.Location.Offset(3, 27);
					lstOrderDetail.Height = 192;
					mnuDeleteOrder.Enabled = false;
					((ListControl)cboCaptura).DataSource = new compraDAO().getComprasAbiertasCap();
					option = "Compra Abierta";
					break;
			}
		}

		private void PurchasesForm_Load(object sender, EventArgs e)
		{
		}

		private void cboOrder_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cboOrder.SelectedIndex > 0)
				{
					txtProvider.Text = ((pedido)cboOrder.SelectedItem).razon_social;
					((ListControl)cboCaptura).DataSource = new compraDAO().getListComprasCap(((pedido)cboOrder.SelectedItem).id_pedido);
				}
				else
				{
					ResetForm(sender);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void cboCaptura_SelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				if (cboCaptura.SelectedIndex > 0)
				{
					showOrderDetail(((compra)cboCaptura.SelectedItem).id_compra);
				}
				else
				{
					ResetForm(sender);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void showOrderDetail(Guid id_compra)
		{
			try
			{
				lstOrderDetail.Items.Clear();
				List<order_detail> purchaseDetail = new compra_articuloDAO().getPurchaseDetail(id_compra);
				if (purchaseDetail != null)
				{
					foreach (order_detail item in purchaseDetail)
					{
						lstOrderDetail.Items.Add(new ListViewItem(new string[4]
						{
						item.cod_barras,
						item.descripcion,
						item.cant_cja.ToString("G9"),
						item.cant_pza.ToString("G9")
						}));
					}
					return;
				}
				MessageBox.Show("La Captura indicada no tiene artículos", "Consultar Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void ResetForm(object sender)
		{
			ComboBox comboBox = (ComboBox)sender;
			if (comboBox.Name.Equals("cboOrder"))
			{
				txtProvider.Text = "";
				((ListControl)cboCaptura).DataSource = null;
				lstOrderDetail.Items.Clear();
			}
			else
			{
				lstOrderDetail.Items.Clear();
			}
		}

		private void mnuDeleteOrder_Click(object sender, EventArgs e)
		{
			try
			{
				if (cboOrder.SelectedIndex > 0)
				{
					if (MessageBox.Show("Desea eliminar el Pedido?\n\rEsta acción eliminará todas las compras vinculadas", "Consultar Compras por Pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						new pedidoDAO().deleteOrder(((pedido)cboOrder.SelectedValue).id_pedido);
						((ListControl)cboOrder).DataSource = new pedidoDAO().getListPedidosCap();
					}
					return;
				}
				throw new Exception("Debe elegir un Pedido");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mnuDeletePurchase_Click(object sender, EventArgs e)
		{
			try
			{
				if (((ListControl)cboCaptura).DataSource != null)
				{
					if (cboCaptura.SelectedIndex <= 0)
					{
						throw new Exception("Debe elegir una Compra");
					}
					if (MessageBox.Show("Desea eliminar la Compra?", "Consultar " + option, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
					{
						new compraDAO().deletePurchase(((compra)cboCaptura.SelectedValue).id_compra);
						((ListControl)cboCaptura).DataSource = new compraDAO().getComprasAbiertasCap();
					}
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
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
