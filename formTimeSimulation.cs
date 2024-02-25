using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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

        private void adicionarListaVeiculosAlugados()
        {
            foreach (var carro in EmpresaController.Controlador.Veiculos)
            {
                if (EmpresaController.Controlador.GetStatus(carro) == "Reservado")
                {
                    dataGridViewVeiculosAlugados.Rows.Add(
                        EmpresaController.Controlador.GetMatricula(carro),
                        EmpresaController.Controlador.GetModelo(carro),
                        EmpresaController.Controlador.GetPrecoPorDia(carro) + " €",
                        EmpresaController.Controlador.GetStatus(carro)
                        );
                }


            }
        }

    }
}
