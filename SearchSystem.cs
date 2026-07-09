using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb; // 🚀 MS Access Connectivity
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class SearchSystem : Form
    {
        // 💾 Database Connection String
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";

        public SearchSystem()
        {
            InitializeComponent();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
        }

        // 🚀 1. PAGE LOAD: Form khulne par chalega
        private void SearchSystem_Load(object sender, EventArgs e)
        {
            this.Text = "Advanced Search System";
            LoadAllStudents(); // Shuru mein saara data lane ke liye
        }

        // 📥 SAFE FUNCTION: Ab isme AvailableTime column bilkul sahi chalega
        private void LoadAllStudents()
        {
            string query = "SELECT FullName AS [Student Name], Email, Subject, AvailableTime AS [Available Time] FROM Users";
            ExecuteSearchQuery(query, null);
        }

        // 🔍 2. NAME SE SEARCH KARNE KA BUTTON
        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearchName.Text.Trim()))
            {
                MessageBox.Show("Please enter a name to search.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT FullName AS [Student Name], Email, Subject, AvailableTime AS [Available Time] FROM Users WHERE FullName LIKE @name";
            OleDbParameter param = new OleDbParameter("@name", "%" + txtSearchName.Text.Trim() + "%");
            ExecuteSearchQuery(query, param);
        }

        // 🔍 3. SUBJECT SE FILTER KARNE KA BUTTON
        private void btnSearchBySubject_Click(object sender, EventArgs e)
        {
            if (cmbSearchSubject.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a subject from the list to filter.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT FullName AS [Student Name], Email, Subject, AvailableTime AS [Available Time] FROM Users WHERE Subject LIKE @subject";
            OleDbParameter param = new OleDbParameter("@subject", "%" + cmbSearchSubject.SelectedItem.ToString() + "%");
            ExecuteSearchQuery(query, param);
        }

        // 🛠️ Helper Function: Jo query run karke DataGridView mein data fill karega
        private void ExecuteSearchQuery(string query, OleDbParameter parameter)
        {
            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    OleDbCommand cmd = new OleDbCommand(query, conn);

                    if (parameter != null)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // GridView ko data dena
                    dgvSearchResults.DataSource = dt;
                    dgvSearchResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database query error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // 🚀 4. BACK BUTTON
        private void btnBack_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard();
            dash.Show();
            this.Hide();
        }
    }
}