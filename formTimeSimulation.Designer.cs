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
            this.label6 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblPreco = new System.Windows.Forms.Label();
            this.comboBoxTipoVeiculo = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVeiculosAlugados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkGray;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1067, 53);
            this.panel2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(407, 12);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Calculate Billing";
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(148, 93);
            this.dateTimePickerInicio.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerInicio.TabIndex = 5;
            this.dateTimePickerInicio.ValueChanged += new System.EventHandler(this.DateTimePickerInicio_ValueChanged);
            // 
            // dateTimePickerFim
            // 
            this.dateTimePickerFim.Location = new System.Drawing.Point(688, 93);
            this.dateTimePickerFim.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePickerFim.Name = "dateTimePickerFim";
            this.dateTimePickerFim.Size = new System.Drawing.Size(265, 22);
            this.dateTimePickerFim.TabIndex = 6;
            this.dateTimePickerFim.ValueChanged += new System.EventHandler(this.DateTimePickerFim_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(81, 93);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Início:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(636, 93);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Fim:";
            // 
            // dataGridViewVeiculosAlugados
            // 
            this.dataGridViewVeiculosAlugados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVeiculosAlugados.Location = new System.Drawing.Point(225, 237);
            this.dataGridViewVeiculosAlugados.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewVeiculosAlugados.Name = "dataGridViewVeiculosAlugados";
            this.dataGridViewVeiculosAlugados.RowHeadersWidth = 51;
            this.dataGridViewVeiculosAlugados.Size = new System.Drawing.Size(613, 129);
            this.dataGridViewVeiculosAlugados.TabIndex = 9;
            this.dataGridViewVeiculosAlugados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewVeiculosAlugados_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(417, 193);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Veículos Alugados";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(457, 387);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(4);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(107, 28);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(666, 466);
            this.lblPreco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
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
            this.comboBoxTipoVeiculo.Location = new System.Drawing.Point(225, 200);
            this.comboBoxTipoVeiculo.Name = "comboBoxTipoVeiculo";
            this.comboBoxTipoVeiculo.Size = new System.Drawing.Size(121, 24);
            this.comboBoxTipoVeiculo.TabIndex = 13;
            this.comboBoxTipoVeiculo.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoVeiculo_SelectedIndexChanged);
            // 
            // FormTimeSimulation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.comboBoxTipoVeiculo);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewVeiculosAlugados);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePickerFim);
            this.Controls.Add(this.dateTimePickerInicio);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.ComboBox comboBoxTipoVeiculo;
    }
}