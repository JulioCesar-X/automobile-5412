using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormPainelControlo : Form
    {
        public FormPainelControlo()
        {
            InitializeComponent();

            lb_user_logado.Text = EmpresaController.userLogado;
            timer1.Start();


            if (EmpresaController.userLogado != "#admin")
            {
                btn_manage_users.Image = null;
            }
            else
            {
                IsAdmin();

            }

        }

        private void Btn_adicionar_veiculo_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Add Vehicle";
            this.PnlFormLoader.Controls.Clear();
            FormAdicionarVeiculo formAdicionarVeiculo = new FormAdicionarVeiculo
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formAdicionarVeiculo);
            formAdicionarVeiculo.Show();
        }

        private void Btn_lista_veiculos_Click(object sender, EventArgs e)
        {
            lb_title.Text = "List of Vehicles";
            this.PnlFormLoader.Controls.Clear();
            FormListaVeiculos formChangeVehicleStatus = new FormListaVeiculos
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formChangeVehicleStatus);
            formChangeVehicleStatus.Show();

            if (EmpresaController.userLogado == "#admin")
            {
                lb_title.Text = "Vehicle Status";
            }

        }


        private void Btn_gerir_aluguer_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Vehicles Available for Rent";
            this.PnlFormLoader.Controls.Clear();
            FormGerirAluguer formVeiculosDisponiveisAlugar = new FormGerirAluguer
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formVeiculosDisponiveisAlugar);
            formVeiculosDisponiveisAlugar.Show();
        }
        private void Btn_sistema_reserva_Click_1(object sender, EventArgs e)
        {
            lb_title.Text = "Calculate Reserves";
            this.PnlFormLoader.Controls.Clear();
            FormSistemaReservas formSistemaReserva = new FormSistemaReservas
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formSistemaReserva);
            formSistemaReserva.Show();

        }

        private void Btn_calcular_reserva_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Reservations";
            this.PnlFormLoader.Controls.Clear();
            FormCalcularReserva formCalcularReserva = new FormCalcularReserva
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formCalcularReserva);
            formCalcularReserva.Show();
        }

        private void Btn_gerir_dados_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Files";
            this.PnlFormLoader.Controls.Clear();
            FormGerirDados formGerirDados = new FormGerirDados
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formGerirDados);
            formGerirDados.Show();
        }


        private void Btn_gerir_users_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Users";
            this.PnlFormLoader.Controls.Clear();
            FormGerirUsers formGerirUsers = new FormGerirUsers
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            this.PnlFormLoader.Controls.Add(formGerirUsers);
            formGerirUsers.Show();
        }

        private void Btn_alterar_conta_Click(object sender, EventArgs e)
        {
            FormSistemaLogin formLoginSystem = new FormSistemaLogin();
            this.Hide();
            formLoginSystem.FormClosed += (s, args) => this.Close();
            formLoginSystem.Show();
            MessageBox.Show("A sua sessão foi terminada com sucesso!", "Sessão Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Btn_retornar_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();

            InitializeComponent();
            if (EmpresaController.userLogado == "#admin")
            {
                IsAdmin();
            }

            EmpresaController.DataAtual = DateTime.Today.Date;

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lb_date_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_date.Text = EmpresaController.DataAtual.ToString("dd/MM/yyyy - dddd");

        }


        private void IsAdmin()
        {

            Image imagem = Properties.Resources.admin1;
            pb_user_image.Image = imagem;

            btn_manage_users.Text = "   Manage Users";
            btn_manage_users.Enabled = true;

            btn_change_veichle_status.Text = "   Vehicles Status";

            lb_user_logado.Text = "# Admin";

            lb_title.ForeColor = System.Drawing.Color.White;

            this.BackColor = System.Drawing.Color.Black;
            panel_system_control.BackColor = System.Drawing.Color.Black;

            btn_manage_users.BackColor = System.Drawing.Color.Gray;

            btn_manage_files.ForeColor = System.Drawing.Color.White;
            btn_sistema_reserva.ForeColor = System.Drawing.Color.White;
            btn_calcular_reserva.ForeColor = System.Drawing.Color.White;
            btn_change_veichle_status.ForeColor = System.Drawing.Color.White;
            btn_manage_users.ForeColor = System.Drawing.Color.White;
            btn_veichles_available.ForeColor = System.Drawing.Color.White;
            btn_veichle.ForeColor = System.Drawing.Color.White;

        }

        private void Btn_avancar_tempo_Click_1(object sender, EventArgs e)
        {
            EmpresaController.DataAtual = EmpresaController.DataAtual.AddDays(1);
            AtualizarListasVeiculos();

        }
        private void Btn_retornar_tempo_Click(object sender, EventArgs e)
        {
            if (EmpresaController.DataAtual.Date > DateTime.Today.Date)
            {
                EmpresaController.DataAtual = EmpresaController.DataAtual.AddDays(-1);
            }
            else
            {
                MessageBox.Show("Limite de recuo no tempo excedido!");
            }
        }

        private void AtualizarListasVeiculos()
        {
            AtualizarVeiculo(EmpresaController.Controlador.VeiculosAlugados);
            AtualizarVeiculo(EmpresaController.Controlador.VeiculosReservados, "Alugado");
            AtualizarVeiculo(EmpresaController.Controlador.VeiculosEmManutencao);
        }

        private void AtualizarVeiculo(List<object> listaRequerida, string statusDestino = "Disponivel")
        {
            foreach (var objeto in listaRequerida.ToArray())
            {
                Veiculo veiculo = objeto as Veiculo;

                if (veiculo != null && veiculo.VeiculoStatus.DataFim.Date == EmpresaController.DataAtual.Date)
                {
                    // Exibe um novo formulário de lista de veículos com os dados atualizados
                    ExibirFormListaVeiculos(objeto.GetType().Name, veiculo.VeiculoStatus.Nome.ToString(), objeto);

                    if (statusDestino == "Alugado" && MessageBox.Show("Deseja alugar o veículo?", "Confirmação de Aluguel", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ExibirFormSelecaoData(veiculo);
                    }

                    RemoverVeiculoDaLista(veiculo, veiculo.VeiculoStatus.Nome.ToString());
                    veiculo.RetornarDisponivel(EmpresaController.DataAtual, DateTime.MaxValue);

                    AdicionarVeiculoNaLista(veiculo, statusDestino);

                }
            }
        }

        private void RemoverVeiculoDaLista(Veiculo veiculo, string status)
        {
            EmpresaController.Controlador.RemoveVeiculoDaLista(veiculo, status);
        }

        private void AdicionarVeiculoNaLista(Veiculo veiculo, string novoStatus)
        {
            EmpresaController.Controlador.AdicionarVeiculoNaLista(veiculo, novoStatus);
        }

        private void ExibirFormListaVeiculos(string filtroTipoVeiculo, string filtroStatusVeiculo, object objeto)
        {
            this.PnlFormLoader.Controls.Clear();
            // Cria uma instância do FormListaVeiculos
            FormListaVeiculos formListaVeiculos = new FormListaVeiculos(filtroTipoVeiculo, filtroStatusVeiculo, objeto, PnlFormLoader)
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            // Define o formulário como filho do controle PnlFormLoader
            PnlFormLoader.Controls.Add(formListaVeiculos);

            formListaVeiculos.Show();

        }

        private void ExibirFormSelecaoData(Veiculo veiculo)
        {
            FormSelecaoData formSelecaoData = new FormSelecaoData
            {
                StartPosition = FormStartPosition.CenterScreen
            };
            DialogResult caixa = formSelecaoData.ShowDialog();

            if (caixa == DialogResult.OK)
            {
                DateTime inicioAluguel = formSelecaoData.InicioSelecionado.Date;
                DateTime fimAluguel = formSelecaoData.FimSelecionado.Date;

                veiculo.Alugar(inicioAluguel, fimAluguel);
            }
        }

    }
}
