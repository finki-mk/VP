namespace ConferencePapers
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteConference = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbYears = new System.Windows.Forms.ComboBox();
            this.btnAddConference = new System.Windows.Forms.Button();
            this.lbConferences = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteConference);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbYears);
            this.groupBox1.Controls.Add(this.btnAddConference);
            this.groupBox1.Controls.Add(this.lbConferences);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Конференции";
            // 
            // btnDeleteConference
            // 
            this.btnDeleteConference.Location = new System.Drawing.Point(7, 366);
            this.btnDeleteConference.Name = "btnDeleteConference";
            this.btnDeleteConference.Size = new System.Drawing.Size(253, 23);
            this.btnDeleteConference.TabIndex = 4;
            this.btnDeleteConference.Text = "Избриши конференција";
            this.btnDeleteConference.UseVisualStyleBackColor = true;
            this.btnDeleteConference.Click += new System.EventHandler(this.btnDeleteConference_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Година:";
            // 
            // cbYears
            // 
            this.cbYears.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYears.FormattingEnabled = true;
            this.cbYears.Location = new System.Drawing.Point(7, 309);
            this.cbYears.Name = "cbYears";
            this.cbYears.Size = new System.Drawing.Size(253, 21);
            this.cbYears.Sorted = true;
            this.cbYears.TabIndex = 2;
            this.cbYears.SelectedIndexChanged += new System.EventHandler(this.cbYears_SelectedIndexChanged);
            // 
            // btnAddConference
            // 
            this.btnAddConference.Location = new System.Drawing.Point(7, 336);
            this.btnAddConference.Name = "btnAddConference";
            this.btnAddConference.Size = new System.Drawing.Size(253, 23);
            this.btnAddConference.TabIndex = 1;
            this.btnAddConference.Text = "Додади конференција";
            this.btnAddConference.UseVisualStyleBackColor = true;
            this.btnAddConference.Click += new System.EventHandler(this.btnAddConference_Click);
            // 
            // lbConferences
            // 
            this.lbConferences.FormattingEnabled = true;
            this.lbConferences.Location = new System.Drawing.Point(7, 20);
            this.lbConferences.Name = "lbConferences";
            this.lbConferences.Size = new System.Drawing.Size(253, 264);
            this.lbConferences.TabIndex = 0;
            this.lbConferences.SelectedIndexChanged += new System.EventHandler(this.lbConferences_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 430);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Конференции";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteConference;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbYears;
        private System.Windows.Forms.Button btnAddConference;
        private System.Windows.Forms.ListBox lbConferences;
    }
}

