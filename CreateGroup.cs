using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class CreateGroup : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";

        public CreateGroup()
        {
            InitializeComponent();

            if (Controls.Find("button1", true).Length > 0)
                ((System.Windows.Forms.Button)Controls.Find("button1", true)[0]).Click += button1_Click;

            if (Controls.Find("button2", true).Length > 0)
                ((System.Windows.Forms.Button)Controls.Find("button2", true)[0]).Click += button2_Click;
        }

        private void CreateGroup_Load(object sender, EventArgs e)
        {
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string title = txtGroupTitle.Text;
            string subject = comboBox1.Text;
            string timeSlot = comboBox2.Text;
            string desc = textBox1.Text;

            if (string.IsNullOrEmpty(title) || string.IsNullOrEmpty(subject) || string.IsNullOrEmpty(timeSlot))
            {
                MessageBox.Show("Please fill all required fields.");
                return;
            }

            string query = "INSERT INTO Groups (GroupTitle, Subject, TimeSlot, Description) VALUES (?, ?, ?, ?)";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Subject", subject);
                        cmd.Parameters.AddWithValue("@TimeSlot", timeSlot);
                        cmd.Parameters.AddWithValue("@Description", desc);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Group Created Successfully!");

                    Dashboard dash = new Dashboard();
                    dash.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }
    }
}