using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormListaVeiculos : Form
    {
        public static string TipoVeiculo { get; set; }

        private DateTime inicio;
        private DateTime fim;

        private List<object> listaSelecionada;
        private Veiculo veiculoSelecionado;

        private DataGridViewComboBoxColumn cb_status2;

        public FormListaVeiculos()
        {
            InitializeComponent();

            lb_status.Visible = false;
            cb_status.Visible = false;

        }

        private void Cb_status2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verificar se o DataGridView tem célula selecionada
            if (dgv_veiculos.CurrentCell != null)
            {
                // Obter a linha e a coluna da célula atualmente selecionada
                int rowIndex = dgv_veiculos.CurrentCell.RowIndex;
                int columnIndex = dgv_veiculos.CurrentCell.ColumnIndex;

                // Verificar se a célula é uma célula de ComboBox na coluna "Estado"
                if (dgv_veiculos.Columns[columnIndex].Name == "Estado")
                {

                    string novoEstado = dgv_veiculos.Rows[rowIndex].Cells[columnIndex].Value.ToString();
                    string id = dgv_veiculos.Rows[rowIndex].Cells[0].Value.ToString();

                    GetVeiculoDaLista(id);

                    if (Estado.Tipo.Disponivel.ToString() == novoEstado)
                    {
                        veiculoSelecionado.RetornarDisponivel();

                    }
                    else if (Estado.Tipo.Alugado.ToString() == novoEstado)
                    {
                        MessageBox.Show("insira data inicio e fim");

                        veiculoSelecionado.Alugar(inicio, fim);

                    }
                    else if (Estado.Tipo.Reservado.ToString() == novoEstado)
                    {
                        MessageBox.Show("insira data inicio e fim");

                        veiculoSelecionado.Reservar(inicio, fim);
                    }
                    else
                    {
                        MessageBox.Show("insira data inicio e fim");

                        veiculoSelecionado.EmManutencao(inicio, fim);
                    }

                    RemoveVeiculoDaLista();
                    AdicionarVeiculoNaLista();

                }
            }
        }

        private void RemoveVeiculoDaLista()
        {
            switch (cb_status.SelectedIndex)
            {
                case 0:

                    EmpresaController.Controlador.VeiculosDisponiveis.Remove(veiculoSelecionado);
                    break;

                case 1:

                    EmpresaController.Controlador.VeiculosAlugados.Remove(veiculoSelecionado);
                    break;

                case 2:

                    EmpresaController.Controlador.VeiculosReservados.Remove(veiculoSelecionado);
                    break;

                case 3:

                    EmpresaController.Controlador.VeiculosEmManutencao.Remove(veiculoSelecionado);
                    break;

                default:
                    break;
            }
        }

        private void GetVeiculoDaLista(string id)
        {
            switch (cb_status.SelectedIndex)
            {
                case 0:

                    listaSelecionada = EmpresaController.Controlador.VeiculosDisponiveis;
                    veiculoSelecionado = (Veiculo)(EmpresaController.Controlador.GetVeiculo(id, listaSelecionada));
                    break;

                case 1:

                    listaSelecionada = EmpresaController.Controlador.VeiculosAlugados;
                    veiculoSelecionado = (Veiculo)(EmpresaController.Controlador.GetVeiculo(id, listaSelecionada));
                    break;

                case 2:

                    listaSelecionada = EmpresaController.Controlador.VeiculosReservados;
                    veiculoSelecionado = (Veiculo)(EmpresaController.Controlador.GetVeiculo(id, listaSelecionada));
                    break;

                case 3:

                    listaSelecionada = EmpresaController.Controlador.VeiculosEmManutencao;
                    veiculoSelecionado = (Veiculo)(EmpresaController.Controlador.GetVeiculo(id, listaSelecionada));
                    break;

                default:
                    break;
            }
        }

        // Método para adicionar o veículo à lista correspondente ao novo estado selecionado
        private void AdicionarVeiculoNaLista()
        {
            switch (cb_status.SelectedIndex)
            {
                case 0:

                    EmpresaController.Controlador.VeiculosDisponiveis.Add(veiculoSelecionado);
                    break;

                case 1:

                    EmpresaController.Controlador.VeiculosAlugados.Add(veiculoSelecionado);
                    break;

                case 2:

                    EmpresaController.Controlador.VeiculosReservados.Add(veiculoSelecionado);
                    break;

                case 3:

                    EmpresaController.Controlador.VeiculosEmManutencao.Add(veiculoSelecionado);
                    break;

                default:
                    break;
            }
        }



        private void AdicionarColunas(DataGridView dgv_veiculos_, string[] colunas)
        {
            dgv_veiculos_.Columns.Clear();

            foreach (var coluna in colunas)
            {
                dgv_veiculos_.Columns.Add(coluna, coluna);
            }

            cb_status2 = new DataGridViewComboBoxColumn();
            cb_status2.HeaderText = "Estado";
            cb_status2.Name = "Estado";
            cb_status2.Items.AddRange("Disponivel", "Alugado", "Reservado", "EmManutencao");

            if (EmpresaController.userLogado != "#admin")
            {
                cb_status2.ReadOnly = false;


            }

            dgv_veiculos_.Columns.Add(cb_status2);

            dgv_veiculos_.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void ComboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {



            lb_status.Visible = true;
            cb_status.Visible = true;
            cb_status.SelectedItem = null;
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

            if (cb_status.SelectedItem != null)
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

        private void pb_list_veiculos_Click(object sender, EventArgs e)
        {

        }
    }
}