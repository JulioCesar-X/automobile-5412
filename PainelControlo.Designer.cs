namespace Automobile
{
    partial class FormPainelControlo
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
            this.components = new System.ComponentModel.Container();
            this.panel_system_control = new System.Windows.Forms.Panel();
            this.panel_user = new System.Windows.Forms.Panel();
            this.btn_change_account = new System.Windows.Forms.Button();
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_back_begin = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lb_date = new System.Windows.Forms.Label();
            this.lb_date_time = new System.Windows.Forms.Label();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.btn_manage_users = new System.Windows.Forms.Button();
            this.btn_veichle = new System.Windows.Forms.Button();
            this.btn_change_veichle_status = new System.Windows.Forms.Button();
            this.btn_veichles_available = new System.Windows.Forms.Button();
            this.btn_vehicle_aintenance = new System.Windows.Forms.Button();
            this.btn_manage_reservations = new System.Windows.Forms.Button();
            this.btn_manage_files = new System.Windows.Forms.Button();
            this.lb_goodjob = new System.Windows.Forms.Label();
            this.lb_user_logado = new System.Windows.Forms.Label();
            this.pb_user_image = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel_system_control.SuspendLayout();
            this.panel_user.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user_image)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_system_control
            // 
            this.panel_system_control.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_system_control.Controls.Add(this.panel_user);
            this.panel_system_control.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_system_control.Location = new System.Drawing.Point(0, 0);
            this.panel_system_control.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_system_control.Name = "panel_system_control";
            this.panel_system_control.Size = new System.Drawing.Size(1385, 762);
            this.panel_system_control.TabIndex = 0;
            // 
            // panel_user
            // 
            this.panel_user.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel_user.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_user.Controls.Add(this.btn_change_account);
            this.panel_user.Controls.Add(this.lb_title);
            this.panel_user.Controls.Add(this.btn_back_begin);
            this.panel_user.Controls.Add(this.btn_exit);
            this.panel_user.Controls.Add(this.lb_date);
            this.panel_user.Controls.Add(this.lb_date_time);
            this.panel_user.Controls.Add(this.PnlFormLoader);
            this.panel_user.Controls.Add(this.btn_manage_users);
            this.panel_user.Controls.Add(this.btn_veichle);
            this.panel_user.Controls.Add(this.btn_change_veichle_status);
            this.panel_user.Controls.Add(this.btn_veichles_available);
            this.panel_user.Controls.Add(this.btn_vehicle_aintenance);
            this.panel_user.Controls.Add(this.btn_manage_reservations);
            this.panel_user.Controls.Add(this.btn_manage_files);
            this.panel_user.Controls.Add(this.lb_goodjob);
            this.panel_user.Controls.Add(this.lb_user_logado);
            this.panel_user.Controls.Add(this.pb_user_image);
            this.panel_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_user.Location = new System.Drawing.Point(0, 0);
            this.panel_user.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel_user.Name = "panel_user";
            this.panel_user.Size = new System.Drawing.Size(1385, 772);
            this.panel_user.TabIndex = 0;
            // 
            // btn_change_account
            // 
            this.btn_change_account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_change_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_change_account.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_change_account.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_account.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_account.ForeColor = System.Drawing.Color.White;
            this.btn_change_account.Location = new System.Drawing.Point(477, 718);
            this.btn_change_account.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_change_account.Name = "btn_change_account";
            this.btn_change_account.Size = new System.Drawing.Size(155, 34);
            this.btn_change_account.TabIndex = 9;
            this.btn_change_account.Text = "Switch Account";
            this.btn_change_account.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_change_account.UseVisualStyleBackColor = false;
            this.btn_change_account.Click += new System.EventHandler(this.BtnChangeAccount_Click);
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.BackColor = System.Drawing.Color.Transparent;
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_title.Location = new System.Drawing.Point(269, 54);
            this.lb_title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(434, 69);
            this.lb_title.TabIndex = 3;
            this.lb_title.Text = "AUTOMOBILE";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_back_begin
            // 
            this.btn_back_begin.BackColor = System.Drawing.Color.Gray;
            this.btn_back_begin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back_begin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_back_begin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back_begin.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back_begin.ForeColor = System.Drawing.Color.White;
            this.btn_back_begin.Location = new System.Drawing.Point(745, 718);
            this.btn_back_begin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_back_begin.Name = "btn_back_begin";
            this.btn_back_begin.Size = new System.Drawing.Size(93, 34);
            this.btn_back_begin.TabIndex = 7;
            this.btn_back_begin.Text = "Refresh";
            this.btn_back_begin.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_back_begin.UseVisualStyleBackColor = false;
            this.btn_back_begin.Click += new System.EventHandler(this.Btn_back_begin_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Red;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Location = new System.Drawing.Point(969, 718);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(117, 34);
            this.btn_exit.TabIndex = 7;
            this.btn_exit.Text = "Power Off";
            this.btn_exit.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.Button7_Click);
            // 
            // lb_date
            // 
            this.lb_date.AutoSize = true;
            this.lb_date.BackColor = System.Drawing.Color.Transparent;
            this.lb_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_date.Location = new System.Drawing.Point(1139, 17);
            this.lb_date.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_date.Name = "lb_date";
            this.lb_date.Size = new System.Drawing.Size(196, 24);
            this.lb_date.TabIndex = 4;
            this.lb_date.Text = "01/02/1990 - domingo ";
            // 
            // lb_date_time
            // 
            this.lb_date_time.AutoSize = true;
            this.lb_date_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_date_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_date_time.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_date_time.Location = new System.Drawing.Point(1256, 52);
            this.lb_date_time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_date_time.Name = "lb_date_time";
            this.lb_date_time.Size = new System.Drawing.Size(80, 24);
            this.lb_date_time.TabIndex = 4;
            this.lb_date_time.Text = "00:00:00";
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.BackColor = System.Drawing.Color.Gainsboro;
            this.PnlFormLoader.BackgroundImage = global::Automobile.Properties.Resources.pngwing_com__10_;
            this.PnlFormLoader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PnlFormLoader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PnlFormLoader.Location = new System.Drawing.Point(260, 149);
            this.PnlFormLoader.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(1077, 550);
            this.PnlFormLoader.TabIndex = 2;
            // 
            // btn_manage_users
            // 
            this.btn_manage_users.BackColor = System.Drawing.Color.Transparent;
            this.btn_manage_users.Enabled = false;
            this.btn_manage_users.FlatAppearance.BorderSize = 0;
            this.btn_manage_users.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_users.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_users.ForeColor = System.Drawing.Color.White;
            this.btn_manage_users.Location = new System.Drawing.Point(47, 628);
            this.btn_manage_users.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_manage_users.Name = "btn_manage_users";
            this.btn_manage_users.Size = new System.Drawing.Size(163, 58);
            this.btn_manage_users.TabIndex = 8;
            this.btn_manage_users.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_manage_users.UseVisualStyleBackColor = false;
            this.btn_manage_users.Click += new System.EventHandler(this.Btn_manage_users_Click);
            // 
            // btn_veichle
            // 
            this.btn_veichle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_veichle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_veichle.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_veichle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veichle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veichle.ForeColor = System.Drawing.Color.White;
            this.btn_veichle.Location = new System.Drawing.Point(47, 162);
            this.btn_veichle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_veichle.Name = "btn_veichle";
            this.btn_veichle.Size = new System.Drawing.Size(163, 58);
            this.btn_veichle.TabIndex = 1;
            this.btn_veichle.Text = "Add Veichle";
            this.btn_veichle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_veichle.UseVisualStyleBackColor = false;
            this.btn_veichle.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_change_veichle_status
            // 
            this.btn_change_veichle_status.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_change_veichle_status.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_change_veichle_status.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_change_veichle_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_change_veichle_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_change_veichle_status.ForeColor = System.Drawing.Color.White;
            this.btn_change_veichle_status.Location = new System.Drawing.Point(47, 239);
            this.btn_change_veichle_status.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_change_veichle_status.Name = "btn_change_veichle_status";
            this.btn_change_veichle_status.Size = new System.Drawing.Size(163, 58);
            this.btn_change_veichle_status.TabIndex = 2;
            this.btn_change_veichle_status.Text = "List of Vehicles";
            this.btn_change_veichle_status.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_change_veichle_status.UseVisualStyleBackColor = false;
            this.btn_change_veichle_status.Click += new System.EventHandler(this.Button2_Click);
            // 
            // btn_veichles_available
            // 
            this.btn_veichles_available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_veichles_available.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_veichles_available.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_veichles_available.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_veichles_available.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_veichles_available.ForeColor = System.Drawing.Color.White;
            this.btn_veichles_available.Location = new System.Drawing.Point(47, 316);
            this.btn_veichles_available.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_veichles_available.Name = "btn_veichles_available";
            this.btn_veichles_available.Size = new System.Drawing.Size(163, 58);
            this.btn_veichles_available.TabIndex = 3;
            this.btn_veichles_available.Text = "Rent a vehicle";
            this.btn_veichles_available.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_veichles_available.UseVisualStyleBackColor = false;
            this.btn_veichles_available.Click += new System.EventHandler(this.Button3_Click);
            // 
            // btn_vehicle_aintenance
            // 
            this.btn_vehicle_aintenance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_vehicle_aintenance.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_vehicle_aintenance.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_vehicle_aintenance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_vehicle_aintenance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vehicle_aintenance.ForeColor = System.Drawing.Color.White;
            this.btn_vehicle_aintenance.Location = new System.Drawing.Point(47, 394);
            this.btn_vehicle_aintenance.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_vehicle_aintenance.Name = "btn_vehicle_aintenance";
            this.btn_vehicle_aintenance.Size = new System.Drawing.Size(163, 58);
            this.btn_vehicle_aintenance.TabIndex = 4;
            this.btn_vehicle_aintenance.Text = "Time Simulation Billing";
            this.btn_vehicle_aintenance.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_vehicle_aintenance.UseVisualStyleBackColor = false;
            this.btn_vehicle_aintenance.Click += new System.EventHandler(this.BtnVehicleMaintenance_Click);
            // 
            // btn_manage_reservations
            // 
            this.btn_manage_reservations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_manage_reservations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_manage_reservations.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_manage_reservations.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_reservations.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_reservations.ForeColor = System.Drawing.Color.White;
            this.btn_manage_reservations.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_manage_reservations.Location = new System.Drawing.Point(47, 473);
            this.btn_manage_reservations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_manage_reservations.Name = "btn_manage_reservations";
            this.btn_manage_reservations.Size = new System.Drawing.Size(163, 58);
            this.btn_manage_reservations.TabIndex = 5;
            this.btn_manage_reservations.Text = "Manage Reservations";
            this.btn_manage_reservations.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_manage_reservations.UseVisualStyleBackColor = false;
            this.btn_manage_reservations.Click += new System.EventHandler(this.BtnManageReservations_Click);
            // 
            // btn_manage_files
            // 
            this.btn_manage_files.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_manage_files.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_manage_files.FlatAppearance.BorderColor = System.Drawing.Color.GhostWhite;
            this.btn_manage_files.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_manage_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_manage_files.ForeColor = System.Drawing.Color.White;
            this.btn_manage_files.Location = new System.Drawing.Point(47, 551);
            this.btn_manage_files.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_manage_files.Name = "btn_manage_files";
            this.btn_manage_files.Size = new System.Drawing.Size(163, 58);
            this.btn_manage_files.TabIndex = 6;
            this.btn_manage_files.Text = "Manage Files";
            this.btn_manage_files.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_manage_files.UseVisualStyleBackColor = false;
            this.btn_manage_files.Click += new System.EventHandler(this.BtnManageFiles_Click);
            // 
            // lb_goodjob
            // 
            this.lb_goodjob.AutoSize = true;
            this.lb_goodjob.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_goodjob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(178)))));
            this.lb_goodjob.Location = new System.Drawing.Point(71, 97);
            this.lb_goodjob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_goodjob.Name = "lb_goodjob";
            this.lb_goodjob.Size = new System.Drawing.Size(111, 15);
            this.lb_goodjob.TabIndex = 2;
            this.lb_goodjob.Text = "Have a good job";
            this.lb_goodjob.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_user_logado
            // 
            this.lb_user_logado.AutoSize = true;
            this.lb_user_logado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_user_logado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lb_user_logado.Location = new System.Drawing.Point(77, 119);
            this.lb_user_logado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_user_logado.Name = "lb_user_logado";
            this.lb_user_logado.Size = new System.Drawing.Size(103, 20);
            this.lb_user_logado.TabIndex = 1;
            this.lb_user_logado.Text = "User Name";
            this.lb_user_logado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_user_image
            // 
            this.pb_user_image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pb_user_image.Image = global::Automobile.Properties.Resources.pngwing_com__13_;
            this.pb_user_image.Location = new System.Drawing.Point(89, 23);
            this.pb_user_image.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_user_image.Name = "pb_user_image";
            this.pb_user_image.Size = new System.Drawing.Size(83, 70);
            this.pb_user_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_user_image.TabIndex = 0;
            this.pb_user_image.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.panel3.Location = new System.Drawing.Point(0, 278);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(4, 123);
            this.panel3.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormPainelControlo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1369, 762);
            this.Controls.Add(this.panel_system_control);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPainelControlo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PainelControlo";
            this.panel_system_control.ResumeLayout(false);
            this.panel_user.ResumeLayout(false);
            this.panel_user.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_user_image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_system_control;
        private System.Windows.Forms.Panel panel_user;
        private System.Windows.Forms.Label lb_user_logado;
        private System.Windows.Forms.PictureBox pb_user_image;
        private System.Windows.Forms.Button btn_veichle;
        private System.Windows.Forms.Label lb_goodjob;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_manage_files;
        private System.Windows.Forms.Button btn_manage_reservations;
        private System.Windows.Forms.Button btn_vehicle_aintenance;
        private System.Windows.Forms.Button btn_veichles_available;
        private System.Windows.Forms.Button btn_change_veichle_status;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_manage_users;
        private System.Windows.Forms.Button btn_change_account;
        private System.Windows.Forms.Label lb_date_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lb_date;
        private System.Windows.Forms.Button btn_back_begin;
    }
}