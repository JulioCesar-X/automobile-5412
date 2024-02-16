using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormLoginSystem : Form
    {

        //[D11Import("Gdi32.d11", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeftRect,
        //        int nTopRect,
        //        int nRightRect,
        //        int nBottomRect,
        //        int nWidthEllipse,
        //        int nHeightEllipse

        //    );


        public FormLoginSystem()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));


        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnterLogin_Click_1(object sender, EventArgs e)
        {

            //Quando tiver os dados de user e password

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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
