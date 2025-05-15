using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace E_Voting_System
{
    public partial class DashboardForm : Form
    {
        private bool adminMode = false;
        private string ScreenView;
        private int positionID;

        public DashboardForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            manageElections_ResultsDataGrid.DefaultCellStyle.ForeColor = Color.Black;
            manageElections_ResultsDataGrid.DefaultCellStyle.BackColor = Color.White;
            manageElections_ResultsDataGrid.RowsDefaultCellStyle.ForeColor = Color.Black;
            manageElections_ResultsDataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            manageElections_ResultsDataGrid.EnableHeadersVisualStyles = false;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                adminBtn.Visible = true;
                addCandidates_Button.Visible = true;
            }
            else if(isEmployee())
            {
                addCandidates_Button.Visible = true;
            }
            else
            {
                addCandidates_Button.Visible = false;
                adminBtn.Visible = false;
            }
            mainPanelDB.Visible = true;
            ShowOnlyPanel(welcomePanel);
        }

        private void dashboardForm_ExitBtn_Click(object sender, EventArgs e)
        {
            updateLoggedStatus();
            Application.Exit();
        }

        private void ShowOnlyPanel(Panel panelToShow)
        {
            addVoter_Panel.Visible = false;
            addCandidates_Panel.Visible = false;
            manageElections_Panel.Visible = false;
            welcomePanel.Visible = false;

            panelToShow.Visible = true;
        }

        private void activeColorButton(Button buttonToChange)
        {
            addVoter_Button.BackColor = Color.WhiteSmoke;
            addCandidates_Button.BackColor = Color.WhiteSmoke;
            manageElections_Button.BackColor = Color.WhiteSmoke;

            if (buttonToChange == null)
            {
                return;
            }
            else {
                buttonToChange.BackColor = Color.LightGray;
            }
        }

        public bool isAdmin()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand checkCommand = new MySqlCommand("SELECT * FROM users WHERE `ID Number` = @idNumber AND Permission = 'Admin'", connection);
                checkCommand.Parameters.AddWithValue("@idNumber", LoginForm.CurrentUserID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(checkCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool isEmployee()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand checkCommand = new MySqlCommand("SELECT * FROM users WHERE `ID Number` = @idNumber AND Permission = 'Employee'", connection);
                checkCommand.Parameters.AddWithValue("@idNumber", LoginForm.CurrentUserID);
                MySqlDataAdapter adapter = new MySqlDataAdapter(checkCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private void updateLoggedStatus()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                try
                {
                    connection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET is_Logged = 0 WHERE `ID Number` = @idNumber", connection);
                    updateCommand.Parameters.AddWithValue("@idNumber", LoginForm.CurrentUserID);
                    updateCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DashboardForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            updateLoggedStatus();
            Application.Exit();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                updateLoggedStatus();
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        // MANAGE BUTTONS IN DASHBOARD

        private void homeBtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ScreenView = "homePanel";
            ShowOnlyPanel(welcomePanel);
            activeColorButton(null);
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            if (!adminMode)
            {
                adminMode = true;
                manageElections_Button.Visible = true;
                adminBtn.Text = "Admin Mode Enabled";
                adminBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            }
            else
            {
                if (ScreenView == "addVoters" || ScreenView == "addCandidates" || ScreenView == "homePanel")
                {
                    manageElections_Button.Visible = false;
                    manageElections_Panel.Visible = false;
                    manageElections_ChoiceBox_Panel.Visible = true;
                    viewResultsPanel.Visible = false;
                }
                else{
                    manageElections_Button.Visible = false;
                    manageElections_Panel.Visible = false;
                    ShowOnlyPanel(welcomePanel);
                    activeColorButton(null);
                    manageElections_ChoiceBox_Panel.Visible = true;
                    viewResultsPanel.Visible = false;
                }
                adminMode = false;
                adminBtn.Text = "Admin Mode";
                adminBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            }
        }

        private void addVoter_Button_Click(object sender, EventArgs e)
        {
            ScreenView = "addVoters";
            ShowOnlyPanel(addVoter_Panel);
            activeColorButton(addVoter_Button);
            EmptyField();

            FillPositionBox(voters_VotePosition_Box);

            voters_Candidate_Box.Enabled = false;
            FillCandidateBox(positionID);
        }

        private void addCandidates_Button_Click(object sender, EventArgs e)
        {
            ScreenView = "addCandidates";
            ShowOnlyPanel(addCandidates_Panel);
            activeColorButton(addCandidates_Button);
            EmptyField();
            FillPositionBox(candidate_Position_Box);
        }

        private void manageElections_Button_Click(object sender, EventArgs e)
        {
            ScreenView = "manageElections";
            ShowOnlyPanel(manageElections_Panel);
            activeColorButton(manageElections_Button);
            manageElections_ChoiceBox_Panel.Visible = true;
            viewResultsPanel.Visible = false;
            EmptyField();
        }

        private void EmptyField()
        {
            if (ScreenView == "addVoters")
            {
                voters_FirstName_Field.Text = "";
                voters_LastName_Field.Text = "";
                voters_Email_Field.Text = "";
                voters_PhoneNumber_Field.Text = "";
                voters_VotePosition_Box.SelectedIndex = -1;
                voters_Candidate_Box.SelectedIndex = -1;
                return;
            }
            if (ScreenView == "addCandidates")
            {
                candidate_FirstName_Field.Text = "";
                candidate_LastName_Field.Text = "";
                candidate_Email_Field.Text = "";
                candidate_PhoneNumber_Field.Text = "";
                candidate_BirthDate_Field.Value = DateTime.Now;
                candidate_Position_Box.SelectedIndex = -1;
                return;
            }
            if (ScreenView == "manageElections")
            {
                return;
            }
        }

        private bool isEmpty()
        {
            if (ScreenView == "addVoters" &&
                (voters_FirstName_Field.Text == "" ||
                 voters_LastName_Field.Text == "" ||
                 voters_Email_Field.Text == "" ||
                 voters_PhoneNumber_Field.Text == "" ||
                 voters_VotePosition_Box.SelectedIndex == -1 ||
                 voters_Candidate_Box.SelectedIndex == -1))
            {
                return true;
            }

            if (ScreenView == "addCandidates" &&
                (candidate_FirstName_Field.Text == "" ||
                 candidate_LastName_Field.Text == "" ||
                 candidate_Email_Field.Text == "" ||
                 candidate_PhoneNumber_Field.Text == "" ||
                 candidate_Position_Box.SelectedIndex == -1))
            {
                return true;
            }

            if (ScreenView == "manageElections")
            {
                return false;
            }

            return false;
        }


        private void voters_VotePosition_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (voters_VotePosition_Box.SelectedValue is int positionID)
            {
                FillCandidateBox(positionID);
            }
        }

        public void FillPositionBox(ComboBox comboBox)
        {   
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand fillCommand = new MySqlCommand("SELECT `Position ID`, `Position` FROM position", connection);
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(fillCommand);
                    adapter.Fill(dt);

                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = "Position";
                    comboBox.ValueMember = "Position ID";
                    comboBox.SelectedIndex = -1;
                    comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void FillCandidateBox(int positionID)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand fillCommand = new MySqlCommand("SELECT `Candidate ID`, `First Name`, `Last Name` FROM candidates WHERE `Position` = @positionID AND `Status` = 'Approved' ", connection);
                fillCommand.Parameters.AddWithValue("@positionID", positionID);
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(fillCommand);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        voters_Candidate_Box.Enabled = true;
                    }
                    else
                    {
                        voters_Candidate_Box.SelectedValue = -1;
                        voters_Candidate_Box.Enabled = false;
                        return;
                    }

                    dt.Columns.Add("FullName", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["FullName"] = row["Last Name"] + ", " + row["First Name"];
                    }

                    voters_Candidate_Box.DataSource = dt;
                    voters_Candidate_Box.DisplayMember = "FullName";
                    voters_Candidate_Box.ValueMember = "Candidate ID";
                    voters_Candidate_Box.DropDownStyle = ComboBoxStyle.DropDownList;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void addCandidate_Button_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                candidate_FirstName_Field.Focus();
                MessageBox.Show("Fields is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO candidates(`First Name`, `Last Name`, `Gender`, `Email`, `Phone Number`, `Birth Date`, `Position`) VALUES(@FirstName, @LastName, @Gender, @Email, @PhoneNumber, @BirthDate, @Position);", connection);
                insertCommand.Parameters.AddWithValue("@FirstName", candidate_FirstName_Field.Text);
                insertCommand.Parameters.AddWithValue("@LastName", candidate_LastName_Field.Text);
                insertCommand.Parameters.AddWithValue("@Gender", candidate_RadioMale_Button.Checked ? "Male" : candidate_RadioFemale_Button.Checked ? "Female" : candidate_RadioOthers_Button.Checked ? "Others" : "");
                insertCommand.Parameters.AddWithValue("@Email", candidate_Email_Field.Text);
                if (!Regex.IsMatch(candidate_PhoneNumber_Field.Text, @"^09\d{9}$"))
                {
                    MessageBox.Show("Phone Number must start with '09' and be 11 digits long.");
                    candidate_PhoneNumber_Field.Text = "";
                    candidate_PhoneNumber_Field.Focus();
                    return;
                }
                else
                {
                    insertCommand.Parameters.AddWithValue("@PhoneNumber", candidate_PhoneNumber_Field.Text);
                }
                insertCommand.Parameters.AddWithValue("@BirthDate", candidate_BirthDate_Field.Value.Date);
                insertCommand.Parameters.AddWithValue("@Position", candidate_Position_Box.SelectedValue);

                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM candidates WHERE `First Name` = @FirstName OR `Last Name` = @LastName OR `Email` = @Email", connection);
                searchCommand.Parameters.AddWithValue("@FirstName", candidate_FirstName_Field.Text);
                searchCommand.Parameters.AddWithValue("@LastName", candidate_LastName_Field.Text);
                searchCommand.Parameters.AddWithValue("@Email", candidate_Email_Field.Text);

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Credentials Already Exist.");
                        candidate_FirstName_Field.Focus();
                        EmptyField();
                        return;
                    }

                    connection.Open();
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Candidate Added Successfully.");
                    candidate_FirstName_Field.Focus();
                    EmptyField();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void voters_AddBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                candidate_FirstName_Field.Focus();
                MessageBox.Show("Fields is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand insertCommand_Voters = new MySqlCommand("INSERt INTO voters(`First Name`, `Last Name`, `Email`, `Phone Number`) VALUES (@FirstName, @LastName, @Email, @PhoneNumber)", connection);
                insertCommand_Voters.Parameters.AddWithValue("@FirstName", voters_FirstName_Field.Text);
                insertCommand_Voters.Parameters.AddWithValue("@LastName", voters_LastName_Field.Text);
                insertCommand_Voters.Parameters.AddWithValue("@Email", voters_Email_Field.Text);
                if (!Regex.IsMatch(voters_PhoneNumber_Field.Text, @"^09\d{9}$"))
                {
                    MessageBox.Show("Phone Number must start with '09' and be 11 digits long.");
                    voters_PhoneNumber_Field.Text = "";
                    voters_PhoneNumber_Field.Focus();
                    return;
                }
                else
                {
                    insertCommand_Voters.Parameters.AddWithValue("@PhoneNumber", voters_PhoneNumber_Field.Text);
                }

                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM voters WHERE `First Name` = @FirstName OR `Last Name` = @LastName AND `Position` = @position", connection);
                searchCommand.Parameters.AddWithValue("@FirstName", voters_FirstName_Field.Text);
                searchCommand.Parameters.AddWithValue("@LastName", voters_LastName_Field.Text);
                searchCommand.Parameters.AddWithValue("@position", voters_VotePosition_Box.SelectedValue);

                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Credentials Already Exist.");
                        voters_FirstName_Field.Focus();
                        EmptyField();
                        return;
                    }

                    connection.Open();
                    insertCommand_Voters.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

                MySqlCommand insertCommand_Election = new MySqlCommand("INSERT INTO election(`Voter`, `Candidate`, `Position`) VALUES(@Voter, @Candidate, @Position)", connection);
                insertCommand_Election.Parameters.AddWithValue("@Voter", insertCommand_Voters.LastInsertedId);
                insertCommand_Election.Parameters.AddWithValue("@Candidate", voters_Candidate_Box.SelectedValue);
                insertCommand_Election.Parameters.AddWithValue("@Position", voters_VotePosition_Box.SelectedValue);
                try
                {
                    connection.Open();
                    insertCommand_Election.ExecuteNonQuery();
                    MessageBox.Show("Voter Added Successfully.");
                    EmptyField();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void viewResultsBtn_Click(object sender, EventArgs e)
        {
            manageElections_ChoiceBox_Panel.Visible = false;
            viewResultsPanel.Visible = true;

            manageElections_ResultsDataGrid.Rows.Clear();

            manageElections_ResultPositionBox.SelectedIndexChanged -= manageElections_ResultPositionBox_SelectedIndexChanged;

            FillPositionBox(manageElections_ResultPositionBox);
            manageElections_ResultPositionBox.SelectedIndex = -1;

            manageElections_ResultPositionBox.SelectedIndexChanged += manageElections_ResultPositionBox_SelectedIndexChanged;

        }


        private void viewResultsPanel_BackBtn_Click(object sender, EventArgs e)
        {
            manageElections_ChoiceBox_Panel.Visible = true;
            viewResultsPanel.Visible = false;
        }

        private void adminPanelBtn_Click(object sender, EventArgs e)
        {
            AdminForm adminForm = new AdminForm();
            adminForm.Show();
            this.Hide();
        }

        private void manageElections_ResultPositionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (manageElections_ResultPositionBox.SelectedValue is int positionID)
            {
                displayResultGrid(positionID);
            }
        }

        private int GetTotalVotes(MySqlConnection connection, int positionID)
        {
            using (var cmd = new MySqlCommand(
                "SELECT COUNT(*) FROM election e JOIN candidates c ON e.Candidate = c.`Candidate ID` WHERE c.Position = @positionID", connection))
            {
                cmd.Parameters.AddWithValue("@positionID", positionID);
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }

        public void displayResultGrid(int positionID)
        {   
            manageElections_ResultsDataGrid.Rows.Clear();
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                try
                {
                    connection.Open();
                    MySqlCommand displayCommand = new MySqlCommand("SELECT c.`Candidate ID`, c.`First Name`, c.`Last Name`, p.`Position` FROM candidates c JOIN position p ON c.`Position` = p.`Position ID` WHERE `Position ID` = @positionID", connection);
                    displayCommand.Parameters.AddWithValue("@positionID", positionID);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(displayCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        foreach (DataRow row in dt.Rows)
                        {   

                            int candidateID = Convert.ToInt32(row["Candidate ID"]);
                            string fullName = $"{row["Last Name"]}, {row["First Name"]}";
                            string position = row["Position"].ToString();

                            MySqlCommand voteCmd = new MySqlCommand("SELECT COUNT(*) FROM election WHERE `Candidate` = @CandidateID", connection);
                            voteCmd.Parameters.AddWithValue("@CandidateID", candidateID);
                            int voteCount = Convert.ToInt32(voteCmd.ExecuteScalar());
                            int totalVotes = GetTotalVotes(connection, positionID);
                            int percentage = totalVotes > 0 ? (int)(((double)voteCount / totalVotes) * 100) : 0;
                            ProgressBarValue progressValue = new ProgressBarValue(voteCount, percentage);

                            manageElections_ResultsDataGrid.Rows.Add(Properties.Resources.user_avatar, candidateID, fullName, position, progressValue);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }

    public class ProgressBarValue
    {
        public int Votes { get; set; }
        public int Percentage { get; set; }

        public ProgressBarValue(int votes, int percentage)
        {
            Votes = votes;
            Percentage = percentage;
        }
    }


    public class DataGridViewProgressBarCell : DataGridViewTextBoxCell
    {
        public DataGridViewProgressBarCell()
        {
            this.ValueType = typeof(ProgressBarValue);
        }

        protected override void Paint(Graphics graphics,
                              Rectangle clipBounds,
                              Rectangle cellBounds,
                              int rowIndex,
                              DataGridViewElementStates cellState,
                              object value,
                              object formattedValue,
                              string errorText,
                              DataGridViewCellStyle cellStyle,
                              DataGridViewAdvancedBorderStyle advancedBorderStyle,
                              DataGridViewPaintParts paintParts)
        {
            // Paint base background and border
            if ((paintParts & DataGridViewPaintParts.Background) == DataGridViewPaintParts.Background)
            {
                using (Brush backgroundBrush = new SolidBrush(cellStyle.BackColor))
                {
                    graphics.FillRectangle(backgroundBrush, cellBounds);
                }
            }

            if ((paintParts & DataGridViewPaintParts.Border) == DataGridViewPaintParts.Border)
            {
                PaintBorder(graphics, clipBounds, cellBounds, cellStyle, advancedBorderStyle);
            }

            if (value is ProgressBarValue progressValue)
            {
                int percentage = progressValue.Percentage;
                int voteCount = progressValue.Votes;

                // Progress bar background
                Rectangle barArea = new Rectangle(cellBounds.X + 2, cellBounds.Y + 2,
                                                  cellBounds.Width - 4, cellBounds.Height - 4);
                using (Brush backBrush = new SolidBrush(Color.LightGray))
                {
                    graphics.FillRectangle(backBrush, barArea);
                }

                // Progress fill
                if (percentage > 0)
                {
                    int fillWidth = (int)(barArea.Width * percentage / 100.0);
                    Rectangle fillRect = new Rectangle(barArea.X, barArea.Y, fillWidth, barArea.Height);
                    using (Brush barBrush = new SolidBrush(Color.FromArgb(158, 188, 138)))
                    {
                        graphics.FillRectangle(barBrush, fillRect);
                    }
                }

                // Vote text
                string text = $"{voteCount} vote{(voteCount == 1 ? "" : "s")} ({percentage}%)";
                SizeF textSize = graphics.MeasureString(text, cellStyle.Font);
                float textX = cellBounds.X + (cellBounds.Width - textSize.Width) / 2;
                float textY = cellBounds.Y + (cellBounds.Height - textSize.Height) / 2;

                using (Brush textBrush = new SolidBrush(Color.Black))
                {
                    graphics.DrawString(text, cellStyle.Font, textBrush, textX, textY);
                }
            }
        }
    }

    public class DataGridViewProgressBarColumn : DataGridViewColumn
    {
        public DataGridViewProgressBarColumn()
        {
            this.CellTemplate = new DataGridViewProgressBarCell();
            this.ReadOnly = true;
        }
    }


}
