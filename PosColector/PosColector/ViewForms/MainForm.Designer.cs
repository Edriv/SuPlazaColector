using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mnuMain;

        private MenuItem mnuExit;

        private Label lblDateTimeNow;

        private Timer tmrNow;

        private MenuItem mnuStart;

        private MenuItem mnuPurchases;

        private MenuItem menuItem3;

        private MenuItem mnuSeparate1;

        private MenuItem mnuPurchaseOrder;

        private MenuItem mnuQueryByPedido;

        private MenuItem menuItem2;

        private MenuItem mnuSeparate2;

        private MenuItem mnuFreePurchase;

        private MenuItem mnuQueryFreePurchase;

        private MenuItem menuItem1;

        private MenuItem mnuInventory;

        private MenuItem mnuCaptureInventory;

        private MenuItem mnuQueryInventory;

        private MenuItem mnuSynchronization;

        private MenuItem mnuCatalogos;

        private MenuItem menuItem4;

        private MenuItem mnuDownload;

        private MenuItem mnuUpload;

        private MenuItem menuItem7;

        private MenuItem mnuDownloadInventory;

        private MenuItem mnuLoadInventory;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            this.mnuMain = new System.Windows.Forms.MainMenu(this.components);
            this.mnuStart = new System.Windows.Forms.MenuItem();
            this.mnuPurchases = new System.Windows.Forms.MenuItem();
            this.menuItem3 = new System.Windows.Forms.MenuItem();
            this.mnuSeparate1 = new System.Windows.Forms.MenuItem();
            this.mnuPurchaseOrder = new System.Windows.Forms.MenuItem();
            this.mnuQueryByPedido = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.mnuSeparate2 = new System.Windows.Forms.MenuItem();
            this.mnuFreePurchase = new System.Windows.Forms.MenuItem();
            this.mnuQueryFreePurchase = new System.Windows.Forms.MenuItem();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.mnuInventory = new System.Windows.Forms.MenuItem();
            this.mnuCaptureInventory = new System.Windows.Forms.MenuItem();
            this.mnuQueryInventory = new System.Windows.Forms.MenuItem();
            this.mnuSynchronization = new System.Windows.Forms.MenuItem();
            this.mnuCatalogos = new System.Windows.Forms.MenuItem();
            this.menuItem4 = new System.Windows.Forms.MenuItem();
            this.mnuDownload = new System.Windows.Forms.MenuItem();
            this.mnuUpload = new System.Windows.Forms.MenuItem();
            this.menuItem7 = new System.Windows.Forms.MenuItem();
            this.mnuDownloadInventory = new System.Windows.Forms.MenuItem();
            this.mnuLoadInventory = new System.Windows.Forms.MenuItem();
            this.mnuExit = new System.Windows.Forms.MenuItem();
            this.lblDateTimeNow = new System.Windows.Forms.Label();
            this.tmrNow = new System.Windows.Forms.Timer(this.components);
            this.menuItem5 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuStart,
            this.mnuExit,
            this.menuItem5});
            // 
            // mnuStart
            // 
            this.mnuStart.Index = 0;
            this.mnuStart.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuPurchases,
            this.mnuInventory,
            this.mnuSynchronization});
            this.mnuStart.Text = "Inicio";
            // 
            // mnuPurchases
            // 
            this.mnuPurchases.Index = 0;
            this.mnuPurchases.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem3,
            this.mnuSeparate1,
            this.mnuPurchaseOrder,
            this.mnuQueryByPedido,
            this.menuItem2,
            this.mnuSeparate2,
            this.mnuFreePurchase,
            this.mnuQueryFreePurchase,
            this.menuItem1});
            this.mnuPurchases.Text = "Compras";
            // 
            // menuItem3
            // 
            this.menuItem3.Index = 0;
            this.menuItem3.Text = "-";
            // 
            // mnuSeparate1
            // 
            this.mnuSeparate1.Enabled = false;
            this.mnuSeparate1.Index = 1;
            this.mnuSeparate1.Text = "-- POR PEDIDO --";
            // 
            // mnuPurchaseOrder
            // 
            this.mnuPurchaseOrder.Index = 2;
            this.mnuPurchaseOrder.Text = "Capturar";
            this.mnuPurchaseOrder.Click += new System.EventHandler(this.mnuPurchaseOrder_Click);
            // 
            // mnuQueryByPedido
            // 
            this.mnuQueryByPedido.Index = 3;
            this.mnuQueryByPedido.Text = "Consultar";
            this.mnuQueryByPedido.Click += new System.EventHandler(this.mnuQueryByPedido_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 4;
            this.menuItem2.Text = "-";
            // 
            // mnuSeparate2
            // 
            this.mnuSeparate2.Enabled = false;
            this.mnuSeparate2.Index = 5;
            this.mnuSeparate2.Text = "-- ABIERTA --";
            // 
            // mnuFreePurchase
            // 
            this.mnuFreePurchase.Index = 6;
            this.mnuFreePurchase.Text = "Capturar";
            this.mnuFreePurchase.Click += new System.EventHandler(this.mnuFreePurchase_Click);
            // 
            // mnuQueryFreePurchase
            // 
            this.mnuQueryFreePurchase.Index = 7;
            this.mnuQueryFreePurchase.Text = "Consultar";
            this.mnuQueryFreePurchase.Click += new System.EventHandler(this.mnuQueryFreePurchase_Click);
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 8;
            this.menuItem1.Text = "-";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Index = 1;
            this.mnuInventory.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCaptureInventory,
            this.mnuQueryInventory});
            this.mnuInventory.Text = "Inventario";
            // 
            // mnuCaptureInventory
            // 
            this.mnuCaptureInventory.Index = 0;
            this.mnuCaptureInventory.Text = "Capturar";
            this.mnuCaptureInventory.Click += new System.EventHandler(this.mnuCaptureInventory_Click);
            // 
            // mnuQueryInventory
            // 
            this.mnuQueryInventory.Index = 1;
            this.mnuQueryInventory.Text = "Consultar";
            this.mnuQueryInventory.Click += new System.EventHandler(this.mnuQueryInventory_Click);
            // 
            // mnuSynchronization
            // 
            this.mnuSynchronization.Index = 2;
            this.mnuSynchronization.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuCatalogos,
            this.menuItem4,
            this.mnuDownload,
            this.mnuUpload,
            this.menuItem7,
            this.mnuDownloadInventory,
            this.mnuLoadInventory});
            this.mnuSynchronization.Text = "Sincronizar";
            // 
            // mnuCatalogos
            // 
            this.mnuCatalogos.Index = 0;
            this.mnuCatalogos.Text = "Catálogos Principales";
            this.mnuCatalogos.Click += new System.EventHandler(this.mnuCatalogos_Click_1);
            // 
            // menuItem4
            // 
            this.menuItem4.Index = 1;
            this.menuItem4.Text = "-";
            // 
            // mnuDownload
            // 
            this.mnuDownload.Index = 2;
            this.mnuDownload.Text = "Pedidos";
            this.mnuDownload.Click += new System.EventHandler(this.mnuDownload_Click);
            // 
            // mnuUpload
            // 
            this.mnuUpload.Index = 3;
            this.mnuUpload.Text = "Compras";
            this.mnuUpload.Click += new System.EventHandler(this.mnuUpload_Click);
            // 
            // menuItem7
            // 
            this.menuItem7.Index = 4;
            this.menuItem7.Text = "-";
            // 
            // mnuDownloadInventory
            // 
            this.mnuDownloadInventory.Index = 5;
            this.mnuDownloadInventory.Text = "Inventarios Abiertos";
            this.mnuDownloadInventory.Click += new System.EventHandler(this.mnuSyncInventory_Click);
            // 
            // mnuLoadInventory
            // 
            this.mnuLoadInventory.Index = 6;
            this.mnuLoadInventory.Text = "Inventarios Realizados";
            this.mnuLoadInventory.Click += new System.EventHandler(this.mnuLoadInventory_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Index = 1;
            this.mnuExit.Text = "Salir";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblDateTimeNow
            // 
            this.lblDateTimeNow.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblDateTimeNow.Location = new System.Drawing.Point(3, 221);
            this.lblDateTimeNow.Name = "lblDateTimeNow";
            this.lblDateTimeNow.Size = new System.Drawing.Size(232, 20);
            this.lblDateTimeNow.TabIndex = 0;
            this.lblDateTimeNow.Text = "01/01/2016 01:00:00";
            this.lblDateTimeNow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tmrNow
            // 
            this.tmrNow.Enabled = true;
            this.tmrNow.Interval = 1000;
            this.tmrNow.Tick += new System.EventHandler(this.tmrNow_Tick);
            // 
            // menuItem5
            // 
            this.menuItem5.Index = 2;
            this.menuItem5.Text = "SuPlaza v2";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 455);
            this.Controls.Add(this.lblDateTimeNow);
            this.MaximizeBox = false;
            this.Menu = this.mnuMain;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "POS Colector v3.5 :: Su Plaza de Actopan";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.MainForm_Closing);
            this.ResumeLayout(false);

		}

		#endregion

		private MenuItem menuItem5;
	}
}