using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Automobile
{
    public partial class formChangeVehicleStatus : Form
    {
        public formChangeVehicleStatus()
        {
            InitializeComponent();

            DataGridViewComboBoxColumn comboBoxColumn = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn comboBoxColumn1 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn comboBoxColumn2 = new DataGridViewComboBoxColumn();
            DataGridViewComboBoxColumn comboBoxColumn3 = new DataGridViewComboBoxColumn();

            comboBoxColumn.HeaderText = "Estado";
            comboBoxColumn1.HeaderText = "Estado";
            comboBoxColumn2.HeaderText = "Estado";
            comboBoxColumn3.HeaderText = "Estado";
            comboBoxColumn.Name = "comboBoxColumn";

            // Adicione opções ao ComboBox
            comboBoxColumn.Items.Add("Disponível");
            comboBoxColumn.Items.Add("Alugado");
            comboBoxColumn.Items.Add("Reservado");
            comboBoxColumn.Items.Add("Manutenção");

            comboBoxColumn1.Items.Add("Disponível");
            comboBoxColumn1.Items.Add("Alugado");
            comboBoxColumn1.Items.Add("Reservado");
            comboBoxColumn1.Items.Add("Manutenção");

            comboBoxColumn2.Items.Add("Disponível");
            comboBoxColumn2.Items.Add("Alugado");
            comboBoxColumn2.Items.Add("Reservado");
            comboBoxColumn2.Items.Add("Manutenção");

            comboBoxColumn3.Items.Add("Disponível");
            comboBoxColumn3.Items.Add("Alugado");
            comboBoxColumn3.Items.Add("Reservado");
            comboBoxColumn3.Items.Add("Manutenção");

            // Adicione a coluna preenchida ao DataGridView
            dataGridViewCarros.Columns.Add(comboBoxColumn);
            dataGridViewMotas.Columns.Add(comboBoxColumn1);
            dataGridViewCamionetas.Columns.Add(comboBoxColumn2);
            dataGridViewCamioes.Columns.Add(comboBoxColumn3);
        }

        private void comboBoxFiltrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            switch (comboBoxFiltrar.SelectedIndex)
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

        
    }
}
