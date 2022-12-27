using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace PosColector.ViewForms
{
    public partial class GetDateForm : Form
    {
		public GetDateForm(string catalogo)
		{
			InitializeComponent();
			lblTitleWindow.Text = $"Sincronizar {catalogo}, a partir de...";
		}

		private void cmdGetDate_Click(object sender, EventArgs e)
		{
			MainForm.lastDate = $"{dtpDateSync.Value.ToShortDateString().ToString()} 00:00:00";
			base.DialogResult = DialogResult.OK;
			Close();
		}

		private void GetDateForm_Closing(object sender, CancelEventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
