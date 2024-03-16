using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormGerirDados : Form
    {
        public FormGerirDados()
        {
            InitializeComponent();
        }

        private void Btn_open_file_explorer_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog
            {
                Description = "Selecionar pasta",
                RootFolder = Environment.SpecialFolder.MyComputer
            };

            DialogResult result = folderBrowserDialog.ShowDialog();


            if (result == DialogResult.OK)
            {

                string pastaSelecionada = folderBrowserDialog.SelectedPath;

                MessageBox.Show("Pasta selecionada: " + pastaSelecionada, "Pasta selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            tb_path_export.Text = folderBrowserDialog.SelectedPath;
        }

        private void Btn_open_import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parte ainda não implementada .... (Em construção)");
            //OpenFileDialog openFileDialog = new OpenFileDialog();

            //// Define as propriedades do OpenFileDialog
            //openFileDialog.Filter = "Arquivos CSV|*.csv"; // Especifica o filtro para arquivos CSV
            //openFileDialog.Title = "Selecionar arquivo CSV para abrir";
            //openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer); // Define o diretório inicial (neste caso, a pasta Documentos do usuário)
            //openFileDialog.Multiselect = false; // Define que apenas um arquivo pode ser selecionado

            //// Abre a janela do OpenFileDialog e aguarda o usuário selecionar o arquivo
            //DialogResult result = openFileDialog.ShowDialog();

            //// Se o usuário clicar em "OK" na janela do OpenFileDialog
            //if (result == DialogResult.OK)
            //{
            //    // Obtém o caminho completo do arquivo selecionado pelo usuário
            //    string caminhoArquivo = openFileDialog.FileName;

            //    // Verifica se o arquivo selecionado é vazio
            //    if (new FileInfo(caminhoArquivo).Length == 0)
            //    {
            //        MessageBox.Show("O arquivo selecionado está vazio.", "Arquivo vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    }
            //    else
            //    {
            //        MessageBox.Show("Arquivo CSV selecionado: " + caminhoArquivo, "Arquivo selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        tb_path_import.Text = openFileDialog.FileName;
            //    }
            //}

            //// Libera os recursos do OpenFileDialog
            //openFileDialog.Dispose();


        }

        private void Btn_import_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Parte ainda não implementada .... (Em construção)");
            //// Verifica se o usuário selecionou uma pasta para salvar os arquivos CSV
            //string caminho = tb_path_import.Text;

            //if (!string.IsNullOrWhiteSpace(caminho))
            //{
            //    var (resultado, erro, dados) = EmpresaController.ImportarDoCsv(caminho);

            //    if (resultado == "Dados carregados com sucesso.")
            //    {
            //        MessageBox.Show(resultado, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //    else
            //    {
            //        // Exibir o formulário de tratamento de erro com as informações relevantes
            //        FormTratamentoErro formTratamentoErro = new FormTratamentoErro(caminho, resultado, erro, dados);

            //        // Centralizar o formulário
            //        formTratamentoErro.StartPosition = FormStartPosition.CenterParent;

            //        // Exibir o formulário de tratamento de erro como um diálogo
            //        formTratamentoErro.ShowDialog(this);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Por favor, selecione um arquivo CSV para carregar os seus dados.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }


        private void Btn_export_Click(object sender, EventArgs e)
        {

            string caminho = tb_path_export.Text;

            if (!string.IsNullOrWhiteSpace(caminho))
            {
                EmpresaController.ExportarParaCsv(caminho);
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma pasta para salvar os arquivos CSV.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }


}


