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
            this.dataGridViewCarros = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCarros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCarros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraCarros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.cb_filtro = new System.Windows.Forms.ComboBox();
            this.dataGridViewMotas = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaMotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaMotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraMotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCamionetas = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_veiculos_disponiveis = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.tb_matricula = new System.Windows.Forms.TextBox();
            this.bt_carcular_valor_a_pagar = new System.Windows.Forms.Button();
            this.list_box_horario = new System.Windows.Forms.ListBox();
            this.date_time_dias = new System.Windows.Forms.DateTimePicker();
            this.bt_ok_fim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_ok_inicio = new System.Windows.Forms.Button();
            this.bt_confirm = new System.Windows.Forms.Button();
            this.tb_inicio = new System.Windows.Forms.TextBox();
            this.tb_fim = new System.Windows.Forms.TextBox();
            this.tb_valorfinaltempo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_disponiveis)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarros
            // 
            this.dataGridViewCarros.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCarros,
            this.ColumnMatriculaCarros,
            this.ColumnPrecoHoraCarros});
            this.dataGridViewCarros.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewCarros.Location = new System.Drawing.Point(228, 262);
            this.dataGridViewCarros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCarros.Name = "dataGridViewCarros";
            this.dataGridViewCarros.RowHeadersWidth = 51;
            this.dataGridViewCarros.RowTemplate.Height = 24;
            this.dataGridViewCarros.Size = new System.Drawing.Size(428, 64);
            this.dataGridViewCarros.TabIndex = 18;
            this.dataGridViewCarros.Visible = false;
            // 
            // ColumnMarcaCarros
            // 
            this.ColumnMarcaCarros.HeaderText = "Marca";
            this.ColumnMarcaCarros.MinimumWidth = 6;
            this.ColumnMarcaCarros.Name = "ColumnMarcaCarros";
            this.ColumnMarcaCarros.Width = 125;
            // 
            // ColumnMatriculaCarros
            // 
            this.ColumnMatriculaCarros.HeaderText = "Matrícula";
            this.ColumnMatriculaCarros.MinimumWidth = 6;
            this.ColumnMatriculaCarros.Name = "ColumnMatriculaCarros";
            this.ColumnMatriculaCarros.Width = 125;
            // 
            // ColumnPrecoHoraCarros
            // 
            this.ColumnPrecoHoraCarros.HeaderText = "Preço /h ";
            this.ColumnPrecoHoraCarros.MinimumWidth = 6;
            this.ColumnPrecoHoraCarros.Name = "ColumnPrecoHoraCarros";
            this.ColumnPrecoHoraCarros.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(225, 226);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Filtrar: ";
            // 
            // cb_filtro
            // 
            this.cb_filtro.FormattingEnabled = true;
            this.cb_filtro.Items.AddRange(new object[] {
            "Carros",
            "Motas",
            "Camionetas",
            "Camiões"});
            this.cb_filtro.Location = new System.Drawing.Point(284, 226);
            this.cb_filtro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_filtro.Name = "cb_filtro";
            this.cb_filtro.Size = new System.Drawing.Size(92, 21);
            this.cb_filtro.TabIndex = 20;
            this.cb_filtro.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewMotas
            // 
            this.dataGridViewMotas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaMotas,
            this.ColumnMatriculaMotas,
            this.ColumnPrecoHoraMotas});
            this.dataGridViewMotas.Location = new System.Drawing.Point(228, 262);
            this.dataGridViewMotas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMotas.Name = "dataGridViewMotas";
            this.dataGridViewMotas.RowHeadersWidth = 51;
            this.dataGridViewMotas.RowTemplate.Height = 24;
            this.dataGridViewMotas.Size = new System.Drawing.Size(428, 64);
            this.dataGridViewMotas.TabIndex = 22;
            this.dataGridViewMotas.Visible = false;
            // 
            // ColumnMarcaMotas
            // 
            this.ColumnMarcaMotas.HeaderText = "Marca";
            this.ColumnMarcaMotas.MinimumWidth = 6;
            this.ColumnMarcaMotas.Name = "ColumnMarcaMotas";
            this.ColumnMarcaMotas.Width = 125;
            // 
            // ColumnMatriculaMotas
            // 
            this.ColumnMatriculaMotas.HeaderText = "Matrícula";
            this.ColumnMatriculaMotas.MinimumWidth = 6;
            this.ColumnMatriculaMotas.Name = "ColumnMatriculaMotas";
            this.ColumnMatriculaMotas.Width = 125;
            // 
            // ColumnPrecoHoraMotas
            // 
            this.ColumnPrecoHoraMotas.HeaderText = "Preço /h";
            this.ColumnPrecoHoraMotas.MinimumWidth = 6;
            this.ColumnPrecoHoraMotas.Name = "ColumnPrecoHoraMotas";
            this.ColumnPrecoHoraMotas.Width = 125;
            // 
            // dataGridViewCamionetas
            // 
            this.dataGridViewCamionetas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCamionetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamionetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCamionetas,
            this.ColumnMatriculaCamionetas,
            this.ColumnPrecoHoraCamionetas});
            this.dataGridViewCamionetas.Location = new System.Drawing.Point(228, 262);
            this.dataGridViewCamionetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewCamionetas.Name = "dataGridViewCamionetas";
            this.dataGridViewCamionetas.RowHeadersWidth = 51;
            this.dataGridViewCamionetas.RowTemplate.Height = 24;
            this.dataGridViewCamionetas.Size = new System.Drawing.Size(428, 64);
            this.dataGridViewCamionetas.TabIndex = 23;
            this.dataGridViewCamionetas.Visible = false;
            // 
            // ColumnMarcaCamionetas
            // 
            this.ColumnMarcaCamionetas.HeaderText = "Marca";
            this.ColumnMarcaCamionetas.MinimumWidth = 6;
            this.ColumnMarcaCamionetas.Name = "ColumnMarcaCamionetas";
            this.ColumnMarcaCamionetas.Width = 125;
            // 
            // ColumnMatriculaCamionetas
            // 
            this.ColumnMatriculaCamionetas.HeaderText = "Matrícula";
            this.ColumnMatriculaCamionetas.MinimumWidth = 6;
            this.ColumnMatriculaCamionetas.Name = "ColumnMatriculaCamionetas";
            this.ColumnMatriculaCamionetas.Width = 125;
            // 
            // ColumnPrecoHoraCamionetas
            // 
            this.ColumnPrecoHoraCamionetas.HeaderText = "Preço /h";
            this.ColumnPrecoHoraCamionetas.MinimumWidth = 6;
            this.ColumnPrecoHoraCamionetas.Name = "ColumnPrecoHoraCamionetas";
            this.ColumnPrecoHoraCamionetas.Width = 125;
            // 
            // dgv_veiculos_disponiveis
            // 
            this.dgv_veiculos_disponiveis.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgv_veiculos_disponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos_disponiveis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCamioes,
            this.ColumnMatriculaCamioes,
            this.ColumnPrecoHoraCamioes});
            this.dgv_veiculos_disponiveis.Location = new System.Drawing.Point(228, 262);
            this.dgv_veiculos_disponiveis.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_veiculos_disponiveis.Name = "dgv_veiculos_disponiveis";
            this.dgv_veiculos_disponiveis.RowHeadersWidth = 51;
            this.dgv_veiculos_disponiveis.RowTemplate.Height = 24;
            this.dgv_veiculos_disponiveis.Size = new System.Drawing.Size(428, 64);
            this.dgv_veiculos_disponiveis.TabIndex = 24;
            this.dgv_veiculos_disponiveis.Visible = false;
            // 
            // ColumnMarcaCamioes
            // 
            this.ColumnMarcaCamioes.HeaderText = "Marca";
            this.ColumnMarcaCamioes.MinimumWidth = 6;
            this.ColumnMarcaCamioes.Name = "ColumnMarcaCamioes";
            this.ColumnMarcaCamioes.Width = 125;
            // 
            // ColumnMatriculaCamioes
            // 
            this.ColumnMatriculaCamioes.HeaderText = "Matrícula";
            this.ColumnMatriculaCamioes.MinimumWidth = 6;
            this.ColumnMatriculaCamioes.Name = "ColumnMatriculaCamioes";
            this.ColumnMatriculaCamioes.Width = 125;
            // 
            // ColumnPrecoHoraCamioes
            // 
            this.ColumnPrecoHoraCamioes.HeaderText = "Preço /h";
            this.ColumnPrecoHoraCamioes.MinimumWidth = 6;
            this.ColumnPrecoHoraCamioes.Name = "ColumnPrecoHoraCamioes";
            this.ColumnPrecoHoraCamioes.Width = 125;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(391, 226);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(141, 17);
            this.label11.TabIndex = 25;
            this.label11.Text = "Veículo Escolhido:";
            // 
            // tb_matricula
            // 
            this.tb_matricula.Location = new System.Drawing.Point(532, 226);
            this.tb_matricula.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_matricula.Name = "tb_matricula";
            this.tb_matricula.Size = new System.Drawing.Size(138, 20);
            this.tb_matricula.TabIndex = 26;
            // 
            // bt_carcular_valor_a_pagar
            // 
            this.bt_carcular_valor_a_pagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_carcular_valor_a_pagar.Location = new System.Drawing.Point(674, 227);
            this.bt_carcular_valor_a_pagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_carcular_valor_a_pagar.Name = "bt_carcular_valor_a_pagar";
            this.bt_carcular_valor_a_pagar.Size = new System.Drawing.Size(56, 19);
            this.bt_carcular_valor_a_pagar.TabIndex = 27;
            this.bt_carcular_valor_a_pagar.Text = "Calcular";
            this.bt_carcular_valor_a_pagar.UseVisualStyleBackColor = true;
            // 
            // list_box_horario
            // 
            this.list_box_horario.FormattingEnabled = true;
            this.list_box_horario.Location = new System.Drawing.Point(46, 70);
            this.list_box_horario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.list_box_horario.Name = "list_box_horario";
            this.list_box_horario.Size = new System.Drawing.Size(157, 264);
            this.list_box_horario.TabIndex = 28;
            // 
            // date_time_dias
            // 
            this.date_time_dias.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_time_dias.Location = new System.Drawing.Point(46, 47);
            this.date_time_dias.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.date_time_dias.Name = "date_time_dias";
            this.date_time_dias.Size = new System.Drawing.Size(157, 20);
            this.date_time_dias.TabIndex = 29;
            // 
            // bt_ok_fim
            // 
            this.bt_ok_fim.Location = new System.Drawing.Point(427, 102);
            this.bt_ok_fim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_ok_fim.Name = "bt_ok_fim";
            this.bt_ok_fim.Size = new System.Drawing.Size(45, 25);
            this.bt_ok_fim.TabIndex = 30;
            this.bt_ok_fim.Text = "OK";
            this.bt_ok_fim.UseVisualStyleBackColor = true;
            this.bt_ok_fim.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 70);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(225, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(225, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tempo de Reserva";
            // 
            // bt_ok_inicio
            // 
            this.bt_ok_inicio.Location = new System.Drawing.Point(427, 67);
            this.bt_ok_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_ok_inicio.Name = "bt_ok_inicio";
            this.bt_ok_inicio.Size = new System.Drawing.Size(45, 25);
            this.bt_ok_inicio.TabIndex = 34;
            this.bt_ok_inicio.Text = "OK";
            this.bt_ok_inicio.UseVisualStyleBackColor = true;
            this.bt_ok_inicio.Click += new System.EventHandler(this.btnOkInicio_Click);
            // 
            // bt_confirm
            // 
            this.bt_confirm.Location = new System.Drawing.Point(518, 134);
            this.bt_confirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_confirm.Name = "bt_confirm";
            this.bt_confirm.Size = new System.Drawing.Size(51, 25);
            this.bt_confirm.TabIndex = 35;
            this.bt_confirm.Text = "Confirm";
            this.bt_confirm.UseVisualStyleBackColor = true;
            this.bt_confirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // tb_inicio
            // 
            this.tb_inicio.Location = new System.Drawing.Point(277, 68);
            this.tb_inicio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_inicio.Name = "tb_inicio";
            this.tb_inicio.Size = new System.Drawing.Size(146, 20);
            this.tb_inicio.TabIndex = 36;
            // 
            // tb_fim
            // 
            this.tb_fim.Location = new System.Drawing.Point(278, 105);
            this.tb_fim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_fim.Name = "tb_fim";
            this.tb_fim.Size = new System.Drawing.Size(146, 20);
            this.tb_fim.TabIndex = 37;
            // 
            // tb_valorfinaltempo
            // 
            this.tb_valorfinaltempo.Location = new System.Drawing.Point(382, 137);
            this.tb_valorfinaltempo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_valorfinaltempo.Name = "tb_valorfinaltempo";
            this.tb_valorfinaltempo.Size = new System.Drawing.Size(120, 20);
            this.tb_valorfinaltempo.TabIndex = 38;
            this.tb_valorfinaltempo.TextChanged += new System.EventHandler(this.textBoxIntervaloEscolhido_TextChanged);
            // 
            // formManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.tb_valorfinaltempo);
            this.Controls.Add(this.tb_fim);
            this.Controls.Add(this.tb_inicio);
            this.Controls.Add(this.bt_confirm);
            this.Controls.Add(this.bt_ok_inicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_ok_fim);
            this.Controls.Add(this.date_time_dias);
            this.Controls.Add(this.list_box_horario);
            this.Controls.Add(this.bt_carcular_valor_a_pagar);
            this.Controls.Add(this.tb_matricula);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgv_veiculos_disponiveis);
            this.Controls.Add(this.dataGridViewCamionetas);
            this.Controls.Add(this.dataGridViewMotas);
            this.Controls.Add(this.cb_filtro);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formManageReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formManageReservations";
            this.Load += new System.EventHandler(this.formManageReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos_disponiveis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCarros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cb_filtro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCarros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecoHoraCarros;
        private System.Windows.Forms.DataGridView dataGridViewMotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaMotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaMotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecoHoraMotas;
        private System.Windows.Forms.DataGridView dataGridViewCamionetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCamionetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCamionetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecoHoraCamionetas;
        private System.Windows.Forms.DataGridView dgv_veiculos_disponiveis;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecoHoraCamioes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb_matricula;
        private System.Windows.Forms.Button bt_carcular_valor_a_pagar;
        private System.Windows.Forms.ListBox list_box_horario;
        private System.Windows.Forms.DateTimePicker date_time_dias;
        private System.Windows.Forms.Button bt_ok_fim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_ok_inicio;
        private System.Windows.Forms.Button bt_confirm;
        private System.Windows.Forms.TextBox tb_inicio;
        private System.Windows.Forms.TextBox tb_fim;
        private System.Windows.Forms.TextBox tb_valorfinaltempo;
    }
}