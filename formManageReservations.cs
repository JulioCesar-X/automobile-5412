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
         public List<object> VeiculosDisponiveis { get; set; }

        public formManageReservations()
        {
            InitializeComponent();
        }
                
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_filtro.SelectedIndex)
            {
                case 0:
                    dataGridViewCarros.Visible = true;
                    dataGridViewMotas.Visible = false;
                    dataGridViewCamionetas.Visible = false;
                    dgv_veiculos_disponiveis.Visible = false;
                    VeiculosDisponiveis = new List<object>();

                    
                    break;
                case 1:
                    dataGridViewMotas.Visible = true;
                    dataGridViewCarros.Visible = false;
                    dataGridViewCamionetas.Visible = false;
                    dgv_veiculos_disponiveis.Visible = false;
                    break;
                case 2:
                    dataGridViewCamionetas.Visible = true;
                    dataGridViewMotas.Visible = false;
                    dataGridViewCarros.Visible = false;
                    dgv_veiculos_disponiveis.Visible = false;
                    break;
                case 3:
                    dgv_veiculos_disponiveis.Visible = true;
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
                list_box_horario.Items.Add(horario.ToString().Substring(0,5));
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

        private List<object> GetListDoTipo(string tipo) 
        {
            bool flag = EmpresaController.ValidarListaVeiculosDoTipo(tipo);

            if (flag) 
            {
                var minhaLista = EmpresaController.Controlador.Veiculos;
                foreach (var veiculo in minhaLista)
                {
                    if () 
                    {

                    }
                    VeiculosDisponiveis.Add(veiculo);
                }
                
            }
            return;
        }
    }
}
