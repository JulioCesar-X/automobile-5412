using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormTimeSimulation : Form
    {
        private DateTime dataAtual;

        private DateTime dataInicio;
        private DateTime dataFim;

        public FormTimeSimulation()
        {
            InitializeComponent();

            dataAtual = DateTime.Today;
            AtualizarLabelData();

            dateTimePickerInicio.MinDate = DateTime.Today;
            dateTimePickerFim.MinDate = DateTime.Today;

            dataInicio = dateTimePickerInicio.Value;
            dataFim = dateTimePickerFim.Value;

            dataGridViewVeiculosAlugados.Columns.Add("Matricula", "Matrícula");
            dataGridViewVeiculosAlugados.Columns.Add("Marca", "Marca");
            dataGridViewVeiculosAlugados.Columns.Add("Preço Dia", "Preço Dia");
            dataGridViewVeiculosAlugados.Columns.Add("Estado", "Estado");

        }

        private void FormTimeSimulation_Load(object sender, EventArgs e)
        {

        }

        private void AvancarUmDia()
        {
            dataAtual = dataAtual.AddDays(1);
            AtualizarLabelData();
        }

        private void AtualizarLabelData()
        {
            lblData.Text = $" {dataAtual:d}";
        }

        private void BtnAvancarDia_Click_1(object sender, EventArgs e)
        {
            AvancarUmDia();
        }

        private void DateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            dataInicio = dateTimePickerInicio.Value;
        }

        private void DateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            dataFim = dateTimePickerFim.Value;
        }

        private void DataGridViewVeiculosAlugados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Aqui estamos apanhando apenas o tipo carro na simulação,se queremos mostrar todos reservados ou alugados na simulação de tempo,
        //temos de criar um button filtro novamente ou TabControl para repetimos o processo de mostrar os veiculos de todos os tipos diferentes
        private void AdicionarListaVeiculosAlugados(string tipoVeiculo)
        {

            foreach (var reserva in EmpresaController.Controlador.VeiculosReservados)
            {
                if (reserva.GetType().Name == tipoVeiculo)
                {
                    switch (comboBoxTipoVeiculo.SelectedItem)
                    {
                        case "Carro":
                            Carro carro = reserva as Carro;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           carro.VeiculoMatricula,
                                           carro.VeiculoModelo,
                                           carro.TipoCaixa,
                                           carro.VeiculoPreco + " €",
                                           carro.VeiculoStatus
                                           );
                            break;
                    }

                }

            }

        }

        private void comboBoxTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxTipoVeiculo.SelectedIndex)
            {
                case 0:
                    AdicionarListaVeiculosAlugados("Carro");
                    break;

                case 1:
                    AdicionarListaVeiculosAlugados("Mota");
                    break;

                case 2:
                    AdicionarListaVeiculosAlugados("Camiao");
                    break;

                case 3:
                    AdicionarListaVeiculosAlugados("Camioneta");
                    break;
            }
        }
    }
}
