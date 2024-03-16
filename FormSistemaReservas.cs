using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormSistemaReservas : Form
    {
        private DateTime _dataAtual;
        private DateTime _dataInicio;
        private DateTime _dataFim;

        public FormSistemaReservas()
        {
            InitializeComponent();

            _dataAtual = EmpresaController.DataAtual.Date;

            dateTimePickerInicio.MinDate = _dataAtual;
            dateTimePickerFim.MinDate = _dataAtual;

            dataGridViewVeiculosAlugados.Columns.Add("Matricula", "Matrícula");
            dataGridViewVeiculosAlugados.Columns.Add("Marca", "Marca");
            dataGridViewVeiculosAlugados.Columns.Add("Preço Dia", "Preço Dia");
            dataGridViewVeiculosAlugados.Columns.Add("Estado", "Estado");
            dataGridViewVeiculosAlugados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            lblPreco.Visible = false;
            comboBoxTipoVeiculo.Visible = false;
            lb_filtro.Visible = false;
            btnCalculate.Visible = false;
            chb_ver_veiculos.Visible = false;

        }

        private void DateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            _dataInicio = dateTimePickerInicio.Value.Date;
        }

        private void DateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            _dataFim = dateTimePickerFim.Value.Date;
            btnCalculate.Visible = true;

        }

        private void AdicionarListaVeiculosAlugados(string tipoVeiculo)
        {
            dataGridViewVeiculosAlugados.Rows.Clear();

            foreach (var alugado in EmpresaController.Controlador.VeiculosAlugados)
            {
                if (alugado.GetType().Name == tipoVeiculo
                    && ((Veiculo)alugado).VeiculoStatus.DataInicio.Date >= _dataInicio
                    && ((Veiculo)alugado).VeiculoStatus.DataFim <= _dataFim)
                {
                    switch (comboBoxTipoVeiculo.SelectedItem)
                    {
                        case "Carro":
                            Carro carro = alugado as Carro;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           carro.VeiculoMatricula,
                                           carro.VeiculoModelo,
                                           carro.VeiculoPreco + " €",
                                           carro.VeiculoStatus.Nome
                                           );
                            break;

                        case "Mota":
                            Mota mota = alugado as Mota;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           mota.VeiculoMatricula,
                                           mota.VeiculoModelo,
                                           mota.VeiculoPreco + " €",
                                           mota.VeiculoStatus.Nome
                                           );
                            break;

                        case "Camiao":
                            Camiao camiao = alugado as Camiao;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           camiao.VeiculoMatricula,
                                           camiao.VeiculoModelo,
                                           camiao.VeiculoPreco + " €",
                                           camiao.VeiculoStatus.Nome
                                           );
                            break;

                        case "Camioneta":
                            Camioneta camioneta = alugado as Camioneta;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           camioneta.VeiculoMatricula,
                                           camioneta.VeiculoModelo,
                                           camioneta.VeiculoPreco + " €",
                                           camioneta.VeiculoStatus.Nome
                                           );
                            break;
                    }

                }

            }

        }

        private void ComboBoxTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBoxTipoVeiculo.SelectedIndex)
            {
                case 0:
                    AdicionarListaVeiculosAlugados("Carro");
                    lb_veiculos_alugados.Text = "Carros Alugados";
                    break;

                case 1:
                    AdicionarListaVeiculosAlugados("Mota");
                    lb_veiculos_alugados.Text = "Motas Alugadas";
                    break;

                case 2:
                    AdicionarListaVeiculosAlugados("Camiao");
                    lb_veiculos_alugados.Text = "Camiões Alugados";
                    break;

                case 3:
                    AdicionarListaVeiculosAlugados("Camioneta");
                    lb_veiculos_alugados.Text = "Camionetas Alugadas";
                    break;
            }
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {

            decimal soma = 0;
            foreach (var alugado in EmpresaController.Controlador.VeiculosAlugados)
            {
                Veiculo veiculo = (Veiculo)alugado;


                if (veiculo.VeiculoStatus.DataInicio.Date >= _dataInicio.Date && veiculo.VeiculoStatus.DataFim <= _dataFim.Date)
                {
                    soma += decimal.Parse(veiculo.VeiculoPreco);
                }
            }

            lblPreco.Text = "Total: " + soma.ToString() + " €";
            lblPreco.Visible = true;
            chb_ver_veiculos.Visible = true;
        }

        private void Chb_ver_veiculos_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ver_veiculos.Checked)
            {
                comboBoxTipoVeiculo.Visible = true;
                lb_filtro.Visible = true;
            }
        }
    }
}
