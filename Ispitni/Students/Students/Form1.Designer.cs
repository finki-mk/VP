namespace Students
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
            this.lbStudents = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lbDosier = new System.Windows.Forms.ListBox();
            this.nudTotal = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTopAverage = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lbStudents
            // 
            this.lbStudents.FormattingEnabled = true;
            this.lbStudents.Location = new System.Drawing.Point(13, 26);
            this.lbStudents.Name = "lbStudents";
            this.lbStudents.Size = new System.Drawing.Size(199, 342);
            this.lbStudents.TabIndex = 0;
            this.lbStudents.SelectedIndexChanged += new System.EventHandler(this.lbStudents_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на студенти";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 379);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(199, 23);
            this.btnAddStudent.TabIndex = 2;
            this.btnAddStudent.Text = "Нов студент";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(12, 409);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(199, 23);
            this.btnDeleteStudent.TabIndex = 3;
            this.btnDeleteStudent.Text = "Избриши студент";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Location = new System.Drawing.Point(218, 55);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(147, 23);
            this.btnGenerate.TabIndex = 4;
            this.btnGenerate.Text = "Генерирај досие";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lbDosier
            // 
            this.lbDosier.FormattingEnabled = true;
            this.lbDosier.Location = new System.Drawing.Point(373, 26);
            this.lbDosier.Name = "lbDosier";
            this.lbDosier.Size = new System.Drawing.Size(199, 342);
            this.lbDosier.TabIndex = 5;
            // 
            // nudTotal
            // 
            this.nudTotal.Location = new System.Drawing.Point(218, 26);
            this.nudTotal.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudTotal.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudTotal.Name = "nudTotal";
            this.nudTotal.Size = new System.Drawing.Size(147, 20);
            this.nudTotal.TabIndex = 6;
            this.nudTotal.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 379);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Просек:";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(467, 374);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(105, 20);
            this.tbAverage.TabIndex = 8;
            this.tbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Досие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Нависок просек";
            // 
            // tbTopAverage
            // 
            this.tbTopAverage.Location = new System.Drawing.Point(467, 406);
            this.tbTopAverage.Name = "tbTopAverage";
            this.tbTopAverage.ReadOnly = true;
            this.tbTopAverage.Size = new System.Drawing.Size(105, 20);
            this.tbTopAverage.TabIndex = 11;
            this.tbTopAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 441);
            this.Controls.Add(this.tbTopAverage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAverage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudTotal);
            this.Controls.Add(this.lbDosier);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbStudents);
            this.Name = "Form1";
            this.Text = "Досие студент";
            ((System.ComponentModel.ISupportInitialize)(this.nudTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbStudents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ListBox lbDosier;
        private System.Windows.Forms.NumericUpDown nudTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTopAverage;
    }
}

