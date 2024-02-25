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

                btn_change_account.BackColor = System.Drawing.Color.Black;
                btn_manage_files.BackColor = System.Drawing.Color.Black;
                btn_manage_reservations.BackColor = System.Drawing.Color.Black;
                btn_vehicle_aintenance.BackColor = System.Drawing.Color.Black;
                btn_change_veichle_status.BackColor = System.Drawing.Color.Black;
                btn_manage_users.BackColor = System.Drawing.Color.Black;
                btn_veichles_available.BackColor = System.Drawing.Color.Black;
                btn_veichle.BackColor = System.Drawing.Color.Black;
                btn_exit.BackColor = System.Drawing.Color.Black;

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

                lb_date_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // Formato da data e hora
                Controls.Add(lb_date_time);

                // Inicie um timer para atualizar a label da data e hora a cada segundo
                Timer timerAdmin = new Timer();
                timerAdmin.Interval = 1000; // Intervalo de atualização em milissegundos (1 segundo)
                timerAdmin.Tick += (sender, e) =>
                {
                    lb_date_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                };
                timerAdmin.Start();

            }


            lb_date_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"); // Formato da data e hora
            Controls.Add(lb_date_time);

            // Inicie um timer para atualizar a label da data e hora a cada segundo
            Timer timer = new Timer();
            timer.Interval = 1000; // Intervalo de atualização em milissegundos (1 segundo)
            timer.Tick += (sender, e) =>
            {
                lb_date_time.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            };
            timer.Start();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {


            this.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

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
            lb_title.Text = "Time Simulation & Billing";
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

        private void FormPainelControlo_Load(object sender, EventArgs e)
        {

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

        private void PnlFormLoader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
