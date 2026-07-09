using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace StudyMatcher
{
    public partial class LoginPage : Form
    {
        public static string LoggedInUserName = "User";

        public LoginPage()
        {
            InitializeComponent();
            this.AcceptButton = this.btnLogin;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string userEmail = txtEmail.Text;
            string userPass = txtPassword.Text;

            if (string.IsNullOrEmpty(userEmail) || string.IsNullOrEmpty(userPass))
            {
                MessageBox.Show("Please enter both Email and Password!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";
            string query = "SELECT COUNT(*) FROM Users WHERE Email = @email AND [Password] = @pass";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", userEmail);
                        cmd.Parameters.AddWithValue("@pass", userPass);

                        int count = Convert.ToInt32(cmd.ExecuteScalar());

                        if (count > 0)
                        {
                            try
                            {
                                string rawName = userEmail.Split('@')[0];
                                LoggedInUserName = char.ToUpper(rawName[0]) + rawName.Substring(1);
                            }
                            catch { LoggedInUserName = "User"; }


                            MessageBox.Show("Login Successful! Welcome to Group Study Matcher.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Dashboard dash = new Dashboard();
                            dash.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Email or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.Show();
            this.Hide();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {
            this.Text = "Group Study Matcher - Login";
        }

        private void label4_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register registerPage = new Register();
            registerPage.Show();
            this.Hide();
        }
    }
}