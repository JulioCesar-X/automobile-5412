using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormPainelControlo : Form
    {

        //private Veiculo veiculoEncontrado;
        //private object[] arrayListaSelecionadaCopia;
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



        //Button ADD Veichle
        private void Button1_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Add Vehicle";
            this.PnlFormLoader.Controls.Clear();
            FormAdicionarVeiculo formAdicionarVeiculo = new FormAdicionarVeiculo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formAdicionarVeiculo.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formAdicionarVeiculo);
            formAdicionarVeiculo.Show();
        }

        //Button Change Vehicle Status
        private void Button2_Click(object sender, EventArgs e)
        {
            lb_title.Text = "List of Vehicles";
            this.PnlFormLoader.Controls.Clear();
            FormListaVeiculos formChangeVehicleStatus = new FormListaVeiculos() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formChangeVehicleStatus.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formChangeVehicleStatus);
            formChangeVehicleStatus.Show();

            if (EmpresaController.userLogado == "#admin")
            {
                lb_title.Text = "Vehicle Status";
            }

        }

        //Button Vehicles Available for Rent
        private void Button3_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Vehicles Available for Rent";
            this.PnlFormLoader.Controls.Clear();
            FormVeiculosDisponiveisAlugar formVeiculosDisponiveisAlugar = new FormVeiculosDisponiveisAlugar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formVeiculosDisponiveisAlugar.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formVeiculosDisponiveisAlugar);
            formVeiculosDisponiveisAlugar.Show();
        }

        private void BtnVehicleMaintenance_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Calculate Reserves";
            this.PnlFormLoader.Controls.Clear();
            FormTimeSimulation formTimeSimulation = new FormTimeSimulation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formTimeSimulation.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formTimeSimulation);
            formTimeSimulation.Show();
        }

        private void BtnManageReservations_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Reservations";
            this.PnlFormLoader.Controls.Clear();
            FormManageReservations formManageReservations = new FormManageReservations() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formManageReservations.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formManageReservations);
            formManageReservations.Show();
        }

        private void BtnManageFiles_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Files";
            this.PnlFormLoader.Controls.Clear();
            FormGerirDados formManageFiles = new FormGerirDados() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formManageFiles.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formManageFiles);
            formManageFiles.Show();
        }



        private void Button7_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void Btn_manage_users_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Users";
            this.PnlFormLoader.Controls.Clear();
            formManageUsers formManageUsers = new formManageUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            formManageUsers.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(formManageUsers);
            formManageUsers.Show();
        }

        private void BtnChangeAccount_Click(object sender, EventArgs e)
        {
            FormLoginSystem formLoginSystem = new FormLoginSystem();
            this.Hide();
            formLoginSystem.FormClosed += (s, args) => this.Close();
            formLoginSystem.Show();
            MessageBox.Show("A sua sessão foi terminada com sucesso!", "Sessão Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void Timer1_Tick(object sender, EventArgs e)
        {
            lb_date_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_date.Text = EmpresaController.DataAtual.ToString("dd/MM/yyyy - dddd");

        }

        private void Btn_back_begin_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();



            InitializeComponent();


            if (EmpresaController.userLogado == "#admin")
            {
                IsAdmin();
            }



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

            //PnlFormLoader.BackColor = System.Drawing.Color.DarkGray;

            btn_manage_users.BackColor = System.Drawing.Color.Gray;

            btn_manage_files.ForeColor = System.Drawing.Color.White;
            btn_manage_reservations.ForeColor = System.Drawing.Color.White;
            btn_vehicle_aintenance.ForeColor = System.Drawing.Color.White;
            btn_change_veichle_status.ForeColor = System.Drawing.Color.White;
            btn_manage_users.ForeColor = System.Drawing.Color.White;
            btn_veichles_available.ForeColor = System.Drawing.Color.White;
            btn_veichle.ForeColor = System.Drawing.Color.White;







        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            EmpresaController.DataAtual = EmpresaController.DataAtual.AddDays(1);

            AtualizarListasVeiculos();


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
            FormListaVeiculos formListaVeiculos = new FormListaVeiculos(filtroTipoVeiculo, filtroStatusVeiculo, objeto, PnlFormLoader);
            // Define o formulário como filho do controle PnlFormLoader
            formListaVeiculos.TopLevel = false;
            formListaVeiculos.Dock = DockStyle.Fill;
            PnlFormLoader.Controls.Add(formListaVeiculos);

            // Exibe o formulário
            formListaVeiculos.Show();


        }


        private void ExibirFormSelecaoData(Veiculo veiculo)
        {
            SelecaoData formSelecaoData = new SelecaoData();
            formSelecaoData.StartPosition = FormStartPosition.CenterScreen;
            DialogResult caixa = formSelecaoData.ShowDialog();

            if (caixa == DialogResult.OK)
            {
                DateTime inicioAluguel = formSelecaoData.InicioSelecionado.Date;
                DateTime fimAluguel = formSelecaoData.FimSelecionado.Date;

                veiculo.Alugar(inicioAluguel, fimAluguel);
            }
        }


        private void lb_date_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_previous_Click(object sender, EventArgs e)
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



    }
}
