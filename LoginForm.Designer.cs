namespace E_Voting_System
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginPanel = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.passText_Log = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.idText_Log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registerPanel = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.registerBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.passText_Reg = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.idText_Reg = new System.Windows.Forms.TextBox();
            this.loginForm_ExitBtn = new System.Windows.Forms.Button();
            this.loginPanel.SuspendLayout();
            this.registerPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.SystemColors.Control;
            this.loginPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.loginPanel.Controls.Add(this.linkLabel1);
            this.loginPanel.Controls.Add(this.label3);
            this.loginPanel.Controls.Add(this.loginBtn);
            this.loginPanel.Controls.Add(this.label5);
            this.loginPanel.Controls.Add(this.label4);
            this.loginPanel.Controls.Add(this.passText_Log);
            this.loginPanel.Controls.Add(this.panel2);
            this.loginPanel.Controls.Add(this.idText_Log);
            this.loginPanel.Location = new System.Drawing.Point(776, 112);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.loginPanel.Size = new System.Drawing.Size(363, 456);
            this.loginPanel.TabIndex = 0;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(211, 421);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(67, 20);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Register";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label3.Location = new System.Drawing.Point(79, 421);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Not Registered?";
            // 
            // loginBtn
            // 
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.loginBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.loginBtn.Location = new System.Drawing.Point(105, 375);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(4);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(157, 38);
            this.loginBtn.TabIndex = 8;
            this.loginBtn.Text = "Log In";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label4.Location = new System.Drawing.Point(12, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID Number";
            // 
            // passText_Log
            // 
            this.passText_Log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passText_Log.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passText_Log.Location = new System.Drawing.Point(17, 313);
            this.passText_Log.Margin = new System.Windows.Forms.Padding(4);
            this.passText_Log.Name = "passText_Log";
            this.passText_Log.PasswordChar = '*';
            this.passText_Log.Size = new System.Drawing.Size(323, 40);
            this.passText_Log.TabIndex = 5;
            this.passText_Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passText_Log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::E_Voting_System.Properties.Resources.login_icon_3048;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(88, 31);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(191, 155);
            this.panel2.TabIndex = 1;
            // 
            // idText_Log
            // 
            this.idText_Log.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.idText_Log.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText_Log.Location = new System.Drawing.Point(17, 230);
            this.idText_Log.Margin = new System.Windows.Forms.Padding(4);
            this.idText_Log.Name = "idText_Log";
            this.idText_Log.Size = new System.Drawing.Size(323, 40);
            this.idText_Log.TabIndex = 0;
            this.idText_Log.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idText_Log.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(240, 329);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 70);
            this.label1.TabIndex = 1;
            this.label1.Text = "COMELEC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label2.Location = new System.Drawing.Point(146, 399);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 70);
            this.label2.TabIndex = 2;
            this.label2.Text = "E-Voting System";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::E_Voting_System.Properties.Resources.Commission_on_Elections__COMELEC__svg;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.ForeColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(290, 133);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(208, 192);
            this.panel1.TabIndex = 3;
            // 
            // registerPanel
            // 
            this.registerPanel.BackColor = System.Drawing.SystemColors.Control;
            this.registerPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.registerPanel.Controls.Add(this.linkLabel2);
            this.registerPanel.Controls.Add(this.label6);
            this.registerPanel.Controls.Add(this.registerBtn);
            this.registerPanel.Controls.Add(this.label7);
            this.registerPanel.Controls.Add(this.label8);
            this.registerPanel.Controls.Add(this.passText_Reg);
            this.registerPanel.Controls.Add(this.panel4);
            this.registerPanel.Controls.Add(this.idText_Reg);
            this.registerPanel.Enabled = false;
            this.registerPanel.Location = new System.Drawing.Point(776, 112);
            this.registerPanel.Margin = new System.Windows.Forms.Padding(4);
            this.registerPanel.Name = "registerPanel";
            this.registerPanel.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
            this.registerPanel.Size = new System.Drawing.Size(363, 456);
            this.registerPanel.TabIndex = 11;
            this.registerPanel.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(236, 423);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(54, 20);
            this.linkLabel2.TabIndex = 10;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Log In";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label6.Location = new System.Drawing.Point(69, 423);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Already Registered?";
            // 
            // registerBtn
            // 
            this.registerBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerBtn.ForeColor = System.Drawing.SystemColors.MenuText;
            this.registerBtn.Location = new System.Drawing.Point(105, 375);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(4);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(157, 38);
            this.registerBtn.TabIndex = 8;
            this.registerBtn.Text = "Register";
            this.registerBtn.UseVisualStyleBackColor = true;
            this.registerBtn.Click += new System.EventHandler(this.registerBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label7.Location = new System.Drawing.Point(12, 283);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 23);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label8.Location = new System.Drawing.Point(12, 201);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 23);
            this.label8.TabIndex = 6;
            this.label8.Text = "ID Number";
            // 
            // passText_Reg
            // 
            this.passText_Reg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.passText_Reg.Font = new System.Drawing.Font("Calibri", 15.75F);
            this.passText_Reg.Location = new System.Drawing.Point(17, 313);
            this.passText_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.passText_Reg.Name = "passText_Reg";
            this.passText_Reg.PasswordChar = '*';
            this.passText_Reg.Size = new System.Drawing.Size(323, 40);
            this.passText_Reg.TabIndex = 5;
            this.passText_Reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passText_Reg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = global::E_Voting_System.Properties.Resources.login_icon_3048;
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.ForeColor = System.Drawing.Color.Gray;
            this.panel4.Location = new System.Drawing.Point(88, 31);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(191, 155);
            this.panel4.TabIndex = 1;
            // 
            // idText_Reg
            // 
            this.idText_Reg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.idText_Reg.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idText_Reg.Location = new System.Drawing.Point(17, 230);
            this.idText_Reg.Margin = new System.Windows.Forms.Padding(4);
            this.idText_Reg.Name = "idText_Reg";
            this.idText_Reg.Size = new System.Drawing.Size(323, 40);
            this.idText_Reg.TabIndex = 0;
            this.idText_Reg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.idText_Reg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnterKey_Event);
            // 
            // loginForm_ExitBtn
            // 
            this.loginForm_ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.loginForm_ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginForm_ExitBtn.FlatAppearance.BorderSize = 0;
            this.loginForm_ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginForm_ExitBtn.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginForm_ExitBtn.ForeColor = System.Drawing.Color.Black;
            this.loginForm_ExitBtn.Location = new System.Drawing.Point(1183, 1);
            this.loginForm_ExitBtn.Name = "loginForm_ExitBtn";
            this.loginForm_ExitBtn.Size = new System.Drawing.Size(52, 46);
            this.loginForm_ExitBtn.TabIndex = 12;
            this.loginForm_ExitBtn.Text = "X";
            this.loginForm_ExitBtn.UseVisualStyleBackColor = false;
            this.loginForm_ExitBtn.Click += new System.EventHandler(this.loginForm_ExitBtn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Voting_System.Properties.Resources._5594016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1236, 640);
            this.Controls.Add(this.loginForm_ExitBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginPanel);
            this.Controls.Add(this.registerPanel);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(93, 86, 93, 86);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMELEC E-Voting System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoginForm_FormClosing);
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.registerPanel.ResumeLayout(false);
            this.registerPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idText_Log;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox passText_Log;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel registerPanel;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox passText_Reg;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox idText_Reg;
        private System.Windows.Forms.Button loginForm_ExitBtn;
    }
}

