using System;
using System.Linq;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormGerirUsers : Form
    {

        public FormGerirUsers()
        {
            InitializeComponent();
        }

        private void FormManageUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Password", "Password");

            foreach (var user in EmpresaController.Controlador.Users)
            {
                if (user.UserName != "#admin")
                {
                    dataGridView1.Rows.Add(user.Id, user.Name, user.Password);
                }

            }
        }

        private void AtualizarDataGridView()
        {
            dataGridView1.Rows.Clear();

            foreach (var user in EmpresaController.Controlador.Users)
            {
                if (user.Name != "admin")
                {
                    dataGridView1.Rows.Add(user.Id, user.Name, user.Password);
                }
            }
        }

        private void Btn_add_user_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            EmpresaController.Controlador.Users.Add(new User("#", username, password));

            AtualizarDataGridView();

            textBoxUsername.Clear();
            textBoxPassword.Clear();

        }

        private void Btn_remove_Click(object sender, EventArgs e)
        {
            string nomeParaRemover = textBoxUsernameRemove.Text;
            string senhaParaRemover = textBoxPasswordRemove.Text;

            var usuarioParaRemover = EmpresaController.Controlador.Users.FirstOrDefault(u => u.Name == nomeParaRemover);

            if (usuarioParaRemover != null && usuarioParaRemover.Password == senhaParaRemover)
            {
                EmpresaController.Controlador.Users.Remove(usuarioParaRemover);

                AtualizarDataGridView();
                textBoxUsernameRemove.Clear();
                textBoxPasswordRemove.Clear();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado ou senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
