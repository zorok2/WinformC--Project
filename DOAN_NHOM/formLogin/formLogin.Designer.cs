﻿namespace formLogin
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb_SavePassword = new System.Windows.Forms.CheckBox();
            this.lbl_ErrorPass = new System.Windows.Forms.Label();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.cb_ShowPass = new System.Windows.Forms.CheckBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Account = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 465);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.AutoSize = true;
            this.panel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(990, 465);
            this.panel3.TabIndex = 26;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::formLogin.Properties.Resources.undraw_Coding_re_iv62__1_1;
            this.pictureBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox1.Location = new System.Drawing.Point(34, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 418);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Controls.Add(this.cb_SavePassword);
            this.panel2.Controls.Add(this.lbl_ErrorPass);
            this.panel2.Controls.Add(this.lbl_Error);
            this.panel2.Controls.Add(this.cb_ShowPass);
            this.panel2.Controls.Add(this.bt_Login);
            this.panel2.Controls.Add(this.txt_Password);
            this.panel2.Controls.Add(this.txt_Account);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(368, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(563, 391);
            this.panel2.TabIndex = 32;
            // 
            // cb_SavePassword
            // 
            this.cb_SavePassword.AutoSize = true;
            this.cb_SavePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cb_SavePassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_SavePassword.Location = new System.Drawing.Point(352, 216);
            this.cb_SavePassword.Name = "cb_SavePassword";
            this.cb_SavePassword.Size = new System.Drawing.Size(130, 24);
            this.cb_SavePassword.TabIndex = 36;
            this.cb_SavePassword.Text = "Lưu đăng nhập";
            this.cb_SavePassword.UseVisualStyleBackColor = true;
            this.cb_SavePassword.CheckedChanged += new System.EventHandler(this.cb_SavePassword_CheckedChanged);
            // 
            // lbl_ErrorPass
            // 
            this.lbl_ErrorPass.AutoSize = true;
            this.lbl_ErrorPass.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_ErrorPass.ForeColor = System.Drawing.Color.Red;
            this.lbl_ErrorPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_ErrorPass.Location = new System.Drawing.Point(57, 195);
            this.lbl_ErrorPass.Name = "lbl_ErrorPass";
            this.lbl_ErrorPass.Size = new System.Drawing.Size(0, 19);
            this.lbl_ErrorPass.TabIndex = 32;
            this.lbl_ErrorPass.Visible = false;
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbl_Error.Location = new System.Drawing.Point(57, 134);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(0, 19);
            this.lbl_Error.TabIndex = 35;
            this.lbl_Error.Visible = false;
            // 
            // cb_ShowPass
            // 
            this.cb_ShowPass.AutoSize = true;
            this.cb_ShowPass.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.cb_ShowPass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_ShowPass.Location = new System.Drawing.Point(61, 217);
            this.cb_ShowPass.Name = "cb_ShowPass";
            this.cb_ShowPass.Size = new System.Drawing.Size(141, 23);
            this.cb_ShowPass.TabIndex = 32;
            this.cb_ShowPass.Text = "Hiển thị mật khẩu";
            this.cb_ShowPass.UseVisualStyleBackColor = true;
            this.cb_ShowPass.CheckedChanged += new System.EventHandler(this.cbShowPass_CheckedChanged);
            // 
            // bt_Login
            // 
            this.bt_Login.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bt_Login.AutoSize = true;
            this.bt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(198)))), ((int)(((byte)(255)))));
            this.bt_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bt_Login.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Login.FlatAppearance.BorderSize = 0;
            this.bt_Login.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bt_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSkyBlue;
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.bt_Login.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.bt_Login.Location = new System.Drawing.Point(61, 256);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Padding = new System.Windows.Forms.Padding(5);
            this.bt_Login.Size = new System.Drawing.Size(421, 45);
            this.bt_Login.TabIndex = 30;
            this.bt_Login.Text = "ĐĂNG NHẬP";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // txt_Password
            // 
            this.txt_Password.AcceptsTab = true;
            this.txt_Password.BackColor = System.Drawing.Color.White;
            this.txt_Password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Password.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_Password.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Password.Location = new System.Drawing.Point(61, 161);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.PasswordChar = '*';
            this.txt_Password.Size = new System.Drawing.Size(421, 31);
            this.txt_Password.TabIndex = 29;
            this.txt_Password.TabStop = false;
            this.txt_Password.Text = "Mật khẩu";
            this.txt_Password.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbpassword_MouseClick);
            // 
            // txt_Account
            // 
            this.txt_Account.BackColor = System.Drawing.Color.White;
            this.txt_Account.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Account.CausesValidation = false;
            this.txt_Account.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txt_Account.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_Account.Location = new System.Drawing.Point(61, 101);
            this.txt_Account.Name = "txt_Account";
            this.txt_Account.Size = new System.Drawing.Size(421, 31);
            this.txt_Account.TabIndex = 28;
            this.txt_Account.TabStop = false;
            this.txt_Account.Text = "Tài khoản";
            this.txt_Account.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbAccount_MouseClick);
            this.txt_Account.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbAccount_KeyDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.Image = global::formLogin.Properties.Resources.slack__1_;
            this.pictureBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.pictureBox3.Location = new System.Drawing.Point(50, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(390, 61);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 34;
            this.pictureBox3.TabStop = false;
            // 
            // FormLogin
            // 
            this.AcceptButton = this.bt_Login;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(990, 465);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.formLogin_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lbl_ErrorPass;
        private System.Windows.Forms.Label lbl_Error;
        private System.Windows.Forms.CheckBox cb_ShowPass;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Account;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox cb_SavePassword;
    }
}

