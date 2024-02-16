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
    public partial class formAdicionarVeiculo : Form
    {
        public formAdicionarVeiculo()
        {
            InitializeComponent();
        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            


            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    lblNmrPortas.Visible = true;
                    comboBoxNmrPortas.Visible = true;
                    lblTipoCaixa.Visible = true;
                    comboBoxTipoCaixa.Visible = true;
                    lblCilindrada.Visible = false;
                    comboBoxCilindrada.Visible = false;
                    lblNmrEixos.Visible = false;
                    comboBoxNmrEixos.Visible = false;
                    lblNmrMaxPassageiros.Visible = false;
                    textBoxNmrMaxPassageiros.Visible = false;
                    lblPesoMaxSuportado.Visible = false;
                    textBoxPesoMaxSuportado.Visible = false;
                    break;
                case 1:
                    lblCilindrada.Visible = true;
                    comboBoxCilindrada.Visible = true;
                    lblNmrPortas.Visible = false;
                    comboBoxNmrPortas.Visible = false;
                    lblTipoCaixa.Visible = false;
                    comboBoxTipoCaixa.Visible = false;
                    lblNmrEixos.Visible = false;
                    comboBoxNmrEixos.Visible = false;
                    lblNmrMaxPassageiros.Visible = false;
                    textBoxNmrMaxPassageiros.Visible = false;
                    lblPesoMaxSuportado.Visible = false;
                    textBoxPesoMaxSuportado.Visible = false;
                    break;
                case 2:
                    lblNmrEixos.Visible = true;
                    comboBoxNmrEixos.Visible = true;
                    lblNmrMaxPassageiros.Visible = true;
                    textBoxNmrMaxPassageiros.Visible = true;
                    lblCilindrada.Visible = false;
                    comboBoxCilindrada.Visible = false;
                    lblNmrPortas.Visible = false;
                    comboBoxNmrPortas.Visible = false;
                    lblTipoCaixa.Visible = false;
                    comboBoxTipoCaixa.Visible = false;
                    lblPesoMaxSuportado.Visible = false;
                    textBoxPesoMaxSuportado.Visible = false;
                    break;
                case 3:
                    lblPesoMaxSuportado.Visible = true;
                    textBoxPesoMaxSuportado.Visible = true;
                    lblNmrEixos.Visible = false;
                    comboBoxNmrEixos.Visible = false;
                    lblNmrMaxPassageiros.Visible = false;
                    textBoxNmrMaxPassageiros.Visible = false;
                    lblCilindrada.Visible = false;
                    comboBoxCilindrada.Visible = false;
                    lblNmrPortas.Visible = false;
                    comboBoxNmrPortas.Visible = false;
                    lblTipoCaixa.Visible = false;
                    comboBoxTipoCaixa.Visible = false;
                    break;
            }
        }
    }
}
