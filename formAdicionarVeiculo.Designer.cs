namespace Automobile
{
    partial class formAdicionarVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblNmrPortas = new System.Windows.Forms.Label();
            this.comboBoxNmrPortas = new System.Windows.Forms.ComboBox();
            this.lblTipoCaixa = new System.Windows.Forms.Label();
            this.comboBoxTipoCaixa = new System.Windows.Forms.ComboBox();
            this.lblCilindrada = new System.Windows.Forms.Label();
            this.comboBoxCilindrada = new System.Windows.Forms.ComboBox();
            this.lblNmrEixos = new System.Windows.Forms.Label();
            this.lblNmrMaxPassageiros = new System.Windows.Forms.Label();
            this.comboBoxNmrEixos = new System.Windows.Forms.ComboBox();
            this.textBoxNmrMaxPassageiros = new System.Windows.Forms.TextBox();
            this.lblPesoMaxSuportado = new System.Windows.Forms.Label();
            this.textBoxPesoMaxSuportado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Matrícula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(308, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Marca:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(395, 152);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 22);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(421, 194);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(353, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 29);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo:";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camioneta",
            "Camião"});
            this.comboBox1.Location = new System.Drawing.Point(433, 36);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(956, 118);
            this.panel1.TabIndex = 16;
            // 
            // lblNmrPortas
            // 
            this.lblNmrPortas.AutoSize = true;
            this.lblNmrPortas.BackColor = System.Drawing.Color.Transparent;
            this.lblNmrPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrPortas.Location = new System.Drawing.Point(308, 238);
            this.lblNmrPortas.Name = "lblNmrPortas";
            this.lblNmrPortas.Size = new System.Drawing.Size(96, 20);
            this.lblNmrPortas.TabIndex = 21;
            this.lblNmrPortas.Text = "Nº Portas:";
            this.lblNmrPortas.Visible = false;
            // 
            // comboBoxNmrPortas
            // 
            this.comboBoxNmrPortas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNmrPortas.FormattingEnabled = true;
            this.comboBoxNmrPortas.Items.AddRange(new object[] {
            "3",
            "5"});
            this.comboBoxNmrPortas.Location = new System.Drawing.Point(421, 234);
            this.comboBoxNmrPortas.Name = "comboBoxNmrPortas";
            this.comboBoxNmrPortas.Size = new System.Drawing.Size(183, 24);
            this.comboBoxNmrPortas.TabIndex = 22;
            this.comboBoxNmrPortas.Visible = false;
            // 
            // lblTipoCaixa
            // 
            this.lblTipoCaixa.AutoSize = true;
            this.lblTipoCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCaixa.Location = new System.Drawing.Point(308, 281);
            this.lblTipoCaixa.Name = "lblTipoCaixa";
            this.lblTipoCaixa.Size = new System.Drawing.Size(130, 20);
            this.lblTipoCaixa.TabIndex = 23;
            this.lblTipoCaixa.Text = "Tipo de Caixa:";
            this.lblTipoCaixa.Visible = false;
            // 
            // comboBoxTipoCaixa
            // 
            this.comboBoxTipoCaixa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoCaixa.FormattingEnabled = true;
            this.comboBoxTipoCaixa.Items.AddRange(new object[] {
            "Manual",
            "Automática"});
            this.comboBoxTipoCaixa.Location = new System.Drawing.Point(466, 277);
            this.comboBoxTipoCaixa.Name = "comboBoxTipoCaixa";
            this.comboBoxTipoCaixa.Size = new System.Drawing.Size(138, 24);
            this.comboBoxTipoCaixa.TabIndex = 24;
            this.comboBoxTipoCaixa.Visible = false;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindrada.Location = new System.Drawing.Point(308, 238);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(100, 20);
            this.lblCilindrada.TabIndex = 26;
            this.lblCilindrada.Text = "Cilindrada:";
            this.lblCilindrada.Visible = false;
            // 
            // comboBoxCilindrada
            // 
            this.comboBoxCilindrada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCilindrada.FormattingEnabled = true;
            this.comboBoxCilindrada.Items.AddRange(new object[] {
            "50cc",
            "125cc",
            "300cc"});
            this.comboBoxCilindrada.Location = new System.Drawing.Point(426, 238);
            this.comboBoxCilindrada.Name = "comboBoxCilindrada";
            this.comboBoxCilindrada.Size = new System.Drawing.Size(178, 24);
            this.comboBoxCilindrada.TabIndex = 27;
            this.comboBoxCilindrada.Visible = false;
            // 
            // lblNmrEixos
            // 
            this.lblNmrEixos.AutoSize = true;
            this.lblNmrEixos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrEixos.Location = new System.Drawing.Point(308, 242);
            this.lblNmrEixos.Name = "lblNmrEixos";
            this.lblNmrEixos.Size = new System.Drawing.Size(113, 20);
            this.lblNmrEixos.TabIndex = 28;
            this.lblNmrEixos.Text = "Nº de Eixos:";
            this.lblNmrEixos.Visible = false;
            // 
            // lblNmrMaxPassageiros
            // 
            this.lblNmrMaxPassageiros.AutoSize = true;
            this.lblNmrMaxPassageiros.BackColor = System.Drawing.Color.Transparent;
            this.lblNmrMaxPassageiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrMaxPassageiros.Location = new System.Drawing.Point(308, 281);
            this.lblNmrMaxPassageiros.Name = "lblNmrMaxPassageiros";
            this.lblNmrMaxPassageiros.Size = new System.Drawing.Size(204, 20);
            this.lblNmrMaxPassageiros.TabIndex = 29;
            this.lblNmrMaxPassageiros.Text = "N Max de Passageiros:";
            this.lblNmrMaxPassageiros.Visible = false;
            // 
            // comboBoxNmrEixos
            // 
            this.comboBoxNmrEixos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNmrEixos.FormattingEnabled = true;
            this.comboBoxNmrEixos.Items.AddRange(new object[] {
            "2",
            "3"});
            this.comboBoxNmrEixos.Location = new System.Drawing.Point(445, 242);
            this.comboBoxNmrEixos.Name = "comboBoxNmrEixos";
            this.comboBoxNmrEixos.Size = new System.Drawing.Size(158, 24);
            this.comboBoxNmrEixos.TabIndex = 30;
            this.comboBoxNmrEixos.Visible = false;
            // 
            // textBoxNmrMaxPassageiros
            // 
            this.textBoxNmrMaxPassageiros.Location = new System.Drawing.Point(543, 278);
            this.textBoxNmrMaxPassageiros.Name = "textBoxNmrMaxPassageiros";
            this.textBoxNmrMaxPassageiros.Size = new System.Drawing.Size(60, 22);
            this.textBoxNmrMaxPassageiros.TabIndex = 31;
            this.textBoxNmrMaxPassageiros.Visible = false;
            // 
            // lblPesoMaxSuportado
            // 
            this.lblPesoMaxSuportado.AutoSize = true;
            this.lblPesoMaxSuportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMaxSuportado.Location = new System.Drawing.Point(308, 238);
            this.lblPesoMaxSuportado.Name = "lblPesoMaxSuportado";
            this.lblPesoMaxSuportado.Size = new System.Drawing.Size(224, 20);
            this.lblPesoMaxSuportado.TabIndex = 32;
            this.lblPesoMaxSuportado.Text = "Peso Max Suportado(Kg):";
            this.lblPesoMaxSuportado.Visible = false;
            // 
            // textBoxPesoMaxSuportado
            // 
            this.textBoxPesoMaxSuportado.Location = new System.Drawing.Point(571, 234);
            this.textBoxPesoMaxSuportado.Name = "textBoxPesoMaxSuportado";
            this.textBoxPesoMaxSuportado.Size = new System.Drawing.Size(32, 22);
            this.textBoxPesoMaxSuportado.TabIndex = 33;
            this.textBoxPesoMaxSuportado.Visible = false;
            // 
            // formAdicionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(956, 539);
            this.Controls.Add(this.textBoxPesoMaxSuportado);
            this.Controls.Add(this.lblPesoMaxSuportado);
            this.Controls.Add(this.textBoxNmrMaxPassageiros);
            this.Controls.Add(this.comboBoxNmrEixos);
            this.Controls.Add(this.lblNmrMaxPassageiros);
            this.Controls.Add(this.lblNmrEixos);
            this.Controls.Add(this.comboBoxCilindrada);
            this.Controls.Add(this.lblCilindrada);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBoxTipoCaixa);
            this.Controls.Add(this.lblTipoCaixa);
            this.Controls.Add(this.comboBoxNmrPortas);
            this.Controls.Add(this.lblNmrPortas);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formAdicionarVeiculo";
            this.Text = "formAdicionarVeiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblNmrPortas;
        private System.Windows.Forms.ComboBox comboBoxNmrPortas;
        private System.Windows.Forms.Label lblTipoCaixa;
        private System.Windows.Forms.ComboBox comboBoxTipoCaixa;
        private System.Windows.Forms.Label lblCilindrada;
        private System.Windows.Forms.ComboBox comboBoxCilindrada;
        private System.Windows.Forms.Label lblNmrEixos;
        private System.Windows.Forms.Label lblNmrMaxPassageiros;
        private System.Windows.Forms.ComboBox comboBoxNmrEixos;
        private System.Windows.Forms.TextBox textBoxNmrMaxPassageiros;
        private System.Windows.Forms.Label lblPesoMaxSuportado;
        private System.Windows.Forms.TextBox textBoxPesoMaxSuportado;
    }
}