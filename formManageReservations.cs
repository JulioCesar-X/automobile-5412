using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formManageReservations : Form
    {
        public List<object> veiculosDisponiveis = new List<object>();

        public formManageReservations()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_filtro.SelectedIndex)
            {
                case 0:

                    AdicionarColunas(dgv_veiculos_disponiveis, "Carro", new string[] { "Matrícula", "Modelo", "Nº Portas", "Tipo de Caixa", "Preço / dia" });
                    PreencheListaDisponiveis("Carro");
                    foreach (var veiculo in veiculosDisponiveis)
                    {
                        Carro carro = veiculo as Carro;

                        dgv_veiculos_disponiveis.Rows.Add(
                                   carro.VeiculoMatricula,
                                   carro.VeiculoModelo,
                                   carro.TipoCaixa,
                                   carro.VeiculoPreco + " €",
                                   carro.VeiculoStatus

                                   );
                    }
                    break;

                case 1:

                    AdicionarColunas(dgv_veiculos_disponiveis, "Mota", new string[] { "Matrícula", "Modelo", "Cilindrada", "Preço / dia" });
                    PreencheListaDisponiveis("Mota");

                    foreach (var veiculo in veiculosDisponiveis)
                    {
                        Mota mota = veiculo as Mota;

                        dgv_veiculos_disponiveis.Rows.Add(
                                    mota.VeiculoMatricula,
                                    mota.VeiculoModelo,
                                    mota.Cilindrada + " cc",
                                    mota.VeiculoPreco + " €",
                                    mota.VeiculoStatus
                                    );
                    }
                    break;

                case 2:

                    AdicionarColunas(dgv_veiculos_disponiveis, "Camioneta", new string[] { "Matrícula", "Modelo", "Nº de Eixos", "Nº Máx. Passageiros", "Preço / dia" });
                    PreencheListaDisponiveis("Camioneta");

                    foreach (var veiculo in veiculosDisponiveis)
                    {
                        Camioneta camioneta = veiculo as Camioneta;

                        dgv_veiculos_disponiveis.Rows.Add(
                                    camioneta.VeiculoMatricula,
                                    camioneta.VeiculoModelo,
                                    camioneta.NumeroEixos,
                                    camioneta.NumeroPassageiros,
                                    camioneta.VeiculoPreco + " €",
                                    camioneta.VeiculoStatus
                                    );
                    }
                    break;

                case 3:

                    AdicionarColunas(dgv_veiculos_disponiveis, "Camiao", new string[] { "Matrícula", "Modelo", "Peso Máx. Suportado", "Preço / dia" });
                    PreencheListaDisponiveis("Camiao");

                    foreach (var veiculo in veiculosDisponiveis)
                    {
                        Camiao camiao = veiculo as Camiao;

                        dgv_veiculos_disponiveis.Rows.Add(
                                   camiao.VeiculoMatricula,
                                   camiao.VeiculoModelo,
                                   camiao.PesoMaximo,
                                   camiao.VeiculoPreco + " €",
                                   camiao.VeiculoStatus
                                   );
                    }
                    break;
            }
        }

        private void formManageReservations_Load(object sender, EventArgs e)
        {
            MontarHorarios();
        }

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
                tb_fim.Text = date_time_dias.Value.ToString().Substring(0, 10) + " " + list_box_horario.Text;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var dataHoraInicio = new DateTime();
            var dataHoraFim = new DateTime();

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
                tb_valorfinaltempo.Text = (dataHoraFim - dataHoraInicio).ToString();
            }
        }

        private void btnOkInicio_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                //primeiro botao ok
                tb_inicio.Text = date_time_dias.Value.ToString().Substring(0, 10) + " " + list_box_horario.Text;
            }
        }

        private void textBoxIntervaloEscolhido_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgv_veiculosdisponiveis(object sender, EventArgs e)
        {

        }

        private void PreencheListaDisponiveis(string tipo)
        {
            if (veiculosDisponiveis.Count() != 0)
            {
                veiculosDisponiveis.Clear();
            }

            bool flag = EmpresaController.ValidarListaVeiculosDoTipo(tipo);

            if (flag)
            {
                var minhaLista = EmpresaController.Controlador.GetListaVeciulosDoTipo(tipo);

                foreach (var objeto in minhaLista)
                {
                    Veiculo veiculo = objeto as Veiculo;

                    if (veiculo.VeiculoStatus == "Disponivel")
                    {
                        veiculosDisponiveis.Add(veiculo);
                    }

                }

            }
            //
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


            //TODO: Validações para enviar a msg box caso n encontrou o veiculo especificado

            //TODO: criar Gerador id reserva automatico que deve começar apartir do ultimo valor ja registrado na lista de reservas
            int id = 0;


            //TODO:Criar uma função que pegue um veiculo quando enviada a matricula
            //Veiculo veiculoSelecionado = (Veiculo)Empresa.Controller.getVeiculo(tb_matricula);
            //EmpresaController.CriarReserva(id++, DateTime.Parse(tb_inicio.Text), DateTime.Parse(tb_fim.Text), veiculoSelecionado);


        }
    }
}
