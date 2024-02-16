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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridViewMotas = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaMotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaMotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraMotas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCamionetas = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraCamionetas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCamioes = new System.Windows.Forms.DataGridView();
            this.ColumnMarcaCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMatriculaCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnPrecoHoraCamioes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnOkFim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOkInicio = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.textBoxInicio = new System.Windows.Forms.TextBox();
            this.textBoxFim = new System.Windows.Forms.TextBox();
            this.textBoxIntervaloEscolhido = new System.Windows.Forms.TextBox();
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
            this.ColumnMarcaCarros,
            this.ColumnMatriculaCarros,
            this.ColumnPrecoHoraCarros});
            this.dataGridViewCarros.GridColor = System.Drawing.Color.LightGray;
            this.dataGridViewCarros.Location = new System.Drawing.Point(304, 323);
            this.dataGridViewCarros.Name = "dataGridViewCarros";
            this.dataGridViewCarros.RowHeadersWidth = 51;
            this.dataGridViewCarros.RowTemplate.Height = 24;
            this.dataGridViewCarros.Size = new System.Drawing.Size(571, 79);
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
            this.label10.Location = new System.Drawing.Point(300, 278);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 20);
            this.label10.TabIndex = 19;
            this.label10.Text = "Filtrar: ";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Carros",
            "Motas",
            "Camionetas",
            "Camiões"});
            this.comboBox1.Location = new System.Drawing.Point(378, 278);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dataGridViewMotas
            // 
            this.dataGridViewMotas.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewMotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaMotas,
            this.ColumnMatriculaMotas,
            this.ColumnPrecoHoraMotas});
            this.dataGridViewMotas.Location = new System.Drawing.Point(304, 323);
            this.dataGridViewMotas.Name = "dataGridViewMotas";
            this.dataGridViewMotas.RowHeadersWidth = 51;
            this.dataGridViewMotas.RowTemplate.Height = 24;
            this.dataGridViewMotas.Size = new System.Drawing.Size(571, 79);
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
            this.dataGridViewCamionetas.Location = new System.Drawing.Point(304, 323);
            this.dataGridViewCamionetas.Name = "dataGridViewCamionetas";
            this.dataGridViewCamionetas.RowHeadersWidth = 51;
            this.dataGridViewCamionetas.RowTemplate.Height = 24;
            this.dataGridViewCamionetas.Size = new System.Drawing.Size(571, 79);
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
            // dataGridViewCamioes
            // 
            this.dataGridViewCamioes.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewCamioes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCamioes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnMarcaCamioes,
            this.ColumnMatriculaCamioes,
            this.ColumnPrecoHoraCamioes});
            this.dataGridViewCamioes.Location = new System.Drawing.Point(304, 323);
            this.dataGridViewCamioes.Name = "dataGridViewCamioes";
            this.dataGridViewCamioes.RowHeadersWidth = 51;
            this.dataGridViewCamioes.RowTemplate.Height = 24;
            this.dataGridViewCamioes.Size = new System.Drawing.Size(571, 79);
            this.dataGridViewCamioes.TabIndex = 24;
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
            this.label11.Location = new System.Drawing.Point(521, 278);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "Veículo Escolhido:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(710, 278);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 22);
            this.textBox1.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(898, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(61, 86);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(208, 324);
            this.listBox1.TabIndex = 28;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(61, 58);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(208, 22);
            this.dateTimePicker1.TabIndex = 29;
            // 
            // btnOkFim
            // 
            this.btnOkFim.Location = new System.Drawing.Point(569, 125);
            this.btnOkFim.Name = "btnOkFim";
            this.btnOkFim.Size = new System.Drawing.Size(60, 31);
            this.btnOkFim.TabIndex = 30;
            this.btnOkFim.Text = "OK";
            this.btnOkFim.UseVisualStyleBackColor = true;
            this.btnOkFim.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(300, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "Início";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(300, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Fim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Tempo de Reserva";
            // 
            // btnOkInicio
            // 
            this.btnOkInicio.Location = new System.Drawing.Point(569, 82);
            this.btnOkInicio.Name = "btnOkInicio";
            this.btnOkInicio.Size = new System.Drawing.Size(60, 31);
            this.btnOkInicio.TabIndex = 34;
            this.btnOkInicio.Text = "OK";
            this.btnOkInicio.UseVisualStyleBackColor = true;
            this.btnOkInicio.Click += new System.EventHandler(this.btnOkInicio_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(690, 165);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(68, 31);
            this.btnConfirm.TabIndex = 35;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // textBoxInicio
            // 
            this.textBoxInicio.Location = new System.Drawing.Point(369, 84);
            this.textBoxInicio.Name = "textBoxInicio";
            this.textBoxInicio.Size = new System.Drawing.Size(194, 22);
            this.textBoxInicio.TabIndex = 36;
            // 
            // textBoxFim
            // 
            this.textBoxFim.Location = new System.Drawing.Point(370, 129);
            this.textBoxFim.Name = "textBoxFim";
            this.textBoxFim.Size = new System.Drawing.Size(194, 22);
            this.textBoxFim.TabIndex = 37;
            // 
            // textBoxIntervaloEscolhido
            // 
            this.textBoxIntervaloEscolhido.Location = new System.Drawing.Point(509, 169);
            this.textBoxIntervaloEscolhido.Name = "textBoxIntervaloEscolhido";
            this.textBoxIntervaloEscolhido.Size = new System.Drawing.Size(159, 22);
            this.textBoxIntervaloEscolhido.TabIndex = 38;
            // 
            // formManageReservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1067, 603);
            this.Controls.Add(this.textBoxIntervaloEscolhido);
            this.Controls.Add(this.textBoxFim);
            this.Controls.Add(this.textBoxInicio);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnOkInicio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOkFim);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewCamioes);
            this.Controls.Add(this.dataGridViewCamionetas);
            this.Controls.Add(this.dataGridViewMotas);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataGridViewCarros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formManageReservations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formManageReservations";
            this.Load += new System.EventHandler(this.formManageReservations_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamionetas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCamioes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewCarros;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
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
        private System.Windows.Forms.DataGridView dataGridViewCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMarcaCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMatriculaCamioes;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrecoHoraCamioes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnOkFim;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOkInicio;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox textBoxInicio;
        private System.Windows.Forms.TextBox textBoxFim;
        private System.Windows.Forms.TextBox textBoxIntervaloEscolhido;
    }
}