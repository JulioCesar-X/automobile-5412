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
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Define as propriedades do FolderBrowserDialog
                folderBrowserDialog.Description = "Selecionar pasta para salvar o arquivo";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Define o diretório raiz (por exemplo, Computador)

                DialogResult result = folderBrowserDialog.ShowDialog();

                // Se o usuário clicar em "OK" na janela do FolderBrowserDialog
                if (result == DialogResult.OK)
                {

                    string pastaSelecionada = folderBrowserDialog.SelectedPath;


                    MessageBox.Show("Pasta selecionada: " + pastaSelecionada, "Pasta selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tb_path_export.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void Btn_open_import_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Define as propriedades do OpenFileDialog
                openFileDialog.Filter = "Arquivos do Excel|*.xlsx;*.xls|Todos os arquivos|*.*"; // Especifica o filtro para arquivos do Excel, permitindo .xlsx e .xls
                openFileDialog.Title = "Selecionar arquivo do Excel para abrir";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Define o diretório inicial (neste caso, a pasta Documentos do usuário)

                // Abre a janela do OpenFileDialog e aguarda o usuário selecionar o arquivo
                DialogResult result = openFileDialog.ShowDialog();

                // Se o usuário clicar em "OK" na janela do OpenFileDialog
                if (result == DialogResult.OK)
                {
                    // Obtém o caminho completo do arquivo selecionado pelo usuário
                    string caminhoArquivo = openFileDialog.FileName;

                    // Agora você pode usar o caminho do arquivo para abrir e ler o conteúdo do arquivo, ou realizar qualquer outra operação desejada
                    // Por exemplo, para abrir o arquivo no Excel:
                    // System.Diagnostics.Process.Start("excel.exe", "\"" + caminhoArquivo + "\"");

                    MessageBox.Show("Arquivo do Excel selecionado: " + caminhoArquivo, "Arquivo selecionado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                tb_path_import.Text = openFileDialog.FileName;
            }
        }

        private void Btn_import_Click(object sender, EventArgs e)
        {

        }


        private void Btn_export_Click(object sender, EventArgs e)
        {
            // Verifica se o usuário selecionou uma pasta para salvar os arquivos CSV
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


