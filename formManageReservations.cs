using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormManageReservations : Form
    {
        private string tipoVeiculoSelecionado;

        public FormManageReservations()
        {
            InitializeComponent();
            lb_preco_total.Visible = false;
<<<<<<< HEAD
            btn_criar_reserva.Visible = false;
=======
            btn_criar_reserva.Visible = false;       
>>>>>>> 38f7503a662c7d21b1300ccf37437393264f0384
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {         
            switch (cb_filtro.SelectedIndex)
            {
                case 0:

                    AdicionarColunas(dgv_veiculos_disponiveis, "Carro", new string[] { "Matrícula", "Modelo", "Nº Portas", "Tipo de Caixa", "Preço /h" });

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

                    AdicionarColunas(dgv_veiculos_disponiveis, "Mota", new string[] { "Matrícula", "Modelo", "Cilindrada", "Preço /h" });


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

                    AdicionarColunas(dgv_veiculos_disponiveis, "Camioneta", new string[] { "Matrícula", "Modelo", "Nº de Eixos", "Nº Máx. Passageiros", "Preço /h" });


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

                    AdicionarColunas(dgv_veiculos_disponiveis, "Camiao", new string[] { "Matrícula", "Modelo", "Peso Máx. Suportado", "Preço /h" });


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

        private void formManageReservations_Load(object sender, EventArgs e)
        {
            
        }
<<<<<<< HEAD

        private void MontarHorarios()
        {
            var horario = new TimeSpan(0, 0, 0);
            var incremento = new TimeSpan(0, 30, 0);

            for (int i = 0; i < 48; i++)
            {
                list_box_horario.Items.Add(horario.ToString().Substring(0, 5));
                horario += incremento;
            }
        }

        private bool validarForm()
        {
            if (list_box_horario.Text == "")
            {
                MessageBox.Show("Selecione a data de Inicio!");
                return false;
            }
            return true;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                tb_fim.Text = date_time_dias.Value.ToString("dd-MM-yyyy") + " " + list_box_horario.Text;

            }
        }

=======
                
>>>>>>> 38f7503a662c7d21b1300ccf37437393264f0384
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime horaInicio = dateTimePickerInicio.Value;
            DateTime horaFim = dateTimePickerFim.Value;

<<<<<<< HEAD
            if (!DateTime.TryParse(tb_inicio.Text, out dataHoraInicio))
            {
                MessageBox.Show("Data/Horário de início inválido!");
            }
            else if (!DateTime.TryParse(tb_fim.Text, out dataHoraFim))
            {
                MessageBox.Show("Data/Horário de fim inválido!");
            }
            else
            {
                // Calcular a diferença entre as datas
                TimeSpan duracao = dataHoraFim - dataHoraInicio;

                // Exibir a duração total em um formato personalizado
                string duracaoFormatada = $"{(int)duracao.TotalDays} dias, {duracao.Hours}h e {duracao.Minutes} minutos";
                tb_valorfinaltempo.Text = duracaoFormatada;
            }
=======
            TimeSpan intervalo = horaFim - horaInicio;

            string intervaloDeTempo = FormatarIntervaloTempo(intervalo);

            tb_valorfinaltempo.Text = intervaloDeTempo.ToString();
>>>>>>> 38f7503a662c7d21b1300ccf37437393264f0384
        }

        private string FormatarIntervaloTempo(TimeSpan intervalo)
        {
<<<<<<< HEAD
            if (validarForm())
            {
                //primeiro botao ok
                tb_inicio.Text = date_time_dias.Value.ToString("dd-MM-yyyy") + " " + list_box_horario.Text;
            }
=======
            // Formata o intervalo de tempo no formato 'hh:mm'
            return $"{(int)intervalo.TotalHours:D2}:{intervalo.Minutes:D2}";
>>>>>>> 38f7503a662c7d21b1300ccf37437393264f0384
        }


        private void textBoxIntervaloEscolhido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_veiculosdisponiveis(object sender, EventArgs e)
        {

        }


        private void AdicionarColunas(DataGridView dgv_veiculos_, string tipoVeiculo, string[] colunas)
        {
            //limpamos a dgv anterior
            dgv_veiculos_.Columns.Clear();

            //add as colunas especificas para a grid dgv_veiculos_
            foreach (var coluna in colunas)
            {
                //add coluna name
                dgv_veiculos_.Columns.Add(coluna, coluna);
            }

            //completar os espaços vazios na grid
            dgv_veiculos_.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void btn_criar_reserva_Click(object sender, EventArgs e)
        {


            // Verifica se um veículo está selecionado na DataGridView
            if (dgv_veiculos_disponiveis.SelectedRows.Count > 0)
            {
                // Obtém a matrícula do veículo selecionado
                string matricula = dgv_veiculos_disponiveis.SelectedRows[0].Cells["Matrícula"].Value.ToString();

                // Procura o veículo na lista de veículos disponíveis
                object veiculoSelecionado = EmpresaController.Controlador.GetVeiculo(matricula,EmpresaController.Controlador.VeiculosDisponiveis);

                if (veiculoSelecionado != null)
                {
                    Veiculo veiculo = veiculoSelecionado as Veiculo;

                    // Adiciona a reserva para o veículo
                    veiculo.VeiculoStatus.DataInicio = dateTimePickerInicio.Value;
                    veiculo.VeiculoStatus.DataFim = dateTimePickerFim.Value;
                    EmpresaController.Controlador.ValidarReserva(matricula, veiculo.VeiculoStatus.DataInicio, veiculo.VeiculoStatus.DataFim);

                    veiculo.Reservar(dateTimePickerInicio.Value, dateTimePickerFim.Value);
                    EmpresaController.Controlador.AdicionarVeiculoReservado(veiculo);
                    EmpresaController.Controlador.VeiculosDisponiveis.Remove(veiculo);

                    // Atualiza a DataGridView
                    comboBox1_SelectedIndexChanged(null, null);

                    // Mostra uma mensagem de sucesso
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


        }

        private void date_time_dias_ValueChanged(object sender, EventArgs e)
        {
            cb_filtro.SelectedItem = null;
            lb_preco_total.Visible = false;
            btn_criar_reserva.Visible = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void bt_calcular_valor_a_pagar_Click(object sender, EventArgs e)
        {
            lb_preco_total.Visible = true;
            btn_criar_reserva.Visible = true;

            string matricula = dgv_veiculos_disponiveis.CurrentRow.Cells["Matrícula"].Value.ToString();

            string precoHoraString = dgv_veiculos_disponiveis.CurrentRow.Cells["Preço /h"].Value.ToString();
            double precoHora = double.Parse(precoHoraString.Replace(" €", ""));

            DateTime horaInicio = dateTimePickerInicio.Value;
            DateTime horaFim = dateTimePickerFim.Value;
            TimeSpan intervalo = horaFim - horaInicio;

            double intervaloHoras = intervalo.TotalHours;

            double valorAluguer = intervaloHoras * precoHora;

            lblPrecoFinal.Text = $"{valorAluguer.ToString("0.00")} €";
            lblMatriculaEscolhida.Text = $"{matricula}";

            lblMatriculaEscolhida.Visible = true;
            lblPrecoFinal.Visible = true ;
        }

        private void dateTimePickerInicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tb_matricula_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgv_veiculos_disponiveis.Rows.Count)
            {
                DataGridViewRow row = dgv_veiculos_disponiveis.Rows[e.RowIndex];
                string matricula = row.Cells["Matrícula"].Value.ToString();
                tb_matricula.Text = matricula;
            }
        }
    }
}
