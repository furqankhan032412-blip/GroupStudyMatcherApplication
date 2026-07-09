using System;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class VIEWGROUPSFORM : Form
    {
        private string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=StudyMatcherDB.accdb;";

        public VIEWGROUPSFORM()
        {
            InitializeComponent();
        }

        private void VIEWGROUPSFORM_Load(object sender, EventArgs e)
        {
            LoadActiveGroups();
        }

        private void LoadActiveGroups()
        {
            flowGroups.Controls.Clear();
            string query = "SELECT GroupID, GroupTitle, Subject, TimeSlot, Description FROM Groups";

            using (OleDbConnection conn = new OleDbConnection(connString))
            {
                try
                {
                    conn.Open();
                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int groupId = Convert.ToInt32(reader["GroupID"]);
                                string title = reader["GroupTitle"].ToString();
                                string subject = reader["Subject"].ToString();
                                string time = reader["TimeSlot"].ToString();

                                Label lblTitle = new Label { Text = title, Font = new Font("Arial", 10, FontStyle.Bold), Location = new Point(10, 10), AutoSize = true };
                                Label lblSub = new Label { Text = "Subject: " + subject, Location = new Point(10, 40), AutoSize = true };
                                Label lblTime = new Label { Text = "Slots: " + time, Location = new Point(10, 70), AutoSize = true };

                                Button btnDetail = new Button
                                {
                                    Text = "VIEW DETAIL ROOM",
                                    Size = new Size(160, 30),
                                    Location = new Point(10, 110),
                                    BackColor = Color.LightGray,
                                    FlatStyle = FlatStyle.Flat
                                };

                                btnDetail.Click += (s, args) =>
                                {
                                    DetailsForm df = new DetailsForm(groupId);
                                    df.Show();
                                    this.Hide();
                                };

                                card.Controls.Add(lblTitle);
                                card.Controls.Add(lblSub);
                                card.Controls.Add(lblTime);
                                card.Controls.Add(btnDetail);

                                flowGroups.Controls.Add(card);
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

        }

        private void flowGroups_Paint(object sender, PaintEventArgs e)
        { 
        }
    }
} 