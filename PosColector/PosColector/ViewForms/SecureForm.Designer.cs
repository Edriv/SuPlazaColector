using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class SecureForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mainMenu1;

        private TextBox txtPassword;

        private Label label1;

        private Button cmdAuth;

        private Button cmbCancelar;

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
			this.mainMenu1 = new System.Windows.Forms.MainMenu();
			this.txtPassword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdAuth = new System.Windows.Forms.Button();
			this.cmbCancelar = new System.Windows.Forms.Button();
			base.SuspendLayout();
			this.txtPassword.Location = new System.Drawing.Point(3, 33);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.Size = new System.Drawing.Size(220, 23);
			this.txtPassword.TabIndex = 0;
			this.label1.Location = new System.Drawing.Point(4, 7);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(149, 20);
			this.label1.Text = "Ingrese su contraseña:";
			this.cmdAuth.Location = new System.Drawing.Point(26, 69);
			this.cmdAuth.Name = "cmdAuth";
			this.cmdAuth.Size = new System.Drawing.Size(72, 20);
			this.cmdAuth.TabIndex = 2;
			this.cmdAuth.Text = "Autorizar";
			this.cmdAuth.Click += new System.EventHandler(cmdAuth_Click);
			this.cmbCancelar.Location = new System.Drawing.Point(117, 69);
			this.cmbCancelar.Name = "cmbCancelar";
			this.cmbCancelar.Size = new System.Drawing.Size(72, 20);
			this.cmbCancelar.TabIndex = 2;
			this.cmbCancelar.Text = "Cancelar";
			this.cmbCancelar.Click += new System.EventHandler(cmbCancelar_Click);
			base.AutoScaleDimensions = new System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			((System.Windows.Forms.Control)this).ClientSize = new System.Drawing.Size(226, 101);
			base.ControlBox = false;
			base.Controls.Add(this.cmbCancelar);
			base.Controls.Add(this.cmdAuth);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.txtPassword);
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "SecureForm";
			this.Text = "SecureForm";
			base.ResumeLayout(false);
		}

		#endregion
	}
}