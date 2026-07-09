using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // 🚀 MS Access DB connectivity ke liye
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class profile : Form
    {
        // 💾 Aapka Database Connection String
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";

        // Logged in user tracking ke liye variables
        private string currentUserName = "";

        public profile()
        {
            InitializeComponent();
        }

        // 🚀 1. PAGE LOAD: Jaise hi Profile khulegi, Signup wala asli data load hoga
        private void profile_Load(object sender, EventArgs e)
        {
            this.Text = "Group Study Matcher - Profile";

            // Shuru mein saare textboxes ko lock (Read-Only) rakhna hai
            SetFieldsReadOnly(true);

            // LoginPage ke global variable se login user ka naam lena
            currentUserName = LoginPage.LoggedInUserName;

            // Agar user logged in hai, toh database se data nikalna
            if (!string.IsNullOrEmpty(currentUserName))
            {
                string query = "SELECT FullName, Email, [Password], Subject FROM Users WHERE FullName = @name";

                using (OleDbConnection conn = new OleDbConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        OleDbCommand cmd = new OleDbCommand(query, conn);
                        cmd.Parameters.AddWithValue("@name", currentUserName);

                        OleDbDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Naye explicit properties ke mutabiq data load karna
                            txtProfileName.Text = reader["FullName"].ToString();
                            txtProfileEmail.Text = reader["Email"].ToString();
                            txtProfilePass.Text = reader["Password"].ToString();
                            txtProfileSubject.Text = reader["Subject"].ToString();

                            // Password field ko hidden dots mein show karna
                            txtProfilePass.UseSystemPasswordChar = true;
                        }
                        else
                        {
                            // Agar khuda-na-khwasta record na mile toh backup ke liye login name likh dena
                            txtProfileName.Text = currentUserName;
                        }
                        reader.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Database se profile load karne mein masla aaya: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("No logged-in user detected! Please login again.", "Session Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            // PictureBox layout ko smooth clean look dena
            if (pictureBox1 != null)
            {
                pictureBox1.BorderStyle = BorderStyle.FixedSingle;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }


        }

        // 🚀 2. EDIT PROFILE BUTTON (button1): Isko dabane se textboxes unlock honge
        private void button1_Click(object sender, EventArgs e)
        {
            SetFieldsReadOnly(false); // Fields Editable ho gayin
            txtProfileName.Focus();   // First field par cursor le jana
            MessageBox.Show("Fields are now unlocked! You can update your information and then click 'Save'.", "Edit Mode Active", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // 🚀 3. SAVE BUTTON (button3): Isko dabane se data safe hoga aur wapas lock ho jayega
        private void button3_Click(object sender, EventArgs e)
        {
            // Input Validation check karna ke koi field khali na ho
            if (string.IsNullOrEmpty(txtProfileName.Text) || string.IsNullOrEmpty(txtProfileEmail.Text) || string.IsNullOrEmpty(txtProfilePass.Text))
            {
                MessageBox.Show("Please fill all the required fields before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Access Database Update Query
            string updateQuery = "UPDATE Users SET FullName = @newname, Email = @email, [Password] = @pass, Subject = @sub WHERE FullName = @oldname";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(updateQuery, conn);
                    cmd.Parameters.AddWithValue("@newname", txtProfileName.Text.Trim());
                    cmd.Parameters.AddWithValue("@email", txtProfileEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtProfilePass.Text.Trim());
                    cmd.Parameters.AddWithValue("@sub", txtProfileSubject.Text.Trim());
                    cmd.Parameters.AddWithValue("@oldname", currentUserName); // Taki purani row updates ho sakein

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Your profile has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Data save karne ke baad wapas read-only lock laga dena
                    SetFieldsReadOnly(true);

                    // Global sessions ko bhi naye naam ke sath update kar dena
                    LoginPage.LoggedInUserName = txtProfileName.Text.Trim();
                    currentUserName = txtProfileName.Text.Trim();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Profile save karne mein error aaya: " + ex.Message, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🚀 4. BACK BUTTON EVENT (button2): Dashboard par wapas bhejna
        private void button2_Click(object sender, EventArgs e)
        {
            profile profilePage = new profile();
            profilePage.Show();
            this.Hide();
        }


        // 🚀 5. PHOTO UPLOAD CLICK LOGIC
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                ofd.Title = "Select Profile Picture";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    if (pictureBox1 != null)
                    {
                        pictureBox1.ImageLocation = ofd.FileName;
                    }
                }
            }
        }
    }
}