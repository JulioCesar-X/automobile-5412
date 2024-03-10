using System;
using System.Windows.Forms;

namespace Automobile
{
    public partial class SelecaoData : Form
    {
        public DateTime InicioSelecionado { get; set; }
        public DateTime FimSelecionado { get; set; }

        public SelecaoData()
        {
            InitializeComponent();

        }
        private void Btn_ok_datas_Click(object sender, EventArgs e)
        {
            // Verifica se ambas as datas foram selecionadas
            if (dtp_inicio.Value != null && dtp_fim.Value != null)
            {
                // Verifica se a data de início é anterior à data de fim
                if (dtp_inicio.Value <= dtp_fim.Value)
                {
                    InicioSelecionado = dtp_inicio.Value;
                    FimSelecionado = dtp_fim.Value;
                    this.DialogResult = DialogResult.OK; // Define o resultado do diálogo como OK
                    this.Close();
                }
                else
                {
                    MessageBox.Show("A data de início deve ser anterior à data de fim.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione ambas as datas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
    }
}
