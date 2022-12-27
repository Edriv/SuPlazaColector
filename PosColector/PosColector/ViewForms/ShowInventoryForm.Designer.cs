using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class ShowInventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mnuPurchase;

        private MenuItem mnuExitPurchase;

        private Panel pnlPurchasesOrder;

        private TextBox txtDescription;

        private Label label5;

        private ListView lstOrderDetail;

        private ColumnHeader cod_barras;

        private ColumnHeader descripcion;

        private ColumnHeader cant_cja;

        private ColumnHeader cant_pzs;

        private ColumnHeader capture;

        private ComboBox comboBox1;

        private Label label1;

        private ComboBox cboInventory;

        private Button cmdDeleteInventory;

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
            this.mnuPurchase = new System.Windows.Forms.MainMenu(this.components);
            this.mnuExitPurchase = new System.Windows.Forms.MenuItem();
            this.pnlPurchasesOrder = new System.Windows.Forms.Panel();
            this.cmdDeleteInventory = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOrderDetail = new System.Windows.Forms.ListView();
            this.cod_barras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_cja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_pzs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboInventory = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlPurchasesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuExitPurchase});
            // 
            // mnuExitPurchase
            // 
            this.mnuExitPurchase.Index = 0;
            this.mnuExitPurchase.Text = "Salir";
            this.mnuExitPurchase.Click += new System.EventHandler(this.mnuExitPurchase_Click);
            // 
            // pnlPurchasesOrder
            // 
            this.pnlPurchasesOrder.Controls.Add(this.cmdDeleteInventory);
            this.pnlPurchasesOrder.Controls.Add(this.label1);
            this.pnlPurchasesOrder.Controls.Add(this.lstOrderDetail);
            this.pnlPurchasesOrder.Controls.Add(this.txtDescription);
            this.pnlPurchasesOrder.Controls.Add(this.cboInventory);
            this.pnlPurchasesOrder.Controls.Add(this.label5);
            this.pnlPurchasesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPurchasesOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchasesOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPurchasesOrder.Name = "pnlPurchasesOrder";
            this.pnlPurchasesOrder.Size = new System.Drawing.Size(957, 682);
            this.pnlPurchasesOrder.TabIndex = 0;
            // 
            // cmdDeleteInventory
            // 
            this.cmdDeleteInventory.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmdDeleteInventory.Location = new System.Drawing.Point(198, 39);
            this.cmdDeleteInventory.Margin = new System.Windows.Forms.Padding(4);
            this.cmdDeleteInventory.Name = "cmdDeleteInventory";
            this.cmdDeleteInventory.Size = new System.Drawing.Size(154, 28);
            this.cmdDeleteInventory.TabIndex = 18;
            this.cmdDeleteInventory.Text = "Eliminar Inventario";
            this.cmdDeleteInventory.Click += new System.EventHandler(this.cmdDeleteInventory_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(8, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Prov:";
            // 
            // lstOrderDetail
            // 
            this.lstOrderDetail.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cod_barras,
            this.descripcion,
            this.cant_cja,
            this.cant_pzs,
            this.capture});
            this.lstOrderDetail.Font = new System.Drawing.Font("Tahoma", 8F);
            this.lstOrderDetail.HideSelection = false;
            this.lstOrderDetail.Location = new System.Drawing.Point(4, 72);
            this.lstOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrderDetail.Name = "lstOrderDetail";
            this.lstOrderDetail.Size = new System.Drawing.Size(348, 286);
            this.lstOrderDetail.TabIndex = 16;
            this.lstOrderDetail.UseCompatibleStateImageBehavior = false;
            this.lstOrderDetail.View = System.Windows.Forms.View.Details;
            // 
            // cod_barras
            // 
            this.cod_barras.Text = "Código";
            this.cod_barras.Width = 80;
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripción";
            this.descripcion.Width = 130;
            // 
            // cant_cja
            // 
            this.cant_cja.Text = "Cja";
            this.cant_cja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cant_cja.Width = 40;
            // 
            // cant_pzs
            // 
            this.cant_pzs.Text = "Pza";
            this.cant_pzs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // capture
            // 
            this.capture.Text = "Captura";
            this.capture.Width = 0;
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtDescription.Location = new System.Drawing.Point(58, 39);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(134, 27);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.Text = "0.00";
            // 
            // cboInventory
            // 
            this.cboInventory.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboInventory.Location = new System.Drawing.Point(58, 4);
            this.cboInventory.Margin = new System.Windows.Forms.Padding(4);
            this.cboInventory.Name = "cboInventory";
            this.cboInventory.Size = new System.Drawing.Size(294, 27);
            this.cboInventory.TabIndex = 4;
            this.cboInventory.SelectedIndexChanged += new System.EventHandler(this.cboInventory_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label5.Location = new System.Drawing.Point(8, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 30);
            this.label5.TabIndex = 20;
            this.label5.Text = "Pzas:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // ShowInventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(957, 682);
            this.Controls.Add(this.pnlPurchasesOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Menu = this.mnuPurchase;
            this.MinimizeBox = false;
            this.Name = "ShowInventoryForm";
            this.Text = "Consultar Inventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Closing += new System.ComponentModel.CancelEventHandler(this.PurchasesForm_Closing);
            this.Load += new System.EventHandler(this.PurchasesForm_Load);
            this.pnlPurchasesOrder.ResumeLayout(false);
            this.pnlPurchasesOrder.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion
	}
}