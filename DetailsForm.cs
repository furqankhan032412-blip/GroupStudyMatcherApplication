using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class DetailsForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";
        private int currentGroupId;

        public DetailsForm(int groupId)
        {
            InitializeComponent();
            this.currentGroupId = groupId;
        }

        public DetailsForm()
        {
            InitializeComponent();
            this.currentGroupId = 1;
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            FetchGroupDetails();
        }

        private void FetchGroupDetails()
        {
            string query = "SELECT GroupTitle, Subject, TimeSlot, Description FROM Groups WHERE GroupID = ?";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@GroupID", currentGroupId);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                textBox1.Text = reader["GroupTitle"].ToString();
                                txtSubject.Text = reader["Subject"].ToString();
                                txtTimeSlot.Text = reader["TimeSlot"].ToString();
                                txtDescription.Text = reader["Description"].ToString();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Successfully Joined the Group!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIEWGROUPSFORM vg = new VIEWGROUPSFORM();
            vg.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtSemester_TextChanged(object sender, EventArgs e)
        {
        }
    }
}