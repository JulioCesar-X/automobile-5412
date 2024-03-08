namespace Automobile
{
    partial class FormManageReservations
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
            this.bt_calcular_valor_a_pagar = new System.Windows.Forms.Button();
            this.lb_tempo_total_reserva = new System.Windows.Forms.Label();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.tb_valorfinaltempo = new System.Windows.Forms.TextBox();
            this.dgv_veiculos_disponiveis = new System.Windows.Forms.DataGridView();
            this.lb_preco_total = new System.Windows.Forms.Label();
            this.btn_criar_reserva = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.lblPrecoFinal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMatriculaEscolhida = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_disponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(823, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
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
            this.cb_filtro.Location = new System.Drawing.Point(896, 38);
            this.cb_filtro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(121, 24);
            this.cb_filtro.TabIndex = 20;
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // lb_matricula_selecionada
            // 
            this.lb_matricula_selecionada.AutoSize = true;
            this.lb_matricula_selecionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_matricula_selecionada.Location = new System.Drawing.Point(301, 390);
            this.lb_matricula_selecionada.Name = "lb_matricula_selecionada";
            this.lb_matricula_selecionada.Size = new System.Drawing.Size(199, 20);
            this.lb_matricula_selecionada.TabIndex = 25;
            this.lb_matricula_selecionada.Text = "Matricula selecionada:";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(529, 391);
            this.tb_matricula.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(183, 22);
            this.tb_matricula.TabIndex = 26;
            this.tb_matricula.TextChanged += new System.EventHandler(this.tb_matricula_TextChanged);
            // 
            // bt_calcular_valor_a_pagar
            // 
            this.bt_calcular_valor_a_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_calcular_valor_a_pagar.Location = new System.Drawing.Point(717, 390);
            this.bt_calcular_valor_a_pagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_calcular_valor_a_pagar.Name = "bt_calcular_valor_a_pagar";
            this.bt_calcular_valor_a_pagar.Size = new System.Drawing.Size(77, 26);
            this.bt_calcular_valor_a_pagar.TabIndex = 27;
            this.bt_calcular_valor_a_pagar.Text = "Enviar";
            this.bt_calcular_valor_a_pagar.UseVisualStyleBackColor = true;
            this.bt_calcular_valor_a_pagar.Click += new System.EventHandler(this.bt_calcular_valor_a_pagar_Click);
            // 
            // lb_tempo_total_reserva
            // 
            this.lb_tempo_total_reserva.AutoSize = true;
            this.lb_tempo_total_reserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_tempo_total_reserva.Location = new System.Drawing.Point(20, 283);
            this.lb_tempo_total_reserva.Name = "lb_tempo_total_reserva";
            this.lb_tempo_total_reserva.Size = new System.Drawing.Size(209, 20);
            this.lb_tempo_total_reserva.TabIndex = 33;
            this.lb_tempo_total_reserva.Text = "Tempo total de Reserva";
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(96, 222);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(75, 31);
            this.bt_confirm.TabIndex = 35;
            this.bt_confirm.Text = "Confirm";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tb_valorfinaltempo
            // 
            this.tb_valorfinaltempo.Location = new System.Drawing.Point(78, 316);
            this.tb_valorfinaltempo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_valorfinaltempo.Name = "tb_valorfinaltempo";
            this.tb_valorfinaltempo.Size = new System.Drawing.Size(93, 22);
            this.tb_valorfinaltempo.TabIndex = 38;
            this.tb_valorfinaltempo.TextChanged += new System.EventHandler(this.textBoxIntervaloEscolhido_TextChanged);
            // 
            // dgv_veiculos_disponiveis
            // 
            this.dgv_veiculos_disponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos_disponiveis.Location = new System.Drawing.Point(276, 70);
            this.dgv_veiculos_disponiveis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgv_veiculos_disponiveis.Name = "dgv_veiculos_disponiveis";
            this.dgv_veiculos_disponiveis.RowHeadersWidth = 62;
            this.dgv_veiculos_disponiveis.RowTemplate.Height = 28;
            this.dgv_veiculos_disponiveis.Size = new System.Drawing.Size(741, 308);
            this.dgv_veiculos_disponiveis.TabIndex = 40;
            this.dgv_veiculos_disponiveis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cellClick);
            // 
            // lb_preco_total
            // 
            this.lb_preco_total.AutoSize = true;
            this.lb_preco_total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_preco_total.Location = new System.Drawing.Point(305, 471);
            this.lb_preco_total.Name = "lb_preco_total";
            this.lb_preco_total.Size = new System.Drawing.Size(130, 25);
            this.lb_preco_total.TabIndex = 41;
            this.lb_preco_total.Text = "Preço Total:";
            this.lb_preco_total.Visible = false;
            // 
            // btn_criar_reserva
            // 
            this.btn_criar_reserva.Location = new System.Drawing.Point(873, 492);
            this.btn_criar_reserva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_criar_reserva.Name = "btn_criar_reserva";
            this.btn_criar_reserva.Size = new System.Drawing.Size(94, 45);
            this.btn_criar_reserva.TabIndex = 42;
            this.btn_criar_reserva.Text = "Reservar";
            this.btn_criar_reserva.UseVisualStyleBackColor = true;
            this.btn_criar_reserva.Click += new System.EventHandler(this.btn_criar_reserva_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 69);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 44;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 144);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 45;
            this.label2.Text = "Fim";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(21, 103);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(224, 22);
            this.dateTimePickerInicio.TabIndex = 46;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.dateTimePickerInicio_ValueChanged);
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(21, 178);
            this.dateTimePickerFim.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(223, 22);
            this.dateTimePickerFim.TabIndex = 47;
            // 
            // lblPrecoFinal
            // 
            this.lblPrecoFinal.AutoSize = true;
            this.lblPrecoFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoFinal.ForeColor = System.Drawing.Color.Red;
            this.lblPrecoFinal.Location = new System.Drawing.Point(441, 471);
            this.lblPrecoFinal.Name = "lblPrecoFinal";
            this.lblPrecoFinal.Size = new System.Drawing.Size(70, 25);
            this.lblPrecoFinal.TabIndex = 48;
            this.lblPrecoFinal.Text = "label3";
            this.lblPrecoFinal.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 49;
            this.label3.Text = "Matricula:";
            // 
            // lblMatriculaEscolhida
            // 
            this.lblMatriculaEscolhida.AutoSize = true;
            this.lblMatriculaEscolhida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatriculaEscolhida.ForeColor = System.Drawing.Color.Red;
            this.lblMatriculaEscolhida.Location = new System.Drawing.Point(418, 433);
            this.lblMatriculaEscolhida.Name = "lblMatriculaEscolhida";
            this.lblMatriculaEscolhida.Size = new System.Drawing.Size(70, 25);
            this.lblMatriculaEscolhida.TabIndex = 50;
            this.lblMatriculaEscolhida.Text = "label4";
            this.lblMatriculaEscolhida.Visible = false;
            // 
            // FormManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1047, 599);
            this.Controls.Add(this.lblMatriculaEscolhida);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPrecoFinal);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_criar_reserva);
            this.Controls.Add(this.lb_preco_total);
            this.Controls.Add(this.dgv_veiculos_disponiveis);
            this.Controls.Add(this.tb_valorfinaltempo);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.lb_tempo_total_reserva);
            this.Controls.Add(this.bt_calcular_valor_a_pagar);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.lb_matricula_selecionada);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.label10);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormManageReservations";
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
        private System.Windows.Forms.Button bt_calcular_valor_a_pagar;
        private System.Windows.Forms.Label lb_tempo_total_reserva;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.TextBox tb_valorfinaltempo;
        private System.Windows.Forms.DataGridView dgv_veiculos_disponiveis;
        private System.Windows.Forms.Label lb_preco_total;
        private System.Windows.Forms.Button btn_criar_reserva;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Label lblPrecoFinal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMatriculaEscolhida;
    }
}