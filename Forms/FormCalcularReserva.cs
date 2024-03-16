using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormCalcularReserva : Form
    {
        public FormCalcularReserva()
        {
            InitializeComponent();
            LimparCampos();

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            pb_reservations.Visible = false;
            lb_veiculos_disponiveis.Visible = true;

            switch (cb_filtro.SelectedIndex)
            {
                case 0:

                    lb_veiculos_disponiveis.Text = "Carros Disponiveis";

                    AdicionarColunas(dgv_veiculos_disponiveis, new string[] { "Matrícula", "Modelo", "Nº Portas", "Tipo de Caixa", "Preço /h" });

                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Carro carro = veiculo as Carro;
                        if (carro != null)
                        {
                            dgv_veiculos_disponiveis.Rows.Add(
                                       carro.VeiculoMatricula,
                                       carro.VeiculoModelo,
                                       carro.NumeroPortas,
                                       carro.TipoCaixa,
                                       carro.VeiculoPreco + " €"

                                       );
                        }
                    }
                    break;

                case 1:

                    lb_veiculos_disponiveis.Text = "Motas Disponiveis";

                    AdicionarColunas(dgv_veiculos_disponiveis, new string[] { "Matrícula", "Modelo", "Cilindrada", "Preço /h" });

                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Mota mota = veiculo as Mota;
                        if (mota != null)
                        {
                            dgv_veiculos_disponiveis.Rows.Add(
                                        mota.VeiculoMatricula,
                                        mota.VeiculoModelo,
                                        mota.Cilindrada + " cc",
                                        mota.VeiculoPreco + " €"
                                        );
                        }
                    }
                    break;

                case 2:

                    lb_veiculos_disponiveis.Text = "Camionetas Disponiveis";

                    AdicionarColunas(dgv_veiculos_disponiveis, new string[] { "Matrícula", "Modelo", "Nº de Eixos", "Nº Máx. Passageiros", "Preço /h" });


                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Camioneta camioneta = veiculo as Camioneta;
                        if (camioneta != null)
                        {
                            dgv_veiculos_disponiveis.Rows.Add(
                                        camioneta.VeiculoMatricula,
                                        camioneta.VeiculoModelo,
                                        camioneta.NumeroEixos,
                                        camioneta.NumeroPassageiros,
                                        camioneta.VeiculoPreco + " €"
                                        );
                        }
                    }
                    break;

                case 3:

                    lb_veiculos_disponiveis.Text = "Camiões Disponiveis";

                    AdicionarColunas(dgv_veiculos_disponiveis, new string[] { "Matrícula", "Modelo", "Peso Máx. Suportado", "Preço /h" });


                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Camiao camiao = veiculo as Camiao;
                        if (camiao != null)
                        {
                            dgv_veiculos_disponiveis.Rows.Add(
                                       camiao.VeiculoMatricula,
                                       camiao.VeiculoModelo,
                                       camiao.PesoMaximo,
                                       camiao.VeiculoPreco + " €"
                                       );
                        }
                    }
                    break;
            }
        }

        private string FormatarIntervaloTempo(TimeSpan intervalo)
        {
            // Formata o intervalo de tempo no formato 'hh:mm'
            return $"{(int)intervalo.TotalHours:D2}:{intervalo.Minutes:D2}";

        }

        private void AdicionarColunas(DataGridView dgv_veiculos_, string[] colunas)
        {

            dgv_veiculos_.Columns.Clear();


            foreach (var coluna in colunas)
            {

                dgv_veiculos_.Columns.Add(coluna, coluna);
            }

            dgv_veiculos_.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void Btn_criar_reserva_Click(object sender, EventArgs e)
        {
            pb_reservations.Visible = true;

            if (tb_matricula.Text != null)
            {

                object veiculoSelecionado = EmpresaController.Controlador.GetVeiculo(tb_matricula.Text, EmpresaController.Controlador.VeiculosDisponiveis);

                if (veiculoSelecionado != null)
                {
                    Veiculo veiculo = veiculoSelecionado as Veiculo;


                    veiculo.VeiculoStatus.DataInicio = dateTimePickerInicio.Value;
                    veiculo.VeiculoStatus.DataFim = dateTimePickerFim.Value;
                    EmpresaController.Controlador.ValidarReserva(tb_matricula.Text, veiculo.VeiculoStatus.DataInicio);

                    veiculo.Reservar(dateTimePickerInicio.Value, dateTimePickerFim.Value);
                    EmpresaController.Controlador.AdicionarVeiculoReservado(veiculo);
                    EmpresaController.Controlador.VeiculosDisponiveis.Remove(veiculo);

                    // Atualiza a DataGridView
                    ComboBox1_SelectedIndexChanged(null, null);

                    MessageBox.Show("Reserva criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O veículo selecionado não foi encontrado na lista de veículos disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Por favor, selecione um veículo na lista de veículos disponíveis.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            LimparCampos();


        }

        private void Date_time_dias_ValueChanged(object sender, EventArgs e)
        {
            cb_filtro.SelectedItem = null;
            lb_preco_total.Visible = false;
            btn_criar_reserva.Visible = false;
        }

        private void Bt_calcular_valor_a_pagar_Click(object sender, EventArgs e)
        {
            lb_preco_total.Visible = true;
            btn_criar_reserva.Visible = true;

            tb_matricula.Text = dgv_veiculos_disponiveis.CurrentRow.Cells["Matrícula"].Value.ToString();

            string precoHoraString = dgv_veiculos_disponiveis.CurrentRow.Cells["Preço /h"].Value.ToString();
            double precoHora = double.Parse(precoHoraString.Replace(" €", ""));

            DateTime horaInicio = dateTimePickerInicio.Value.Date;
            DateTime horaFim = dateTimePickerFim.Value.Date;
            TimeSpan intervalo = horaFim - horaInicio;

            double intervaloHoras = intervalo.TotalHours;

            double valorAluguer = intervaloHoras * precoHora;

            lblPrecoFinal.Text = $"{valorAluguer:0.00} €";
            lblMatriculaEscolhida.Text = $"{tb_matricula.Text}";
            lb_matricula_r.Visible = true;
            lblMatriculaEscolhida.Visible = true;
            lblPrecoFinal.Visible = true;
        }

        private void CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_veiculos_disponiveis.Rows.Count)
            {
                DataGridViewRow row = dgv_veiculos_disponiveis.Rows[e.RowIndex];
                string matricula = row.Cells["Matrícula"].Value.ToString();
                tb_matricula.Text = matricula;
            }
        }

        private void Bt_confirm_Click(object sender, EventArgs e)
        {


            TimeSpan intervalo = dateTimePickerFim.Value - dateTimePickerInicio.Value;
            int minutos = (int)intervalo.TotalMinutes;

            if (minutos > 0)
            {
                string intervaloDeTempo = FormatarIntervaloTempo(intervalo);
                tb_valorfinaltempo.Text = intervaloDeTempo.ToString();

            }
            else
            {
                MessageBox.Show("Tempo de reserva 00:00 inválido!");
            }

        }
        private void LimparCampos()
        {
            tb_valorfinaltempo.Clear();
            tb_matricula.Clear();
            lblPrecoFinal.Text = string.Empty;
            lblMatriculaEscolhida.Text = string.Empty;
            lb_veiculos_disponiveis.Visible = false;
            lb_preco_total.Visible = false;
            lb_matricula_r.Visible = false;
            btn_criar_reserva.Visible = false;

            pb_reservations.Visible = true;

        }


    }
}
