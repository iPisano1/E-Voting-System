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
            this.addVoter_Button = new System.Windows.Forms.Button();
            this.manageElections_Button = new System.Windows.Forms.Button();
            this.addCandidates_Button = new System.Windows.Forms.Button();
            this.addVoter_Panel = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.voters_Candidate_Box = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.voters_VotePosition_Box = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.voters_PhoneNumber_Field = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.voters_Email_Field = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.voters_LastName_Field = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.voters_FirstName_Field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanelDB = new System.Windows.Forms.Panel();
            this.addCandidates_Panel = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.candidate_Position_Box = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.candidate_BirthDate_Field = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.candidate_PhoneNumber_Field = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.candidate_Email_Field = new System.Windows.Forms.TextBox();
            this.candidate_RadioOthers_Button = new System.Windows.Forms.RadioButton();
            this.candidate_RadioFemale_Button = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.candidate_RadioMale_Button = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.candidate_LastName_Field = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.candidate_FirstName_Field = new System.Windows.Forms.TextBox();
            this.addCandidate_Button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.manageElections_Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.addVoter_Panel.SuspendLayout();
            this.mainPanelDB.SuspendLayout();
            this.addCandidates_Panel.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 67);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = global::E_Voting_System.Properties.Resources.home_button;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(35, 17);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(34, 37);
            this.panel3.TabIndex = 3;
            // 
            // adminBtn
            // 
            this.adminBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(30)))));
            this.adminBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(185)))), ((int)(((byte)(30)))));
            this.adminBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.adminBtn.Location = new System.Drawing.Point(853, 12);
            this.adminBtn.Name = "adminBtn";
            this.adminBtn.Size = new System.Drawing.Size(124, 42);
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
            this.label1.Location = new System.Drawing.Point(74, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dashboard";
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.logoutBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(59)))), ((int)(((byte)(59)))));
            this.logoutBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.Location = new System.Drawing.Point(997, 12);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(89, 42);
            this.logoutBtn.TabIndex = 0;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // addVoter_Button
            // 
            this.addVoter_Button.BackColor = System.Drawing.Color.White;
            this.addVoter_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVoter_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addVoter_Button.Location = new System.Drawing.Point(0, 0);
            this.addVoter_Button.Margin = new System.Windows.Forms.Padding(2);
            this.addVoter_Button.Name = "addVoter_Button";
            this.addVoter_Button.Size = new System.Drawing.Size(316, 48);
            this.addVoter_Button.TabIndex = 3;
            this.addVoter_Button.Text = "Add New Voter";
            this.addVoter_Button.UseVisualStyleBackColor = false;
            this.addVoter_Button.Click += new System.EventHandler(this.addVoter_Button_Click);
            // 
            // manageElections_Button
            // 
            this.manageElections_Button.BackColor = System.Drawing.Color.White;
            this.manageElections_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageElections_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.manageElections_Button.Location = new System.Drawing.Point(734, 0);
            this.manageElections_Button.Margin = new System.Windows.Forms.Padding(2);
            this.manageElections_Button.Name = "manageElections_Button";
            this.manageElections_Button.Size = new System.Drawing.Size(316, 48);
            this.manageElections_Button.TabIndex = 4;
            this.manageElections_Button.Text = "Manage Elections";
            this.manageElections_Button.UseVisualStyleBackColor = false;
            this.manageElections_Button.Visible = false;
            this.manageElections_Button.Click += new System.EventHandler(this.manageElections_Button_Click);
            // 
            // addCandidates_Button
            // 
            this.addCandidates_Button.BackColor = System.Drawing.Color.White;
            this.addCandidates_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCandidates_Button.ForeColor = System.Drawing.SystemColors.MenuText;
            this.addCandidates_Button.Location = new System.Drawing.Point(320, 0);
            this.addCandidates_Button.Margin = new System.Windows.Forms.Padding(2);
            this.addCandidates_Button.Name = "addCandidates_Button";
            this.addCandidates_Button.Size = new System.Drawing.Size(316, 48);
            this.addCandidates_Button.TabIndex = 5;
            this.addCandidates_Button.Text = "Add New Candidate";
            this.addCandidates_Button.UseVisualStyleBackColor = false;
            this.addCandidates_Button.Click += new System.EventHandler(this.addCandidates_Button_Click);
            // 
            // addVoter_Panel
            // 
            this.addVoter_Panel.BackColor = System.Drawing.Color.White;
            this.addVoter_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addVoter_Panel.Controls.Add(this.label16);
            this.addVoter_Panel.Controls.Add(this.voters_Candidate_Box);
            this.addVoter_Panel.Controls.Add(this.label15);
            this.addVoter_Panel.Controls.Add(this.voters_VotePosition_Box);
            this.addVoter_Panel.Controls.Add(this.button1);
            this.addVoter_Panel.Controls.Add(this.label14);
            this.addVoter_Panel.Controls.Add(this.voters_PhoneNumber_Field);
            this.addVoter_Panel.Controls.Add(this.label13);
            this.addVoter_Panel.Controls.Add(this.voters_Email_Field);
            this.addVoter_Panel.Controls.Add(this.label12);
            this.addVoter_Panel.Controls.Add(this.voters_LastName_Field);
            this.addVoter_Panel.Controls.Add(this.label11);
            this.addVoter_Panel.Controls.Add(this.voters_FirstName_Field);
            this.addVoter_Panel.Controls.Add(this.label2);
            this.addVoter_Panel.Location = new System.Drawing.Point(0, 45);
            this.addVoter_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.addVoter_Panel.Name = "addVoter_Panel";
            this.addVoter_Panel.Padding = new System.Windows.Forms.Padding(30);
            this.addVoter_Panel.Size = new System.Drawing.Size(1051, 460);
            this.addVoter_Panel.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(745, 207);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(88, 21);
            this.label16.TabIndex = 16;
            this.label16.Text = "Candidate";
            // 
            // voters_Candidate_Box
            // 
            this.voters_Candidate_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voters_Candidate_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_Candidate_Box.FormattingEnabled = true;
            this.voters_Candidate_Box.Location = new System.Drawing.Point(749, 231);
            this.voters_Candidate_Box.Name = "voters_Candidate_Box";
            this.voters_Candidate_Box.Size = new System.Drawing.Size(267, 33);
            this.voters_Candidate_Box.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(745, 132);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 21);
            this.label15.TabIndex = 14;
            this.label15.Text = "Vote Position";
            // 
            // voters_VotePosition_Box
            // 
            this.voters_VotePosition_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.voters_VotePosition_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_VotePosition_Box.FormattingEnabled = true;
            this.voters_VotePosition_Box.Location = new System.Drawing.Point(749, 156);
            this.voters_VotePosition_Box.Name = "voters_VotePosition_Box";
            this.voters_VotePosition_Box.Size = new System.Drawing.Size(267, 33);
            this.voters_VotePosition_Box.TabIndex = 13;
            this.voters_VotePosition_Box.SelectedIndexChanged += new System.EventHandler(this.voters_VotePosition_Box_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(455, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(395, 207);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(126, 21);
            this.label14.TabIndex = 11;
            this.label14.Text = "Phone Number";
            // 
            // voters_PhoneNumber_Field
            // 
            this.voters_PhoneNumber_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_PhoneNumber_Field.Location = new System.Drawing.Point(399, 231);
            this.voters_PhoneNumber_Field.Name = "voters_PhoneNumber_Field";
            this.voters_PhoneNumber_Field.Size = new System.Drawing.Size(310, 33);
            this.voters_PhoneNumber_Field.TabIndex = 10;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(395, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 21);
            this.label13.TabIndex = 9;
            this.label13.Text = "Email";
            // 
            // voters_Email_Field
            // 
            this.voters_Email_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_Email_Field.Location = new System.Drawing.Point(399, 156);
            this.voters_Email_Field.Name = "voters_Email_Field";
            this.voters_Email_Field.Size = new System.Drawing.Size(310, 33);
            this.voters_Email_Field.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(41, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 21);
            this.label12.TabIndex = 7;
            this.label12.Text = "Last Name";
            // 
            // voters_LastName_Field
            // 
            this.voters_LastName_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_LastName_Field.Location = new System.Drawing.Point(45, 231);
            this.voters_LastName_Field.Name = "voters_LastName_Field";
            this.voters_LastName_Field.Size = new System.Drawing.Size(310, 33);
            this.voters_LastName_Field.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(41, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(92, 21);
            this.label11.TabIndex = 5;
            this.label11.Text = "First Name";
            // 
            // voters_FirstName_Field
            // 
            this.voters_FirstName_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voters_FirstName_Field.Location = new System.Drawing.Point(45, 156);
            this.voters_FirstName_Field.Name = "voters_FirstName_Field";
            this.voters_FirstName_Field.Size = new System.Drawing.Size(310, 33);
            this.voters_FirstName_Field.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(439, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Voter";
            // 
            // mainPanelDB
            // 
            this.mainPanelDB.BackColor = System.Drawing.Color.Transparent;
            this.mainPanelDB.Controls.Add(this.manageElections_Panel);
            this.mainPanelDB.Controls.Add(this.addVoter_Panel);
            this.mainPanelDB.Controls.Add(this.addCandidates_Panel);
            this.mainPanelDB.Controls.Add(this.addVoter_Button);
            this.mainPanelDB.Controls.Add(this.addCandidates_Button);
            this.mainPanelDB.Controls.Add(this.manageElections_Button);
            this.mainPanelDB.ForeColor = System.Drawing.Color.Transparent;
            this.mainPanelDB.Location = new System.Drawing.Point(32, 103);
            this.mainPanelDB.Margin = new System.Windows.Forms.Padding(2);
            this.mainPanelDB.Name = "mainPanelDB";
            this.mainPanelDB.Size = new System.Drawing.Size(1051, 505);
            this.mainPanelDB.TabIndex = 6;
            // 
            // addCandidates_Panel
            // 
            this.addCandidates_Panel.BackColor = System.Drawing.Color.White;
            this.addCandidates_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.addCandidates_Panel.Controls.Add(this.label17);
            this.addCandidates_Panel.Controls.Add(this.candidate_Position_Box);
            this.addCandidates_Panel.Controls.Add(this.label10);
            this.addCandidates_Panel.Controls.Add(this.candidate_BirthDate_Field);
            this.addCandidates_Panel.Controls.Add(this.label9);
            this.addCandidates_Panel.Controls.Add(this.candidate_PhoneNumber_Field);
            this.addCandidates_Panel.Controls.Add(this.label8);
            this.addCandidates_Panel.Controls.Add(this.candidate_Email_Field);
            this.addCandidates_Panel.Controls.Add(this.candidate_RadioOthers_Button);
            this.addCandidates_Panel.Controls.Add(this.candidate_RadioFemale_Button);
            this.addCandidates_Panel.Controls.Add(this.label7);
            this.addCandidates_Panel.Controls.Add(this.candidate_RadioMale_Button);
            this.addCandidates_Panel.Controls.Add(this.label6);
            this.addCandidates_Panel.Controls.Add(this.candidate_LastName_Field);
            this.addCandidates_Panel.Controls.Add(this.label5);
            this.addCandidates_Panel.Controls.Add(this.candidate_FirstName_Field);
            this.addCandidates_Panel.Controls.Add(this.addCandidate_Button);
            this.addCandidates_Panel.Controls.Add(this.label3);
            this.addCandidates_Panel.Location = new System.Drawing.Point(0, 45);
            this.addCandidates_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.addCandidates_Panel.Name = "addCandidates_Panel";
            this.addCandidates_Panel.Padding = new System.Windows.Forms.Padding(30);
            this.addCandidates_Panel.Size = new System.Drawing.Size(1051, 460);
            this.addCandidates_Panel.TabIndex = 3;
            this.addCandidates_Panel.Visible = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(543, 305);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 21);
            this.label17.TabIndex = 17;
            this.label17.Text = "Position";
            // 
            // candidate_Position_Box
            // 
            this.candidate_Position_Box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.candidate_Position_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_Position_Box.FormattingEnabled = true;
            this.candidate_Position_Box.Location = new System.Drawing.Point(547, 329);
            this.candidate_Position_Box.Name = "candidate_Position_Box";
            this.candidate_Position_Box.Size = new System.Drawing.Size(310, 33);
            this.candidate_Position_Box.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(543, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 21);
            this.label10.TabIndex = 15;
            this.label10.Text = "Birth Date";
            // 
            // candidate_BirthDate_Field
            // 
            this.candidate_BirthDate_Field.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_BirthDate_Field.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.candidate_BirthDate_Field.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_BirthDate_Field.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.candidate_BirthDate_Field.Location = new System.Drawing.Point(547, 270);
            this.candidate_BirthDate_Field.Name = "candidate_BirthDate_Field";
            this.candidate_BirthDate_Field.Size = new System.Drawing.Size(310, 29);
            this.candidate_BirthDate_Field.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(543, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(126, 21);
            this.label9.TabIndex = 13;
            this.label9.Text = "Phone Number";
            // 
            // candidate_PhoneNumber_Field
            // 
            this.candidate_PhoneNumber_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_PhoneNumber_Field.Location = new System.Drawing.Point(547, 192);
            this.candidate_PhoneNumber_Field.Name = "candidate_PhoneNumber_Field";
            this.candidate_PhoneNumber_Field.Size = new System.Drawing.Size(310, 33);
            this.candidate_PhoneNumber_Field.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(543, 100);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "Email";
            // 
            // candidate_Email_Field
            // 
            this.candidate_Email_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_Email_Field.Location = new System.Drawing.Point(547, 124);
            this.candidate_Email_Field.Name = "candidate_Email_Field";
            this.candidate_Email_Field.Size = new System.Drawing.Size(310, 33);
            this.candidate_Email_Field.TabIndex = 10;
            // 
            // candidate_RadioOthers_Button
            // 
            this.candidate_RadioOthers_Button.AutoSize = true;
            this.candidate_RadioOthers_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_RadioOthers_Button.ForeColor = System.Drawing.Color.Black;
            this.candidate_RadioOthers_Button.Location = new System.Drawing.Point(187, 337);
            this.candidate_RadioOthers_Button.Name = "candidate_RadioOthers_Button";
            this.candidate_RadioOthers_Button.Size = new System.Drawing.Size(75, 25);
            this.candidate_RadioOthers_Button.TabIndex = 9;
            this.candidate_RadioOthers_Button.TabStop = true;
            this.candidate_RadioOthers_Button.Text = "Others";
            this.candidate_RadioOthers_Button.UseVisualStyleBackColor = true;
            // 
            // candidate_RadioFemale_Button
            // 
            this.candidate_RadioFemale_Button.AutoSize = true;
            this.candidate_RadioFemale_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_RadioFemale_Button.ForeColor = System.Drawing.Color.Black;
            this.candidate_RadioFemale_Button.Location = new System.Drawing.Point(187, 306);
            this.candidate_RadioFemale_Button.Name = "candidate_RadioFemale_Button";
            this.candidate_RadioFemale_Button.Size = new System.Drawing.Size(78, 25);
            this.candidate_RadioFemale_Button.TabIndex = 8;
            this.candidate_RadioFemale_Button.TabStop = true;
            this.candidate_RadioFemale_Button.Text = "Female";
            this.candidate_RadioFemale_Button.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(183, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Gender";
            // 
            // candidate_RadioMale_Button
            // 
            this.candidate_RadioMale_Button.AutoSize = true;
            this.candidate_RadioMale_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_RadioMale_Button.ForeColor = System.Drawing.Color.Black;
            this.candidate_RadioMale_Button.Location = new System.Drawing.Point(187, 275);
            this.candidate_RadioMale_Button.Name = "candidate_RadioMale_Button";
            this.candidate_RadioMale_Button.Size = new System.Drawing.Size(62, 25);
            this.candidate_RadioMale_Button.TabIndex = 6;
            this.candidate_RadioMale_Button.TabStop = true;
            this.candidate_RadioMale_Button.Text = "Male";
            this.candidate_RadioMale_Button.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(183, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // candidate_LastName_Field
            // 
            this.candidate_LastName_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_LastName_Field.Location = new System.Drawing.Point(187, 192);
            this.candidate_LastName_Field.Name = "candidate_LastName_Field";
            this.candidate_LastName_Field.Size = new System.Drawing.Size(310, 33);
            this.candidate_LastName_Field.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(183, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "First Name";
            // 
            // candidate_FirstName_Field
            // 
            this.candidate_FirstName_Field.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidate_FirstName_Field.Location = new System.Drawing.Point(187, 124);
            this.candidate_FirstName_Field.Name = "candidate_FirstName_Field";
            this.candidate_FirstName_Field.Size = new System.Drawing.Size(310, 33);
            this.candidate_FirstName_Field.TabIndex = 2;
            // 
            // addCandidate_Button
            // 
            this.addCandidate_Button.BackColor = System.Drawing.Color.White;
            this.addCandidate_Button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCandidate_Button.ForeColor = System.Drawing.Color.Black;
            this.addCandidate_Button.Location = new System.Drawing.Point(455, 390);
            this.addCandidate_Button.Name = "addCandidate_Button";
            this.addCandidate_Button.Size = new System.Drawing.Size(139, 35);
            this.addCandidate_Button.TabIndex = 1;
            this.addCandidate_Button.Text = "Add";
            this.addCandidate_Button.UseVisualStyleBackColor = false;
            this.addCandidate_Button.Click += new System.EventHandler(this.addCandidate_Button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(401, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 41);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Candidate";
            // 
            // manageElections_Panel
            // 
            this.manageElections_Panel.BackColor = System.Drawing.Color.White;
            this.manageElections_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageElections_Panel.Controls.Add(this.label4);
            this.manageElections_Panel.Location = new System.Drawing.Point(0, 45);
            this.manageElections_Panel.Margin = new System.Windows.Forms.Padding(2);
            this.manageElections_Panel.Name = "manageElections_Panel";
            this.manageElections_Panel.Padding = new System.Windows.Forms.Padding(30);
            this.manageElections_Panel.Size = new System.Drawing.Size(1051, 460);
            this.manageElections_Panel.TabIndex = 3;
            this.manageElections_Panel.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(392, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(265, 41);
            this.label4.TabIndex = 0;
            this.label4.Text = "Manage Elections";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label18.Location = new System.Drawing.Point(0, 631);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(151, 13);
            this.label18.TabIndex = 7;
            this.label18.Text = "Created By: Carlos, Rendyl John";
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::E_Voting_System.Properties.Resources._5594016;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1115, 643);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.mainPanelDB);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DashboardForm";
            this.Padding = new System.Windows.Forms.Padding(30, 0, 30, 32);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "COMELEC E-Voting System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DashboardForm_FormClosing_1);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.addVoter_Panel.ResumeLayout(false);
            this.addVoter_Panel.PerformLayout();
            this.mainPanelDB.ResumeLayout(false);
            this.addCandidates_Panel.ResumeLayout(false);
            this.addCandidates_Panel.PerformLayout();
            this.manageElections_Panel.ResumeLayout(false);
            this.manageElections_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button adminBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button addVoter_Button;
        private System.Windows.Forms.Button manageElections_Button;
        private System.Windows.Forms.Button addCandidates_Button;
        private System.Windows.Forms.Panel addVoter_Panel;
        private System.Windows.Forms.Panel mainPanelDB;
        private System.Windows.Forms.Panel addCandidates_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel manageElections_Panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCandidate_Button;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox candidate_FirstName_Field;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox candidate_LastName_Field;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker candidate_BirthDate_Field;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox candidate_PhoneNumber_Field;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox candidate_Email_Field;
        private System.Windows.Forms.RadioButton candidate_RadioOthers_Button;
        private System.Windows.Forms.RadioButton candidate_RadioFemale_Button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton candidate_RadioMale_Button;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox voters_FirstName_Field;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox voters_PhoneNumber_Field;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox voters_Email_Field;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox voters_LastName_Field;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox voters_Candidate_Box;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox candidate_Position_Box;
        private System.Windows.Forms.ComboBox voters_VotePosition_Box;
        private System.Windows.Forms.Label label18;
    }
}