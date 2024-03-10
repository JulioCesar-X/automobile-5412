using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormListaVeiculos : Form
    {

        private DateTime inicio;
        private DateTime fim;

        private List<object> listaSelecionada;
        private Veiculo veiculoSelecionado;

        private DataGridViewComboBoxColumn cb_status2;
        public static string TipoVeiculo { get; set; }

        public FormListaVeiculos()
        {
            InitializeComponent();

            lb_status.Visible = false;
            cb_status.Visible = false;

            dgv_veiculos.EditingControlShowing += Dgv_veiculos_EditingControlShowing;
            cb_status.SelectedIndexChanged += Cb_status_SelectedIndexChanged;

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
        private void MudarEstadoVeiculo(string novoEstado)
        {
            if (Estado.Tipo.Disponivel.ToString() == novoEstado)
            {
                veiculoSelecionado.RetornarDisponivel();

            }
            else if (Estado.Tipo.Alugado.ToString() == novoEstado)
            {
                SelecaoData formSelecaoData = new SelecaoData();
                formSelecaoData.StartPosition = FormStartPosition.CenterScreen;
                DialogResult caixa = formSelecaoData.ShowDialog();
                if (caixa == DialogResult.OK)
                {
                    inicio = formSelecaoData.InicioSelecionado.Date;
                    fim = formSelecaoData.FimSelecionado.Date;

                }

                veiculoSelecionado.Alugar(inicio, fim);

            }
            else if (Estado.Tipo.Reservado.ToString() == novoEstado)
            {
                SelecaoData formSelecaoData = new SelecaoData();
                formSelecaoData.StartPosition = FormStartPosition.CenterScreen;
                DialogResult caixa = formSelecaoData.ShowDialog();
                if (caixa == DialogResult.OK)
                {
                    inicio = formSelecaoData.InicioSelecionado.Date;
                    fim = formSelecaoData.FimSelecionado.Date;

                }

                veiculoSelecionado.Reservar(inicio, fim);
            }
            else
            {
                SelecaoData formSelecaoData = new SelecaoData();
                formSelecaoData.StartPosition = FormStartPosition.CenterScreen;
                DialogResult caixa = formSelecaoData.ShowDialog();
                if (caixa == DialogResult.OK)
                {
                    inicio = formSelecaoData.InicioSelecionado.Date;
                    fim = formSelecaoData.FimSelecionado.Date;

                }

                veiculoSelecionado.EmManutencao(inicio, fim);
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
        private void AdicionarVeiculoNaLista(string novoEstado)
        {
            switch (novoEstado)
            {
                case "Disponivel":

                    EmpresaController.Controlador.VeiculosDisponiveis.Add(veiculoSelecionado);
                    break;

                case "Alugado":

                    EmpresaController.Controlador.VeiculosAlugados.Add(veiculoSelecionado);
                    break;

                case "Reservado":

                    EmpresaController.Controlador.VeiculosReservados.Add(veiculoSelecionado);
                    break;

                case "EmManutencao":

                    EmpresaController.Controlador.VeiculosEmManutencao.Add(veiculoSelecionado);
                    break;

                default:
                    break;
            }
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

            dgv_veiculos_.EditingControlShowing += Dgv_veiculos_EditingControlShowing;
        }

        private void Dgv_veiculos_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var dgv = (DataGridView)sender;
            var editingComboBox = e.Control as ComboBox;

            if (editingComboBox != null && dgv.CurrentCell is DataGridViewComboBoxCell comboBoxCell)
            {
                if (comboBoxCell.ColumnIndex == dgv.Columns["Estado"].Index)
                {
                    // Desabilita o evento SelectedIndexChanged
                    editingComboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

                    // Habilita o evento SelectedIndexChanged apenas quando um item é selecionado
                    editingComboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
                }
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = (ComboBox)sender;
            var dgv = (DataGridView)cb_status2.DataGridView; // Acessa o DataGridView diretamente
            var novoEstado = comboBox.SelectedItem.ToString();
            var id = dgv.CurrentRow.Cells[0].Value.ToString();

            // Desabilita novamente o evento SelectedIndexChanged
            comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;

            // Realiza as alterações necessárias
            GetVeiculoDaLista(id);
            MudarEstadoVeiculo(novoEstado);
            RemoveVeiculoDaLista();
            AdicionarVeiculoNaLista(novoEstado);
            // Atualiza o estado selecionado no cb_status
            cb_status.SelectedItem = novoEstado;
        }


    }
}