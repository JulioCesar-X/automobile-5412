using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formManageFiles : Form
    {
        public formManageFiles()
        {
            InitializeComponent();
        }

        private void btn_open_file_explorer_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                // Define as propriedades do FolderBrowserDialog
                folderBrowserDialog.Description = "Selecionar pasta para salvar o arquivo";
                folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer; // Define o diretório raiz (por exemplo, Computador)

                // Abre a janela do FolderBrowserDialog e aguarda o usuário selecionar a pasta
                DialogResult result = folderBrowserDialog.ShowDialog();

                // Se o usuário clicar em "OK" na janela do FolderBrowserDialog
                if (result == DialogResult.OK)
                {
                    // Obtém o caminho da pasta selecionada pelo usuário
                    string pastaSelecionada = folderBrowserDialog.SelectedPath;

                    // Agora você pode usar o caminho da pasta para adicionar o arquivo no local selecionado
                    // Por exemplo:
                    // string caminhoArquivo = System.IO.Path.Combine(pastaSelecionada, "nome_arquivo.txt");
                    // System.IO.File.WriteAllText(caminhoArquivo, "Conteúdo do arquivo"); // Isso adiciona um arquivo com um conteúdo específico

                    MessageBox.Show("Pasta selecionada: " + pastaSelecionada, "Pasta selecionada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                textBox_file_location.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btn_open_import_Click(object sender, EventArgs e)
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

                textBox_file_location_import.Text = openFileDialog.FileName;
            }
        }
    }
}
