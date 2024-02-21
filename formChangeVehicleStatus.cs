using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formChangeVehicleStatus : Form
    {
        private static string _tipoVeiculo;
        public formChangeVehicleStatus()
        {
            InitializeComponent();

        }

        private void AdicionarColunas(DataGridView dgv_veiculos_, string tipoVeiculo, string[] colunas)
        {
            //limpamos a dgv anterior
            dgv_veiculos_.Columns.Clear();

            //add as colunas especificas para a grid dgv_veiculos__veiculos_
            foreach (var coluna in colunas)
            {
                //add coluna name
                dgv_veiculos_.Columns.Add(coluna, coluna);
            }


            // Add a coluna de ComboBox do status
            DataGridViewComboBoxColumn cb_status = new DataGridViewComboBoxColumn();
            cb_status.HeaderText = "Estado";
            cb_status.Name = "Estado";

            // Add as opções ao ComboBox de estado
            cb_status.Items.Add("Disponível");
            cb_status.Items.Add("Alugado");
            cb_status.Items.Add("Reservado");
            cb_status.Items.Add("Em manutenção");

            if (EmpresaController.userLogado != "#")
            {
                //Assim apenas o admin pode alterar diretamente o status do veiculo
                cb_status.ReadOnly = true;
            }

            //add a ComboBox do status ao dgv
            dgv_veiculos_.Columns.Add(cb_status);

            //completar os espaços vazios na grid
            dgv_veiculos_.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {

            dgv_veiculos.Columns.Clear();


            switch (cb_filtrar.SelectedIndex)
            {
                case 0:

                    AdicionarColunas(dgv_veiculos, "Carro", new string[] { "Matrícula", "Marca", "Nº Portas", "Tipo de Caixa", "Preço / dia" });

                    break;

                case 1:

                    AdicionarColunas(dgv_veiculos, "Mota", new string[] { "Matrícula", "Marca", "Cilindrada", "Preço / dia" });

                    break;

                case 2:

                    AdicionarColunas(dgv_veiculos, "Camioneta", new string[] { "Matrícula", "Marca", "Nº de Eixos", "Nº Máx. Passageiros", "Preço / dia" });

                    break;

                case 3:

                    AdicionarColunas(dgv_veiculos, "Camiao", new string[] { "Matrícula", "Marca", "Peso Máx. Suportado", "Preço / dia" });

                    break;
            }
            _tipoVeiculo = cb_filtrar.SelectedItem.ToString();
        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {


            bool flag = EmpresaController.ValidarListaVeiculosDoTipo(_tipoVeiculo);

            if (flag)
            {
                //se existir veiculos do tipo selecionado deve limpar as linhas e mostrar as novas
                dgv_veiculos.Rows.Clear();

                var listaRequerida = EmpresaController.Controlador.ListaVeciulosDoTipo(_tipoVeiculo);

                switch (cb_status.SelectedIndex)
                {
                    case 0: //Disponivel

                        foreach (var veiculo in listaRequerida)
                        {
                            if (veiculo.VeiculoStatus == "Disponivel")
                            {
                                dgv_veiculos.Rows.Add(veiculo);
                            }
                        }



                        break;

                    case 1:

                        AdicionarColunas(dgv_veiculos, "Motas", new string[] { "Matrícula", "Marca", "Cilindrada", "Preço / dia" });

                        break;

                    case 2:

                        AdicionarColunas(dgv_veiculos, "Camionetas", new string[] { "Matrícula", "Marca", "Nº de Eixos", "Nº Máx. Passageiros", "Preço / dia" });

                        break;

                    case 3:

                        AdicionarColunas(dgv_veiculos, "Camiões", new string[] { "Matrícula", "Marca", "Peso Máx. Suportado", "Preço / dia" });

                        break;

                }
            }

        }
    }
}
