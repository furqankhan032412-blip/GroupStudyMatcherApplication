using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class AdminDashboardForm : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";

        public AdminDashboardForm()
        {
            InitializeComponent();

            if (Controls.Find("button1", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button1", true)[0]).Click += btnBack_Click;
            }
            else if (Controls.Find("btnBack", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("btnBack", true)[0]).Click += btnBack_Click;
            }
        }

        private void AdminDashboardForm_Load(object sender, EventArgs e)
        {
            LoadAdminStats();
            LoadGridData();
        }

        private void LoadAdminStats()
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();

                    string qUsers = "SELECT COUNT(*) FROM Users";
                    using (OleDbCommand cmd = new OleDbCommand(qUsers, conn))
                    {
                        int users = Convert.ToInt32(cmd.ExecuteScalar());
                        if (Controls.Find("lblTotalUsers", true).Length > 0)
                        {
                            Controls.Find("lblTotalUsers", true)[0].Text = users.ToString();
                        }
                    }

                    string qGroups = "SELECT COUNT(*) FROM Groups";
                    using (OleDbCommand cmd = new OleDbCommand(qGroups, conn))
                    {
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void LoadGridData()
        {
            string query = "SELECT GroupID, GroupTitle, Subject, TimeSlot FROM Groups";
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (Controls.Find("dataGridView1", true).Length > 0)
                        {
                            DataGridView dgv = (DataGridView)Controls.Find("dataGridView1", true)[0];
                            dgv.DataSource = dt;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAdminStats();
            LoadGridData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
  
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}