using System;
using System.ComponentModel;
using System.Windows.Forms;
using PosColector.DAO;

namespace PosColector.ViewForms
{
    public partial class MainForm : Form
    {

		public string msgCatalogos { get; set; }

		public string msgPedidos { get; set; }

		public string msgInventarios { get; set; }

		public static string lastDate { get; set; }

		public MainForm()
        {
            InitializeComponent();
        }

		private void mnuPurchaseOrder_Click(object sender, EventArgs e)
		{
			try
			{
				new PurchasesForm().Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mnuFreePurchase_Click(object sender, EventArgs e)
		{
			try
			{
				new PurchasesFreeForm().Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra abierta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mnuExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void MainForm_Closing(object sender, CancelEventArgs e)
		{
			e.Cancel = MessageBox.Show("Desea salir?", "Compra abierta", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) != DialogResult.Yes;
		}

		private void mnuCaptureInventory_Click(object sender, EventArgs e)
		{
			try
			{
				new InventoryForm().Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra abierta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mnuQueryByPedido_Click(object sender, EventArgs e)
		{
			try
			{
				new ShowPurchasesForm(ShowPurchasesForm.PurchaseMethod.ByOrder).Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compras por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mnuQueryFreePurchase_Click(object sender, EventArgs e)
		{
			try
			{
				new ShowPurchasesForm(ShowPurchasesForm.PurchaseMethod.Free).Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compras Abiertas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void mnuQueryInventory_Click(object sender, EventArgs e)
		{
			try
			{
				new ShowInventoryForm().Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Consultar Inventario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}

		private void tmrNow_Tick(object sender, EventArgs e)
		{
			lblDateTimeNow.Text = DateTime.Now.ToString("dd/MMM/yyyy hh:mm:ss tt");
		}

		private void mnuCatalogos_Click_1(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				SynchronizerDAO synchronizerDAO = new SynchronizerDAO();
				synchronizerDAO.syncProveedores();
				synchronizerDAO.syncUnidades();
				synchronizerDAO.syncArticulos();
				synchronizerDAO.syncUsuarios();
				synchronizerDAO.syncPermisosUsuarios();
				synchronizerDAO = null;
				GC.Collect();
				MessageBox.Show($"Descargó {SynchronizerDAO.count} registro de Catálogos Principales.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Sincronización de Catálogos Principales", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			Cursor.Current = Cursors.Default;
		}

		private void mnuDownload_Click(object sender, EventArgs e)
		{
			lastDate = SynchronizerDAO.getLastChangeDateTimeOrders();
			if (lastDate != null || new GetDateForm("Pedidos").ShowDialog() == DialogResult.Cancel)
			{
				Cursor.Current = Cursors.WaitCursor;
				try
				{
					SynchronizerDAO synchronizerDAO = new SynchronizerDAO();
					synchronizerDAO.syncPedidos(lastDate);
					synchronizerDAO = null;
					GC.Collect();
					MessageBox.Show($"Descargó {SynchronizerDAO.count} registros de Pedidos.");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Sincronización de Pedidos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
				Cursor.Current = Cursors.Default;
			}
		}

		private void mnuUpload_Click(object sender, EventArgs e)
		{
			Cursor.Current = Cursors.WaitCursor;
			try
			{
				SynchronizerDAO synchronizerDAO = new SynchronizerDAO();
				synchronizerDAO.syncCompras();
				synchronizerDAO = null;
				GC.Collect();
				MessageBox.Show($"Subió {SynchronizerDAO.count} registro de Compras.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Sincronización de Compras", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
			Cursor.Current = Cursors.Default;
		}

		private void mnuSyncInventory_Click(object sender, EventArgs e)
		{
			lastDate = SynchronizerDAO.getLastChangeDateTimeInventarios();
			if (lastDate != null || new GetDateForm("Inventarios").ShowDialog() == DialogResult.Cancel)
			{
				Cursor.Current = Cursors.WaitCursor;
				try
				{
					SynchronizerDAO synchronizerDAO = new SynchronizerDAO();
					synchronizerDAO.syncDowloadInventory(lastDate);
					synchronizerDAO = null;
					GC.Collect();
					MessageBox.Show($"Descargó {SynchronizerDAO.count} registro de Inventarios Abiertos.");
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message, "Sincronización de Inventarios Abiertos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				}
				Cursor.Current = Cursors.Default;
			}
		}

		private void mnuLoadInventory_Click(object sender, EventArgs e)
		{
			try
			{
				SynchronizerDAO synchronizerDAO = new SynchronizerDAO();
				synchronizerDAO.syncUploadInventario();
				synchronizerDAO = null;
				GC.Collect();
				MessageBox.Show($"Subió {SynchronizerDAO.count} registro de Inventarios Capturados.");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Sincronización de Inventarios Capturados", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
			}
		}
	}
}
