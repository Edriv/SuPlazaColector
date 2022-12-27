using System;
using System.Windows.Forms;

using PosColector.DAO;

namespace PosColector.ViewForms
{
    public partial class SecureForm : Form
    {
        public SecureForm()
        {
            InitializeComponent();
        }

		private void cmdAuth_Click(object sender, EventArgs e)
		{
			try
			{
				if (txtPassword.Text.Trim().Length == 0)
				{
					txtPassword.Focus();
					throw new Exception("Debe ingresar el password");
				}
				if (new usuarioDAO().AuthorizerUser(txtPassword.Text.Trim()))
				{
					base.DialogResult = DialogResult.OK;
					Close();
					return;
				}
				throw new Exception("La constraseña no es valida");
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Compra por Pedido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
				txtPassword.SelectAll();
			}
		}

		private void cmbCancelar_Click(object sender, EventArgs e)
		{
			base.DialogResult = DialogResult.Cancel;
			Close();
		}
	}
}
