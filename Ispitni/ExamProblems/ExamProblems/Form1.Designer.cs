namespace ExamProblems
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
            this.btnDeleteExam = new System.Windows.Forms.Button();
            this.btnAddExam = new System.Windows.Forms.Button();
            this.lbExams = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.nudPoints1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescription1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nudPoints2 = new System.Windows.Forms.NumericUpDown();
            this.btnSave2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbDescription2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteExam);
            this.groupBox1.Controls.Add(this.btnAddExam);
            this.groupBox1.Controls.Add(this.lbExams);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 402);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Испити";
            // 
            // btnDeleteExam
            // 
            this.btnDeleteExam.Enabled = false;
            this.btnDeleteExam.Location = new System.Drawing.Point(7, 366);
            this.btnDeleteExam.Name = "btnDeleteExam";
            this.btnDeleteExam.Size = new System.Drawing.Size(253, 23);
            this.btnDeleteExam.TabIndex = 4;
            this.btnDeleteExam.Text = "Избриши испит";
            this.btnDeleteExam.UseVisualStyleBackColor = true;
            this.btnDeleteExam.Click += new System.EventHandler(this.btnDeleteConference_Click);
            // 
            // btnAddExam
            // 
            this.btnAddExam.Location = new System.Drawing.Point(7, 336);
            this.btnAddExam.Name = "btnAddExam";
            this.btnAddExam.Size = new System.Drawing.Size(253, 23);
            this.btnAddExam.TabIndex = 1;
            this.btnAddExam.Text = "Додади испит";
            this.btnAddExam.UseVisualStyleBackColor = true;
            this.btnAddExam.Click += new System.EventHandler(this.btnAddConference_Click);
            // 
            // lbExams
            // 
            this.lbExams.FormattingEnabled = true;
            this.lbExams.Location = new System.Drawing.Point(7, 20);
            this.lbExams.Name = "lbExams";
            this.lbExams.Size = new System.Drawing.Size(253, 303);
            this.lbExams.TabIndex = 0;
            this.lbExams.SelectedIndexChanged += new System.EventHandler(this.lbConferences_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSave1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.nudPoints1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tbDescription1);
            this.groupBox2.Location = new System.Drawing.Point(286, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(274, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Задача 1";
            // 
            // btnSave1
            // 
            this.btnSave1.Location = new System.Drawing.Point(193, 160);
            this.btnSave1.Name = "btnSave1";
            this.btnSave1.Size = new System.Drawing.Size(75, 23);
            this.btnSave1.TabIndex = 6;
            this.btnSave1.Text = "Зачувај";
            this.btnSave1.UseVisualStyleBackColor = true;
            this.btnSave1.Click += new System.EventHandler(this.btnSave1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Поени:";
            // 
            // nudPoints1
            // 
            this.nudPoints1.Location = new System.Drawing.Point(10, 129);
            this.nudPoints1.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudPoints1.Name = "nudPoints1";
            this.nudPoints1.Size = new System.Drawing.Size(120, 20);
            this.nudPoints1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Опис:";
            // 
            // tbDescription1
            // 
            this.tbDescription1.Location = new System.Drawing.Point(10, 33);
            this.tbDescription1.Multiline = true;
            this.tbDescription1.Name = "tbDescription1";
            this.tbDescription1.Size = new System.Drawing.Size(258, 75);
            this.tbDescription1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.nudPoints2);
            this.groupBox3.Controls.Add(this.btnSave2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.tbDescription2);
            this.groupBox3.Location = new System.Drawing.Point(286, 213);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(274, 189);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Задача 2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Поени:";
            // 
            // nudPoints2
            // 
            this.nudPoints2.Location = new System.Drawing.Point(10, 135);
            this.nudPoints2.Name = "nudPoints2";
            this.nudPoints2.Size = new System.Drawing.Size(120, 20);
            this.nudPoints2.TabIndex = 7;
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(193, 160);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(75, 23);
            this.btnSave2.TabIndex = 7;
            this.btnSave2.Text = "Зачувај";
            this.btnSave2.UseVisualStyleBackColor = true;
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Опис:";
            // 
            // tbDescription2
            // 
            this.tbDescription2.Location = new System.Drawing.Point(10, 33);
            this.tbDescription2.Multiline = true;
            this.tbDescription2.Name = "tbDescription2";
            this.tbDescription2.Size = new System.Drawing.Size(258, 75);
            this.tbDescription2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 430);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Испити";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPoints2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteExam;
        private System.Windows.Forms.Button btnAddExam;
        private System.Windows.Forms.ListBox lbExams;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPoints1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescription1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudPoints2;
        private System.Windows.Forms.Button btnSave2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbDescription2;
    }
}

