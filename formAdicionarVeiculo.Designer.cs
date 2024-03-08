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
            this.lb_matricula = new System.Windows.Forms.Label();
            this.lb_modelo = new System.Windows.Forms.Label();
            this.tb_modelo_marca = new System.Windows.Forms.TextBox();
            this.tb_id_matricula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_tipo = new System.Windows.Forms.ComboBox();
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
            this.lblPesoMaxSuportado = new System.Windows.Forms.Label();
            this.textBoxPesoMaxSuportado = new System.Windows.Forms.TextBox();
            this.lb_preco = new System.Windows.Forms.Label();
            this.tb_preco = new System.Windows.Forms.TextBox();
            this.btn_criar = new System.Windows.Forms.Button();
            this.textBoxNmrMaxPassageiros = new System.Windows.Forms.TextBox();
            this.pb_add_veiculos = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_veiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_matricula
            // 
            this.lb_matricula.AutoSize = true;
            this.lb_matricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula.Location = new System.Drawing.Point(231, 159);
            this.lb_matricula.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_matricula.Name = "lb_matricula";
            this.lb_matricula.Size = new System.Drawing.Size(79, 17);
            this.lb_matricula.TabIndex = 18;
            this.lb_matricula.Text = "Matrícula:";
            // 
            // lb_modelo
            // 
            this.lb_modelo.AutoSize = true;
            this.lb_modelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_modelo.Location = new System.Drawing.Point(231, 125);
            this.lb_modelo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_modelo.Name = "lb_modelo";
            this.lb_modelo.Size = new System.Drawing.Size(65, 17);
            this.lb_modelo.TabIndex = 17;
            this.lb_modelo.Text = "Modelo:";
            // 
            // tb_modelo_marca
            // 
            this.tb_modelo_marca.Location = new System.Drawing.Point(296, 123);
            this.tb_modelo_marca.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_modelo_marca.Name = "tb_modelo_marca";
            this.tb_modelo_marca.Size = new System.Drawing.Size(158, 20);
            this.tb_modelo_marca.TabIndex = 19;
            this.tb_modelo_marca.TextChanged += new System.EventHandler(this.tb_modelo_marca_TextChanged);
            // 
            // tb_id_matricula
            // 
            this.tb_id_matricula.Location = new System.Drawing.Point(316, 157);
            this.tb_id_matricula.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_id_matricula.Name = "tb_id_matricula";
            this.tb_id_matricula.Size = new System.Drawing.Size(138, 20);
            this.tb_id_matricula.TabIndex = 25;
            this.tb_id_matricula.TextChanged += new System.EventHandler(this.tb_id_matricula_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(265, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Tipo:";
            // 
            // cb_tipo
            // 
            this.cb_tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_tipo.FormattingEnabled = true;
            this.cb_tipo.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camioneta",
            "Camião"});
            this.cb_tipo.Location = new System.Drawing.Point(325, 25);
            this.cb_tipo.Name = "cb_tipo";
            this.cb_tipo.Size = new System.Drawing.Size(121, 21);
            this.cb_tipo.TabIndex = 15;
            this.cb_tipo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_tipo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 68);
            this.panel1.TabIndex = 16;
            // 
            // lblNmrPortas
            // 
            this.lblNmrPortas.AutoSize = true;
            this.lblNmrPortas.BackColor = System.Drawing.Color.Transparent;
            this.lblNmrPortas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrPortas.Location = new System.Drawing.Point(231, 194);
            this.lblNmrPortas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNmrPortas.Name = "lblNmrPortas";
            this.lblNmrPortas.Size = new System.Drawing.Size(82, 17);
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
            this.comboBoxNmrPortas.Location = new System.Drawing.Point(316, 190);
            this.comboBoxNmrPortas.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxNmrPortas.Name = "comboBoxNmrPortas";
            this.comboBoxNmrPortas.Size = new System.Drawing.Size(138, 21);
            this.comboBoxNmrPortas.TabIndex = 22;
            this.comboBoxNmrPortas.Visible = false;
            // 
            // lblTipoCaixa
            // 
            this.lblTipoCaixa.AutoSize = true;
            this.lblTipoCaixa.BackColor = System.Drawing.Color.Transparent;
            this.lblTipoCaixa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCaixa.Location = new System.Drawing.Point(231, 228);
            this.lblTipoCaixa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoCaixa.Name = "lblTipoCaixa";
            this.lblTipoCaixa.Size = new System.Drawing.Size(112, 17);
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
            this.comboBoxTipoCaixa.Location = new System.Drawing.Point(349, 220);
            this.comboBoxTipoCaixa.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTipoCaixa.Name = "comboBoxTipoCaixa";
            this.comboBoxTipoCaixa.Size = new System.Drawing.Size(105, 21);
            this.comboBoxTipoCaixa.TabIndex = 24;
            this.comboBoxTipoCaixa.Visible = false;
            // 
            // lblCilindrada
            // 
            this.lblCilindrada.AutoSize = true;
            this.lblCilindrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCilindrada.Location = new System.Drawing.Point(231, 194);
            this.lblCilindrada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCilindrada.Name = "lblCilindrada";
            this.lblCilindrada.Size = new System.Drawing.Size(86, 17);
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
            this.comboBoxCilindrada.Location = new System.Drawing.Point(319, 194);
            this.comboBoxCilindrada.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxCilindrada.Name = "comboBoxCilindrada";
            this.comboBoxCilindrada.Size = new System.Drawing.Size(135, 21);
            this.comboBoxCilindrada.TabIndex = 27;
            this.comboBoxCilindrada.Visible = false;
            // 
            // lblNmrEixos
            // 
            this.lblNmrEixos.AutoSize = true;
            this.lblNmrEixos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrEixos.Location = new System.Drawing.Point(231, 196);
            this.lblNmrEixos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNmrEixos.Name = "lblNmrEixos";
            this.lblNmrEixos.Size = new System.Drawing.Size(96, 17);
            this.lblNmrEixos.TabIndex = 28;
            this.lblNmrEixos.Text = "Nº de Eixos:";
            this.lblNmrEixos.Visible = false;
            // 
            // lblNmrMaxPassageiros
            // 
            this.lblNmrMaxPassageiros.AutoSize = true;
            this.lblNmrMaxPassageiros.BackColor = System.Drawing.Color.Transparent;
            this.lblNmrMaxPassageiros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNmrMaxPassageiros.Location = new System.Drawing.Point(161, 225);
            this.lblNmrMaxPassageiros.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNmrMaxPassageiros.Name = "lblNmrMaxPassageiros";
            this.lblNmrMaxPassageiros.Size = new System.Drawing.Size(180, 17);
            this.lblNmrMaxPassageiros.TabIndex = 29;
            this.lblNmrMaxPassageiros.Text = "Nº Max de Passageiros:";
            this.lblNmrMaxPassageiros.Visible = false;
            // 
            // comboBoxNmrEixos
            // 
            this.comboBoxNmrEixos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNmrEixos.FormattingEnabled = true;
            this.comboBoxNmrEixos.Items.AddRange(new object[] {
            "2",
            "3"});
            this.comboBoxNmrEixos.Location = new System.Drawing.Point(334, 196);
            this.comboBoxNmrEixos.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxNmrEixos.Name = "comboBoxNmrEixos";
            this.comboBoxNmrEixos.Size = new System.Drawing.Size(119, 21);
            this.comboBoxNmrEixos.TabIndex = 30;
            this.comboBoxNmrEixos.Visible = false;
            // 
            // lblPesoMaxSuportado
            // 
            this.lblPesoMaxSuportado.AutoSize = true;
            this.lblPesoMaxSuportado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPesoMaxSuportado.Location = new System.Drawing.Point(137, 197);
            this.lblPesoMaxSuportado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPesoMaxSuportado.Name = "lblPesoMaxSuportado";
            this.lblPesoMaxSuportado.Size = new System.Drawing.Size(193, 17);
            this.lblPesoMaxSuportado.TabIndex = 32;
            this.lblPesoMaxSuportado.Text = "Peso Max Suportado(Kg):";
            this.lblPesoMaxSuportado.Visible = false;
            // 
            // textBoxPesoMaxSuportado
            // 
            this.textBoxPesoMaxSuportado.Location = new System.Drawing.Point(334, 197);
            this.textBoxPesoMaxSuportado.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxPesoMaxSuportado.Name = "textBoxPesoMaxSuportado";
            this.textBoxPesoMaxSuportado.Size = new System.Drawing.Size(119, 20);
            this.textBoxPesoMaxSuportado.TabIndex = 33;
            this.textBoxPesoMaxSuportado.Visible = false;
            // 
            // lb_preco
            // 
            this.lb_preco.AutoSize = true;
            this.lb_preco.BackColor = System.Drawing.Color.Transparent;
            this.lb_preco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preco.Location = new System.Drawing.Point(231, 257);
            this.lb_preco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_preco.Name = "lb_preco";
            this.lb_preco.Size = new System.Drawing.Size(93, 17);
            this.lb_preco.TabIndex = 29;
            this.lb_preco.Text = "Preço/hora:";
            this.lb_preco.Visible = false;
            // 
            // tb_preco
            // 
            this.tb_preco.Location = new System.Drawing.Point(325, 258);
            this.tb_preco.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tb_preco.Name = "tb_preco";
            this.tb_preco.Size = new System.Drawing.Size(129, 20);
            this.tb_preco.TabIndex = 33;
            this.tb_preco.Visible = false;
            this.tb_preco.TextChanged += new System.EventHandler(this.tb_preco_TextChanged);
            // 
            // btn_criar
            // 
            this.btn_criar.Location = new System.Drawing.Point(296, 311);
            this.btn_criar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_criar.Name = "btn_criar";
            this.btn_criar.Size = new System.Drawing.Size(93, 34);
            this.btn_criar.TabIndex = 34;
            this.btn_criar.Text = "Criar";
            this.btn_criar.UseVisualStyleBackColor = true;
            this.btn_criar.Click += new System.EventHandler(this.btn_criar_Click);
            // 
            // textBoxNmrMaxPassageiros
            // 
            this.textBoxNmrMaxPassageiros.AcceptsReturn = true;
            this.textBoxNmrMaxPassageiros.Location = new System.Drawing.Point(343, 226);
            this.textBoxNmrMaxPassageiros.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBoxNmrMaxPassageiros.Name = "textBoxNmrMaxPassageiros";
            this.textBoxNmrMaxPassageiros.Size = new System.Drawing.Size(111, 20);
            this.textBoxNmrMaxPassageiros.TabIndex = 31;
            this.textBoxNmrMaxPassageiros.Visible = false;
            // 
            // pb_add_veiculos
            // 
            this.pb_add_veiculos.BackColor = System.Drawing.Color.Transparent;
            this.pb_add_veiculos.BackgroundImage = global::Automobile.Properties.Resources.pngwing_com__24_;
            this.pb_add_veiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_add_veiculos.Location = new System.Drawing.Point(124, 123);
            this.pb_add_veiculos.Margin = new System.Windows.Forms.Padding(2);
            this.pb_add_veiculos.Name = "pb_add_veiculos";
            this.pb_add_veiculos.Size = new System.Drawing.Size(476, 244);
            this.pb_add_veiculos.TabIndex = 35;
            this.pb_add_veiculos.TabStop = false;
            // 
            // formAdicionarVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(717, 438);
            this.Controls.Add(this.pb_add_veiculos);
            this.Controls.Add(this.btn_criar);
            this.Controls.Add(this.tb_preco);
            this.Controls.Add(this.textBoxPesoMaxSuportado);
            this.Controls.Add(this.lblPesoMaxSuportado);
            this.Controls.Add(this.textBoxNmrMaxPassageiros);
            this.Controls.Add(this.comboBoxNmrEixos);
            this.Controls.Add(this.lb_preco);
            this.Controls.Add(this.lblNmrMaxPassageiros);
            this.Controls.Add(this.lblNmrEixos);
            this.Controls.Add(this.comboBoxCilindrada);
            this.Controls.Add(this.lblCilindrada);
            this.Controls.Add(this.tb_id_matricula);
            this.Controls.Add(this.comboBoxTipoCaixa);
            this.Controls.Add(this.lblTipoCaixa);
            this.Controls.Add(this.comboBoxNmrPortas);
            this.Controls.Add(this.lblNmrPortas);
            this.Controls.Add(this.tb_modelo_marca);
            this.Controls.Add(this.lb_matricula);
            this.Controls.Add(this.lb_modelo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAdicionarVeiculo";
            this.Text = "formAdicionarVeiculo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_add_veiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_matricula;
        private System.Windows.Forms.Label lb_modelo;
        private System.Windows.Forms.TextBox tb_id_matricula;
        private System.Windows.Forms.TextBox tb_modelo_marca;
        private System.Windows.Forms.ComboBox cb_tipo;
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
        private System.Windows.Forms.Label lblPesoMaxSuportado;
        private System.Windows.Forms.TextBox textBoxPesoMaxSuportado;
        private System.Windows.Forms.Label lb_preco;
        private System.Windows.Forms.TextBox tb_preco;
        private System.Windows.Forms.Button btn_criar;
        private System.Windows.Forms.TextBox textBoxNmrMaxPassageiros;
        private System.Windows.Forms.PictureBox pb_add_veiculos;
    }
}