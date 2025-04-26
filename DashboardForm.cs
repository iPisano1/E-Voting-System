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
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {

        }

        private void SetLoggedOut()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection("server=localhost;user=root;password=;database=e_voting_system"))
                {
                    connection.Open();
                    MySqlCommand updateCommand = new MySqlCommand("UPDATE users SET is_Logged = 0 WHERE `ID Number` = @idNumber", connection);
                    updateCommand.Parameters.AddWithValue("@idNumber", LoginForm.CurrentUserID);
                    updateCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

                SetLoggedOut();
            }
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes) {
                isLoggingOut = true;
                SetLoggedOut();
                this.Close();
            }
        }
    }
}
