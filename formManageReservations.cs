using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formManageReservations : Form
    {
        
        public formManageReservations()
        {
            InitializeComponent();
        }
                
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    dataGridViewCarros.Visible = true;
                    dataGridViewMotas.Visible = false;
                    dataGridViewCamionetas.Visible = false;
                    dataGridViewCamioes.Visible = false;
                    break;
                case 1:
                    dataGridViewMotas.Visible = true;
                    dataGridViewCarros.Visible = false;
                    dataGridViewCamionetas.Visible = false;
                    dataGridViewCamioes.Visible = false;
                    break;
                case 2:
                    dataGridViewCamionetas.Visible = true;
                    dataGridViewMotas.Visible = false;
                    dataGridViewCarros.Visible = false;
                    dataGridViewCamioes.Visible = false;
                    break;
                case 3:
                    dataGridViewCamioes.Visible = true;
                    dataGridViewCamionetas.Visible = false;
                    dataGridViewMotas.Visible = false;
                    dataGridViewCarros.Visible = false;
                    break;
            }
        }

        private void formManageReservations_Load(object sender, EventArgs e)
        {
            montarHorarios();
        }

        private void montarHorarios()
        {
            var horario = new TimeSpan(0,0,0);
            var incremento = new TimeSpan(0,30,0);

            for (int i = 0; i < 48; i++)
            {
                listBox1.Items.Add(horario.ToString().Substring(0,5));
                horario += incremento;
            }
        }

        private bool validarForm()
        {
            if (listBox1.Text == "")
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
                textBoxFim.Text = dateTimePicker1.Value.ToString().Substring(0, 10) + " " + listBox1.Text;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            var dataHoraInicio = new DateTime();
            var dataHoraFim = new DateTime();

            if (!DateTime.TryParse(textBoxInicio.Text, out dataHoraInicio))
            {
                MessageBox.Show("Data/Horário de início inválido!");
            }
            else if (!DateTime.TryParse(textBoxFim.Text, out dataHoraFim))
            {
                MessageBox.Show("Data/Horário de fim inválido!");
            }
            else
            {
                textBoxIntervaloEscolhido.Text = (dataHoraFim - dataHoraInicio).ToString();
            }
        }

        private void btnOkInicio_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                textBoxInicio.Text = dateTimePicker1.Value.ToString().Substring(0, 10) + " " + listBox1.Text;
            }
        }
    }
}
