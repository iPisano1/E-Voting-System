namespace E_Voting_System
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.manageVote_Button = new System.Windows.Forms.Button();
            this.manageElections_Button = new System.Windows.Forms.Button();
            this.manageCandidates_Button = new System.Windows.Forms.Button();
            this.manageVote_Panel = new System.Windows.Forms.Panel();
            this.mainPanelDB = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.manageCandidates_Panel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.manageElections_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.manageVote_Panel.SuspendLayout();
            this.mainPanelDB.SuspendLayout();
            this.manageCandidates_Panel.SuspendLayout();
            this.manageElections_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adminBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logoutBtn);
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1493, 82);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::E_Voting_System.Properties.Resources.home_button;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(47, 21);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(46, 46);
            this.panel3.TabIndex = 3;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.Gold;
            this.adminBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminBtn.Location = new System.Drawing.Point(1137, 15);
            this.adminBtn.Margin = new System.Windows.Forms.Padding(4);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(166, 52);
            this.adminBtn.TabIndex = 2;
            this.adminBtn.Text = "Admin Mode";
            this.adminBtn.UseVisualStyleBackColor = false;
            this.adminBtn.Visible = false;
            this.adminBtn.Click += new System.EventHandler(this.adminBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(99, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.logoutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(1329, 15);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(119, 52);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // manageVote_Button
            // 
            this.manageVote_Button.BackColor = System.Drawing.Color.White;
            this.manageVote_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageVote_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.manageVote_Button.Location = new System.Drawing.Point(0, 0);
            this.manageVote_Button.Name = "manageVote_Button";
            this.manageVote_Button.Size = new System.Drawing.Size(422, 59);
            this.manageVote_Button.TabIndex = 3;
            this.manageVote_Button.Text = "Manage Voters";
            this.manageVote_Button.UseVisualStyleBackColor = false;
            this.manageVote_Button.Click += new System.EventHandler(this.manageVote_Button_Click);
            // 
            // manageElections_Button
            // 
            this.manageElections_Button.BackColor = System.Drawing.Color.White;
            this.manageElections_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageElections_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.manageElections_Button.Location = new System.Drawing.Point(979, 0);
            this.manageElections_Button.Name = "manageElections_Button";
            this.manageElections_Button.Size = new System.Drawing.Size(422, 59);
            this.manageElections_Button.TabIndex = 4;
            this.manageElections_Button.Text = "Manage Elections";
            this.manageElections_Button.UseVisualStyleBackColor = false;
            this.manageElections_Button.Click += new System.EventHandler(this.manageElections_Button_Click);
            // 
            // manageCandidates_Button
            // 
            this.manageCandidates_Button.BackColor = System.Drawing.Color.White;
            this.manageCandidates_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageCandidates_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.manageCandidates_Button.Location = new System.Drawing.Point(490, 0);
            this.manageCandidates_Button.Name = "manageCandidates_Button";
            this.manageCandidates_Button.Size = new System.Drawing.Size(422, 59);
            this.manageCandidates_Button.TabIndex = 5;
            this.manageCandidates_Button.Text = "Manage Candidates";
            this.manageCandidates_Button.UseVisualStyleBackColor = false;
            this.manageCandidates_Button.Click += new System.EventHandler(this.manageCandidates_Button_Click);
            // 
            // manageVote_Panel
            // 
            this.manageVote_Panel.BackColor = System.Drawing.Color.White;
            this.manageVote_Panel.Controls.Add(this.label2);
            this.manageVote_Panel.Location = new System.Drawing.Point(0, 65);
            this.manageVote_Panel.Name = "manageVote_Panel";
            this.manageVote_Panel.Size = new System.Drawing.Size(1401, 556);
            this.manageVote_Panel.TabIndex = 2;
            // 
            // mainPanelDB
            // 
            this.mainPanelDB.BackColor = System.Drawing.Color.Transparent;
            this.mainPanelDB.Controls.Add(this.manageElections_Button);
            this.mainPanelDB.Controls.Add(this.manageCandidates_Button);
            this.mainPanelDB.Controls.Add(this.manageVote_Button);
            this.mainPanelDB.Controls.Add(this.manageVote_Panel);
            this.mainPanelDB.Controls.Add(this.manageCandidates_Panel);
            this.mainPanelDB.Controls.Add(this.manageElections_Panel);
            this.mainPanelDB.ForeColor = System.Drawing.Color.Transparent;
            this.mainPanelDB.Location = new System.Drawing.Point(43, 127);
            this.mainPanelDB.Name = "mainPanelDB";
            this.mainPanelDB.Size = new System.Drawing.Size(1401, 621);
            this.mainPanelDB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(565, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Voters";
            // 
            // manageCandidates_Panel
            // 
            this.manageCandidates_Panel.BackColor = System.Drawing.Color.White;
            this.manageCandidates_Panel.Controls.Add(this.label3);
            this.manageCandidates_Panel.Location = new System.Drawing.Point(0, 65);
            this.manageCandidates_Panel.Name = "manageCandidates_Panel";
            this.manageCandidates_Panel.Size = new System.Drawing.Size(1401, 556);
            this.manageCandidates_Panel.TabIndex = 3;
            this.manageCandidates_Panel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(516, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(364, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Candidates";
            // 
            // manageElections_Panel
            // 
            this.manageElections_Panel.BackColor = System.Drawing.Color.White;
            this.manageElections_Panel.Controls.Add(this.label4);
            this.manageElections_Panel.Location = new System.Drawing.Point(0, 65);
            this.manageElections_Panel.Name = "manageElections_Panel";
            this.manageElections_Panel.Size = new System.Drawing.Size(1401, 556);
            this.manageElections_Panel.TabIndex = 3;
            this.manageElections_Panel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(536, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage Elections";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Voting_System.Properties.Resources._5594016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1487, 791);
            this.Controls.Add(this.mainPanelDB);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(40, 0, 40, 40);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMELEC E-Voting System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing_1);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.manageVote_Panel.ResumeLayout(false);
            this.manageVote_Panel.PerformLayout();
            this.mainPanelDB.ResumeLayout(false);
            this.manageCandidates_Panel.ResumeLayout(false);
            this.manageCandidates_Panel.PerformLayout();
            this.manageElections_Panel.ResumeLayout(false);
            this.manageElections_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button manageVote_Button;
        private System.Windows.Forms.Button manageElections_Button;
        private System.Windows.Forms.Button manageCandidates_Button;
        private System.Windows.Forms.Panel manageVote_Panel;
        private System.Windows.Forms.Panel mainPanelDB;
        private System.Windows.Forms.Panel manageCandidates_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel manageElections_Panel;
        private System.Windows.Forms.Label label4;
    }
}