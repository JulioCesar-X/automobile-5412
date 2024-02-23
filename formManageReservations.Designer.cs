namespace Automobile
{
    partial class formManageReservations
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
            this.label10 = new System.Windows.Forms.Label();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.lb_matricula_selecionada = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.bt_carcular_valor_a_pagar = new System.Windows.Forms.Button();
            this.list_box_horario = new System.Windows.Forms.ListBox();
            this.date_time_dias = new System.Windows.Forms.DateTimePicker();
            this.bt_ok_fim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_tempo_total_reserva = new System.Windows.Forms.Label();
            this.bt_ok_inicio = new System.Windows.Forms.Button();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.tb_inicio = new System.Windows.Forms.TextBox();
            this.tb_fim = new System.Windows.Forms.TextBox();
            this.tb_valorfinaltempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dgv_veiculos_disponiveis = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_disponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(911, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "Filtrar: ";
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camioneta",
            "Camiao"});
            this.cb_filtro.Location = new System.Drawing.Point(993, 117);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(136, 28);
            this.cb_filtro.TabIndex = 20;
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_matricula_selecionada
            // 
            this.lb_matricula_selecionada.AutoSize = true;
            this.lb_matricula_selecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula_selecionada.Location = new System.Drawing.Point(265, 121);
            this.lb_matricula_selecionada.Name = "lb_matricula_selecionada";
            this.lb_matricula_selecionada.Size = new System.Drawing.Size(250, 25);
            this.lb_matricula_selecionada.TabIndex = 25;
            this.lb_matricula_selecionada.Text = "Matricula selecionada:";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(521, 120);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(205, 26);
            this.tb_matricula.TabIndex = 26;
            // 
            // bt_carcular_valor_a_pagar
            // 
            this.bt_carcular_valor_a_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_carcular_valor_a_pagar.Location = new System.Drawing.Point(732, 116);
            this.bt_carcular_valor_a_pagar.Name = "bt_carcular_valor_a_pagar";
            this.bt_carcular_valor_a_pagar.Size = new System.Drawing.Size(87, 33);
            this.bt_carcular_valor_a_pagar.TabIndex = 27;
            this.bt_carcular_valor_a_pagar.Text = "Enviar";
            this.bt_carcular_valor_a_pagar.UseVisualStyleBackColor = true;
            // 
            // list_box_horario
            // 
            this.list_box_horario.FormattingEnabled = true;
            this.list_box_horario.ItemHeight = 20;
            this.list_box_horario.Location = new System.Drawing.Point(15, 158);
            this.list_box_horario.Name = "list_box_horario";
            this.list_box_horario.Size = new System.Drawing.Size(211, 384);
            this.list_box_horario.TabIndex = 28;
            // 
            // date_time_dias
            // 
            this.date_time_dias.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time_dias.Location = new System.Drawing.Point(15, 90);
            this.date_time_dias.Name = "date_time_dias";
            this.date_time_dias.Size = new System.Drawing.Size(211, 26);
            this.date_time_dias.TabIndex = 29;
            // 
            // bt_ok_fim
            // 
            this.bt_ok_fim.Location = new System.Drawing.Point(237, 640);
            this.bt_ok_fim.Name = "bt_ok_fim";
            this.bt_ok_fim.Size = new System.Drawing.Size(61, 37);
            this.bt_ok_fim.TabIndex = 30;
            this.bt_ok_fim.Text = "OK";
            this.bt_ok_fim.UseVisualStyleBackColor = true;
            this.bt_ok_fim.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 559);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 31;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fim";
            // 
            // lb_tempo_total_reserva
            // 
            this.lb_tempo_total_reserva.AutoSize = true;
            this.lb_tempo_total_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempo_total_reserva.Location = new System.Drawing.Point(336, 559);
            this.lb_tempo_total_reserva.Name = "lb_tempo_total_reserva";
            this.lb_tempo_total_reserva.Size = new System.Drawing.Size(270, 25);
            this.lb_tempo_total_reserva.TabIndex = 33;
            this.lb_tempo_total_reserva.Text = "Tempo total de Reserva:";
            // 
            // bt_ok_inicio
            // 
            this.bt_ok_inicio.Location = new System.Drawing.Point(238, 586);
            this.bt_ok_inicio.Name = "bt_ok_inicio";
            this.bt_ok_inicio.Size = new System.Drawing.Size(61, 37);
            this.bt_ok_inicio.TabIndex = 34;
            this.bt_ok_inicio.Text = "OK";
            this.bt_ok_inicio.UseVisualStyleBackColor = true;
            this.bt_ok_inicio.Click += new System.EventHandler(this.btnOkInicio_Click);
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(556, 585);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(73, 38);
            this.bt_confirm.TabIndex = 35;
            this.bt_confirm.Text = "Confirm";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(14, 588);
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(210, 26);
            this.tb_inicio.TabIndex = 36;
            // 
            // tb_fim
            // 
            this.tb_fim.Location = new System.Drawing.Point(14, 645);
            this.tb_fim.Name = "tb_fim";
            this.tb_fim.Size = new System.Drawing.Size(210, 26);
            this.tb_fim.TabIndex = 37;
            // 
            // tb_valorfinaltempo
            // 
            this.tb_valorfinaltempo.Location = new System.Drawing.Point(340, 591);
            this.tb_valorfinaltempo.Name = "tb_valorfinaltempo";
            this.tb_valorfinaltempo.Size = new System.Drawing.Size(205, 26);
            this.tb_valorfinaltempo.TabIndex = 38;
            this.tb_valorfinaltempo.TextChanged += new System.EventHandler(this.textBoxIntervaloEscolhido_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Quando?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 39;
            this.label5.Text = "Que horas?";
            // 
            // dgv_veiculos_disponiveis
            // 
            this.dgv_veiculos_disponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos_disponiveis.Location = new System.Drawing.Point(270, 158);
            this.dgv_veiculos_disponiveis.Name = "dgv_veiculos_disponiveis";
            this.dgv_veiculos_disponiveis.RowHeadersWidth = 62;
            this.dgv_veiculos_disponiveis.RowTemplate.Height = 28;
            this.dgv_veiculos_disponiveis.Size = new System.Drawing.Size(858, 382);
            this.dgv_veiculos_disponiveis.TabIndex = 40;
            // 
            // formManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1200, 754);
            this.Controls.Add(this.dgv_veiculos_disponiveis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_valorfinaltempo);
            this.Controls.Add(this.tb_fim);
            this.Controls.Add(this.tb_inicio);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.bt_ok_inicio);
            this.Controls.Add(this.lb_tempo_total_reserva);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ok_fim);
            this.Controls.Add(this.date_time_dias);
            this.Controls.Add(this.list_box_horario);
            this.Controls.Add(this.bt_carcular_valor_a_pagar);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.lb_matricula_selecionada);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "formManageReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formManageReservations";
            this.Load += new System.EventHandler(this.formManageReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_disponiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.Label lb_matricula_selecionada;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Button bt_carcular_valor_a_pagar;
        private System.Windows.Forms.ListBox list_box_horario;
        private System.Windows.Forms.DateTimePicker date_time_dias;
        private System.Windows.Forms.Button bt_ok_fim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_tempo_total_reserva;
        private System.Windows.Forms.Button bt_ok_inicio;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.TextBox tb_inicio;
        private System.Windows.Forms.TextBox tb_fim;
        private System.Windows.Forms.TextBox tb_valorfinaltempo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgv_veiculos_disponiveis;
    }
}