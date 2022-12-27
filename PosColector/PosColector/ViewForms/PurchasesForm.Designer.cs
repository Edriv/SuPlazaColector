using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class PurchasesForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mnuPurchase;

        private MenuItem mnuQueryPurchase;

        private MenuItem mnuExitPurchase;

        private Panel pnlPurchasesOrder;

        private Button cmdStart;

        private Button cmdAdd;

        private TextBox txtCantidadPedida;

        private TextBox txtBarCode;

        private TextBox txtCantidad;

        private TextBox txtDescription;

        private TextBox txtProvider;

        private ComboBox cboUM;

        private ComboBox cboOrder;

        private Label label4;

        private Label label6;

        private Label label5;

        private Label label3;

        private Label label2;

        private Label label1;

        private ListView lstOrderDetail;

        private ColumnHeader cod_barras;

        private ColumnHeader descripcion;

        private ColumnHeader cant_cja;

        private ColumnHeader cant_pzs;

        private ColumnHeader capture;

        private ComboBox comboBox1;

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
            this.mnuQueryPurchase = new System.Windows.Forms.MenuItem();
            this.mnuExitPurchase = new System.Windows.Forms.MenuItem();
            this.pnlPurchasesOrder = new System.Windows.Forms.Panel();
            this.lstOrderDetail = new System.Windows.Forms.ListView();
            this.cod_barras = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descripcion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_cja = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cant_pzs = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.capture = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.txtCantidadPedida = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtProvider = new System.Windows.Forms.TextBox();
            this.cboUM = new System.Windows.Forms.ComboBox();
            this.cboOrder = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
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
            this.mnuQueryPurchase,
            this.mnuExitPurchase});
            // 
            // mnuQueryPurchase
            // 
            this.mnuQueryPurchase.Index = 0;
            this.mnuQueryPurchase.Text = "Ver";
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
            this.pnlPurchasesOrder.Controls.Add(this.cmdStart);
            this.pnlPurchasesOrder.Controls.Add(this.cmdAdd);
            this.pnlPurchasesOrder.Controls.Add(this.txtCantidadPedida);
            this.pnlPurchasesOrder.Controls.Add(this.txtBarCode);
            this.pnlPurchasesOrder.Controls.Add(this.txtCantidad);
            this.pnlPurchasesOrder.Controls.Add(this.txtDescription);
            this.pnlPurchasesOrder.Controls.Add(this.txtProvider);
            this.pnlPurchasesOrder.Controls.Add(this.cboUM);
            this.pnlPurchasesOrder.Controls.Add(this.cboOrder);
            this.pnlPurchasesOrder.Controls.Add(this.label4);
            this.pnlPurchasesOrder.Controls.Add(this.label6);
            this.pnlPurchasesOrder.Controls.Add(this.label5);
            this.pnlPurchasesOrder.Controls.Add(this.label3);
            this.pnlPurchasesOrder.Controls.Add(this.label2);
            this.pnlPurchasesOrder.Controls.Add(this.label1);
            this.pnlPurchasesOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPurchasesOrder.Location = new System.Drawing.Point(0, 0);
            this.pnlPurchasesOrder.Margin = new System.Windows.Forms.Padding(4);
            this.pnlPurchasesOrder.Name = "pnlPurchasesOrder";
            this.pnlPurchasesOrder.Size = new System.Drawing.Size(958, 683);
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
            this.lstOrderDetail.Location = new System.Drawing.Point(4, 170);
            this.lstOrderDetail.Margin = new System.Windows.Forms.Padding(4);
            this.lstOrderDetail.Name = "lstOrderDetail";
            this.lstOrderDetail.Size = new System.Drawing.Size(346, 187);
            this.lstOrderDetail.TabIndex = 16;
            this.lstOrderDetail.UseCompatibleStateImageBehavior = false;
            this.lstOrderDetail.View = System.Windows.Forms.View.Details;
            // 
            // cod_barras
            // 
            this.cod_barras.Text = "Código";
            this.cod_barras.Width = 58;
            // 
            // descripcion
            // 
            this.descripcion.Text = "Descripción";
            this.descripcion.Width = 108;
            // 
            // cant_cja
            // 
            this.cant_cja.Text = "Cja";
            this.cant_cja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cant_cja.Width = 31;
            // 
            // cant_pzs
            // 
            this.cant_pzs.Text = "Pza";
            this.cant_pzs.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cant_pzs.Width = 31;
            // 
            // capture
            // 
            this.capture.Text = "Captura";
            this.capture.Width = 0;
            // 
            // cmdStart
            // 
            this.cmdStart.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmdStart.Location = new System.Drawing.Point(220, 3);
            this.cmdStart.Margin = new System.Windows.Forms.Padding(4);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.Size = new System.Drawing.Size(130, 32);
            this.cmdStart.TabIndex = 8;
            this.cmdStart.Text = "Iniciar captura";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.Enabled = false;
            this.cmdAdd.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cmdAdd.Location = new System.Drawing.Point(280, 136);
            this.cmdAdd.Margin = new System.Windows.Forms.Padding(4);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(70, 28);
            this.cmdAdd.TabIndex = 8;
            this.cmdAdd.Text = "Anexar";
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // txtCantidadPedida
            // 
            this.txtCantidadPedida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCantidadPedida.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtCantidadPedida.Location = new System.Drawing.Point(272, 70);
            this.txtCantidadPedida.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadPedida.Name = "txtCantidadPedida";
            this.txtCantidadPedida.ReadOnly = true;
            this.txtCantidadPedida.Size = new System.Drawing.Size(78, 27);
            this.txtCantidadPedida.TabIndex = 4;
            // 
            // txtBarCode
            // 
            this.txtBarCode.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtBarCode.Location = new System.Drawing.Point(62, 70);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarCode.MaxLength = 15;
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(132, 27);
            this.txtBarCode.TabIndex = 4;
            this.txtBarCode.TextChanged += new System.EventHandler(this.txtBarCode_TextChanged);
            this.txtBarCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBarCode_KeyDown);
            this.txtBarCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBarCode_KeyPress);
            // 
            // txtCantidad
            // 
            this.txtCantidad.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtCantidad.Location = new System.Drawing.Point(62, 136);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.MaxLength = 7;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(98, 27);
            this.txtCantidad.TabIndex = 4;
            this.txtCantidad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCantidad_KeyDown);
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtDescription.Location = new System.Drawing.Point(62, 104);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(288, 27);
            this.txtDescription.TabIndex = 4;
            // 
            // txtProvider
            // 
            this.txtProvider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtProvider.Font = new System.Drawing.Font("Tahoma", 8F);
            this.txtProvider.Location = new System.Drawing.Point(62, 38);
            this.txtProvider.Margin = new System.Windows.Forms.Padding(4);
            this.txtProvider.Name = "txtProvider";
            this.txtProvider.ReadOnly = true;
            this.txtProvider.Size = new System.Drawing.Size(286, 27);
            this.txtProvider.TabIndex = 4;
            this.txtProvider.TextChanged += new System.EventHandler(this.txtProvider_TextChanged);
            // 
            // cboUM
            // 
            this.cboUM.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboUM.Location = new System.Drawing.Point(166, 136);
            this.cboUM.Margin = new System.Windows.Forms.Padding(4);
            this.cboUM.Name = "cboUM";
            this.cboUM.Size = new System.Drawing.Size(108, 27);
            this.cboUM.TabIndex = 1;
            // 
            // cboOrder
            // 
            this.cboOrder.Font = new System.Drawing.Font("Tahoma", 8F);
            this.cboOrder.Location = new System.Drawing.Point(62, 3);
            this.cboOrder.Margin = new System.Windows.Forms.Padding(4);
            this.cboOrder.Name = "cboOrder";
            this.cboOrder.Size = new System.Drawing.Size(152, 27);
            this.cboOrder.TabIndex = 1;
            this.cboOrder.SelectedIndexChanged += new System.EventHandler(this.cboOrder_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label4.Location = new System.Drawing.Point(196, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 20);
            this.label4.TabIndex = 17;
            this.label4.Text = "Se pidió:";
            this.label4.ParentChanged += new System.EventHandler(this.label4_ParentChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label6.Location = new System.Drawing.Point(10, 138);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cant:";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label5.Location = new System.Drawing.Point(10, 105);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Desc:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "C.B.:";
            this.label3.ParentChanged += new System.EventHandler(this.label3_ParentChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label2.Location = new System.Drawing.Point(10, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Pro:";
            this.label2.ParentChanged += new System.EventHandler(this.label2_ParentChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 8F);
            this.label1.Location = new System.Drawing.Point(10, 4);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 30);
            this.label1.TabIndex = 22;
            this.label1.Text = "Ped:";
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(0, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 28);
            this.comboBox1.TabIndex = 0;
            // 
            // PurchasesForm
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
            this.Name = "PurchasesForm";
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