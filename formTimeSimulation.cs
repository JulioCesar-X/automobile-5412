using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formTimeSimulation : Form
    {
        private DateTime dataAtual;

        private DateTime dataInicio;
        private DateTime dataFim;

        public formTimeSimulation()
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

            adicionarListaVeiculosAlugados();
        }

        private void formTimeSimulation_Load(object sender, EventArgs e)
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

        private void btnAvancarDia_Click_1(object sender, EventArgs e)
        {
            AvancarUmDia();
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            dataInicio = dateTimePickerInicio.Value;
        }

        private void dateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            dataFim = dateTimePickerFim.Value;
        }

        private void dataGridViewVeiculosAlugados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Aqui estamos apanhando apenas o tipo carro na simulação,se queremos mostrar todos reservados ou alugados na simulação de tempo,
        //temos de criar um button filtro novamente ou TabControl para repetimos o processo de mostrar os veiculos de todos os tipos diferentes
        private void adicionarListaVeiculosAlugados()
        {
            foreach (var objeto in EmpresaController.Controlador.Veiculos)
            {
                Carro carro = objeto as Carro;

                if (carro.VeiculoStatus == "Reservado")
                {
                    dataGridViewVeiculosAlugados.Rows.Add(
                                   carro.VeiculoMatricula,
                                   carro.VeiculoModelo,
                                   carro.TipoCaixa,
                                   carro.VeiculoPreco + " €",
                                   carro.VeiculoStatus
                                   );
                }


            }
        }

    }
}
