namespace Automobile
{
    partial class SelecaoData
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
            this.dtp_inicio = new System.Windows.Forms.DateTimePicker();
            this.dtp_fim = new System.Windows.Forms.DateTimePicker();
            this.btn_ok_datas = new System.Windows.Forms.Button();
            this.lb_selecao_data = new System.Windows.Forms.Label();
            this.lb_inicio = new System.Windows.Forms.Label();
            this.lb_fim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_inicio
            // 
            this.dtp_inicio.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_inicio.CalendarMonthBackground = System.Drawing.Color.AliceBlue;
            this.dtp_inicio.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtp_inicio.Location = new System.Drawing.Point(12, 223);
            this.dtp_inicio.Name = "dtp_inicio";
            this.dtp_inicio.Size = new System.Drawing.Size(200, 26);
            this.dtp_inicio.TabIndex = 0;
            // 
            // dtp_fim
            // 
            this.dtp_fim.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtp_fim.Location = new System.Drawing.Point(353, 223);
            this.dtp_fim.Name = "dtp_fim";
            this.dtp_fim.Size = new System.Drawing.Size(200, 26);
            this.dtp_fim.TabIndex = 1;
            this.dtp_fim.Value = new System.DateTime(2024, 3, 10, 16, 41, 14, 0);
            // 
            // btn_ok_datas
            // 
            this.btn_ok_datas.BackColor = System.Drawing.Color.White;
            this.btn_ok_datas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_ok_datas.FlatAppearance.BorderSize = 2;
            this.btn_ok_datas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_datas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_datas.ForeColor = System.Drawing.Color.Black;
            this.btn_ok_datas.Location = new System.Drawing.Point(237, 274);
            this.btn_ok_datas.Name = "btn_ok_datas";
            this.btn_ok_datas.Size = new System.Drawing.Size(100, 49);
            this.btn_ok_datas.TabIndex = 2;
            this.btn_ok_datas.Text = "OK";
            this.btn_ok_datas.UseVisualStyleBackColor = false;
            this.btn_ok_datas.Click += new System.EventHandler(this.Btn_ok_datas_Click);
            // 
            // lb_selecao_data
            // 
            this.lb_selecao_data.AutoSize = true;
            this.lb_selecao_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_selecao_data.ForeColor = System.Drawing.Color.White;
            this.lb_selecao_data.Location = new System.Drawing.Point(92, 9);
            this.lb_selecao_data.Name = "lb_selecao_data";
            this.lb_selecao_data.Size = new System.Drawing.Size(388, 46);
            this.lb_selecao_data.TabIndex = 3;
            this.lb_selecao_data.Text = "Selecione as datas!";
            // 
            // lb_inicio
            // 
            this.lb_inicio.AutoSize = true;
            this.lb_inicio.BackColor = System.Drawing.Color.Black;
            this.lb_inicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_inicio.ForeColor = System.Drawing.Color.White;
            this.lb_inicio.Location = new System.Drawing.Point(83, 195);
            this.lb_inicio.Name = "lb_inicio";
            this.lb_inicio.Size = new System.Drawing.Size(70, 25);
            this.lb_inicio.TabIndex = 4;
            this.lb_inicio.Text = "Inicio:";
            // 
            // lb_fim
            // 
            this.lb_fim.AutoSize = true;
            this.lb_fim.BackColor = System.Drawing.Color.Black;
            this.lb_fim.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_fim.ForeColor = System.Drawing.Color.White;
            this.lb_fim.Location = new System.Drawing.Point(426, 195);
            this.lb_fim.Name = "lb_fim";
            this.lb_fim.Size = new System.Drawing.Size(54, 25);
            this.lb_fim.TabIndex = 4;
            this.lb_fim.Text = "Fim:";
            // 
            // SelecaoData
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.BackgroundImage = global::Automobile.Properties.Resources.pngwing1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(567, 386);
            this.Controls.Add(this.lb_fim);
            this.Controls.Add(this.lb_inicio);
            this.Controls.Add(this.lb_selecao_data);
            this.Controls.Add(this.btn_ok_datas);
            this.Controls.Add(this.dtp_fim);
            this.Controls.Add(this.dtp_inicio);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SelecaoData";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_inicio;
        private System.Windows.Forms.DateTimePicker dtp_fim;
        private System.Windows.Forms.Button btn_ok_datas;
        private System.Windows.Forms.Label lb_selecao_data;
        private System.Windows.Forms.Label lb_inicio;
        private System.Windows.Forms.Label lb_fim;
    }
}