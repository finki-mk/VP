namespace Pregled
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
            this.lbPatients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMeasures = new System.Windows.Forms.ListBox();
            this.btnAddPatient = new System.Windows.Forms.Button();
            this.btnDeletePatient = new System.Windows.Forms.Button();
            this.btnAddMeasure = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbMeasureType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMeasureValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeasureValue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPatients
            // 
            this.lbPatients.FormattingEnabled = true;
            this.lbPatients.Location = new System.Drawing.Point(13, 39);
            this.lbPatients.Name = "lbPatients";
            this.lbPatients.Size = new System.Drawing.Size(218, 381);
            this.lbPatients.TabIndex = 0;
            this.lbPatients.SelectedIndexChanged += new System.EventHandler(this.lbPatients_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пациенти:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Мерења:";
            // 
            // lbMeasures
            // 
            this.lbMeasures.FormattingEnabled = true;
            this.lbMeasures.Location = new System.Drawing.Point(273, 208);
            this.lbMeasures.Name = "lbMeasures";
            this.lbMeasures.Size = new System.Drawing.Size(307, 212);
            this.lbMeasures.TabIndex = 3;
            // 
            // btnAddPatient
            // 
            this.btnAddPatient.Location = new System.Drawing.Point(13, 427);
            this.btnAddPatient.Name = "btnAddPatient";
            this.btnAddPatient.Size = new System.Drawing.Size(218, 23);
            this.btnAddPatient.TabIndex = 4;
            this.btnAddPatient.Text = "Додади пациент";
            this.btnAddPatient.UseVisualStyleBackColor = true;
            this.btnAddPatient.Click += new System.EventHandler(this.btnAddPatient_Click);
            // 
            // btnDeletePatient
            // 
            this.btnDeletePatient.Location = new System.Drawing.Point(13, 457);
            this.btnDeletePatient.Name = "btnDeletePatient";
            this.btnDeletePatient.Size = new System.Drawing.Size(218, 23);
            this.btnDeletePatient.TabIndex = 5;
            this.btnDeletePatient.Text = "Избриши пациент";
            this.btnDeletePatient.UseVisualStyleBackColor = true;
            this.btnDeletePatient.Click += new System.EventHandler(this.btnDeletePatient_Click);
            // 
            // btnAddMeasure
            // 
            this.btnAddMeasure.Enabled = false;
            this.btnAddMeasure.Location = new System.Drawing.Point(167, 121);
            this.btnAddMeasure.Name = "btnAddMeasure";
            this.btnAddMeasure.Size = new System.Drawing.Size(134, 23);
            this.btnAddMeasure.TabIndex = 6;
            this.btnAddMeasure.Text = "Додади мерење";
            this.btnAddMeasure.UseVisualStyleBackColor = true;
            this.btnAddMeasure.Click += new System.EventHandler(this.btnAddMeasure_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudMeasureValue);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbMeasureType);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnAddMeasure);
            this.groupBox1.Location = new System.Drawing.Point(273, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 150);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади мерење";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вид на мерење";
            // 
            // cbMeasureType
            // 
            this.cbMeasureType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMeasureType.FormattingEnabled = true;
            this.cbMeasureType.Location = new System.Drawing.Point(10, 37);
            this.cbMeasureType.Name = "cbMeasureType";
            this.cbMeasureType.Size = new System.Drawing.Size(291, 21);
            this.cbMeasureType.TabIndex = 8;
            this.cbMeasureType.SelectedIndexChanged += new System.EventHandler(this.cbMeasureType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Вредност:";
            // 
            // nudMeasureValue
            // 
            this.nudMeasureValue.Location = new System.Drawing.Point(13, 82);
            this.nudMeasureValue.Name = "nudMeasureValue";
            this.nudMeasureValue.Size = new System.Drawing.Size(288, 20);
            this.nudMeasureValue.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 493);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeletePatient);
            this.Controls.Add(this.btnAddPatient);
            this.Controls.Add(this.lbMeasures);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPatients);
            this.Name = "Form1";
            this.Text = "Преглед";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMeasureValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbPatients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbMeasures;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnDeletePatient;
        private System.Windows.Forms.Button btnAddMeasure;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudMeasureValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbMeasureType;
    }
}

