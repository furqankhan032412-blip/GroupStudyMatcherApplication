using System;
using System.Data.OleDb; // 🚀 FIXED: MS Access ke liye OleDb library zaroori hai
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        // 🚀 1. CREATE ACCOUNT Button ka code - MS Access Database Se Connected!
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            // 1. Validation check ke koi field khali na ho
            if (string.IsNullOrEmpty(txtFullName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Please fill all fields before creating an account!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Database Connection aur Insert Query (Access ke mutabiq [Password] bracket mein hai)
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";
            string query = "INSERT INTO Users (FullName, Email, [Password], Subject) VALUES (@name, @email, @pass, @sub)";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        // Parameters matching (Access ke sequential order ke mutabiq)
                        cmd.Parameters.AddWithValue("@name", txtFullName.Text.Trim());
                        cmd.Parameters.AddWithValue("@email", txtEmail.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                        cmd.Parameters.AddWithValue("@sub", string.IsNullOrEmpty(cmbSubject.Text) ? "General" : cmbSubject.Text.Trim());

                        cmd.ExecuteNonQuery(); // Query execute karne ke liye

                        MessageBox.Show("Account Created & Saved to Database Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Wapas Login page par bhejna
                        LoginPage login = new LoginPage();
                        login.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Error while registering: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🚀 2. BACK TO LOGIN Button ka code
        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        // 🔒 AAPKE DESIGN KE MUTABIK FUNCTIONS (Bilkul touch nahi kiya, jaise the waise hi hain)
        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void txtEmail_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
        }

        private void Register_Load(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        // 🔗 Register Form Ki Link Jo Login Page Par Le Jati Hai
        private void lnkLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }
    }
}