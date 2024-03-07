using System;
using System.Linq;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formManageUsers : Form
    {

        public formManageUsers()
        {
            InitializeComponent();
        }

        private void formManageUsers_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns.Add("Id", "ID");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Password", "Password");

            // Preencha o DataGridView com os dados dos usuários da lista em EmpresaModel
            foreach (var user in EmpresaController.Controlador.Users)
            {
                if (user.UserName != "#admin")
                {
                    dataGridView1.Rows.Add(user.Id, user.Name, user.Password);
                }
            
            }
        }

        private void atualizarDataGridView()
        {
            // Limpa as linhas existentes no DataGridView
            dataGridView1.Rows.Clear();

            foreach (var user in EmpresaController.Controlador.Users)
            {
                if (user.Name != "admin")
                {
                    dataGridView1.Rows.Add(user.Id, user.Name, user.Password);
                }
            }

            
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;
            EmpresaController.Controlador.Users.Add(new User("#", username, password));

            atualizarDataGridView();
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomeParaRemover = textBoxUsernameRemove.Text;
            // Obtém a senha do usuário a ser removido da TextBox
            string senhaParaRemover = textBoxPasswordRemove.Text;

            // Procura o usuário na lista pelo nome
            var usuarioParaRemover = EmpresaController.Controlador.Users.FirstOrDefault(u => u.Name == nomeParaRemover);

            // Verifica se o usuário foi encontrado e se a senha corresponde
            if (usuarioParaRemover != null && usuarioParaRemover.Password == senhaParaRemover)
            {
                // Remove o usuário da lista
                EmpresaController.Controlador.Users.Remove(usuarioParaRemover);
                // Atualize o DataGridView para refletir a lista atualizada de usuários
                atualizarDataGridView();
            }
            else
            {
                MessageBox.Show("Usuário não encontrado ou senha incorreta.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
