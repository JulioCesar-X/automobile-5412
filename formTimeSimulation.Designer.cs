namespace Automobile
{
    partial class FormTimeSimulation
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFim = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewVeiculosAlugados = new System.Windows.Forms.DataGridView();
            this.lb_veiculos_alugados = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.comboBoxTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.lb_filtro = new System.Windows.Forms.Label();
            this.chb_ver_veiculos = new System.Windows.Forms.CheckBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculosAlugados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(781, 43);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(278, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Calculate Reserves";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(89, 52);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerInicio.TabIndex = 5;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.DateTimePickerInicio_ValueChanged);
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(377, 53);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerFim.TabIndex = 6;
            this.dateTimePickerFim.ValueChanged += new System.EventHandler(this.DateTimePickerFim_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(327, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fim:";
            // 
            // dataGridViewVeiculosAlugados
            // 
            this.dataGridViewVeiculosAlugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeiculosAlugados.Location = new System.Drawing.Point(43, 189);
            this.dataGridViewVeiculosAlugados.Name = "dataGridViewVeiculosAlugados";
            this.dataGridViewVeiculosAlugados.RowHeadersWidth = 51;
            this.dataGridViewVeiculosAlugados.Size = new System.Drawing.Size(709, 234);
            this.dataGridViewVeiculosAlugados.TabIndex = 9;
            this.dataGridViewVeiculosAlugados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculosAlugados_CellContentClick);
            // 
            // lb_veiculos_alugados
            // 
            this.lb_veiculos_alugados.AutoSize = true;
            this.lb_veiculos_alugados.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_veiculos_alugados.Location = new System.Drawing.Point(296, 158);
            this.lb_veiculos_alugados.Name = "lb_veiculos_alugados";
            this.lb_veiculos_alugados.Size = new System.Drawing.Size(168, 29);
            this.lb_veiculos_alugados.TabIndex = 10;
            this.lb_veiculos_alugados.Text = "??? Alugados";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(623, 53);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(85, 27);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(39, 103);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(89, 31);
            this.lblPreco.TabIndex = 12;
            this.lblPreco.Text = "Total:";
            this.lblPreco.Click += new System.EventHandler(this.lblPreco_Click);
            // 
            // comboBoxTipoVeiculo
            // 
            this.comboBoxTipoVeiculo.FormattingEnabled = true;
            this.comboBoxTipoVeiculo.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camiao",
            "Camioneta"});
            this.comboBoxTipoVeiculo.Location = new System.Drawing.Point(661, 112);
            this.comboBoxTipoVeiculo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxTipoVeiculo.Name = "comboBoxTipoVeiculo";
            this.comboBoxTipoVeiculo.Size = new System.Drawing.Size(92, 21);
            this.comboBoxTipoVeiculo.TabIndex = 13;
            this.comboBoxTipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoVeiculo_SelectedIndexChanged);
            // 
            // lb_filtro
            // 
            this.lb_filtro.AutoSize = true;
            this.lb_filtro.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filtro.Location = new System.Drawing.Point(607, 111);
            this.lb_filtro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_filtro.Name = "lb_filtro";
            this.lb_filtro.Size = new System.Drawing.Size(59, 20);
            this.lb_filtro.TabIndex = 14;
            this.lb_filtro.Text = "Filtro:";
            // 
            // chb_ver_veiculos
            // 
            this.chb_ver_veiculos.AutoSize = true;
            this.chb_ver_veiculos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chb_ver_veiculos.Location = new System.Drawing.Point(468, 111);
            this.chb_ver_veiculos.Margin = new System.Windows.Forms.Padding(2);
            this.chb_ver_veiculos.Name = "chb_ver_veiculos";
            this.chb_ver_veiculos.Size = new System.Drawing.Size(138, 24);
            this.chb_ver_veiculos.TabIndex = 16;
            this.chb_ver_veiculos.Text = "Ver Veiculos";
            this.chb_ver_veiculos.UseVisualStyleBackColor = true;
            this.chb_ver_veiculos.CheckedChanged += new System.EventHandler(this.chb_ver_veiculos_CheckedChanged);
            // 
            // FormTimeSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(781, 443);
            this.Controls.Add(this.chb_ver_veiculos);
            this.Controls.Add(this.lb_filtro);
            this.Controls.Add(this.comboBoxTipoVeiculo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lb_veiculos_alugados);
            this.Controls.Add(this.dataGridViewVeiculosAlugados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTimeSimulation";
            this.Text = "formTimeSimulation";
            this.Load += new System.EventHandler(this.FormTimeSimulation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculosAlugados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.DateTimePicker dateTimePickerFim;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewVeiculosAlugados;
        private System.Windows.Forms.Label lb_veiculos_alugados;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox comboBoxTipoVeiculo;
        private System.Windows.Forms.Label lb_filtro;
        private System.Windows.Forms.CheckBox chb_ver_veiculos;
    }
}