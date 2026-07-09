using System;
using System.Windows.Forms;

namespace StudyMatcher
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();

            if (Controls.Find("button1", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button1", true)[0]).Click += button1_Click;
            }

            if (Controls.Find("button2", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button2", true)[0]).Click += button2_Click;
            }

            if (Controls.Find("button3", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button3", true)[0]).Click += button3_Click;
            }

            if (Controls.Find("button4", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button4", true)[0]).Click += button4_Click;
            }

            if (Controls.Find("button5", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button5", true)[0]).Click += button5_Click;
            }

            if (Controls.Find("button6", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button6", true)[0]).Click += button6_Click;
            }

            if (Controls.Find("button7", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button7", true)[0]).Click += button7_Click;
            }

            if (Controls.Find("button8", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("button8", true)[0]).Click += button8_Click;
            }

            if (Controls.Find("btnsearch", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("btnsearch", true)[0]).Click += btnsearch_Click;
            }

            if (Controls.Find("btnhost", true).Length > 0)
            {
                ((System.Windows.Forms.Button)Controls.Find("btnhost", true)[0]).Click += btnhost_Click;
            }
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            this.Text = "Group Study Matcher - Dashboard";

            if (Controls.Find("lblWelcome", true).Length > 0)
            {
                Controls.Find("lblWelcome", true)[0].Text = "Welcome, " + LoginPage.LoggedInUserName + "!";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            profile profilePage = new profile();
            profilePage.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Match matchPage = new Match();
            matchPage.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
 
        private void button4_Click(object sender, EventArgs e)
        {
            LoginPage login = new LoginPage();
            login.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SearchSystem searchForm = new SearchSystem();
            searchForm.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            profile profilePage = new profile();
            profilePage.Show();
            this.Hide();
        }

        

        private void button8_Click(object sender, EventArgs e)
        {


        private void btnsearch_Click(object sender, EventArgs e)
 
        public void btnhost_Click(object sender, EventArgs e)
   

        private void button7_Click_1(object sender, EventArgs e)
        {
            profile profilePage = new profile();
            profilePage.Show();
            this.Hide();
        }
S

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}