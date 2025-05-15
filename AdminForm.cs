using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Voting_System
{
    public partial class AdminForm : Form
    {
        private int positionID;

        public AdminForm()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public static extern void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public static extern void SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private void AdminForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Show();
            this.Hide();
        }

        private void ShowOnlyPanel(Panel panelToShow)
        {
            candidatesPanel.Visible = false;
            electionPanel.Visible = false;
            positionPanel.Visible = false;
            votersPanel.Visible = false;
            usersPanel.Visible = false;

            panelToShow.Visible = true;
        }

        private void activeColorButton(Button buttonToChange)
        {
            candidatesBtn.BackColor = Color.WhiteSmoke;
            electionBtn.BackColor = Color.WhiteSmoke;
            positionBtn.BackColor = Color.WhiteSmoke;
            votersBtn.BackColor = Color.WhiteSmoke;
            usersBtn.BackColor = Color.WhiteSmoke;

            if (buttonToChange == null)
            {
                return;
            }
            else
            {
                buttonToChange.BackColor = Color.LightGray;
            }
        }

        // Manage Buttons

        private void candidatesBtn_Click(object sender, EventArgs e)
        {
            activeColorButton(candidatesBtn);
            ShowOnlyPanel(candidatesPanel);
            FillPositionBox(candidates_PositionBox);
            displayCandidatesGrid();
            candidates_DataGrid.ClearSelection();
            ClearCandidatesFields();
        }

        private void electionBtn_Click(object sender, EventArgs e)
        {
            activeColorButton(electionBtn);
            ShowOnlyPanel(electionPanel);
            FillPositionBox(election_PositionBox);
            FillCandidateBox(election_CandidateBox, positionID);
            FillVoterBox(election_VoterBox);
            displayElectionGrid();
            election_DataGrid.ClearSelection();
            ClearElectionFields();
        }

        private void positionBtn_Click(object sender, EventArgs e)
        {
            activeColorButton(positionBtn);
            ShowOnlyPanel(positionPanel);
            displayPositionGrid();
            position_DataGrid.ClearSelection();
            ClearPositionFields();
        }

        private void votersBtn_Click(object sender, EventArgs e)
        {
            activeColorButton(votersBtn);
            ShowOnlyPanel(votersPanel);
            displayVotersGrid();
            voters_DataGrid.ClearSelection();
            ClearVotersFields();
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            activeColorButton(usersBtn);
            ShowOnlyPanel(usersPanel);
            displayUsersGrid();
            users_DataGrid.ClearSelection();
            ClearUsersFields();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void adminDashboard_ExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // Fill Combo Boxs

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

        private void election_PositionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (election_PositionBox.SelectedValue is int positionID)
            {
                FillCandidateBox(election_CandidateBox, positionID);
            }
        }

        public void FillCandidateBox(ComboBox comboBox, int positionID)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand fillCommand = new MySqlCommand("SELECT `Candidate ID`, `First Name`, `Last Name` FROM candidates WHERE `Position` = @positionID AND `Status` = 'Approved'", connection);
                fillCommand.Parameters.AddWithValue("@positionID", positionID);
                try
                {
                    DataTable dt = new DataTable();
                    MySqlDataAdapter adapter = new MySqlDataAdapter(fillCommand);
                    adapter.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        election_CandidateBox.Enabled = true;
                    }
                    else
                    {
                        election_CandidateBox.SelectedValue = -1;
                        election_CandidateBox.Enabled = false;
                        return;
                    }

                    dt.Columns.Add("FullName", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["FullName"] = row["Last Name"] + ", " + row["First Name"];
                    }

                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = "FullName";
                    comboBox.ValueMember = "Candidate ID";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        public void FillVoterBox(ComboBox comboBox)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand fillCommand = new MySqlCommand("Select `Voters ID`, `First Name`, `Last Name` FROM voters", connection);
                try
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(fillCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dt.Columns.Add("FullName", typeof(string));
                    foreach (DataRow row in dt.Rows)
                    {
                        row["FullName"] = row["Last Name"] + ", " + row["First Name"];
                    }

                    comboBox.DataSource = dt;
                    comboBox.DisplayMember = "FullName";
                    comboBox.ValueMember = "Voters ID";
                    comboBox.SelectedValue = -1;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Display Candidate Grid

        public void displayCandidatesGrid()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {

                MySqlCommand displayCommand = new MySqlCommand("SELECT c.`Candidate ID`, c.`First Name`, c.`Last Name`, c.`Gender`, c.`Email`, c.`Phone Number`, c.`Birth Date`, p.`Position`, c.`Status` FROM candidates c JOIN position p ON c.`Position` = p.`Position ID`", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(displayCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                candidates_DataGrid.DataSource = dt;

                candidates_DataGrid.Columns["First Name"].FillWeight = 80;
                candidates_DataGrid.Columns["Last Name"].FillWeight = 80;
                candidates_DataGrid.Columns["Candidate ID"].FillWeight = 90;
                candidates_DataGrid.Columns["Gender"].FillWeight = 50;
                candidates_DataGrid.Columns["Birth Date"].FillWeight = 80;
                candidates_DataGrid.Columns["Position"].FillWeight = 70;
                candidates_DataGrid.Columns["Status"].FillWeight = 80;

            }
        }

        private void candidates_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                candidates_CandidateIDText.Text = Convert.ToInt32(candidates_DataGrid.Rows[e.RowIndex].Cells["Candidate ID"].Value).ToString();
                candidates_FirstNameText.Text = candidates_DataGrid.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
                candidates_LastNameText.Text = candidates_DataGrid.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
                candidates_GenderBox.SelectedIndex = candidates_GenderBox.FindStringExact(candidates_DataGrid.Rows[e.RowIndex].Cells["Gender"].Value.ToString());
                candidates_EmailText.Text = candidates_DataGrid.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                candidates_PhoneNumberText.Text = candidates_DataGrid.Rows[e.RowIndex].Cells["Phone Number"].Value.ToString();
                candidates_BirthDateBox.Value = Convert.ToDateTime(candidates_DataGrid.Rows[e.RowIndex].Cells["Birth Date"].Value.ToString());
                candidates_PositionBox.SelectedIndex = candidates_PositionBox.FindStringExact(candidates_DataGrid.Rows[e.RowIndex].Cells["Position"].Value.ToString());
                candidates_StatusBox.SelectedIndex = candidates_StatusBox.FindStringExact(candidates_DataGrid.Rows[e.RowIndex].Cells["Status"].Value.ToString());
            }
        }

        // Config Candidates

        public void ClearCandidatesFields()
        {
            candidates_CandidateIDText.Text = "";
            candidates_FirstNameText.Text = "";
            candidates_LastNameText.Text = "";
            candidates_GenderBox.SelectedIndex = -1;
            candidates_EmailText.Text = "";
            candidates_PhoneNumberText.Text = "";
            candidates_BirthDateBox.Value = DateTime.Now;
            candidates_PositionBox.SelectedIndex = -1;
            candidates_StatusBox.SelectedIndex = -1;
            candidates_DataGrid.ClearSelection();
        }

        public bool CheckCandidateExist()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM candidates WHERE `First Name` = @firstName AND `Last Name` = @lastName AND `Position` = @position", connection);
                searchCommand.Parameters.AddWithValue("@firstName", candidates_FirstNameText.Text);
                searchCommand.Parameters.AddWithValue("@lastName", candidates_LastNameText.Text);
                searchCommand.Parameters.AddWithValue("@position", candidates_PositionBox.SelectedValue);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
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

        private void candidates_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(candidates_FirstNameText.Text) || string.IsNullOrWhiteSpace(candidates_LastNameText.Text) || string.IsNullOrWhiteSpace(candidates_EmailText.Text) || string.IsNullOrWhiteSpace(candidates_PhoneNumberText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (candidates_GenderBox.SelectedItem == null || candidates_StatusBox.SelectedItem == null || candidates_PositionBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid Gender, Status, and Position.");
                return;
            }
            if (CheckCandidateExist())
            {
                MessageBox.Show("Candidate Already Exist");
                ClearCandidatesFields();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand addCommand = new MySqlCommand("INSERT INTO candidates (`First Name`, `Last Name`, `Gender`, `Email`, `Phone Number`, `Birth Date`, `Position`, `Status`) VALUES (@firstName, @lastName, @gender, @email, @phoneNumber, @birthDate, @position, @status)", connection);
                addCommand.Parameters.AddWithValue("@firstName", candidates_FirstNameText.Text);
                addCommand.Parameters.AddWithValue("@lastName", candidates_LastNameText.Text);
                addCommand.Parameters.AddWithValue("@gender", candidates_GenderBox.SelectedItem.ToString());
                addCommand.Parameters.AddWithValue("@email", candidates_EmailText.Text);
                addCommand.Parameters.AddWithValue("@phoneNumber", candidates_PhoneNumberText.Text);
                addCommand.Parameters.AddWithValue("@birthDate", candidates_BirthDateBox.Value.Date);
                addCommand.Parameters.AddWithValue("@position", candidates_PositionBox.SelectedValue);
                addCommand.Parameters.AddWithValue("@status", candidates_StatusBox.SelectedItem.ToString());

                try
                {
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("Candidate Added Successfully.");
                    displayCandidatesGrid();
                    candidates_DataGrid.ClearSelection();
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

        private void candidates_UpdatesBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(candidates_FirstNameText.Text) || string.IsNullOrWhiteSpace(candidates_LastNameText.Text) || string.IsNullOrWhiteSpace(candidates_EmailText.Text) || string.IsNullOrWhiteSpace(candidates_PhoneNumberText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (candidates_GenderBox.SelectedItem == null || candidates_StatusBox.SelectedItem == null || candidates_PositionBox.SelectedValue == null)
            {
                MessageBox.Show("Please select a valid Gender, Status, and Position.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE candidates SET `First Name` = @firstName, `Last Name` = @lastName, `Gender` = @gender, `Email` = @email, `Phone Number` = @phoneNumber, `Birth Date` = @birthDate, `Position` = @position, `Status` = @status WHERE `Candidate ID` = @candidateID", connection);
                updateCommand.Parameters.AddWithValue("@candidateID", candidates_CandidateIDText.Text);
                updateCommand.Parameters.AddWithValue("@firstName", candidates_FirstNameText.Text);
                updateCommand.Parameters.AddWithValue("@lastName", candidates_LastNameText.Text);
                updateCommand.Parameters.AddWithValue("@gender", candidates_GenderBox.SelectedItem.ToString());
                updateCommand.Parameters.AddWithValue("@email", candidates_EmailText.Text);
                updateCommand.Parameters.AddWithValue("@phoneNumber", candidates_PhoneNumberText.Text);
                updateCommand.Parameters.AddWithValue("@birthDate", candidates_BirthDateBox.Value.Date);
                updateCommand.Parameters.AddWithValue("@position", candidates_PositionBox.SelectedValue);
                updateCommand.Parameters.AddWithValue("@status", candidates_StatusBox.SelectedItem.ToString());

                try
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Candidate Updated Successfully.");
                    displayCandidatesGrid();
                    ClearCandidatesFields();
                    candidates_DataGrid.ClearSelection();
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

        private void candidates_DeleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                if (candidates_CandidateIDText.Text != "")
                {
                    connection.Open();
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM candidates WHERE `Candidate ID` = @candidateID", connection);
                    deleteCommand.Parameters.AddWithValue("@candidateID", candidates_CandidateIDText.Text);

                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Candidate Deleted Successfully.");
                        displayCandidatesGrid();
                        ClearCandidatesFields();
                        candidates_DataGrid.ClearSelection();
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
                else
                {
                    MessageBox.Show("Select a Valid Candidate to Delete.");
                    ClearCandidatesFields();
                }
            }
        }

        private void candidates_RefreshBtn_Click(object sender, EventArgs e)
        {
            displayCandidatesGrid();
            ClearCandidatesFields();
            candidates_DataGrid.ClearSelection();
        }

        private void candidates_SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = candidates_SearchText.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Search Field is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT c.`Candidate ID`, c.`First Name`, c.`Last Name`, c.`Gender`, c.`Email`, c.`Phone Number`, c.`Birth Date`, p.`Position`, c.`Status` FROM candidates c JOIN position p ON c.`Position` = p.`Position ID` WHERE CONCAT(c.`First Name`, ' ', c.`Last Name`) OR CONCAT(c.`Candidate ID`) LIKE @searchText", connection);
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    candidates_DataGrid.DataSource = dt;
                    candidates_DataGrid.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Results Found.");
                    displayCandidatesGrid();
                    candidates_DataGrid.ClearSelection();
                    candidates_SearchText.Focus();
                }
                candidates_SearchText.Text = "";
            }
        }

        private void candidates_SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                candidates_SearchBtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Display Election Grid

        public void displayElectionGrid()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand displayCommand = new MySqlCommand("SELECT e.`Election ID`, CONCAT(v.`Last Name`, ', ', v.`First Name`) AS `Voter`, CONCAT(c.`Last Name`, ', ', c.`First Name`) AS `Candidate`, p.`Position` AS `Position`, e.`Date Voted` FROM election e JOIN voters v ON e.`Voter` = v.`Voters ID` JOIN candidates c ON e.`Candidate` = c.`Candidate ID` JOIN position p ON e.`Position` = p.`Position ID`", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(displayCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                election_DataGrid.DataSource = dt;
            }
        }

        private void election_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                election_ElectionIDText.Text = Convert.ToInt32(election_DataGrid.Rows[e.RowIndex].Cells["Election ID"].Value).ToString();
                election_VoterBox.SelectedIndex = election_VoterBox.FindStringExact(election_DataGrid.Rows[e.RowIndex].Cells["Voter"].Value.ToString());
                election_CandidateBox.SelectedIndex = election_CandidateBox.FindStringExact(election_DataGrid.Rows[e.RowIndex].Cells["Candidate"].Value.ToString());
                election_PositionBox.SelectedIndex = election_PositionBox.FindStringExact(election_DataGrid.Rows[e.RowIndex].Cells["Position"].Value.ToString());
                election_DateVotedBox.Value = Convert.ToDateTime(election_DataGrid.Rows[e.RowIndex].Cells["Date Voted"].Value.ToString());
            }
        }

        // Config Election

        public void ClearElectionFields()
        {
            election_ElectionIDText.Text = "";
            election_VoterBox.SelectedIndex = -1;
            election_CandidateBox.SelectedIndex = -1;
            election_PositionBox.SelectedIndex = -1;
            election_DateVotedBox.Value = DateTime.Now;
            election_DataGrid.ClearSelection();
            FillCandidateBox(election_CandidateBox, positionID);
        }

        public bool CheckElectionExist()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM election WHERE `Voter` = @voter AND `Position` = @position", connection);
                searchCommand.Parameters.AddWithValue("@voter", election_VoterBox.SelectedValue);
                searchCommand.Parameters.AddWithValue("@candidate", election_CandidateBox.SelectedValue);
                searchCommand.Parameters.AddWithValue("@position", election_PositionBox.SelectedValue);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
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

        private void election_AddBtn_Click(object sender, EventArgs e)
        {
            if (election_VoterBox.SelectedItem == null || election_CandidateBox.SelectedItem == null || election_PositionBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (CheckElectionExist())
            {
                MessageBox.Show("Vote Already Exist");
                ClearElectionFields();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand addCommand = new MySqlCommand("INSERT INTO election (`Voter`, `Candidate`, `Position`, `Date Voted`) VALUES (@voter, @candidate, @position, @dateVoted)", connection);
                addCommand.Parameters.AddWithValue("@voter", election_VoterBox.SelectedValue);
                addCommand.Parameters.AddWithValue("@candidate", election_CandidateBox.SelectedValue);
                addCommand.Parameters.AddWithValue("@position", election_PositionBox.SelectedValue);
                addCommand.Parameters.AddWithValue("@dateVoted", election_DateVotedBox.Value.Date);
                try
                {
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("Vote Added Successfully.");
                    displayElectionGrid();
                    ClearElectionFields();
                    election_DataGrid.ClearSelection();
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

        private void election_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (election_VoterBox.SelectedItem == null || election_CandidateBox.SelectedItem == null || election_PositionBox.SelectedItem == null)
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE election SET `Voter` = @voter, `Candidate` = @candidate, `Position` = @position WHERE `Election ID` = @electionID", connection);
                updateCommand.Parameters.AddWithValue("@electionID", election_ElectionIDText.Text);
                updateCommand.Parameters.AddWithValue("@voter", election_VoterBox.SelectedValue);
                updateCommand.Parameters.AddWithValue("@candidate", election_CandidateBox.SelectedValue);
                updateCommand.Parameters.AddWithValue("@position", election_PositionBox.SelectedValue);
                try
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Vote Updated Successfully.");
                    displayElectionGrid();
                    ClearElectionFields();
                    election_DataGrid.ClearSelection();
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

        private void election_DeleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                if (election_ElectionIDText.Text != "")
                {
                    connection.Open();
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM election WHERE `Election ID` = @electionID", connection);
                    deleteCommand.Parameters.AddWithValue("@electionID", election_ElectionIDText.Text);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Vote Deleted Successfully.");
                        displayElectionGrid();
                        ClearElectionFields();
                        election_DataGrid.ClearSelection();
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
                else
                {
                    MessageBox.Show("Select a Valid Vote to Delete.");
                    ClearElectionFields();
                }
            }
        }

        private void election_RefreshBtn_Click(object sender, EventArgs e)
        {
            displayElectionGrid();
            ClearElectionFields();
            FillCandidateBox(election_CandidateBox, positionID);
            election_DataGrid.ClearSelection();
        }

        private void election_SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = election_SearchText.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Search Field is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT e.`Election ID`, CONCAT(v.`Last Name`, ', ', v.`First Name`) AS `Voter`, CONCAT(c.`Last Name`, ', ', c.`First Name`) AS `Candidate`, p.`Position` AS `Position`, e.`Date Voted` FROM election e JOIN voters v ON e.`Voter` = v.`Voters ID` JOIN candidates c ON e.`Candidate` = c.`Candidate ID` JOIN position p ON e.`Position` = p.`Position ID` WHERE CONCAT(v.`First Name`, ' ', v.`Last Name`) LIKE @searchText OR CONCAT(c.`First Name`, ' ', c.`Last Name`) LIKE @searchText OR CONCAT(e.`Election ID`) LIKE @searchText", connection);
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    election_DataGrid.DataSource = dt;
                    election_DataGrid.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Results Found.");
                    displayElectionGrid();
                    election_DataGrid.ClearSelection();
                    election_SearchText.Focus();
                }
                election_SearchText.Text = "";
            }
        }

        private void election_SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                election_SearchBtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Display Position Grid

        public void displayPositionGrid()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand displayCommand = new MySqlCommand("SELECT `Position ID`, `Position` FROM position", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(displayCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                position_DataGrid.DataSource = dt;
            }
        }

        private void position_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                position_PositionIDText.Text = Convert.ToInt32(position_DataGrid.Rows[e.RowIndex].Cells["Position ID"].Value).ToString();
                position_PositionText.Text = position_DataGrid.Rows[e.RowIndex].Cells["Position"].Value.ToString();
            }
        }

        // Config Position

        public void ClearPositionFields()
        {
            position_PositionIDText.Text = "";
            position_PositionText.Text = "";
            position_DataGrid.ClearSelection();
        }

        public bool CheckPositionExist()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM position WHERE `Position` = @position", connection);
                searchCommand.Parameters.AddWithValue("@position", position_PositionText.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
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

        private void position_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(position_PositionText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (CheckPositionExist())
            {
                MessageBox.Show("Position Already Exist");
                ClearPositionFields();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand addCommand = new MySqlCommand("INSERT INTO position (`Position`) VALUES (@position)", connection);
                addCommand.Parameters.AddWithValue("@position", position_PositionText.Text);
                try
                {
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("Position Added Successfully.");
                    displayPositionGrid();
                    ClearPositionFields();
                    position_DataGrid.ClearSelection();
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

        private void position_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(position_PositionText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE position SET `Position` = @position WHERE `Position ID` = @positionID", connection);
                updateCommand.Parameters.AddWithValue("@positionID", position_PositionIDText.Text);
                updateCommand.Parameters.AddWithValue("@position", position_PositionText.Text);
                try
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Position Updated Successfully.");
                    displayPositionGrid();
                    ClearPositionFields();
                    position_DataGrid.ClearSelection();
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

        private void position_DeleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                if (position_PositionIDText.Text != "")
                {
                    connection.Open();
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM position WHERE `Position ID` = @positionID", connection);
                    deleteCommand.Parameters.AddWithValue("@positionID", position_PositionIDText.Text);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Position Deleted Successfully.");
                        displayPositionGrid();
                        ClearPositionFields();
                        position_DataGrid.ClearSelection();
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
                else
                {
                    MessageBox.Show("Select a Valid Position to Delete.");
                    ClearPositionFields();
                }
            }
        }

        private void position_RefreshBtn_Click(object sender, EventArgs e)
        {
            displayPositionGrid();
            ClearPositionFields();
            position_DataGrid.ClearSelection();
        }

        private void position_SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = position_SearchText.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Search Field is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT `Position ID`, `Position` FROM position WHERE CONCAT(`Position`) LIKE @searchText OR CONCAT(`Position ID`) LIKE @searchText", connection);
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    position_DataGrid.DataSource = dt;
                    position_DataGrid.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Results Found.");
                    displayPositionGrid();
                    position_DataGrid.ClearSelection();
                    position_SearchText.Focus();
                }
                position_SearchText.Text = "";
            }
        }

        private void position_SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                position_SearchBtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Display Voters Grid

        public void displayVotersGrid()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand displayCommand = new MySqlCommand("SELECT `Voters ID`, `First Name`, `Last Name`, `Email`, `Phone Number` FROM voters", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(displayCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                voters_DataGrid.DataSource = dt;
            }
        }

        private void voters_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                voters_VotersIDText.Text = Convert.ToInt32(voters_DataGrid.Rows[e.RowIndex].Cells["Voters ID"].Value).ToString();
                voters_FirstNameText.Text = voters_DataGrid.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
                voters_LastNameText.Text = voters_DataGrid.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
                voters_EmailText.Text = voters_DataGrid.Rows[e.RowIndex].Cells["Email"].Value.ToString();
                voters_PhoneNumberText.Text = voters_DataGrid.Rows[e.RowIndex].Cells["Phone Number"].Value.ToString();
            }
        }

        // Config Voters

        public void ClearVotersFields()
        {
            voters_VotersIDText.Text = "";
            voters_FirstNameText.Text = "";
            voters_LastNameText.Text = "";
            voters_EmailText.Text = "";
            voters_PhoneNumberText.Text = "";
            voters_DataGrid.ClearSelection();
        }

        public bool CheckVoterExist()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM voters WHERE `First Name` = @firstName AND `Last Name` = @lastName", connection);
                searchCommand.Parameters.AddWithValue("@firstName", voters_FirstNameText.Text);
                searchCommand.Parameters.AddWithValue("@lastName", voters_LastNameText.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
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

        private void voters_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(voters_FirstNameText.Text) || string.IsNullOrWhiteSpace(voters_LastNameText.Text) || string.IsNullOrWhiteSpace(voters_EmailText.Text) || string.IsNullOrWhiteSpace(voters_PhoneNumberText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (CheckVoterExist())
            {
                MessageBox.Show("Voter Already Exist");
                ClearVotersFields();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand addCommand = new MySqlCommand("INSERT INTO voters (`First Name`, `Last Name`, `Email`, `Phone Number`) VALUES (@firstName, @lastName, @email, @phoneNumber)", connection);
                addCommand.Parameters.AddWithValue("@firstName", voters_FirstNameText.Text);
                addCommand.Parameters.AddWithValue("@lastName", voters_LastNameText.Text);
                addCommand.Parameters.AddWithValue("@email", voters_EmailText.Text);
                addCommand.Parameters.AddWithValue("@phoneNumber", voters_PhoneNumberText.Text);
                try
                {
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("Voter Added Successfully.");
                    displayVotersGrid();
                    ClearVotersFields();
                    voters_DataGrid.ClearSelection();
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

        private void voters_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(voters_FirstNameText.Text) || string.IsNullOrWhiteSpace(voters_LastNameText.Text) || string.IsNullOrWhiteSpace(voters_EmailText.Text) || string.IsNullOrWhiteSpace(voters_PhoneNumberText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE voters SET `First Name` = @firstName, `Last Name` = @lastName, `Email` = @email, `Phone Number` = @phoneNumber WHERE `Voters ID` = @voterID", connection);
                updateCommand.Parameters.AddWithValue("@voterID", voters_VotersIDText.Text);
                updateCommand.Parameters.AddWithValue("@firstName", voters_FirstNameText.Text);
                updateCommand.Parameters.AddWithValue("@lastName", voters_LastNameText.Text);
                updateCommand.Parameters.AddWithValue("@email", voters_EmailText.Text);
                updateCommand.Parameters.AddWithValue("@phoneNumber", voters_PhoneNumberText.Text);
                try
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("Voter Updated Successfully.");
                    displayVotersGrid();
                    ClearVotersFields();
                    voters_DataGrid.ClearSelection();
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

        private void voters_DeleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                if (voters_VotersIDText.Text != "")
                {
                    connection.Open();
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM voters WHERE `Voters ID` = @voterID", connection);
                    deleteCommand.Parameters.AddWithValue("@voterID", voters_VotersIDText.Text);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("Voter Deleted Successfully.");
                        displayVotersGrid();
                        ClearVotersFields();
                        voters_DataGrid.ClearSelection();
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
                else
                {
                    MessageBox.Show("Select a Valid Voter to Delete.");
                    ClearVotersFields();
                }
            }
        }

        private void voters_RefreshBtn_Click(object sender, EventArgs e)
        {
            displayVotersGrid();
            ClearVotersFields();
            voters_DataGrid.ClearSelection();
        }

        private void voters_SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = voters_SearchText.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Search Field is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT `Voters ID`, `First Name`, `Last Name`, `Email`, `Phone Number` FROM voters WHERE CONCAT(`First Name`, ' ', `Last Name`) LIKE @searchText OR CONCAT(`Voters ID`) LIKE @searchText", connection);
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    voters_DataGrid.DataSource = dt;
                    voters_DataGrid.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Results Found.");
                    displayVotersGrid();
                    voters_DataGrid.ClearSelection();
                    voters_SearchText.Focus();
                }
                voters_SearchText.Text = "";
            }
        }
        private void voters_SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                voters_SearchBtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        // Display Users Grid

        public void displayUsersGrid()
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand displayCommand = new MySqlCommand("SELECT `User ID`, `ID Number`, `Password`, `Permission` FROM users", connection);
                MySqlDataAdapter adapter = new MySqlDataAdapter(displayCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                users_DataGrid.DataSource = dt;
            }
        }

        private void users_DataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                users_UserIDText.Text = Convert.ToInt32(users_DataGrid.Rows[e.RowIndex].Cells["User ID"].Value).ToString();
                users_IDNumberText.Text = users_DataGrid.Rows[e.RowIndex].Cells["ID Number"].Value.ToString();
                users_PasswordText.Text = users_DataGrid.Rows[e.RowIndex].Cells["Password"].Value.ToString();
                users_PermissionBox.SelectedIndex = users_PermissionBox.FindStringExact(users_DataGrid.Rows[e.RowIndex].Cells["Permission"].Value.ToString());
            }
        }

        // Config Users
        public void ClearUsersFields()
        {
            users_UserIDText.Text = "";
            users_IDNumberText.Text = "";
            users_PasswordText.Text = "";
            users_PermissionBox.SelectedIndex = -1;
            users_DataGrid.ClearSelection();
        }

        public bool CheckUsersExist() {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users WHERE `ID Number` = @idNumber", connection);
                searchCommand.Parameters.AddWithValue("@idNumber", users_IDNumberText.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
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

        private void users_AddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(users_IDNumberText.Text) || string.IsNullOrWhiteSpace(users_PasswordText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (users_PermissionBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid Permission.");
                return;
            }
            if (CheckUsersExist())
            {
                MessageBox.Show("User Already Exist");
                ClearUsersFields();
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand addCommand = new MySqlCommand("INSERT INTO users (`ID Number`, `Password`, `Permission`) VALUES (@idNumber, @password, @permission)", connection);
                addCommand.Parameters.AddWithValue("@idNumber", users_IDNumberText.Text);
                addCommand.Parameters.AddWithValue("@password", users_PasswordText.Text);
                addCommand.Parameters.AddWithValue("@permission", users_PermissionBox.SelectedItem.ToString());
                try
                {
                    addCommand.ExecuteNonQuery();
                    MessageBox.Show("User Added Successfully.");
                    displayUsersGrid();
                    ClearUsersFields();
                    users_DataGrid.ClearSelection();
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

        private void users_UpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(users_IDNumberText.Text) || string.IsNullOrWhiteSpace(users_PasswordText.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            if (users_PermissionBox.SelectedItem == null)
            {
                MessageBox.Show("Please select a valid Permission.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET `ID Number` = @idNumber, `Password` = @password, `Permission` = @permission WHERE `User ID` = @userID", connection);
                updateCommand.Parameters.AddWithValue("@userID", users_UserIDText.Text);
                updateCommand.Parameters.AddWithValue("@idNumber", users_IDNumberText.Text);
                updateCommand.Parameters.AddWithValue("@password", users_PasswordText.Text);
                updateCommand.Parameters.AddWithValue("@permission", users_PermissionBox.SelectedItem.ToString());
                try
                {
                    updateCommand.ExecuteNonQuery();
                    MessageBox.Show("User Updated Successfully.");
                    displayUsersGrid();
                    ClearUsersFields();
                    users_DataGrid.ClearSelection();
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

        private void users_DeleteBtn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                if (users_UserIDText.Text != "")
                {
                    connection.Open();
                    MySqlCommand deleteCommand = new MySqlCommand("DELETE FROM users WHERE `User ID` = @userID", connection);
                    deleteCommand.Parameters.AddWithValue("@userID", users_UserIDText.Text);
                    try
                    {
                        deleteCommand.ExecuteNonQuery();
                        MessageBox.Show("User Deleted Successfully.");
                        displayUsersGrid();
                        ClearUsersFields();
                        users_DataGrid.ClearSelection();
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
                else
                {
                    MessageBox.Show("Select a Valid User to Delete.");
                    ClearUsersFields();
                }
            }
        }

        private void users_RefreshBtn_Click(object sender, EventArgs e)
        {
            displayUsersGrid();
            ClearUsersFields();
            users_DataGrid.ClearSelection();
        }

        private void users_SearchBtn_Click(object sender, EventArgs e)
        {
            string searchText = users_SearchText.Text;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Search Field is Empty.");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
            {
                connection.Open();
                MySqlCommand searchCommand = new MySqlCommand("SELECT `User ID`, `ID Number`, `Password`, `Permission` FROM users WHERE CONCAT(`ID Number`) LIKE @searchText OR CONCAT(`User ID`) LIKE @searchText", connection);
                searchCommand.Parameters.AddWithValue("@searchText", "%" + searchText + "%");
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    users_DataGrid.DataSource = dt;
                    users_DataGrid.ClearSelection();
                }
                else
                {
                    MessageBox.Show("No Results Found.");
                    displayUsersGrid();
                    users_DataGrid.ClearSelection();
                    users_SearchText.Focus();
                }
                users_SearchText.Text = "";
            }
        }

        private void users_SearchText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                users_SearchBtn.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
