using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormGerirAluguer : Form
    {
        private DateTime _dataInicio;
        private DateTime _dataFim;
        private TimeSpan _intervalo;

        public FormGerirAluguer()
        {
            InitializeComponent();

            LimparCampos();

        }

        private void Cb_filtro_SelectedIndexChanged(object sender, EventArgs e)
        {

            pb_aluguer.Visible = false;
            lb_veiculos_disponiveis.Visible = true;

            switch (cb_filtro_disponiveis.SelectedIndex)
            {
                case 0:

                    lb_veiculos_disponiveis.Text = "Carros Disponiveis";

                    AdicionarColunas(dgv_disponiveis, new string[] { "Matrícula", "Modelo", "Nº Portas", "Tipo de Caixa", "Preço /h" });

                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Carro carro = veiculo as Carro;
                        if (carro != null)
                        {
                            dgv_disponiveis.Rows.Add(
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

                    AdicionarColunas(dgv_disponiveis, new string[] { "Matrícula", "Modelo", "Cilindrada", "Preço /h" });

                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Mota mota = veiculo as Mota;
                        if (mota != null)
                        {
                            dgv_disponiveis.Rows.Add(
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

                    AdicionarColunas(dgv_disponiveis, new string[] { "Matrícula", "Modelo", "Nº de Eixos", "Nº Máx. Passageiros", "Preço /h" });


                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Camioneta camioneta = veiculo as Camioneta;
                        if (camioneta != null)
                        {
                            dgv_disponiveis.Rows.Add(
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

                    AdicionarColunas(dgv_disponiveis, new string[] { "Matrícula", "Modelo", "Peso Máx. Suportado", "Preço /h" });


                    foreach (var veiculo in EmpresaController.Controlador.VeiculosDisponiveis)
                    {
                        Camiao camiao = veiculo as Camiao;
                        if (camiao != null)
                        {
                            dgv_disponiveis.Rows.Add(
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

        private string FormatarTempo(TimeSpan intervalo)
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

        private void Btn_criar_aluguer_Click(object sender, EventArgs e)
        {
            pb_aluguer.Visible = true;

            if (tb_matricula_selec.Text != null)
            {

                object veiculoSelecionado = EmpresaController.Controlador.GetVeiculo(tb_matricula_selec.Text, EmpresaController.Controlador.VeiculosDisponiveis);

                if (veiculoSelecionado != null)
                {
                    Veiculo veiculo = veiculoSelecionado as Veiculo;

                    EmpresaController.Controlador.ValidarAluguer(tb_matricula_selec.Text, veiculo.VeiculoStatus.DataInicio);

                    veiculo.Alugar(_dataInicio, _dataFim);

                    EmpresaController.Controlador.VeiculosAlugados.Add(veiculo);
                    EmpresaController.Controlador.VeiculosDisponiveis.Remove(veiculo);

                    // Atualiza a DataGridView
                    Cb_filtro_SelectedIndexChanged(null, null);

                    MessageBox.Show("Aluguer criado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Bt_calcular_valor_Click(object sender, EventArgs e)
        {
            lb_preco_total_aluguer.Visible = true;
            btn_criar_aluguer.Visible = true;

            tb_matricula_selec.Text = dgv_disponiveis.CurrentRow.Cells["Matrícula"].Value.ToString();

            string precoHoraString = dgv_disponiveis.CurrentRow.Cells["Preço /h"].Value.ToString();
            double precoHora = double.Parse(precoHoraString.Replace(" €", ""));




            double intervaloHoras = _intervalo.TotalHours;

            double valorAluguer = intervaloHoras * precoHora;

            lb_total_aluguer.Text = $"{valorAluguer:0.00} €";
            lb_matricula_selec.Text = $"{tb_matricula_selec.Text}";

            lb_matricula_a.Visible = true;
            lb_matricula_selec.Visible = true;

            lb_preco_total_aluguer.Visible = true;
            lb_total_aluguer.Visible = true;
        }

        private void Cell_Click(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_disponiveis.Rows.Count)
            {
                DataGridViewRow row = dgv_disponiveis.Rows[e.RowIndex];

                tb_matricula_selec.Text = row.Cells["Matrícula"].Value.ToString();
            }
        }

        private void Bt_confirmar_Click(object sender, EventArgs e)
        {

            _intervalo = _dataFim - _dataInicio;

            int minutos = (int)_intervalo.TotalMinutes;

            if (minutos > 0)
            {
                string intervaloDeTempo = FormatarTempo(_intervalo);
                tb_tempo_total.Text = intervaloDeTempo.ToString();

            }
            else
            {
                MessageBox.Show("Tempo de reserva 00:00 inválido!");
            }

        }
        private void LimparCampos()
        {
            tb_tempo_total.Clear();
            tb_matricula_selec.Clear();
            lb_preco_total_aluguer.Text = string.Empty;
            lb_matricula_selec.Text = string.Empty;
            lb_veiculos_disponiveis.Visible = false;
            lb_total_aluguer.Visible = false;
            lb_matricula_a.Visible = false;
            btn_criar_aluguer.Visible = false;
            pb_aluguer.Visible = true;

        }

        private void Dtp_inicio_ValueChanged_1(object sender, EventArgs e)
        {
            _dataInicio = dtp_inicio.Value.Date;
        }

        private void Dtp_fim_ValueChanged(object sender, EventArgs e)
        {
            _dataFim = dtp_fim.Value.Date;
        }
    }


}

