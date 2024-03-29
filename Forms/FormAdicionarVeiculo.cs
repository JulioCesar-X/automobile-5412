﻿using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Automobile
{
    public partial class FormAdicionarVeiculo : Form
    {
        private string _modelo;
        private string _matricula;
        private string _preco;

        private bool CamposVeiculosPreenchidos
        {
            get
            {
                // Especificar a cultura inglesa (onde o ponto é o separador decimal)
                CultureInfo culture = CultureInfo.InvariantCulture;

                return (
                          !string.IsNullOrEmpty(_modelo) &&
                          !string.IsNullOrEmpty(_matricula) &&
                          decimal.TryParse(_preco, NumberStyles.Number, culture, out decimal preco) &&
                          preco > 0
                      );
            }
        }
        private bool CamposCarroPreenchidos
        {
            get
            {
                return (
                         CamposVeiculosPreenchidos &&
                         comboBoxNmrPortas.SelectedItem != null &&
                         comboBoxTipoCaixa.SelectedItem != null
                     );
            }
        }
        private bool CamposMotaPreenchidos
        {
            get
            {
                return (
                         CamposVeiculosPreenchidos &&
                         comboBoxCilindrada.SelectedItem != null
                     );
            }
        }
        private bool CamposCamionetaPreenchidos
        {
            get
            {
                return (
                         CamposVeiculosPreenchidos &&
                         comboBoxNmrEixos.SelectedItem != null &&
                         !string.IsNullOrEmpty(textBoxNmrMaxPassageiros.Text)
                     );
            }
        }
        private bool CamposCamiaoPreenchidos
        {
            get
            {
                return (
                         CamposVeiculosPreenchidos &&
                         !string.IsNullOrEmpty(textBoxPesoMaxSuportado.Text)
                     );
            }
        }

        public FormAdicionarVeiculo()
        {
            InitializeComponent();

            lb_modelo.Visible = false;
            lb_matricula.Visible = false;
            tb_id_matricula.Visible = false;
            tb_modelo_marca.Visible = false;

        }

        private void CriarBordaVermelha(Control objetoCriado)
        {
            Graphics elemento = objetoCriado.CreateGraphics(); ;

            int borda = 5;
            int margemX = 0;
            int margemY = 0;

            Pen pen = new Pen(Color.LightCoral, borda);
            Rectangle r = new Rectangle(margemX, margemY, objetoCriado.Width - borda, objetoCriado.Height - borda);
            elemento.DrawRectangle(pen, r);

        }

        private void PintarBordaVermelho()
        {

            if (string.IsNullOrEmpty(_matricula))
            {
                CriarBordaVermelha(tb_id_matricula);

            }

            if (string.IsNullOrEmpty(_modelo))
            {
                CriarBordaVermelha(tb_modelo_marca);
            }

            if (!decimal.TryParse(_preco, out decimal preco) || preco <= 0)
            {
                tb_preco.Text = null;
                CriarBordaVermelha(tb_preco);
                MessageBox.Show("Insira um preco válido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (cb_tipo.SelectedIndex == 0)
            {
                if (comboBoxNmrPortas.SelectedItem == null)
                {
                    CriarBordaVermelha(comboBoxNmrPortas);
                }

                if (comboBoxTipoCaixa.SelectedItem == null)
                {
                    CriarBordaVermelha(comboBoxTipoCaixa);
                }
            }
            else if (cb_tipo.SelectedIndex == 1)
            {
                if (comboBoxCilindrada.SelectedItem == null)
                {
                    CriarBordaVermelha(comboBoxCilindrada);
                }
            }
            else if (cb_tipo.SelectedIndex == 2)
            {
                if (comboBoxNmrEixos.SelectedItem == null)
                {
                    CriarBordaVermelha(comboBoxNmrEixos);
                }

                if (string.IsNullOrEmpty(textBoxNmrMaxPassageiros.Text))
                {
                    CriarBordaVermelha(textBoxNmrMaxPassageiros);
                }
            }
            else if (cb_tipo.SelectedIndex == 3)
            {
                if (string.IsNullOrEmpty(textBoxPesoMaxSuportado.Text))
                {
                    CriarBordaVermelha(textBoxPesoMaxSuportado);
                }
            }

        }

        private bool ChecarCampos()
        {
            bool flagCamposPreenchidos;
            switch (cb_tipo.SelectedIndex)
            {
                case 0:
                    flagCamposPreenchidos = CamposCarroPreenchidos;
                    break;

                case 1:
                    flagCamposPreenchidos = CamposMotaPreenchidos;
                    break;

                case 2:
                    flagCamposPreenchidos = CamposCamionetaPreenchidos;
                    break;

                case 3:
                    flagCamposPreenchidos = CamposCamiaoPreenchidos;
                    break;

                default:
                    flagCamposPreenchidos = false;
                    break;
            }

            if (!flagCamposPreenchidos)
            {
                PintarBordaVermelho();
            }

            return flagCamposPreenchidos;

        }

        private void Cb_filtro_SelectedIndexChanged_1(object sender, EventArgs e)
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
                    lb_preco.Visible = true;
                    tb_preco.Visible = true;

                    break;
            }
        }

        private void LimparCampos()
        {
            tb_id_matricula.Clear();
            tb_modelo_marca.Clear();
            tb_preco.Clear();

            comboBoxNmrPortas.SelectedItem = null;
            comboBoxTipoCaixa.SelectedItem = null;
            comboBoxCilindrada.SelectedItem = null;
            textBoxNmrMaxPassageiros.Clear();
            comboBoxNmrEixos.SelectedItem = null;
            textBoxPesoMaxSuportado.Clear();

            cb_tipo.SelectedItem = null;

            pb_add_veiculos.Visible = true;

        }

        private void Btn_criar_Click(object sender, EventArgs e)
        {
            if (ChecarCampos())
            {
                switch (cb_tipo.SelectedIndex)
                {
                    case 0:

                        string numPortas = comboBoxNmrPortas.SelectedItem.ToString();
                        string tipoCaixa = comboBoxTipoCaixa.SelectedItem.ToString();

                        if (EmpresaController.CriarCarro(_matricula, _modelo, _preco, numPortas, tipoCaixa))
                        {
                            LimparCampos();
                        }

                        break;

                    case 1:

                        string cilindrada = comboBoxCilindrada.SelectedItem.ToString();


                        if (EmpresaController.CriarMota(_matricula, _modelo, _preco, cilindrada))
                        {
                            LimparCampos();
                        }


                        break;
                    case 2:

                        string numEixos = comboBoxNmrEixos.SelectedItem.ToString();
                        string numPassageiros = textBoxNmrMaxPassageiros.Text;

                        if (EmpresaController.CriarCamioneta(_matricula, _modelo, _preco, numEixos, numPassageiros))
                        {
                            LimparCampos();
                        }
                        break;

                    case 3:

                        string pesoMax = textBoxPesoMaxSuportado.Text;

                        if (EmpresaController.CriarCamiao(_matricula, _modelo, _preco, pesoMax))
                        {
                            LimparCampos();
                        }
                        break;
                }

            }
            else
            {

                MessageBox.Show("Campos não preenchidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Tb_modelo_marca_TextChanged(object sender, EventArgs e)
        {
            _modelo = tb_modelo_marca.Text;
        }

        private void Tb_id_matricula_TextChanged(object sender, EventArgs e)
        {
            _matricula = tb_id_matricula.Text.Trim();
        }


        private void Tb_preco_TextChanged(object sender, EventArgs e)
        {
            _preco = tb_preco.Text;

        }


    }
}

