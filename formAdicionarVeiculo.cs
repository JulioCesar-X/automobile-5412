﻿using System;
using System.Globalization;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formAdicionarVeiculo : Form
    {
        private string _modelo;
        private string _matricula;
        private decimal _preco;

        public formAdicionarVeiculo()
        {
            InitializeComponent();

            btn_criar.Visible = false;
            btn_criar.Enabled = false;
            lb_modelo.Visible = false;
            lb_matricula.Visible = false;
            tb_id_matricula.Visible = false;
            tb_modelo_marca.Visible = false;

        }

        //apenas a view que mostra o local de preenchimento 
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            pb_add_veiculos.Visible = false;

            switch (cb_tipo.SelectedIndex)
            {
                case 0:

                    lb_modelo.Visible = true;
                    lb_matricula.Visible = true;
                    tb_id_matricula.Visible = true;
                    tb_modelo_marca.Visible = true;

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
                    btn_criar.Enabled = true;
                    btn_criar.Visible = true;
                    lb_preco.Visible = true;
                    tb_preco.Visible = true;

                    break;
                case 1:

                    lb_modelo.Visible = true;
                    lb_matricula.Visible = true;
                    tb_id_matricula.Visible = true;
                    tb_modelo_marca.Visible = true;

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
                    btn_criar.Enabled = true;
                    btn_criar.Visible = true;
                    lb_preco.Visible = true;
                    tb_preco.Visible = true;

                    break;

                case 2:

                    lb_modelo.Visible = true;
                    lb_matricula.Visible = true;
                    tb_id_matricula.Visible = true;
                    tb_modelo_marca.Visible = true;

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
                    btn_criar.Enabled = true;
                    btn_criar.Visible = true;
                    lb_preco.Visible = true;
                    tb_preco.Visible = true;

                    break;

                case 3:

                    lb_modelo.Visible = true;
                    lb_matricula.Visible = true;
                    tb_id_matricula.Visible = true;
                    tb_modelo_marca.Visible = true;

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
                    btn_criar.Enabled = true;
                    btn_criar.Visible = true;
                    lb_preco.Visible = true;
                    tb_preco.Visible = true;


                    break;
            }
        }

        //Caso preenchido e ao click cria de facto o objeto
        private void btn_criar_Click(object sender, EventArgs e)
        {
            switch (cb_tipo.SelectedIndex)
            {
                case 0:

                    int numPortas = int.Parse(comboBoxNmrPortas.SelectedItem.ToString());
                    string tipoCaixa = comboBoxTipoCaixa.SelectedItem.ToString();

                    if (EmpresaController.CriarCarro(_matricula, _modelo, _preco, numPortas, tipoCaixa))
                    {
                        //Estamos limpando especificamente
                        tb_id_matricula.Clear();
                        tb_modelo_marca.Clear();
                        tb_preco.Clear();
                        comboBoxNmrPortas.SelectedItem = null;
                        comboBoxTipoCaixa.SelectedItem = null;


                    }

                    break;

                case 1:

                    string[] aux = comboBoxCilindrada.SelectedItem.ToString().Split('c'); // [150 , cc]

                    int cilindrada = int.Parse(aux[0]);

                    if (EmpresaController.CriarMota(_matricula, _modelo, _preco, cilindrada))
                    {
                        tb_id_matricula.Clear();
                        tb_modelo_marca.Clear();
                        tb_preco.Clear();
                        comboBoxCilindrada.SelectedItem = null;

                    }


                    break;
                case 2:

                    int numEixos = int.Parse(comboBoxNmrEixos.SelectedItem.ToString());
                    int numPassageiros = int.Parse(textBoxNmrMaxPassageiros.Text);

                    if (EmpresaController.CriarCamioneta(_matricula, _modelo, _preco, numEixos, numPassageiros))
                    {
                        tb_id_matricula.Clear();
                        tb_modelo_marca.Clear();
                        tb_preco.Clear();
                        textBoxNmrMaxPassageiros.Clear();
                        comboBoxNmrEixos.SelectedItem = null;

                    }
                    break;
                case 3:

                    int pesoMax = int.Parse(textBoxPesoMaxSuportado.Text);

                    if (EmpresaController.CriarCamiao(_matricula, _modelo, _preco, pesoMax))
                    {
                        tb_id_matricula.Clear();
                        tb_modelo_marca.Clear();
                        tb_preco.Clear();
                        textBoxPesoMaxSuportado.Clear();


                    }
                    break;
            }
        }

        private void tb_modelo_marca_TextChanged(object sender, EventArgs e)
        {
            _modelo = tb_modelo_marca.Text;
        }

        private void tb_id_matricula_TextChanged(object sender, EventArgs e)
        {
            _matricula = tb_id_matricula.Text.Trim();
        }


        private void tb_preco_TextChanged(object sender, EventArgs e)
        {
            string precoText = tb_preco.Text.Trim();

            // Especificar a cultura inglesa (onde o ponto é o separador decimal)
            CultureInfo culture = CultureInfo.InvariantCulture;

            if (!decimal.TryParse(precoText, NumberStyles.Number, culture, out decimal _precoConvertido))
            {
                // Verifica se o texto inserido é vazio, caso seja, não mostra o MessageBox
                if (!string.IsNullOrEmpty(precoText))
                {
                    MessageBox.Show("Por favor, insira um valor de preço válido.");
                }
            }
            else
            {
                _preco = _precoConvertido;
            }
        }


    }
}
