using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    partial class GetDateForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        private MainMenu mainMenu1;

        private DateTimePicker dtpDateSync;

        private Button cmdGetDate;

        private Label lblTitleWindow;

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
			this.dtpDateSync = new System.Windows.Forms.DateTimePicker();
			this.cmdGetDate = new System.Windows.Forms.Button();
			this.lblTitleWindow = new System.Windows.Forms.Label();
			base.SuspendLayout();
			this.dtpDateSync.Location = new System.Drawing.Point(5, 29);
			this.dtpDateSync.Name = "dtpDateSync";
			this.dtpDateSync.Size = new System.Drawing.Size(218, 24);
			this.dtpDateSync.TabIndex = 0;
			this.cmdGetDate.Location = new System.Drawing.Point(62, 63);
			this.cmdGetDate.Name = "cmdGetDate";
			this.cmdGetDate.Size = new System.Drawing.Size(97, 20);
			this.cmdGetDate.TabIndex = 1;
			this.cmdGetDate.Text = "Sincronizar";
			this.cmdGetDate.Click += new System.EventHandler(cmdGetDate_Click);
			this.lblTitleWindow.Location = new System.Drawing.Point(5, 6);
			this.lblTitleWindow.Name = "lblTitleWindow";
			this.lblTitleWindow.Size = new System.Drawing.Size(214, 20);
			this.lblTitleWindow.Text = "Sincronizar a partir de...";
			base.AutoScaleDimensions = new System.Drawing.SizeF(96f, 96f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
			((System.Windows.Forms.Control)this).ClientSize = new System.Drawing.Size(228, 95);
			base.Controls.Add(this.lblTitleWindow);
			base.Controls.Add(this.cmdGetDate);
			base.Controls.Add(this.dtpDateSync);
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "GetDateForm";
			this.Text = "Asistente para sincronizar";
			base.Closing += new System.ComponentModel.CancelEventHandler(GetDateForm_Closing);
			base.ResumeLayout(false);
		}

		#endregion
	}
}