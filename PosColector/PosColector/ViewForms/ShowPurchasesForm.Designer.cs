
using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class ShowPurchasesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mnuPurchase;

        private MenuItem mnuExitPurchase;

        private Panel pnlPurchasesOrder;

        private TextBox txtProvider;

        private ComboBox cboOrder;

        private Label label2;

        private Label label1;

        private ListView lstOrderDetail;

        private ColumnHeader cod_barras;

        private ColumnHeader descripcion;

        private ColumnHeader cant_cja;

        private ColumnHeader cant_pzs;

        private ColumnHeader capture;

        private ComboBox comboBox1;

        private ComboBox cboCaptura;

        private Label label3;

        private MenuItem mnuDelete;

        private MenuItem mnuDeleteOrder;

        private MenuItem mnuDeletePurchase;

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
            this.mnuDelete = new System.Windows.Forms.MenuItem();
            this.mnuDeleteOrder = new System.Windows.Forms.MenuItem();
            this.mnuDeletePurchase = new System.Windows.Forms.MenuItem();
            this.mnuExitPurchase = new System.Windows.Forms.MenuItem();
            this.pnlPurchasesOrder = new System.Windows.Forms.Panel();
            this.lstOrderDetail = new System.Windows.Forms.ListView();
            this.cod_barras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_cja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_pzs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.cboCaptura = new System.Windows.Forms.ComboBox();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pnlPurchasesOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPurchase
            // 
            this.mnuPurchase.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDelete,
            this.mnuExitPurchase});
            // 
            // mnuDelete
            // 
            this.mnuDelete.Index = 0;
            this.mnuDelete.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.mnuDeleteOrder,
            this.mnuDeletePurchase});
            this.mnuDelete.Text = "Eliminar";
            // 
            // mnuDeleteOrder
            // 
            this.mnuDeleteOrder.Index = 0;
            this.mnuDeleteOrder.Text = "Pedido";
            this.mnuDeleteOrder.Click += new System.EventHandler(this.mnuDeleteOrder_Click);
            // 
            // mnuDeletePurchase
            // 
            this.mnuDeletePurchase.Index = 1;
            this.mnuDeletePurchase.Text = "Compra";
            this.mnuDeletePurchase.Click += new System.EventHandler(this.mnuDeletePurchase_Click);
            // 
            // mnuExitPurchase
            // 
            this.mnuExitPurchase.Index = 1;
            this.mnuExitPurchase.Text = "Salir";
            this.mnuExitPurchase.Click += new System.EventHandler(this.mnuExitPurchase_Click);
            // 
            // pnlPurchasesOrder
            // 
            this.pnlPurchasesOrder.Controls.Add(this.lstOrderDetail);
            this.pnlPurchasesOrder.Controls.Add(this.txtProvider);
            this.pnlPurchasesOrder.Controls.Add(this.cboCaptura);
            this.pnlPurchasesOrder.Controls.Add(this.cboOrder);
            this.pnlPurchasesOrder.Controls.Add(this.label3);
            this.pnlPurchasesOrder.Controls.Add(this.label2);
            this.pnlPurchasesOrder.Controls.Add(this.label1);
            this.pnlPurchasesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPurchasesOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchasesOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlPurchasesOrder.Name = "pnlPurchasesOrder";
            this.pnlPurchasesOrder.Size = new System.Drawing.Size(357, 363);
            this.pnlPurchasesOrder.TabIndex = 0;
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
            this.lstOrderDetail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstOrderDetail.Name = "lstOrderDetail";
            this.lstOrderDetail.Size = new System.Drawing.Size(346, 284);
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
            // txtProvider
            // 
            this.txtProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProvider.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtProvider.Location = new System.Drawing.Point(52, 38);
            this.txtProvider.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.ReadOnly = true;
            this.txtProvider.Size = new System.Drawing.Size(300, 27);
            this.txtProvider.TabIndex = 4;
            // 
            // cboCaptura
            // 
            this.cboCaptura.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboCaptura.Location = new System.Drawing.Point(222, 3);
            this.cboCaptura.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboCaptura.Name = "cboCaptura";
            this.cboCaptura.Size = new System.Drawing.Size(132, 27);
            this.cboCaptura.TabIndex = 1;
            this.cboCaptura.SelectedIndexChanged += new System.EventHandler(this.cboCaptura_SelectedIndexChanged);
            // 
            // cboOrder
            // 
            this.cboOrder.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboOrder.Location = new System.Drawing.Point(52, 3);
            this.cboOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(126, 27);
            this.cboOrder.TabIndex = 1;
            this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.cboOrder_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.Location = new System.Drawing.Point(182, 6);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 30);
            this.label3.TabIndex = 17;
            this.label3.Text = "Cap:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "Pro:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ped:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // ShowPurchasesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(357, 363);
            this.Controls.Add(this.pnlPurchasesOrder);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Menu = this.mnuPurchase;
            this.MinimizeBox = false;
            this.Name = "ShowPurchasesForm";
            this.Text = "Compra por Pedido";
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