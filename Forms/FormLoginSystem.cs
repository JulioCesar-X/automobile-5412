using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormSistemaLogin : Form
    {
        public FormSistemaLogin()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnEnterLogin_Click_1(object sender, EventArgs e)
        {

            string username = tb_username.Text;
            string password = tb_password.Text;

            if (EmpresaController.ValidarLogin(username, password))
            {
                EmpresaController.userLogado = username;

                FormPainelControlo formPainelControlo = new FormPainelControlo();
                this.Hide();

                formPainelControlo.FormClosed += (s, args) => this.Close();
                formPainelControlo.Show();

            }
            else
            {
                return;
            }

        }

        private void Tb_username_Enter(object sender, EventArgs e)
        {
            tb_username.Clear();
        }

        private void Tb_password_Enter(object sender, EventArgs e)
        {
            tb_password.Clear();
        }

    }
}
