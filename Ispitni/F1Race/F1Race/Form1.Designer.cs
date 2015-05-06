namespace F1Race
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
            this.btnDeleteDriver = new System.Windows.Forms.Button();
            this.btnAddDriver = new System.Windows.Forms.Button();
            this.lbDrivers = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddLap = new System.Windows.Forms.Button();
            this.nudSeconds = new System.Windows.Forms.NumericUpDown();
            this.nudMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudLimit = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbBestLap = new System.Windows.Forms.TextBox();
            this.lbLaps = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteDriver);
            this.groupBox1.Controls.Add(this.btnAddDriver);
            this.groupBox1.Controls.Add(this.lbDrivers);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 533);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Возачи";
            // 
            // btnDeleteDriver
            // 
            this.btnDeleteDriver.Enabled = false;
            this.btnDeleteDriver.Location = new System.Drawing.Point(6, 487);
            this.btnDeleteDriver.Name = "btnDeleteDriver";
            this.btnDeleteDriver.Size = new System.Drawing.Size(344, 40);
            this.btnDeleteDriver.TabIndex = 2;
            this.btnDeleteDriver.Text = "Избриши возач";
            this.btnDeleteDriver.UseVisualStyleBackColor = true;
            this.btnDeleteDriver.Click += new System.EventHandler(this.btnDeleteDriver_Click);
            // 
            // btnAddDriver
            // 
            this.btnAddDriver.Location = new System.Drawing.Point(6, 444);
            this.btnAddDriver.Name = "btnAddDriver";
            this.btnAddDriver.Size = new System.Drawing.Size(344, 40);
            this.btnAddDriver.TabIndex = 1;
            this.btnAddDriver.Text = "Додади возач";
            this.btnAddDriver.UseVisualStyleBackColor = true;
            this.btnAddDriver.Click += new System.EventHandler(this.btnAddDriver_Click);
            // 
            // lbDrivers
            // 
            this.lbDrivers.FormattingEnabled = true;
            this.lbDrivers.ItemHeight = 16;
            this.lbDrivers.Location = new System.Drawing.Point(7, 22);
            this.lbDrivers.Name = "lbDrivers";
            this.lbDrivers.Size = new System.Drawing.Size(343, 404);
            this.lbDrivers.TabIndex = 0;
            this.lbDrivers.SelectedIndexChanged += new System.EventHandler(this.lbDrivers_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnAddLap);
            this.groupBox2.Controls.Add(this.nudSeconds);
            this.groupBox2.Controls.Add(this.nudMinutes);
            this.groupBox2.Controls.Add(this.nudLimit);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbBestLap);
            this.groupBox2.Controls.Add(this.lbLaps);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 533);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кругови";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(114, 349);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "Секунди";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 349);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Минути";
            // 
            // btnAddLap
            // 
            this.btnAddLap.Enabled = false;
            this.btnAddLap.Location = new System.Drawing.Point(228, 369);
            this.btnAddLap.Name = "btnAddLap";
            this.btnAddLap.Size = new System.Drawing.Size(161, 34);
            this.btnAddLap.TabIndex = 11;
            this.btnAddLap.Text = "Додади круг";
            this.btnAddLap.UseVisualStyleBackColor = true;
            this.btnAddLap.Click += new System.EventHandler(this.btnAddLap_Click);
            // 
            // nudSeconds
            // 
            this.nudSeconds.Location = new System.Drawing.Point(117, 369);
            this.nudSeconds.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSeconds.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.nudSeconds.Name = "nudSeconds";
            this.nudSeconds.Size = new System.Drawing.Size(105, 22);
            this.nudSeconds.TabIndex = 10;
            this.nudSeconds.ValueChanged += new System.EventHandler(this.nudSeconds_ValueChanged);
            // 
            // nudMinutes
            // 
            this.nudMinutes.Location = new System.Drawing.Point(6, 369);
            this.nudMinutes.Name = "nudMinutes";
            this.nudMinutes.Size = new System.Drawing.Size(105, 22);
            this.nudMinutes.TabIndex = 9;
            // 
            // nudLimit
            // 
            this.nudLimit.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudLimit.Location = new System.Drawing.Point(6, 476);
            this.nudLimit.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLimit.Name = "nudLimit";
            this.nudLimit.Size = new System.Drawing.Size(120, 22);
            this.nudLimit.TabIndex = 8;
            this.nudLimit.ValueChanged += new System.EventHandler(this.nudLimit_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 456);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Време";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 409);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Најдобар круг";
            // 
            // tbBestLap
            // 
            this.tbBestLap.Location = new System.Drawing.Point(6, 429);
            this.tbBestLap.Name = "tbBestLap";
            this.tbBestLap.ReadOnly = true;
            this.tbBestLap.Size = new System.Drawing.Size(383, 22);
            this.tbBestLap.TabIndex = 5;
            // 
            // lbLaps
            // 
            this.lbLaps.FormattingEnabled = true;
            this.lbLaps.ItemHeight = 16;
            this.lbLaps.Location = new System.Drawing.Point(6, 22);
            this.lbLaps.Name = "lbLaps";
            this.lbLaps.Size = new System.Drawing.Size(384, 324);
            this.lbLaps.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 557);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ф1 Трка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteDriver;
        private System.Windows.Forms.Button btnAddDriver;
        private System.Windows.Forms.ListBox lbDrivers;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbBestLap;
        private System.Windows.Forms.ListBox lbLaps;
        private System.Windows.Forms.NumericUpDown nudLimit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddLap;
        private System.Windows.Forms.NumericUpDown nudSeconds;
        private System.Windows.Forms.NumericUpDown nudMinutes;
    }
}

