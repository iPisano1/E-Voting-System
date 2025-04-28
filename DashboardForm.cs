using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Voting_System
{
    public partial class DashboardForm: Form
    {

        private bool isLoggingOut = false;
        private LoginForm loginForm;
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
            manageVote_Button.Focus();
            manageVote_Button.Select();
            manageVote_Button.BackColor = Color.WhiteSmoke;
            manageCandidates_Button.BackColor = Color.White;
            manageElections_Button.BackColor = Color.White;
            manageVote_Panel.Visible = true;
            manageCandidates_Panel.Visible = false;
            manageElections_Panel.Visible = false;
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
            if (mainPanelDB.Visible == true) {
                mainPanelDB.Visible = false;
            }else {
                mainPanelDB.Visible = true;
            }
        }

        private void ShowOnlyPanel(Panel panelToShow)
        {
            manageVote_Panel.Visible = false;
            manageCandidates_Panel.Visible = false;
            manageElections_Panel.Visible = false;

            panelToShow.Visible = true;
        }

        private void manageVote_Button_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(manageVote_Panel);
            manageVote_Button.BackColor = Color.WhiteSmoke;
            manageCandidates_Button.BackColor = Color.White;
            manageElections_Button.BackColor = Color.White;
        }

        private void manageCandidates_Button_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(manageCandidates_Panel);
            manageVote_Button.BackColor = Color.White;
            manageCandidates_Button.BackColor = Color.WhiteSmoke;
            manageElections_Button.BackColor = Color.White;
        }

        private void manageElections_Button_Click(object sender, EventArgs e)
        {
            ShowOnlyPanel(manageElections_Panel);
            manageVote_Button.BackColor = Color.White;
            manageCandidates_Button.BackColor = Color.White;
            manageElections_Button.BackColor = Color.WhiteSmoke;
        }
    }
}
