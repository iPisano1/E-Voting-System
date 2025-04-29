using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_System
{
    public partial class DashboardForm: Form
    {

        private bool isLoggingOut = false;
        private LoginForm loginForm;
        private bool adminMode = false;
        private string ScreenView;
        private int positionID;

        public DashboardForm(LoginForm form)
        {
            InitializeComponent();
            loginForm = form;
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            if (isAdmin())
            {
                adminBtn.Visible = true;
            }
            else {
                adminBtn.Visible = false;
            }
            mainPanelDB.Visible = true;
            ScreenView = "addVoters";
            addVoter_Button.Focus();
            addVoter_Button.Select();
            activeColorButton(addVoter_Button);
            ShowOnlyPanel(addVoter_Panel);
            FillPositionBox();
            FillCandidateBox(positionID);
        }

        public Boolean isAdmin() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand checkCommand = new MySqlCommand("SELECT * FROM users WHERE `ID Number` = @idNumber AND Permission = 'admin'", connection);
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

        private void updateLoggedStatus() {
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
            if (!isLoggingOut) {
                DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else {
                    updateLoggedStatus();
                    Application.Exit();
                }
       
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                isLoggingOut = true;
                updateLoggedStatus();
                this.Hide();
                loginForm.Show();
            }
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {   
            if (!adminMode) {
                //mainPanelDB.Visible = false;
                adminMode = true;
                manageElections_Button.Visible = true;
                manageElections_Panel.Visible = true;
                manageElections_Button.Focus();
                activeColorButton(manageElections_Button);
                ShowOnlyPanel(manageElections_Panel);
            }
            else {
                //mainPanelDB.Visible = true;
                manageElections_Button.Visible = false;
                manageElections_Panel.Visible = false;
                addVoter_Button.Focus();
                activeColorButton(addVoter_Button);
                ShowOnlyPanel(addVoter_Panel);
                adminMode = false;
            }
        }

        private void ShowOnlyPanel(Panel panelToShow)
        {
            addVoter_Panel.Visible = false;
            addCandidates_Panel.Visible = false;
            manageElections_Panel.Visible = false;

            panelToShow.Visible = true;
        }

        private void activeColorButton(Button buttonToChange) {
            addVoter_Button.BackColor = Color.White;
            addCandidates_Button.BackColor = Color.White;
            manageElections_Button.BackColor = Color.White;

            buttonToChange.BackColor = Color.WhiteSmoke;
        }

        private void addVoter_Button_Click(object sender, EventArgs e)
        {
            ScreenView = "addVoters";
            ShowOnlyPanel(addVoter_Panel);
            activeColorButton(addVoter_Button);
        }

        private void addCandidates_Button_Click(object sender, EventArgs e)
        {
            ScreenView = "addCandidates";
            ShowOnlyPanel(addCandidates_Panel);
            activeColorButton(addCandidates_Button);
        }

        private void manageElections_Button_Click(object sender, EventArgs e)
        {
            ScreenView = "manageElections";
            ShowOnlyPanel(manageElections_Panel);
            activeColorButton(manageElections_Button);
        }

        private void EmptyField() {
            if (ScreenView == "addVoters") {
                voters_FirstName_Field.Text = "";
                voters_LastName_Field.Text = "";
                voters_Email_Field.Text = "";
                voters_PhoneNumber_Field.Text = "";
                voters_VotePosition_Box.SelectedIndex = -1;
                voters_Candidate_Box.SelectedIndex = -1;
                return;
            }
            if (ScreenView == "addCandidates") {
                candidate_FirstName_Field.Text = "";
                candidate_LastName_Field.Text = "";
                candidate_Email_Field.Text = "";
                candidate_PhoneNumber_Field.Text = "";
                candidate_Position_Box.SelectedIndex = -1;
                return;
            }
            if (ScreenView == "manageElections") {
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

        public void FillPositionBox() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system")){
                MySqlCommand fillCommand = new MySqlCommand("SELECT `Position ID`, `Position` FROM position", connection);
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(fillCommand);
                    adapter.Fill(dt);

                    candidate_Position_Box.DataSource = dt;
                    candidate_Position_Box.DisplayMember = "Position";     
                    candidate_Position_Box.ValueMember = "Position ID";
                    candidate_Position_Box.SelectedIndex = -1;

                    voters_VotePosition_Box.DataSource = dt.Copy();
                    voters_VotePosition_Box.DisplayMember = "Position";
                    voters_VotePosition_Box.ValueMember = "Position ID";
                    voters_VotePosition_Box.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void FillCandidateBox(int positionID)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system")){
                MySqlCommand fillCommand = new MySqlCommand("SELECT `Candidate ID`, `First Name`, `Last Name` FROM candidates WHERE `Position` = @positionID", connection);
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
                    else {
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
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system")) {
                MySqlCommand insertCommand = new MySqlCommand("INSERT INTO candidates(`First Name`, `Last Name`, `Gender`, `Email`, `Phone Number`, `Birth Date`, `Position`) VALUES(@FirstName, @LastName, @Gender, @Email, @PhoneNumber, @BirthDate, @Position);", connection);
                insertCommand.Parameters.AddWithValue("@FirstName", candidate_FirstName_Field.Text);
                insertCommand.Parameters.AddWithValue("@LastName", candidate_LastName_Field.Text);
                insertCommand.Parameters.AddWithValue("@Gender", candidate_RadioMale_Button.Checked ? "Male" : candidate_RadioFemale_Button.Checked ? "Female" : candidate_RadioOthers_Button.Checked ? "Others": "");
                insertCommand.Parameters.AddWithValue("@Email", candidate_Email_Field.Text);
                if (!Regex.IsMatch(candidate_PhoneNumber_Field.Text, @"^09\d{9}$"))
                {
                    MessageBox.Show("Phone Number must start with '09' and be 11 digits long.");
                    candidate_PhoneNumber_Field.Text = "";
                    candidate_PhoneNumber_Field.Focus();
                    return;
                }
                else {  
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

                    if (dt.Rows.Count > 0) {
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
                finally {
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                candidate_FirstName_Field.Focus();
                MessageBox.Show("Fields is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system")) {
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

                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM voters WHERE `First Name` = @FirstName OR `Last Name` = @LastName OR `Email` = @Email", connection);
                searchCommand.Parameters.AddWithValue("@FirstName", voters_FirstName_Field.Text);
                searchCommand.Parameters.AddWithValue("@LastName", voters_LastName_Field.Text);
                searchCommand.Parameters.AddWithValue("@Email", voters_Email_Field.Text);

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
                finally {
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
                finally {
                    connection.Close();
                }
            }
        }
    }
}
