﻿using System;
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


            dateTimePickerInicio.MinDate = DateTime.Today;
            dateTimePickerFim.MinDate = DateTime.Today;

            dataInicio = dateTimePickerInicio.Value;
            dataFim = dateTimePickerFim.Value;

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

        private void FormTimeSimulation_Load(object sender, EventArgs e)
        {

        }







        private void DateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {
            dataInicio = dateTimePickerInicio.Value;
        }

        private void DateTimePickerFim_ValueChanged(object sender, EventArgs e)
        {
            dataFim = dateTimePickerFim.Value;
            btnCalculate.Visible = true;

        }

        private void DataGridViewVeiculosAlugados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //Aqui estamos apanhando apenas o tipo carro na simulação,se queremos mostrar todos reservados ou alugados na simulação de tempo,
        //temos de criar um button filtro novamente ou TabControl para repetimos o processo de mostrar os veiculos de todos os tipos diferentes
        private void AdicionarListaVeiculosAlugados(string tipoVeiculo)
        {
            dataGridViewVeiculosAlugados.Rows.Clear();
            foreach (var reserva in EmpresaController.Controlador.VeiculosReservados)
            {
                if (reserva.GetType().Name == tipoVeiculo
                    && ((Veiculo)reserva).VeiculoStatus.DataInicio.Date >= dateTimePickerInicio.Value.Date
                    && ((Veiculo)reserva).VeiculoStatus.DataFim <= dateTimePickerFim.Value.Date)
                {
                    switch (comboBoxTipoVeiculo.SelectedItem)
                    {
                        case "Carro":
                            Carro carro = reserva as Carro;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           carro.VeiculoMatricula,
                                           carro.VeiculoModelo,
                                           carro.VeiculoPreco + " €",
                                           carro.VeiculoStatus.Nome
                                           );
                            break;

                        case "Mota":
                            Mota mota = reserva as Mota;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           mota.VeiculoMatricula,
                                           mota.VeiculoModelo,
                                           mota.VeiculoPreco + " €",
                                           mota.VeiculoStatus.Nome
                                           );
                            break;

                        case "Camiao":
                            Camiao camiao = reserva as Camiao;
                            dataGridViewVeiculosAlugados.Rows.Add(
                                           camiao.VeiculoMatricula,
                                           camiao.VeiculoModelo,
                                           camiao.VeiculoPreco + " €",
                                           camiao.VeiculoStatus.Nome
                                           );
                            break;

                        case "Camioneta":
                            Camioneta camioneta = reserva as Camioneta;
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

        private void comboBoxTipoVeiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            pb_veiculos_alugados.Visible = false;

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

        private void btnCalculate_Click(object sender, EventArgs e)
        {

            decimal soma = 0;
            foreach (var reserva in EmpresaController.Controlador.VeiculosReservados)
            {
                Veiculo veiculo = (Veiculo)reserva;


                if (veiculo.VeiculoPreco != null &&
                    veiculo.VeiculoStatus.DataInicio.Date >= dateTimePickerInicio.Value.Date &&
                    veiculo.VeiculoStatus.DataFim <= dateTimePickerFim.Value.Date)
                {
                    soma += veiculo.VeiculoPreco;
                }
            }

            lblPreco.Text = "Total: " + soma.ToString() + " €";
            lblPreco.Visible = true;
            chb_ver_veiculos.Visible = true;
        }


        private void lblPreco_Click(object sender, EventArgs e)
        {

        }

        private void chb_ver_veiculos_CheckedChanged(object sender, EventArgs e)
        {
            if (chb_ver_veiculos.Checked)
            {
                comboBoxTipoVeiculo.Visible = true;
                lb_filtro.Visible = true;
            }
        }
    }
}
