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
            this.lb_filtrar = new System.Windows.Forms.Label();
            this.cb_filtrar = new System.Windows.Forms.ComboBox();
            this.lb_status = new System.Windows.Forms.Label();
            this.dgv_veiculos = new System.Windows.Forms.DataGridView();
            this.cb_status = new System.Windows.Forms.ComboBox();
            this.pb_list_veiculos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_list_veiculos)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_filtrar
            // 
            this.lb_filtrar.AutoSize = true;
            this.lb_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_filtrar.Location = new System.Drawing.Point(19, 17);
            this.lb_filtrar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_filtrar.Name = "lb_filtrar";
            this.lb_filtrar.Size = new System.Drawing.Size(69, 24);
            this.lb_filtrar.TabIndex = 1;
            this.lb_filtrar.Text = "Filtrar:";
            // 
            // cb_filtrar
            // 
            this.cb_filtrar.FormattingEnabled = true;
            this.cb_filtrar.Items.AddRange(new object[] {
            "Carro",
            "Mota",
            "Camioneta",
            "Camiao"});
            this.cb_filtrar.Location = new System.Drawing.Point(91, 21);
            this.cb_filtrar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cb_filtrar.Name = "cb_filtrar";
            this.cb_filtrar.Size = new System.Drawing.Size(92, 21);
            this.cb_filtrar.TabIndex = 2;
            this.cb_filtrar.SelectedIndexChanged += new System.EventHandler(this.ComboBoxFiltrar_SelectedIndexChanged);
            // 
            // lb_status
            // 
            this.lb_status.AutoSize = true;
            this.lb_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_status.Location = new System.Drawing.Point(215, 17);
            this.lb_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_status.Name = "lb_status";
            this.lb_status.Size = new System.Drawing.Size(72, 24);
            this.lb_status.TabIndex = 1;
            this.lb_status.Text = "Status:";
            // 
            // dgv_veiculos
            // 
            this.dgv_veiculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_veiculos.Location = new System.Drawing.Point(-1, 54);
            this.dgv_veiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv_veiculos.Name = "dgv_veiculos";
            this.dgv_veiculos.RowHeadersWidth = 62;
            this.dgv_veiculos.RowTemplate.Height = 28;
            this.dgv_veiculos.Size = new System.Drawing.Size(799, 426);
            this.dgv_veiculos.TabIndex = 6;
            this.dgv_veiculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_veiculos_CellContentClick);
            // 
            // cb_status
            // 
            this.cb_status.FormattingEnabled = true;
            this.cb_status.Items.AddRange(new object[] {
            "Disponivel",
            "Alugado",
            "Reservado",
            "EmManutencao"});
            this.cb_status.Location = new System.Drawing.Point(294, 21);
            this.cb_status.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_status.Name = "cb_status";
            this.cb_status.Size = new System.Drawing.Size(109, 21);
            this.cb_status.TabIndex = 7;
            this.cb_status.SelectedIndexChanged += new System.EventHandler(this.Cb_status_SelectedIndexChanged);
            // 
            // pb_list_veiculos
            // 
            this.pb_list_veiculos.BackColor = System.Drawing.Color.Transparent;
            this.pb_list_veiculos.BackgroundImage = global::Automobile.Properties.Resources.pngwing_com__33_;
            this.pb_list_veiculos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_list_veiculos.Location = new System.Drawing.Point(-1, 54);
            this.pb_list_veiculos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_list_veiculos.Name = "pb_list_veiculos";
            this.pb_list_veiculos.Size = new System.Drawing.Size(799, 426);
            this.pb_list_veiculos.TabIndex = 8;
            this.pb_list_veiculos.TabStop = false;
            // 
            // formChangeVehicleStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(795, 479);
            this.Controls.Add(this.pb_list_veiculos);
            this.Controls.Add(this.cb_status);
            this.Controls.Add(this.dgv_veiculos);
            this.Controls.Add(this.cb_filtrar);
            this.Controls.Add(this.lb_status);
            this.Controls.Add(this.lb_filtrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formChangeVehicleStatus";
            this.Text = "formChangeVehicleStatus";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_veiculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_list_veiculos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lb_filtrar;
        private System.Windows.Forms.ComboBox cb_filtrar;
        private System.Windows.Forms.Label lb_status;
        private System.Windows.Forms.DataGridView dgv_veiculos;
        private System.Windows.Forms.ComboBox cb_status;
        private System.Windows.Forms.PictureBox pb_list_veiculos;
    }
}