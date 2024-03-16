namespace Automobile
{
    partial class FormGerirAluguer
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
            this.dgv_disponiveis = new System.Windows.Forms.DataGridView();
            this.btn_criar_aluguer = new System.Windows.Forms.Button();
            this.lb_tempo_total_aluguer = new System.Windows.Forms.Label();
            this.bt_confirm_aluguer = new System.Windows.Forms.Button();
            this.tb_tempo_total = new System.Windows.Forms.TextBox();
            this.lb_inicio = new System.Windows.Forms.Label();
            this.lb_fim = new System.Windows.Forms.Label();
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.lb_filtro = new System.Windows.Forms.Label();
            this.cb_filtro_disponiveis = new System.Windows.Forms.ComboBox();
            this.pb_aluguer = new System.Windows.Forms.PictureBox();
            this.lb_veiculos_disponiveis = new System.Windows.Forms.Label();
            this.lb_matricula_selecionada = new System.Windows.Forms.Label();
            this.tb_matricula_selec = new System.Windows.Forms.TextBox();
            this.bt_calcular_valor = new System.Windows.Forms.Button();
            this.lb_preco_total_aluguer = new System.Windows.Forms.Label();
            this.lb_total_aluguer = new System.Windows.Forms.Label();
            this.lb_matricula_a = new System.Windows.Forms.Label();
            this.lb_matricula_selec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aluguer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_disponiveis
            // 
            this.dgv_disponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_disponiveis.Location = new System.Drawing.Point(388, 142);
            this.dgv_disponiveis.Name = "dgv_disponiveis";
            this.dgv_disponiveis.RowHeadersWidth = 62;
            this.dgv_disponiveis.RowTemplate.Height = 28;
            this.dgv_disponiveis.Size = new System.Drawing.Size(779, 374);
            this.dgv_disponiveis.TabIndex = 0;
            // 
            // btn_criar_aluguer
            // 
            this.btn_criar_aluguer.BackColor = System.Drawing.Color.Black;
            this.btn_criar_aluguer.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_criar_aluguer.FlatAppearance.BorderSize = 5;
            this.btn_criar_aluguer.Font = new System.Drawing.Font("Bauhaus 93", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_criar_aluguer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_criar_aluguer.Location = new System.Drawing.Point(98, 451);
            this.btn_criar_aluguer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_criar_aluguer.Name = "btn_criar_aluguer";
            this.btn_criar_aluguer.Size = new System.Drawing.Size(162, 77);
            this.btn_criar_aluguer.TabIndex = 42;
            this.btn_criar_aluguer.Text = "Alugar";
            this.btn_criar_aluguer.UseVisualStyleBackColor = false;
            this.btn_criar_aluguer.Click += new System.EventHandler(this.Btn_criar_aluguer_Click);
            // 
            // lb_tempo_total_aluguer
            // 
            this.lb_tempo_total_aluguer.AutoSize = true;
            this.lb_tempo_total_aluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempo_total_aluguer.Location = new System.Drawing.Point(61, 343);
            this.lb_tempo_total_aluguer.Name = "lb_tempo_total_aluguer";
            this.lb_tempo_total_aluguer.Size = new System.Drawing.Size(263, 25);
            this.lb_tempo_total_aluguer.TabIndex = 33;
            this.lb_tempo_total_aluguer.Text = "Tempo total de Reserva";
            // 
            // bt_confirm_aluguer
            // 
            this.bt_confirm_aluguer.Location = new System.Drawing.Point(147, 267);
            this.bt_confirm_aluguer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_confirm_aluguer.Name = "bt_confirm_aluguer";
            this.bt_confirm_aluguer.Size = new System.Drawing.Size(84, 39);
            this.bt_confirm_aluguer.TabIndex = 35;
            this.bt_confirm_aluguer.Text = "Confirm";
            this.bt_confirm_aluguer.UseVisualStyleBackColor = true;
            this.bt_confirm_aluguer.Click += new System.EventHandler(this.Bt_confirmar_Click);
            // 
            // tb_tempo_total
            // 
            this.tb_tempo_total.Location = new System.Drawing.Point(136, 389);
            this.tb_tempo_total.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_tempo_total.Name = "tb_tempo_total";
            this.tb_tempo_total.Size = new System.Drawing.Size(104, 26);
            this.tb_tempo_total.TabIndex = 38;
            // 
            // lb_inicio
            // 
            this.lb_inicio.AutoSize = true;
            this.lb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inicio.Location = new System.Drawing.Point(60, 75);
            this.lb_inicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_inicio.Name = "lb_inicio";
            this.lb_inicio.Size = new System.Drawing.Size(48, 18);
            this.lb_inicio.TabIndex = 44;
            this.lb_inicio.Text = "Início";
            // 
            // lb_fim
            // 
            this.lb_fim.AutoSize = true;
            this.lb_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fim.Location = new System.Drawing.Point(60, 169);
            this.lb_fim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_fim.Name = "lb_fim";
            this.lb_fim.Size = new System.Drawing.Size(36, 18);
            this.lb_fim.TabIndex = 45;
            this.lb_fim.Text = "Fim";
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.Location = new System.Drawing.Point(63, 118);
            this.dtp_inicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(252, 26);
            this.dtp_inicio.TabIndex = 46;
            this.dtp_inicio.ValueChanged += new System.EventHandler(this.Dtp_inicio_ValueChanged_1);
            // 
            // dtp_fim
            // 
            this.dtp_fim.Location = new System.Drawing.Point(63, 211);
            this.dtp_fim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(250, 26);
            this.dtp_fim.TabIndex = 47;
            this.dtp_fim.ValueChanged += new System.EventHandler(this.Dtp_fim_ValueChanged);
            // 
            // lb_filtro
            // 
            this.lb_filtro.AutoSize = true;
            this.lb_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filtro.Location = new System.Drawing.Point(947, 75);
            this.lb_filtro.Name = "lb_filtro";
            this.lb_filtro.Size = new System.Drawing.Size(88, 25);
            this.lb_filtro.TabIndex = 19;
            this.lb_filtro.Text = "Filtrar: ";
            // 
            // cb_filtro_disponiveis
            // 
            this.cb_filtro_disponiveis.FormattingEnabled = true;
            this.cb_filtro_disponiveis.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camioneta",
            "Camiao"});
            this.cb_filtro_disponiveis.Location = new System.Drawing.Point(1041, 72);
            this.cb_filtro_disponiveis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_filtro_disponiveis.Name = "cb_filtro_disponiveis";
            this.cb_filtro_disponiveis.Size = new System.Drawing.Size(136, 28);
            this.cb_filtro_disponiveis.TabIndex = 20;
            this.cb_filtro_disponiveis.SelectedIndexChanged += new System.EventHandler(this.Cb_filtro_SelectedIndexChanged);
            // 
            // pb_aluguer
            // 
            this.pb_aluguer.BackColor = System.Drawing.Color.Transparent;
            this.pb_aluguer.BackgroundImage = global::Automobile.Properties.Resources.pngwing_com__37_;
            this.pb_aluguer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_aluguer.Location = new System.Drawing.Point(357, 110);
            this.pb_aluguer.Name = "pb_aluguer";
            this.pb_aluguer.Size = new System.Drawing.Size(821, 544);
            this.pb_aluguer.TabIndex = 51;
            this.pb_aluguer.TabStop = false;
            // 
            // lb_veiculos_disponiveis
            // 
            this.lb_veiculos_disponiveis.AutoSize = true;
            this.lb_veiculos_disponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_veiculos_disponiveis.Location = new System.Drawing.Point(383, 110);
            this.lb_veiculos_disponiveis.Name = "lb_veiculos_disponiveis";
            this.lb_veiculos_disponiveis.Size = new System.Drawing.Size(188, 29);
            this.lb_veiculos_disponiveis.TabIndex = 33;
            this.lb_veiculos_disponiveis.Text = "??? Disponveis";
            // 
            // lb_matricula_selecionada
            // 
            this.lb_matricula_selecionada.AutoSize = true;
            this.lb_matricula_selecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula_selecionada.Location = new System.Drawing.Point(401, 518);
            this.lb_matricula_selecionada.Name = "lb_matricula_selecionada";
            this.lb_matricula_selecionada.Size = new System.Drawing.Size(250, 25);
            this.lb_matricula_selecionada.TabIndex = 25;
            this.lb_matricula_selecionada.Text = "Matricula selecionada:";
            // 
            // tb_matricula_selec
            // 
            this.tb_matricula_selec.Location = new System.Drawing.Point(657, 521);
            this.tb_matricula_selec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_matricula_selec.Name = "tb_matricula_selec";
            this.tb_matricula_selec.Size = new System.Drawing.Size(205, 26);
            this.tb_matricula_selec.TabIndex = 26;
            // 
            // bt_calcular_valor
            // 
            this.bt_calcular_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular_valor.Location = new System.Drawing.Point(868, 521);
            this.bt_calcular_valor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_calcular_valor.Name = "bt_calcular_valor";
            this.bt_calcular_valor.Size = new System.Drawing.Size(87, 32);
            this.bt_calcular_valor.TabIndex = 27;
            this.bt_calcular_valor.Text = "Enviar";
            this.bt_calcular_valor.UseVisualStyleBackColor = true;
            this.bt_calcular_valor.Click += new System.EventHandler(this.Bt_calcular_valor_Click);
            // 
            // lb_preco_total_aluguer
            // 
            this.lb_preco_total_aluguer.AutoSize = true;
            this.lb_preco_total_aluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preco_total_aluguer.Location = new System.Drawing.Point(606, 618);
            this.lb_preco_total_aluguer.Name = "lb_preco_total_aluguer";
            this.lb_preco_total_aluguer.Size = new System.Drawing.Size(156, 29);
            this.lb_preco_total_aluguer.TabIndex = 41;
            this.lb_preco_total_aluguer.Text = "Preço Total:";
            this.lb_preco_total_aluguer.Visible = false;
            // 
            // lb_total_aluguer
            // 
            this.lb_total_aluguer.AutoSize = true;
            this.lb_total_aluguer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total_aluguer.ForeColor = System.Drawing.Color.Red;
            this.lb_total_aluguer.Location = new System.Drawing.Point(759, 618);
            this.lb_total_aluguer.Name = "lb_total_aluguer";
            this.lb_total_aluguer.Size = new System.Drawing.Size(83, 29);
            this.lb_total_aluguer.TabIndex = 48;
            this.lb_total_aluguer.Text = "0.00 €";
            this.lb_total_aluguer.Visible = false;
            // 
            // lb_matricula_a
            // 
            this.lb_matricula_a.AutoSize = true;
            this.lb_matricula_a.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula_a.Location = new System.Drawing.Point(606, 577);
            this.lb_matricula_a.Name = "lb_matricula_a";
            this.lb_matricula_a.Size = new System.Drawing.Size(126, 29);
            this.lb_matricula_a.TabIndex = 49;
            this.lb_matricula_a.Text = "Matricula:";
            // 
            // lb_matricula_selec
            // 
            this.lb_matricula_selec.AutoSize = true;
            this.lb_matricula_selec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula_selec.ForeColor = System.Drawing.Color.Red;
            this.lb_matricula_selec.Location = new System.Drawing.Point(733, 577);
            this.lb_matricula_selec.Name = "lb_matricula_selec";
            this.lb_matricula_selec.Size = new System.Drawing.Size(139, 29);
            this.lb_matricula_selec.TabIndex = 50;
            this.lb_matricula_selec.Text = "XX-XX-XX";
            this.lb_matricula_selec.Visible = false;
            // 
            // FormGerirAluguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 743);
            this.Controls.Add(this.pb_aluguer);
            this.Controls.Add(this.dgv_disponiveis);
            this.Controls.Add(this.lb_matricula_selec);
            this.Controls.Add(this.btn_criar_aluguer);
            this.Controls.Add(this.lb_matricula_a);
            this.Controls.Add(this.dtp_inicio);
            this.Controls.Add(this.lb_total_aluguer);
            this.Controls.Add(this.lb_veiculos_disponiveis);
            this.Controls.Add(this.lb_tempo_total_aluguer);
            this.Controls.Add(this.bt_confirm_aluguer);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.tb_tempo_total);
            this.Controls.Add(this.lb_inicio);
            this.Controls.Add(this.lb_preco_total_aluguer);
            this.Controls.Add(this.lb_fim);
            this.Controls.Add(this.cb_filtro_disponiveis);
            this.Controls.Add(this.lb_filtro);
            this.Controls.Add(this.lb_matricula_selecionada);
            this.Controls.Add(this.tb_matricula_selec);
            this.Controls.Add(this.bt_calcular_valor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormGerirAluguer";
            this.Text = "FormGerirAluguer";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_disponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_aluguer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_disponiveis;
        private System.Windows.Forms.Button btn_criar_aluguer;
        private System.Windows.Forms.Label lb_tempo_total_aluguer;
        private System.Windows.Forms.Button bt_confirm_aluguer;
        private System.Windows.Forms.TextBox tb_tempo_total;
        private System.Windows.Forms.Label lb_inicio;
        private System.Windows.Forms.Label lb_fim;
        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fim;
        private System.Windows.Forms.Label lb_filtro;
        private System.Windows.Forms.ComboBox cb_filtro_disponiveis;
        private System.Windows.Forms.PictureBox pb_aluguer;
        private System.Windows.Forms.Label lb_veiculos_disponiveis;
        private System.Windows.Forms.Label lb_matricula_selecionada;
        private System.Windows.Forms.TextBox tb_matricula_selec;
        private System.Windows.Forms.Button bt_calcular_valor;
        private System.Windows.Forms.Label lb_preco_total_aluguer;
        private System.Windows.Forms.Label lb_total_aluguer;
        private System.Windows.Forms.Label lb_matricula_a;
        private System.Windows.Forms.Label lb_matricula_selec;
    }
}