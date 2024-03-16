using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormTratamentoErro : Form
    {
        private string _caminhoDoErro;
        private string _atributoErrado;
        private string[] _linhaDoCsv;
        public FormTratamentoErro(string caminho, string atributoErrado, string erro, string[] colunas)
        {
            InitializeComponent();

            btn_novo_valor.Visible = false;
            lb_erro.Text = erro;
            AdicionarColunas(colunas); //colunas [matricula, modelo ...]
            _caminhoDoErro = caminho;
            _atributoErrado = atributoErrado;
            _linhaDoCsv = colunas;
        }



        private void FormTratamentoErro_Load(object sender, EventArgs e)
        {

        }
        private void AdicionarColunas(string[] colunas)
        {
            dgv_erro.Columns.Clear();

            foreach (var coluna in colunas)
            {
                dgv_erro.Columns.Add(coluna, coluna);
            }

            dgv_erro.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }




        private void Btn_novo_valor_Click(object sender, EventArgs e)
        {
            AlterarValorNoArquivoCSV();
            this.Close();
        }

        private void AlterarValorNoArquivoCSV()
        {
            // Ler todas as linhas do arquivo CSV
            string[] linhas = File.ReadAllLines(_caminhoDoErro);

            // Encontrar a linha correspondente com os mesmos valores que _colunas
            string linhaParaAtualizar = linhas.FirstOrDefault(l => l.Split(';').SequenceEqual(_linhaDoCsv));

            // Se a linha não for encontrada, sair do método
            if (linhaParaAtualizar == null)
            {

                return;
            }

            // Encontrar o índice do atributo errado na linha
            int index = Array.IndexOf(_linhaDoCsv, _atributoErrado);

            // Se o atributo errado não estiver presente na linha, sair do método
            if (index == -1)
            {
                return;
            }

            // Substituir o valor na posição do atributo errado pelo novo valor
            string[] valores = linhaParaAtualizar.Split(';');
            valores[index] = tb_novo_valor.Text;

            // Construir a nova linha com os valores atualizados
            string novaLinha = string.Join(";", valores);

            // Substituir a linha antiga pela nova linha no array de linhas
            int indexLinha = Array.IndexOf(linhas, linhaParaAtualizar);
            linhas[indexLinha] = novaLinha;

            // Reescrever o arquivo CSV com as linhas atualizadas
            File.WriteAllLines(_caminhoDoErro, linhas);
            MessageBox.Show("Tente novamente ...");
        }
        private void Tb_novo_valor_TextChanged(object sender, EventArgs e)
        {
            btn_novo_valor.Visible = true;

        }
    }

}

