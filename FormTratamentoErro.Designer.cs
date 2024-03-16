namespace Automobile
{
    partial class FormTratamentoErro
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
            this.dgv_erro = new System.Windows.Forms.DataGridView();
            this.lb_erro = new System.Windows.Forms.Label();
            this.tb_novo_valor = new System.Windows.Forms.TextBox();
            this.lb_novo_valor = new System.Windows.Forms.Label();
            this.btn_novo_valor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_erro)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_erro
            // 
            this.dgv_erro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_erro.Location = new System.Drawing.Point(75, 411);
            this.dgv_erro.Name = "dgv_erro";
            this.dgv_erro.RowHeadersWidth = 62;
            this.dgv_erro.RowTemplate.Height = 28;
            this.dgv_erro.Size = new System.Drawing.Size(782, 51);
            this.dgv_erro.TabIndex = 1;
            // 
            // lb_erro
            // 
            this.lb_erro.AutoSize = true;
            this.lb_erro.BackColor = System.Drawing.Color.Black;
            this.lb_erro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_erro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_erro.Location = new System.Drawing.Point(54, 73);
            this.lb_erro.Name = "lb_erro";
            this.lb_erro.Size = new System.Drawing.Size(65, 29);
            this.lb_erro.TabIndex = 2;
            this.lb_erro.Text = "????";
            this.lb_erro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_novo_valor
            // 
            this.tb_novo_valor.Location = new System.Drawing.Point(314, 493);
            this.tb_novo_valor.Name = "tb_novo_valor";
            this.tb_novo_valor.Size = new System.Drawing.Size(212, 26);
            this.tb_novo_valor.TabIndex = 3;
            this.tb_novo_valor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb_novo_valor.TextChanged += new System.EventHandler(this.Tb_novo_valor_TextChanged);
            // 
            // lb_novo_valor
            // 
            this.lb_novo_valor.AutoSize = true;
            this.lb_novo_valor.BackColor = System.Drawing.Color.Black;
            this.lb_novo_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_novo_valor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_novo_valor.Location = new System.Drawing.Point(166, 494);
            this.lb_novo_valor.Name = "lb_novo_valor";
            this.lb_novo_valor.Size = new System.Drawing.Size(129, 25);
            this.lb_novo_valor.TabIndex = 4;
            this.lb_novo_valor.Text = "New Value: ";
            // 
            // btn_novo_valor
            // 
            this.btn_novo_valor.BackColor = System.Drawing.Color.Black;
            this.btn_novo_valor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_novo_valor.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_novo_valor.Location = new System.Drawing.Point(626, 481);
            this.btn_novo_valor.Name = "btn_novo_valor";
            this.btn_novo_valor.Size = new System.Drawing.Size(110, 51);
            this.btn_novo_valor.TabIndex = 5;
            this.btn_novo_valor.Text = "Alterar";
            this.btn_novo_valor.UseVisualStyleBackColor = false;
            this.btn_novo_valor.Click += new System.EventHandler(this.Btn_novo_valor_Click);
            // 
            // FormTratamentoErro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::Automobile.Properties.Resources.pngwing_com__10_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(933, 583);
            this.Controls.Add(this.btn_novo_valor);
            this.Controls.Add(this.lb_novo_valor);
            this.Controls.Add(this.tb_novo_valor);
            this.Controls.Add(this.lb_erro);
            this.Controls.Add(this.dgv_erro);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTratamentoErro";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Tratamento Erro";
            this.Load += new System.EventHandler(this.FormTratamentoErro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_erro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_erro;
        private System.Windows.Forms.Label lb_erro;
        private System.Windows.Forms.TextBox tb_novo_valor;
        private System.Windows.Forms.Label lb_novo_valor;
        private System.Windows.Forms.Button btn_novo_valor;
    }
}