using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formChangeVehicleStatus : Form
    {
        public static string TipoVeiculo { get; set; }

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
            cb_status.Items.Add("Disponivel");
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

                    AdicionarColunas(dgv_veiculos, "Carro", new string[] { "Matrícula", "Modelo", "Nº Portas", "Tipo de Caixa", "Preço / hora" });
                    TipoVeiculo = "Carro";
                    break;

                case 1:

                    AdicionarColunas(dgv_veiculos, "Mota", new string[] { "Matrícula", "Modelo", "Cilindrada", "Preço / hora" });
                    TipoVeiculo = "Mota";
                    break;

                case 2:

                    AdicionarColunas(dgv_veiculos, "Camioneta", new string[] { "Matrícula", "Modelo", "Nº de Eixos", "Nº Máx. Passageiros", "Preço / hora" });
                    TipoVeiculo = "Camioneta";
                    break;

                case 3:

                    AdicionarColunas(dgv_veiculos, "Camiao", new string[] { "Matrícula", "Modelo", "Peso Máx. Suportado", "Preço / hora" });
                    TipoVeiculo = "Camiao";
                    break;
            }


        }

        private void cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {


            bool flag = EmpresaController.ValidarListaVeiculosDoTipo(TipoVeiculo);

            if (flag)
            {
                //se existir veiculos do tipo selecionado deve limpar as linhas e mostrar as novas
                dgv_veiculos.Rows.Clear();

                var listaRequerida = EmpresaController.Controlador.GetListaVeciulosDoTipo(TipoVeiculo);

                switch (cb_status.SelectedIndex)
                {
                    case 0:

                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Disponivel");
                        break;

                    case 1:

                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Alugado");
                        break;

                    case 2:

                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Reservado");
                        break;

                    case 3:

                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Em manutenção");
                        break;

                }


            }

        }

        private void dgv_veiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void PreencheListaDeVeiculosDoStatus(List<object> listaRequerida, string TipoVeiculo, string status)
        {
            switch (TipoVeiculo)
            {
                case "Carro":

                    foreach (var objeto in listaRequerida)
                    {
                        //Conversão explicita
                        if (objeto is Carro)
                        {
                            Carro carro = objeto as Carro;

                            if (carro.VeiculoStatus == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    carro.VeiculoMatricula,
                                    carro.VeiculoModelo,
                                    carro.TipoCaixa,
                                    carro.VeiculoPreco + " €",
                                    carro.VeiculoStatus

                                    );
                            }
                        }

                    }
                    break;

                case "Mota":

                    foreach (var objeto in listaRequerida)
                    {
                        if (objeto is Mota)
                        {
                            Mota mota = (Mota)objeto;

                            if (mota.VeiculoStatus == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    mota.VeiculoMatricula,
                                    mota.VeiculoModelo,
                                    mota.Cilindrada + " cc",
                                    mota.VeiculoPreco + " €",
                                    mota.VeiculoStatus
                                    );
                            }
                        }
                    }
                    break;

                case "Camioneta":

                    foreach (var objeto in listaRequerida)
                    {
                        if (objeto is Camioneta)
                        {
                            Camioneta camioneta = objeto as Camioneta;

                            if (camioneta.VeiculoStatus == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    camioneta.VeiculoMatricula,
                                    camioneta.VeiculoModelo,
                                    camioneta.NumeroEixos,
                                    camioneta.NumeroPassageiros,
                                    camioneta.VeiculoPreco + " €",
                                    camioneta.VeiculoStatus
                                    );
                            }
                        }


                    }
                    break;

                case "Camiao":

                    foreach (var objeto in listaRequerida)
                    {
                        if (objeto is Camiao)
                        {
                            Camiao camiao = (Camiao)objeto;

                            if (camiao.VeiculoStatus == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    camiao.VeiculoMatricula,
                                    camiao.VeiculoModelo,
                                    camiao.PesoMaximo,
                                    camiao.VeiculoPreco + " €",
                                    camiao.VeiculoStatus
                                    );
                            }
                        }


                    }
                    break;
            }

        }
    }
}
