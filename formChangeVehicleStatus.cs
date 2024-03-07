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


        private void AdicionarColunas(DataGridView dgv_veiculos_, string[] colunas)
        {
            dgv_veiculos_.Columns.Clear();

            foreach (var coluna in colunas)
            {
                dgv_veiculos_.Columns.Add(coluna, coluna);
            }

            DataGridViewComboBoxColumn cb_status = new DataGridViewComboBoxColumn();
            cb_status.HeaderText = "Estado";
            cb_status.Name = "Estado";
            cb_status.Items.AddRange("Disponivel", "Alugado", "Reservado", "EmManutencao");

            if (EmpresaController.userLogado != "#")
            {
                cb_status.ReadOnly = true;
            }

            dgv_veiculos_.Columns.Add(cb_status);

            dgv_veiculos_.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void ComboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_list_veiculos.Visible = true;
            dgv_veiculos.Columns.Clear();

            switch (cb_filtrar.SelectedIndex)
            {
                case 0:
                    AdicionarColunas(dgv_veiculos, new string[] { "Matrícula", "Modelo", "Nº Portas", "Tipo de Caixa", "Preço / hora" });
                    TipoVeiculo = "Carro";
                    break;

                case 1:
                    AdicionarColunas(dgv_veiculos, new string[] { "Matrícula", "Modelo", "Cilindrada", "Preço / hora" });
                    TipoVeiculo = "Mota";
                    break;

                case 2:
                    AdicionarColunas(dgv_veiculos, new string[] { "Matrícula", "Modelo", "Nº de Eixos", "Nº Máx. Passageiros", "Preço / hora" });
                    TipoVeiculo = "Camioneta";
                    break;

                case 3:
                    AdicionarColunas(dgv_veiculos, new string[] { "Matrícula", "Modelo", "Peso Máx. Suportado", "Preço / hora" });
                    TipoVeiculo = "Camiao";
                    break;
            }
        }

        private void Cb_status_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_list_veiculos.Visible = false;

            if (EmpresaController.ValidarListaVeiculosDoTipo(TipoVeiculo, cb_status.SelectedItem.ToString()))
            {
                dgv_veiculos.Rows.Clear();
                var listaRequerida = new List<object>();

                switch (cb_status.SelectedIndex)
                {
                    case 0:
                        listaRequerida = EmpresaController.Controlador.VeiculosDisponiveis;
                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Disponivel");
                        break;

                    case 1:
                        listaRequerida = EmpresaController.Controlador.VeiculosAlugados;
                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Alugado");
                        break;

                    case 2:
                        listaRequerida = EmpresaController.Controlador.VeiculosReservados;
                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "Reservado");
                        break;

                    case 3:
                        listaRequerida = EmpresaController.Controlador.VeiculosEmManutencao;
                        PreencheListaDeVeiculosDoStatus(listaRequerida, TipoVeiculo, "EmManutencao");
                        break;
                }
            }
            else
            {
                MessageBox.Show("Tipo de veiculo não encontrado com esse estado");
            }
        }



        private void Dgv_veiculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

                            if (carro.VeiculoStatus.Nome.ToString() == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    carro.VeiculoMatricula,
                                    carro.VeiculoModelo,
                                    carro.NumeroPortas,
                                    carro.TipoCaixa,
                                    carro.VeiculoPreco + " €",
                                    status


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

                            if (mota.VeiculoStatus.Nome.ToString() == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    mota.VeiculoMatricula,
                                    mota.VeiculoModelo,
                                    mota.Cilindrada + " cc",
                                    mota.VeiculoPreco + " €",
                                    status
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

                            if (camioneta.VeiculoStatus.Nome.ToString() == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    camioneta.VeiculoMatricula,
                                    camioneta.VeiculoModelo,
                                    camioneta.NumeroEixos,
                                    camioneta.NumeroPassageiros,
                                    camioneta.VeiculoPreco + " €",
                                    status
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

                            if (camiao.VeiculoStatus.Nome.ToString() == status)
                            {
                                dgv_veiculos.Rows.Add(
                                    camiao.VeiculoMatricula,
                                    camiao.VeiculoModelo,
                                    camiao.PesoMaximo,
                                    camiao.VeiculoPreco + " €",
                                    status
                                    );
                            }
                        }


                    }
                    break;
            }

        }
    }
}