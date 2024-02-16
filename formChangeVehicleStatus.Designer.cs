namespace Automobile
{
    partial class formChangeVehicleStatus
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
            this.ColumnMarcaCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCarro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNmrPortas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTipoCaixa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.dataGridViewMotas = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCilindrada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCamionetas = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNmrEixos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNmrMaxPassageiros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCamioes = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPesoMaxSuportado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionetas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamioes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCarros
            // 
            this.dataGridViewCarros.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCarros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCarro,
            this.ColumnMatriculaCarro,
            this.ColumnNmrPortas,
            this.ColumnTipoCaixa});
            this.dataGridViewCarros.Location = new System.Drawing.Point(0, 83);
            this.dataGridViewCarros.Name = "dataGridViewCarros";
            this.dataGridViewCarros.RowHeadersWidth = 51;
            this.dataGridViewCarros.RowTemplate.Height = 24;
            this.dataGridViewCarros.Size = new System.Drawing.Size(977, 130);
            this.dataGridViewCarros.TabIndex = 0;
            this.dataGridViewCarros.Visible = false;
            // 
            // ColumnMarcaCarro
            // 
            this.ColumnMarcaCarro.HeaderText = "Marca";
            this.ColumnMarcaCarro.MinimumWidth = 6;
            this.ColumnMarcaCarro.Name = "ColumnMarcaCarro";
            this.ColumnMarcaCarro.Width = 125;
            // 
            // ColumnMatriculaCarro
            // 
            this.ColumnMatriculaCarro.HeaderText = "Matrícula";
            this.ColumnMatriculaCarro.MinimumWidth = 6;
            this.ColumnMatriculaCarro.Name = "ColumnMatriculaCarro";
            this.ColumnMatriculaCarro.Width = 125;
            // 
            // ColumnNmrPortas
            // 
            this.ColumnNmrPortas.HeaderText = "Nº Portas";
            this.ColumnNmrPortas.MinimumWidth = 6;
            this.ColumnNmrPortas.Name = "ColumnNmrPortas";
            this.ColumnNmrPortas.Width = 70;
            // 
            // ColumnTipoCaixa
            // 
            this.ColumnTipoCaixa.HeaderText = "Tipo de Caixa";
            this.ColumnTipoCaixa.MinimumWidth = 6;
            this.ColumnTipoCaixa.Name = "ColumnTipoCaixa";
            this.ColumnTipoCaixa.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar:";
            // 
            // comboBoxFiltrar
            // 
            this.comboBoxFiltrar.FormattingEnabled = true;
            this.comboBoxFiltrar.Items.AddRange(new object[] {
            "Carros",
            "Motas",
            "Camionetas",
            "Camiões"});
            this.comboBoxFiltrar.Location = new System.Drawing.Point(120, 36);
            this.comboBoxFiltrar.Name = "comboBoxFiltrar";
            this.comboBoxFiltrar.Size = new System.Drawing.Size(121, 24);
            this.comboBoxFiltrar.TabIndex = 2;
            this.comboBoxFiltrar.SelectedIndexChanged += new System.EventHandler(this.comboBoxFiltrar_SelectedIndexChanged);
            // 
            // dataGridViewMotas
            // 
            this.dataGridViewMotas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaMota,
            this.ColumnMatriculaMota,
            this.ColumnCilindrada});
            this.dataGridViewMotas.Location = new System.Drawing.Point(0, 83);
            this.dataGridViewMotas.Name = "dataGridViewMotas";
            this.dataGridViewMotas.RowHeadersWidth = 51;
            this.dataGridViewMotas.RowTemplate.Height = 24;
            this.dataGridViewMotas.Size = new System.Drawing.Size(977, 156);
            this.dataGridViewMotas.TabIndex = 3;
            this.dataGridViewMotas.Visible = false;
            // 
            // ColumnMarcaMota
            // 
            this.ColumnMarcaMota.HeaderText = "Marca";
            this.ColumnMarcaMota.MinimumWidth = 6;
            this.ColumnMarcaMota.Name = "ColumnMarcaMota";
            this.ColumnMarcaMota.Width = 125;
            // 
            // ColumnMatriculaMota
            // 
            this.ColumnMatriculaMota.HeaderText = "Matrícula";
            this.ColumnMatriculaMota.MinimumWidth = 6;
            this.ColumnMatriculaMota.Name = "ColumnMatriculaMota";
            this.ColumnMatriculaMota.Width = 125;
            // 
            // ColumnCilindrada
            // 
            this.ColumnCilindrada.HeaderText = "Cilindrada";
            this.ColumnCilindrada.MinimumWidth = 6;
            this.ColumnCilindrada.Name = "ColumnCilindrada";
            this.ColumnCilindrada.Width = 125;
            // 
            // dataGridViewCamionetas
            // 
            this.dataGridViewCamionetas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCamionetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamionetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCamionetas,
            this.ColumnMatriculaCamionetas,
            this.ColumnNmrEixos,
            this.ColumnNmrMaxPassageiros});
            this.dataGridViewCamionetas.Location = new System.Drawing.Point(0, 83);
            this.dataGridViewCamionetas.Name = "dataGridViewCamionetas";
            this.dataGridViewCamionetas.RowHeadersWidth = 51;
            this.dataGridViewCamionetas.RowTemplate.Height = 24;
            this.dataGridViewCamionetas.Size = new System.Drawing.Size(977, 150);
            this.dataGridViewCamionetas.TabIndex = 4;
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
            // ColumnNmrEixos
            // 
            this.ColumnNmrEixos.HeaderText = "Nº de Eixos";
            this.ColumnNmrEixos.MinimumWidth = 6;
            this.ColumnNmrEixos.Name = "ColumnNmrEixos";
            this.ColumnNmrEixos.Width = 125;
            // 
            // ColumnNmrMaxPassageiros
            // 
            this.ColumnNmrMaxPassageiros.HeaderText = "Nº Mx Passageiros";
            this.ColumnNmrMaxPassageiros.MinimumWidth = 6;
            this.ColumnNmrMaxPassageiros.Name = "ColumnNmrMaxPassageiros";
            this.ColumnNmrMaxPassageiros.Width = 125;
            // 
            // dataGridViewCamioes
            // 
            this.dataGridViewCamioes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCamioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamioes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCamioes,
            this.ColumnMatriculaCamioes,
            this.ColumnPesoMaxSuportado});
            this.dataGridViewCamioes.Location = new System.Drawing.Point(0, 83);
            this.dataGridViewCamioes.Name = "dataGridViewCamioes";
            this.dataGridViewCamioes.RowHeadersWidth = 51;
            this.dataGridViewCamioes.RowTemplate.Height = 24;
            this.dataGridViewCamioes.Size = new System.Drawing.Size(977, 150);
            this.dataGridViewCamioes.TabIndex = 5;
            this.dataGridViewCamioes.Visible = false;
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
            // ColumnPesoMaxSuportado
            // 
            this.ColumnPesoMaxSuportado.HeaderText = "Peso Max Suportado";
            this.ColumnPesoMaxSuportado.MinimumWidth = 6;
            this.ColumnPesoMaxSuportado.Name = "ColumnPesoMaxSuportado";
            this.ColumnPesoMaxSuportado.Width = 125;
            // 
            // formChangeVehicleStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(977, 587);
            this.Controls.Add(this.dataGridViewCamioes);
            this.Controls.Add(this.dataGridViewCamionetas);
            this.Controls.Add(this.dataGridViewMotas);
            this.Controls.Add(this.comboBoxFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formChangeVehicleStatus";
            this.Text = "formChangeVehicleStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamioes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCarros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxFiltrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCarro;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNmrPortas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTipoCaixa;
        private System.Windows.Forms.DataGridView dataGridViewMotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCilindrada;
        private System.Windows.Forms.DataGridView dataGridViewCamionetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCamionetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCamionetas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNmrEixos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNmrMaxPassageiros;
        private System.Windows.Forms.DataGridView dataGridViewCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPesoMaxSuportado;
    }
}