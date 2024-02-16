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

                lb_title.ForeColor = System.Drawing.Color.SlateGray;

                this.BackColor = System.Drawing.Color.Black;
                panel_system_control.BackColor = System.Drawing.Color.Black;

                btnManageFiles.BackColor = System.Drawing.Color.Black;
                btnManageReservations.BackColor = System.Drawing.Color.Black;
                btnVehicleMaintenance.BackColor = System.Drawing.Color.Black;
                btn_change_veichle_status.BackColor = System.Drawing.Color.Black;
                btn_manage_users.BackColor = System.Drawing.Color.Black;
                btn_veichles_available.BackColor = System.Drawing.Color.Black;
                btn_veichle.BackColor = System.Drawing.Color.Black;
                btn_exit.BackColor = System.Drawing.Color.Black;

                PnlFormLoader.BackColor = System.Drawing.Color.DarkGray;

                btnManageFiles.ForeColor = System.Drawing.Color.SlateGray;
                btnManageReservations.ForeColor = System.Drawing.Color.SlateGray;
                btnVehicleMaintenance.ForeColor = System.Drawing.Color.SlateGray;
                btn_change_veichle_status.ForeColor = System.Drawing.Color.SlateGray;
                btn_manage_users.ForeColor = System.Drawing.Color.SlateGray;
                btn_veichles_available.ForeColor = System.Drawing.Color.SlateGray;
                btn_veichle.ForeColor = System.Drawing.Color.SlateGray;
                btn_exit.ForeColor = System.Drawing.Color.SlateGray;


            }

            //lblTitle.Text = "Add Veichle";
            //this.PnlFormLoader.Controls.Clear();
            //formAdicionarVeiculo FormAdicionarVeiculo = new formAdicionarVeiculo() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            //FormAdicionarVeiculo.FormBorderStyle = FormBorderStyle.None;
            //this.PnlFormLoader.Controls.Add(FormAdicionarVeiculo);
            //FormAdicionarVeiculo.Show();
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
            lb_title.Text = "Change Vehicle Status";
            this.PnlFormLoader.Controls.Clear();
            formChangeVehicleStatus FormChangeVehicleStatus = new formChangeVehicleStatus() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormChangeVehicleStatus.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormChangeVehicleStatus);
            FormChangeVehicleStatus.Show();
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
            lb_title.Text = "Vehicle Maintenance";
            this.PnlFormLoader.Controls.Clear();
            formVehicleMaintenance FormVehicleMaintenance = new formVehicleMaintenance() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FormVehicleMaintenance.FormBorderStyle = FormBorderStyle.None;
            this.PnlFormLoader.Controls.Add(FormVehicleMaintenance);
            FormVehicleMaintenance.Show();
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
    }
}
