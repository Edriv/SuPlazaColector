using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class InventoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mnuPurchase;

        private MenuItem mnuExitPurchase;

        private Panel pnlPurchasesOrder;

        private Button cmdStart;

        private Button cmdAdd;

        private TextBox txtBarCode;

        private TextBox txtCantidad;

        private TextBox txtDescription;

        private ComboBox cboUM;

        private Label label6;

        private Label label5;

        private Label label3;

        private ListView lstOrderDetail;

        private ColumnHeader cod_barras;

        private ColumnHeader descripcion;

        private ColumnHeader cant_cja;

        private ColumnHeader cant_pzs;

        private ColumnHeader capture;

        private ComboBox comboBox1;

        private Label label1;

        private ComboBox cboInventory;

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
            this.label1 = new System.Windows.Forms.Label();
            this.lstOrderDetail = new System.Windows.Forms.ListView();
            this.cod_barras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_cja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_pzs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.cboInventory = new System.Windows.Forms.ComboBox();
            this.cboUM = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.pnlPurchasesOrder.Controls.Add(this.label1);
            this.pnlPurchasesOrder.Controls.Add(this.lstOrderDetail);
            this.pnlPurchasesOrder.Controls.Add(this.cmdStart);
            this.pnlPurchasesOrder.Controls.Add(this.cmdAdd);
            this.pnlPurchasesOrder.Controls.Add(this.txtBarCode);
            this.pnlPurchasesOrder.Controls.Add(this.txtCantidad);
            this.pnlPurchasesOrder.Controls.Add(this.txtDescription);
            this.pnlPurchasesOrder.Controls.Add(this.cboInventory);
            this.pnlPurchasesOrder.Controls.Add(this.cboUM);
            this.pnlPurchasesOrder.Controls.Add(this.label6);
            this.pnlPurchasesOrder.Controls.Add(this.label5);
            this.pnlPurchasesOrder.Controls.Add(this.label3);
            this.pnlPurchasesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPurchasesOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchasesOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPurchasesOrder.Name = "pnlPurchasesOrder";
            this.pnlPurchasesOrder.Size = new System.Drawing.Size(958, 683);
            this.pnlPurchasesOrder.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 30);
            this.label1.TabIndex = 0;
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
            this.lstOrderDetail.Location = new System.Drawing.Point(4, 140);
            this.lstOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrderDetail.Name = "lstOrderDetail";
            this.lstOrderDetail.Size = new System.Drawing.Size(346, 217);
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
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmdStart.Location = new System.Drawing.Point(234, 39);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(120, 28);
            this.cmdStart.TabIndex = 8;
            this.cmdStart.Text = "Iniciar captura";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmdAdd.Location = new System.Drawing.Point(272, 105);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(82, 28);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Anexar";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtBarCode.Location = new System.Drawing.Point(56, 39);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarCode.MaxLength = 15;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(174, 27);
            this.txtBarCode.TabIndex = 4;
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtCantidad.Location = new System.Drawing.Point(56, 105);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.MaxLength = 4;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(102, 27);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtDescription.Location = new System.Drawing.Point(56, 72);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(296, 27);
            this.txtDescription.TabIndex = 4;
            // 
            // cboInventory
            // 
            this.cboInventory.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboInventory.Location = new System.Drawing.Point(56, 4);
            this.cboInventory.Margin = new System.Windows.Forms.Padding(4);
            this.cboInventory.Name = "cboInventory";
            this.cboInventory.Size = new System.Drawing.Size(296, 27);
            this.cboInventory.TabIndex = 4;
            // 
            // cboUM
            // 
            this.cboUM.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboUM.Location = new System.Drawing.Point(162, 105);
            this.cboUM.Margin = new System.Windows.Forms.Padding(4);
            this.cboUM.Name = "cboUM";
            this.cboUM.Size = new System.Drawing.Size(106, 27);
            this.cboUM.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label6.Location = new System.Drawing.Point(4, 106);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 30);
            this.label6.TabIndex = 17;
            this.label6.Text = "Cant:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label5.Location = new System.Drawing.Point(4, 74);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 30);
            this.label5.TabIndex = 18;
            this.label5.Text = "Desc:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.Location = new System.Drawing.Point(4, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 19;
            this.label3.Text = "C.B.:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // InventoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(958, 683);
            this.Controls.Add(this.pnlPurchasesOrder);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Menu = this.mnuPurchase;
            this.MinimizeBox = false;
            this.Name = "InventoryForm";
            this.Text = "Inventario";
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