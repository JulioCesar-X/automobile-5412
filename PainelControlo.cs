using System;
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

            if (EmpresaController.userLogado == "#")
            {

                Image imagem = Properties.Resources.admin1;
                pb_user_image.Image = imagem;

                btn_manage_users.Text = "Manage Users";
                btn_manage_users.Enabled = true;

                btn_change_veichle_status.Text = "Change Vehicles Status";

                lb_user_logado.Text = "# Admin";

                lb_title.ForeColor = System.Drawing.Color.SlateGray;

                this.BackColor = System.Drawing.Color.Black;
                panel_system_control.BackColor = System.Drawing.Color.Black;




                PnlFormLoader.BackColor = System.Drawing.Color.DarkGray;

                btn_change_account.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_files.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_reservations.ForeColor = System.Drawing.Color.SlateGray;
                btn_vehicle_aintenance.ForeColor = System.Drawing.Color.SlateGray;
                btn_change_veichle_status.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_users.ForeColor = System.Drawing.Color.SlateGray;
                btn_veichles_available.ForeColor = System.Drawing.Color.SlateGray;
                btn_veichle.ForeColor = System.Drawing.Color.SlateGray;
                btn_exit.ForeColor = System.Drawing.Color.SlateGray;

                btn_manage_users.FlatAppearance.BorderColor = Color.White;
                btn_manage_users.FlatAppearance.BorderSize = 1;

                pb_users_manage.BackgroundImage = Properties.Resources.pngwing_com__23_;
            }




        }



        //Button ADD Veichle
        private void button1_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Add Vehicle";
            this.PnlFormLoader.Controls.Clear();
            formAdicionarVeiculo FormAdicionarVeiculo = new formAdicionarVeiculo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormAdicionarVeiculo.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormAdicionarVeiculo);
            FormAdicionarVeiculo.Show();
        }

        //Button Change Vehicle Status
        private void button2_Click(object sender, EventArgs e)
        {
            lb_title.Text = "List of Vehicles";
            this.PnlFormLoader.Controls.Clear();
            formChangeVehicleStatus FormChangeVehicleStatus = new formChangeVehicleStatus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormChangeVehicleStatus.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormChangeVehicleStatus);
            FormChangeVehicleStatus.Show();

            if (EmpresaController.userLogado == "#")
            {
                lb_title.Text = "Change Vehicle Status";
            }

        }

        //Button Vehicles Available for Rent
        private void button3_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Vehicles Available for Rent";
            this.PnlFormLoader.Controls.Clear();
            formVeiculosDisponiveisAlugar FormVeiculosDisponiveisAlugar = new formVeiculosDisponiveisAlugar() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormVeiculosDisponiveisAlugar.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormVeiculosDisponiveisAlugar);
            FormVeiculosDisponiveisAlugar.Show();
        }

        private void btnVehicleMaintenance_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Time Simulation and Billing";
            this.PnlFormLoader.Controls.Clear();
            formTimeSimulation FormTimeSimulation = new formTimeSimulation() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormTimeSimulation.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormTimeSimulation);
            FormTimeSimulation.Show();
        }

        private void btnManageReservations_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Reservations";
            this.PnlFormLoader.Controls.Clear();
            formManageReservations FormManageReservations = new formManageReservations() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormManageReservations.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormManageReservations);
            FormManageReservations.Show();
        }

        private void btnManageFiles_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Files";
            this.PnlFormLoader.Controls.Clear();
            formManageFiles FormManageFiles = new formManageFiles() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormManageFiles.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormManageFiles);
            FormManageFiles.Show();
        }



        private void button7_Click(object sender, EventArgs e)
        {

            Application.Exit();

        }

        private void btn_manage_users_Click(object sender, EventArgs e)
        {
            lb_title.Text = "Manage Users";
            this.PnlFormLoader.Controls.Clear();
            formManageUsers FormManageUsers = new formManageUsers() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormManageUsers.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormManageUsers);
            FormManageUsers.Show();
        }

        private void btnChangeAccount_Click(object sender, EventArgs e)
        {
            FormLoginSystem formLoginSystem = new FormLoginSystem();
            this.Hide();
            formLoginSystem.FormClosed += (s, args) => this.Close();
            formLoginSystem.Show();
            MessageBox.Show("A sua sessão foi terminada com sucesso!", "Sessão Terminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            lb_date_time.Text = DateTime.Now.ToString("HH:mm:ss");
            lb_date.Text = DateTime.Now.ToString("dddd - dd/MM/yyyy");
        }

        private void btn_back_begin_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();



            InitializeComponent();
            if (EmpresaController.userLogado == "#")
            {

                Image imagem = Properties.Resources.admin1;
                pb_user_image.Image = imagem;

                btn_manage_users.Text = "Manage Users";
                btn_manage_users.Enabled = true;

                btn_change_veichle_status.Text = "Change Vehicles Status";

                lb_user_logado.Text = "# Admin";

                lb_title.ForeColor = System.Drawing.Color.SlateGray;

                this.BackColor = System.Drawing.Color.Black;
                panel_system_control.BackColor = System.Drawing.Color.Black;




                PnlFormLoader.BackColor = System.Drawing.Color.DarkGray;

                btn_change_account.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_files.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_reservations.ForeColor = System.Drawing.Color.SlateGray;
                btn_vehicle_aintenance.ForeColor = System.Drawing.Color.SlateGray;
                btn_change_veichle_status.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_users.ForeColor = System.Drawing.Color.SlateGray;
                btn_veichles_available.ForeColor = System.Drawing.Color.SlateGray;
                btn_veichle.ForeColor = System.Drawing.Color.SlateGray;
                btn_exit.ForeColor = System.Drawing.Color.SlateGray;

                btn_manage_users.FlatAppearance.BorderColor = Color.White;
                btn_manage_users.FlatAppearance.BorderSize = 1;

                pb_users_manage.BackgroundImage = Properties.Resources.pngwing_com__23_;
            }

        }
    }
}
