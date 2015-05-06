namespace Zadaca1
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddSeries = new System.Windows.Forms.Button();
            this.nudSeasons = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudRating = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProductions = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbMostSeasons = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbRatingAverage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbSeries = new System.Windows.Forms.ListBox();
            this.btnAddProduction = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddSeries);
            this.groupBox1.Controls.Add(this.nudSeasons);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudRating);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbProductions);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 235);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова серија:";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(188, 205);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 23);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Избриши серија";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnAddSeries
            // 
            this.btnAddSeries.Enabled = false;
            this.btnAddSeries.Location = new System.Drawing.Point(6, 205);
            this.btnAddSeries.Name = "btnAddSeries";
            this.btnAddSeries.Size = new System.Drawing.Size(176, 23);
            this.btnAddSeries.TabIndex = 4;
            this.btnAddSeries.Text = "Додади серија";
            this.btnAddSeries.UseVisualStyleBackColor = true;
            this.btnAddSeries.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // nudSeasons
            // 
            this.nudSeasons.Location = new System.Drawing.Point(6, 169);
            this.nudSeasons.Name = "nudSeasons";
            this.nudSeasons.Size = new System.Drawing.Size(120, 20);
            this.nudSeasons.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Број на сезони:";
            // 
            // nudRating
            // 
            this.nudRating.DecimalPlaces = 1;
            this.nudRating.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudRating.Location = new System.Drawing.Point(6, 125);
            this.nudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudRating.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudRating.Name = "nudRating";
            this.nudRating.Size = new System.Drawing.Size(120, 20);
            this.nudRating.TabIndex = 2;
            this.nudRating.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Рејтинг:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(6, 81);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(305, 20);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име:";
            // 
            // cbProductions
            // 
            this.cbProductions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProductions.FormattingEnabled = true;
            this.cbProductions.Location = new System.Drawing.Point(6, 36);
            this.cbProductions.MaxDropDownItems = 20;
            this.cbProductions.Name = "cbProductions";
            this.cbProductions.Size = new System.Drawing.Size(305, 21);
            this.cbProductions.TabIndex = 0;
            this.cbProductions.SelectedIndexChanged += new System.EventHandler(this.cbProductions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Продукција:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbMostSeasons);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbRatingAverage);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.lbSeries);
            this.groupBox3.Location = new System.Drawing.Point(337, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 333);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Листа на серии:";
            // 
            // tbMostSeasons
            // 
            this.tbMostSeasons.Location = new System.Drawing.Point(10, 303);
            this.tbMostSeasons.Name = "tbMostSeasons";
            this.tbMostSeasons.ReadOnly = true;
            this.tbMostSeasons.Size = new System.Drawing.Size(291, 20);
            this.tbMostSeasons.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Просечен рејтинг:";
            // 
            // tbRatingAverage
            // 
            this.tbRatingAverage.Location = new System.Drawing.Point(10, 264);
            this.tbRatingAverage.Name = "tbRatingAverage";
            this.tbRatingAverage.ReadOnly = true;
            this.tbRatingAverage.Size = new System.Drawing.Size(291, 20);
            this.tbRatingAverage.TabIndex = 1;
            this.tbRatingAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 287);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Најмногу сезони:";
            // 
            // lbSeries
            // 
            this.lbSeries.FormattingEnabled = true;
            this.lbSeries.Location = new System.Drawing.Point(7, 20);
            this.lbSeries.Name = "lbSeries";
            this.lbSeries.Size = new System.Drawing.Size(294, 212);
            this.lbSeries.TabIndex = 0;
            this.lbSeries.SelectedIndexChanged += new System.EventHandler(this.lbSeries_SelectedIndexChanged);
            // 
            // btnAddProduction
            // 
            this.btnAddProduction.Location = new System.Drawing.Point(12, 319);
            this.btnAddProduction.Name = "btnAddProduction";
            this.btnAddProduction.Size = new System.Drawing.Size(182, 23);
            this.btnAddProduction.TabIndex = 0;
            this.btnAddProduction.Text = "Додади продукција";
            this.btnAddProduction.UseVisualStyleBackColor = true;
            this.btnAddProduction.Click += new System.EventHandler(this.btnAddProduction_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddSeries;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 354);
            this.Controls.Add(this.btnAddProduction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "ТВ Серии";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSeasons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRating)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudSeasons;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProductions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddSeries;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbMostSeasons;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbRatingAverage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbSeries;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddProduction;
    }
}

