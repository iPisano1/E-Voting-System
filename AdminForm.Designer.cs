namespace E_Voting_System
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.candidatesBtn = new System.Windows.Forms.Button();
            this.electionBtn = new System.Windows.Forms.Button();
            this.positionBtn = new System.Windows.Forms.Button();
            this.usersBtn = new System.Windows.Forms.Button();
            this.votersBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.votersBtn);
            this.panel1.Controls.Add(this.usersBtn);
            this.panel1.Controls.Add(this.positionBtn);
            this.panel1.Controls.Add(this.electionBtn);
            this.panel1.Controls.Add(this.candidatesBtn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1312, 81);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(84, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Admin Mode";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BackgroundImage = global::E_Voting_System.Properties.Resources.login_icon_3048;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.ForeColor = System.Drawing.Color.Gray;
            this.panel2.Location = new System.Drawing.Point(21, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65, 54);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(29, 104);
            this.panel3.Margin = new System.Windows.Forms.Padding(20);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 700);
            this.panel3.TabIndex = 1;
            // 
            // candidatesBtn
            // 
            this.candidatesBtn.BackColor = System.Drawing.Color.Transparent;
            this.candidatesBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.candidatesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.candidatesBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatesBtn.Location = new System.Drawing.Point(326, 0);
            this.candidatesBtn.Name = "candidatesBtn";
            this.candidatesBtn.Size = new System.Drawing.Size(144, 82);
            this.candidatesBtn.TabIndex = 0;
            this.candidatesBtn.Text = "Candidates";
            this.candidatesBtn.UseVisualStyleBackColor = false;
            // 
            // electionBtn
            // 
            this.electionBtn.BackColor = System.Drawing.Color.Transparent;
            this.electionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.electionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.electionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.electionBtn.Location = new System.Drawing.Point(476, 0);
            this.electionBtn.Name = "electionBtn";
            this.electionBtn.Size = new System.Drawing.Size(144, 82);
            this.electionBtn.TabIndex = 7;
            this.electionBtn.Text = "Election";
            this.electionBtn.UseVisualStyleBackColor = false;
            // 
            // positionBtn
            // 
            this.positionBtn.BackColor = System.Drawing.Color.Transparent;
            this.positionBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.positionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.positionBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionBtn.Location = new System.Drawing.Point(626, 0);
            this.positionBtn.Name = "positionBtn";
            this.positionBtn.Size = new System.Drawing.Size(144, 82);
            this.positionBtn.TabIndex = 8;
            this.positionBtn.Text = "Position";
            this.positionBtn.UseVisualStyleBackColor = false;
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.Transparent;
            this.usersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.Location = new System.Drawing.Point(926, 0);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(144, 82);
            this.usersBtn.TabIndex = 9;
            this.usersBtn.Text = "Users";
            this.usersBtn.UseVisualStyleBackColor = false;
            // 
            // votersBtn
            // 
            this.votersBtn.BackColor = System.Drawing.Color.Transparent;
            this.votersBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.votersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.votersBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votersBtn.Location = new System.Drawing.Point(776, 0);
            this.votersBtn.Name = "votersBtn";
            this.votersBtn.Size = new System.Drawing.Size(144, 82);
            this.votersBtn.TabIndex = 10;
            this.votersBtn.Text = "Voters";
            this.votersBtn.UseVisualStyleBackColor = false;
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(1177, 22);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 41);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Voting_System.Properties.Resources._5594016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1308, 833);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMELEC Admin Mode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminForm_FormClosed);
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button positionBtn;
        private System.Windows.Forms.Button electionBtn;
        private System.Windows.Forms.Button candidatesBtn;
        private System.Windows.Forms.Button votersBtn;
        private System.Windows.Forms.Button backBtn;
    }
}