using System;
using System.Globalization;
using System.Windows.Forms;

namespace Automobile
{
    public partial class formAdicionarVeiculo : Form
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

        public formAdicionarVeiculo()
        {
            InitializeComponent();

            lb_modelo.Visible = false;
            lb_matricula.Visible = false;
            tb_id_matricula.Visible = false;
            tb_modelo_marca.Visible = false;



        }



        private bool ChecarCampos()
        {

            switch (cb_tipo.SelectedIndex)
            {
                case 0:
                    return CamposCarroPreenchidos;

                case 1:
                    return CamposMotaPreenchidos;

                case 2:
                    return CamposCamionetaPreenchidos;

                case 3:
                    return CamposCamiaoPreenchidos;

                default:
                    return false;
            }

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

        //Caso preenchido e ao click cria de facto o objeto
        private void btn_criar_Click(object sender, EventArgs e)
        {
            if (ChecarCampos())
            {
                switch (cb_tipo.SelectedIndex)
                {
                    case 0:

                        int numPortas = int.Parse(comboBoxNmrPortas.SelectedItem.ToString());
                        string tipoCaixa = comboBoxTipoCaixa.SelectedItem.ToString();

                        if (EmpresaController.CriarCarro(_matricula, _modelo, decimal.Parse(_preco), numPortas, tipoCaixa))
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

                        if (EmpresaController.CriarMota(_matricula, _modelo, decimal.Parse(_preco), cilindrada))
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

                        if (EmpresaController.CriarCamioneta(_matricula, _modelo, decimal.Parse(_preco), numEixos, numPassageiros))
                        {
                            tb_id_matricula.Clear();
                            tb_modelo_marca.Clear();
                            tb_preco.Clear();
                            textBoxNmrMaxPassageiros.Clear();
                            comboBoxNmrEixos.SelectedItem = null;

                        }
                        break;
                    case 3:

                        string pesoMax = textBoxPesoMaxSuportado.Text;

                        if (EmpresaController.CriarCamiao(_matricula, _modelo, decimal.Parse(_preco), pesoMax))
                        {
                            tb_id_matricula.Clear();
                            tb_modelo_marca.Clear();
                            tb_preco.Clear();
                            textBoxPesoMaxSuportado.Clear();

                        }
                        break;
                }

            }
            else
            {
                MessageBox.Show("Campos não preenchidos");
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
            _preco = tb_preco.Text;

        }


    }
}
