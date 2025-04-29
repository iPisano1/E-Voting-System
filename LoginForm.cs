using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace E_Voting_System
{
    public partial class LoginForm: Form
    {   
        static MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system");
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            idText_Log.Focus();
        }

        public static int CurrentUserID;
        private Boolean logSession = true;  

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logSession = false;
            idText_Reg.Text = "";
            passText_Reg.Text = "";
            loginPanel.Enabled = false;
            loginPanel.Visible = false;
            registerPanel.Enabled = true;
            registerPanel.Visible = true;
            idText_Reg.Focus();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            logSession = true;
            idText_Log.Text = "";
            passText_Log.Text = "";
            registerPanel.Enabled = false;
            registerPanel.Visible = false;
            loginPanel.Enabled = true;
            loginPanel.Visible = true;
            idText_Log.Focus();
        }

        private void registerBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idText_Reg.Text) || string.IsNullOrWhiteSpace(passText_Reg.Text)){
                MessageBox.Show("Please fill in all fields.");
                idText_Reg.Focus();
                return;
            }

            MySqlCommand InsertCommand = new MySqlCommand("INSERT INTO users(`ID Number`, Password) VALUES(@idNumber, @password)", connection);
            if (int.TryParse(idText_Reg.Text, out int idNumber)){
                InsertCommand.Parameters.AddWithValue("@idNumber", idNumber);
            }
            else {
                MessageBox.Show("Invalid ID Number.");
                idText_Reg.Text = "";
                passText_Reg.Text = "";
                idText_Reg.Focus();
                return;
            }
            InsertCommand.Parameters.AddWithValue("@password", passText_Reg.Text);

            MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users WHERE `ID Number` = @idNumber", connection);
            searchCommand.Parameters.AddWithValue("@idNumber", idNumber);

            try
            {
                connection.Open();

                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0) {
                    MessageBox.Show("Credentials Already Exist.");
                    idText_Reg.Text = "";
                    passText_Reg.Text = "";
                    idText_Reg.Focus();
                    return;
                }

                InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Successfully Registered.");
                registerPanel.Enabled = false;
                registerPanel.Visible = false;
                loginPanel.Enabled = true;
                loginPanel.Visible = true;
                idText_Log.Focus();
                logSession = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                connection.Close();
            }
        }

        private void EnterKey_Event(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                loginBtn.Focus();
                if (logSession == false)
                {
                    registerBtn_Click(sender, e);
                    idText_Reg.Focus();
                }
                else if (logSession == true)
                {
                    loginBtn_Click(sender, e);
                    idText_Log.Focus();
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(idText_Log.Text) || string.IsNullOrWhiteSpace(passText_Log.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                idText_Log.Focus();
                idText_Log.Text = "";
                passText_Log.Text = "";
                return;
            }

            MySqlCommand searchCommand = new MySqlCommand("SELECT * FROM users WHERE `ID Number` = @idNumber AND Password = @password", connection);
            if (int.TryParse(idText_Log.Text, out int idNumber))
            {
                searchCommand.Parameters.AddWithValue("@idNumber", idNumber);
            }
            else { 
                MessageBox.Show("Invalid ID Number.");
                idText_Log.Text = "";
                passText_Log.Text = "";
                idText_Log.Focus();
                return;
            }
            searchCommand.Parameters.AddWithValue("@password", passText_Log.Text);
            try
            {
                connection.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(searchCommand);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login Successful.");
                    MySqlCommand insertCommand = new MySqlCommand("UPDATE users SET is_Logged = 1 WHERE `ID Number` = @idNumber", connection);
                    insertCommand.Parameters.AddWithValue("@idNumber", idNumber);
                    insertCommand.ExecuteNonQuery();
                    CurrentUserID = idNumber;
                    idText_Log.Focus();
                    idText_Log.Text = "";
                    passText_Log.Text = "";
                    DashboardForm dashboardForm = new DashboardForm(this);
                    dashboardForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                    idText_Log.Text = "";
                    passText_Log.Text = "";
                    idText_Log.Focus();
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

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
