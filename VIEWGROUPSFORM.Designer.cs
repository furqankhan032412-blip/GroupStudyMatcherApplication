namespace StudyMatcher
{
    partial class VIEWGROUPSFORM
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowGroups = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SUBJECT = new System.Windows.Forms.Label();
            this.SLOT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.flowGroups.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1282, 78);
            this.panel1.TabIndex = 1;
            // 
            // btnBack
            // 
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.Location = new System.Drawing.Point(24, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(120, 46);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "← BACK";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(360, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "👨🏻‍🤝‍👨🏼ALL ACTIVE CAMPUS GROUPS";
            // 
            // flowGroups
            // 
            this.flowGroups.AutoScroll = true;
            this.flowGroups.Controls.Add(this.panel2);
            this.flowGroups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowGroups.Location = new System.Drawing.Point(0, 78);
            this.flowGroups.Name = "flowGroups";
            this.flowGroups.Padding = new System.Windows.Forms.Padding(20);
            this.flowGroups.Size = new System.Drawing.Size(1282, 725);
            this.flowGroups.TabIndex = 2;
            this.flowGroups.Paint += new System.Windows.Forms.PaintEventHandler(this.flowGroups_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SUBJECT);
            this.panel2.Controls.Add(this.SLOT);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Location = new System.Drawing.Point(40, 40);
            this.panel2.Margin = new System.Windows.Forms.Padding(20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 220);
            this.panel2.TabIndex = 0;
            // 
            // SUBJECT
            // 
            this.SUBJECT.AutoSize = true;
            this.SUBJECT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SUBJECT.Location = new System.Drawing.Point(14, 64);
            this.SUBJECT.Name = "SUBJECT";
            this.SUBJECT.Size = new System.Drawing.Size(221, 25);
            this.SUBJECT.TabIndex = 2;
            this.SUBJECT.Text = "Subject: Object Oriented";
            // 
            // SLOT
            // 
            this.SLOT.AutoSize = true;
            this.SLOT.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SLOT.Location = new System.Drawing.Point(14, 114);
            this.SLOT.Name = "SLOT";
            this.SLOT.Size = new System.Drawing.Size(203, 25);
            this.SLOT.TabIndex = 3;
            this.SLOT.Text = "Slots: 02:00 PM - 04:00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "📚 OOP Exam Prep Group";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(43, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(250, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "📑 VIEW DETAIL ROOM";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // VIEWGROUPSFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudyMatcher.Properties.Resources.Gemini_Generated_Image_z1i8hkz1i8hkz1i8;
            this.ClientSize = new System.Drawing.Size(1282, 803);
            this.Controls.Add(this.flowGroups);
            this.Controls.Add(this.panel1);
            this.Name = "VIEWGROUPSFORM";
            this.Text = "VIEWGROUPSFORM";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flowGroups.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowGroups;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label SUBJECT;
        private System.Windows.Forms.Label SLOT;
    }
}