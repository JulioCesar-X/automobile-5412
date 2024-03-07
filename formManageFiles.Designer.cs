namespace Automobile
{
    partial class FormManageFiles
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
            this.btn_open_file_explorer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_file_location = new System.Windows.Forms.TextBox();
            this.btn_export = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_import = new System.Windows.Forms.Button();
            this.textBox_file_location_import = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_open_import = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_open_file_explorer
            // 
            this.btn_open_file_explorer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_file_explorer.Location = new System.Drawing.Point(516, 84);
            this.btn_open_file_explorer.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_open_file_explorer.Name = "btn_open_file_explorer";
            this.btn_open_file_explorer.Size = new System.Drawing.Size(58, 23);
            this.btn_open_file_explorer.TabIndex = 0;
            this.btn_open_file_explorer.Text = "Open";
            this.btn_open_file_explorer.UseVisualStyleBackColor = true;
            this.btn_open_file_explorer.Click += new System.EventHandler(this.Btn_open_file_explorer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 91);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "File Location:";
            // 
            // textBox_file_location
            // 
            this.textBox_file_location.Location = new System.Drawing.Point(287, 86);
            this.textBox_file_location.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_file_location.Name = "textBox_file_location";
            this.textBox_file_location.Size = new System.Drawing.Size(215, 20);
            this.textBox_file_location.TabIndex = 2;
            // 
            // btn_export
            // 
            this.btn_export.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_export.Location = new System.Drawing.Point(361, 129);
            this.btn_export.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_export.Name = "btn_export";
            this.btn_export.Size = new System.Drawing.Size(63, 23);
            this.btn_export.TabIndex = 4;
            this.btn_export.Text = "Export";
            this.btn_export.UseVisualStyleBackColor = true;
            this.btn_export.Click += new System.EventHandler(this.Btn_export_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(0, 198);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(808, 58);
            this.panel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(302, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "Import Information";
            // 
            // btn_import
            // 
            this.btn_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_import.Location = new System.Drawing.Point(366, 344);
            this.btn_import.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_import.Name = "btn_import";
            this.btn_import.Size = new System.Drawing.Size(63, 23);
            this.btn_import.TabIndex = 9;
            this.btn_import.Text = "Import";
            this.btn_import.UseVisualStyleBackColor = true;
            this.btn_import.Click += new System.EventHandler(this.Btn_import_Click);
            // 
            // textBox_file_location_import
            // 
            this.textBox_file_location_import.Location = new System.Drawing.Point(293, 302);
            this.textBox_file_location_import.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textBox_file_location_import.Name = "textBox_file_location_import";
            this.textBox_file_location_import.Size = new System.Drawing.Size(215, 20);
            this.textBox_file_location_import.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(190, 306);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "File Location:";
            // 
            // btn_open_import
            // 
            this.btn_open_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_open_import.Location = new System.Drawing.Point(521, 299);
            this.btn_open_import.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_open_import.Name = "btn_open_import";
            this.btn_open_import.Size = new System.Drawing.Size(58, 23);
            this.btn_open_import.TabIndex = 6;
            this.btn_open_import.Text = "Open";
            this.btn_open_import.UseVisualStyleBackColor = true;
            this.btn_open_import.Click += new System.EventHandler(this.Btn_open_import_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 58);
            this.panel1.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(302, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Export Information";
            // 
            // FormManageFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_import);
            this.Controls.Add(this.textBox_file_location_import);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_open_import);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_export);
            this.Controls.Add(this.textBox_file_location);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_open_file_explorer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormManageFiles";
            this.Text = "FormManageFiles";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_open_file_explorer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_file_location;
        private System.Windows.Forms.Button btn_export;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_import;
        private System.Windows.Forms.TextBox textBox_file_location_import;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_open_import;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
    }
}