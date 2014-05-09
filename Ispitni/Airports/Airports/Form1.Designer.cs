namespace Airports
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbAirports = new System.Windows.Forms.ListBox();
            this.lbDestinations = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbLongest = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.btnAddDestination = new System.Windows.Forms.Button();
            this.btnDeleteDestination = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Аеродроми";
            // 
            // lbAirports
            // 
            this.lbAirports.FormattingEnabled = true;
            this.lbAirports.Location = new System.Drawing.Point(16, 29);
            this.lbAirports.Name = "lbAirports";
            this.lbAirports.Size = new System.Drawing.Size(258, 238);
            this.lbAirports.TabIndex = 1;
            this.lbAirports.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // lbDestinations
            // 
            this.lbDestinations.FormattingEnabled = true;
            this.lbDestinations.Location = new System.Drawing.Point(280, 29);
            this.lbDestinations.Name = "lbDestinations";
            this.lbDestinations.Size = new System.Drawing.Size(292, 238);
            this.lbDestinations.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Дестинации";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAverage);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbLongest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(280, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дестинации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Најскапа дестинација";
            // 
            // tbLongest
            // 
            this.tbLongest.Location = new System.Drawing.Point(10, 36);
            this.tbLongest.Name = "tbLongest";
            this.tbLongest.ReadOnly = true;
            this.tbLongest.Size = new System.Drawing.Size(276, 20);
            this.tbLongest.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Просечна должина на дестинациите";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(10, 75);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(276, 20);
            this.tbAverage.TabIndex = 3;
            this.tbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnAddDestination
            // 
            this.btnAddDestination.Enabled = false;
            this.btnAddDestination.Location = new System.Drawing.Point(16, 363);
            this.btnAddDestination.Name = "btnAddDestination";
            this.btnAddDestination.Size = new System.Drawing.Size(258, 23);
            this.btnAddDestination.TabIndex = 4;
            this.btnAddDestination.Text = "Додади дестинација";
            this.btnAddDestination.UseVisualStyleBackColor = true;
            this.btnAddDestination.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // btnDeleteDestination
            // 
            this.btnDeleteDestination.Enabled = false;
            this.btnDeleteDestination.Location = new System.Drawing.Point(16, 323);
            this.btnDeleteDestination.Name = "btnDeleteDestination";
            this.btnDeleteDestination.Size = new System.Drawing.Size(258, 23);
            this.btnDeleteDestination.TabIndex = 5;
            this.btnDeleteDestination.Text = "Избриши аеродром";
            this.btnDeleteDestination.UseVisualStyleBackColor = true;
            this.btnDeleteDestination.Click += new System.EventHandler(this.btnDeleteDestination_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(258, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Додади аеродром";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.btnDeleteDestination);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAddDestination);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbDestinations);
            this.Controls.Add(this.lbAirports);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Аеродроми";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbAirports;
        private System.Windows.Forms.ListBox lbDestinations;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteDestination;
        private System.Windows.Forms.Button btnAddDestination;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbLongest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
    }
}

