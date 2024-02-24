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

                var listaRequerida = EmpresaController.Controlador.ListaVeciulosDoTipo(TipoVeiculo);

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

                    foreach (var carro in listaRequerida)
                    {
                        if (EmpresaController.Controlador.GetStatus(carro) == status)
                        {
                            dgv_veiculos.Rows.Add(
                                EmpresaController.Controlador.GetMatricula(carro),
                                EmpresaController.Controlador.GetModelo(carro),
                                EmpresaController.Controlador.GetNumPortas(carro),
                                EmpresaController.Controlador.GetTipoDeCaixa(carro),
                                EmpresaController.Controlador.GetPrecoPorDia(carro) + " €",
                                EmpresaController.Controlador.GetStatus(carro)
                                );
                        }


                    }
                    break;

                case "Mota":

                    foreach (var mota in listaRequerida)
                    {
                        if (EmpresaController.Controlador.GetStatus(mota) == status)
                        {
                            dgv_veiculos.Rows.Add(
                                EmpresaController.Controlador.GetMatricula(mota),
                                EmpresaController.Controlador.GetModelo(mota),
                                EmpresaController.Controlador.GetCilindrada(mota),
                                EmpresaController.Controlador.GetPrecoPorDia(mota) + " €",
                                EmpresaController.Controlador.GetStatus(mota)
                                );
                        }


                    }
                    break;

                case "Camioneta":

                    foreach (var camioneta in listaRequerida)
                    {
                        if (EmpresaController.Controlador.GetStatus(camioneta) == status)
                        {
                            dgv_veiculos.Rows.Add(
                                EmpresaController.Controlador.GetMatricula(camioneta),
                                EmpresaController.Controlador.GetModelo(camioneta),
                                EmpresaController.Controlador.GetNumEixos(camioneta),
                                EmpresaController.Controlador.GetNumMaxPassageiros(camioneta),
                                EmpresaController.Controlador.GetPrecoPorDia(camioneta) + " €",
                                EmpresaController.Controlador.GetStatus(camioneta)
                                );
                        }


                    }
                    break;

                case "Camiao":

                    foreach (var camiao in listaRequerida)
                    {
                        if (EmpresaController.Controlador.GetStatus(camiao) == status)
                        {
                            dgv_veiculos.Rows.Add(
                                EmpresaController.Controlador.GetMatricula(camiao),
                                EmpresaController.Controlador.GetModelo(camiao),
                                EmpresaController.Controlador.GetPesoMaxSuportado(camiao),
                                EmpresaController.Controlador.GetPrecoPorDia(camiao) + " €",
                                EmpresaController.Controlador.GetStatus(camiao)
                                );
                        }


                    }
                    break;
            }

        }
    }
}
