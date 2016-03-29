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
            this.btnAddProgram = new System.Windows.Forms.Button();
            this.nudDuration = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTVS = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.lbProgram = new System.Windows.Forms.ListBox();
            this.btnAddProduction = new System.Windows.Forms.Button();
            this.lblTV = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAddProgram);
            this.groupBox1.Controls.Add(this.nudDuration);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbTVS);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(17, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(423, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нова програма";
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(251, 252);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(164, 28);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Избриши програма";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // btnAddProgram
            // 
            this.btnAddProgram.Enabled = false;
            this.btnAddProgram.Location = new System.Drawing.Point(8, 252);
            this.btnAddProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProgram.Name = "btnAddProgram";
            this.btnAddProgram.Size = new System.Drawing.Size(235, 28);
            this.btnAddProgram.TabIndex = 4;
            this.btnAddProgram.Text = "Додади програма";
            this.btnAddProgram.UseVisualStyleBackColor = true;
            this.btnAddProgram.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // nudDuration
            // 
            this.nudDuration.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudDuration.Location = new System.Drawing.Point(8, 154);
            this.nudDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nudDuration.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudDuration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudDuration.Name = "nudDuration";
            this.nudDuration.Size = new System.Drawing.Size(160, 22);
            this.nudDuration.TabIndex = 2;
            this.nudDuration.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 128);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Времетраење (мин):";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(8, 100);
            this.tbName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(405, 22);
            this.tbName.TabIndex = 1;
            this.tbName.TextChanged += new System.EventHandler(this.tbName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Име:";
            // 
            // cbTVS
            // 
            this.cbTVS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTVS.FormattingEnabled = true;
            this.cbTVS.Location = new System.Drawing.Point(8, 44);
            this.cbTVS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbTVS.MaxDropDownItems = 20;
            this.cbTVS.Name = "cbTVS";
            this.cbTVS.Size = new System.Drawing.Size(405, 24);
            this.cbTVS.TabIndex = 0;
            this.cbTVS.SelectedIndexChanged += new System.EventHandler(this.cbProductions_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Телевизија:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTV);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbAverage);
            this.groupBox3.Controls.Add(this.lbProgram);
            this.groupBox3.Location = new System.Drawing.Point(449, 16);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(409, 410);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Програма на ТВ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 360);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(184, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Просечно времетрањење:";
            // 
            // tbAverage
            // 
            this.tbAverage.Location = new System.Drawing.Point(9, 380);
            this.tbAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.ReadOnly = true;
            this.tbAverage.Size = new System.Drawing.Size(387, 22);
            this.tbAverage.TabIndex = 1;
            this.tbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbProgram
            // 
            this.lbProgram.FormattingEnabled = true;
            this.lbProgram.ItemHeight = 16;
            this.lbProgram.Location = new System.Drawing.Point(8, 80);
            this.lbProgram.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbProgram.Name = "lbProgram";
            this.lbProgram.Size = new System.Drawing.Size(391, 260);
            this.lbProgram.TabIndex = 0;
            this.lbProgram.SelectedIndexChanged += new System.EventHandler(this.lbSeries_SelectedIndexChanged);
            // 
            // btnAddProduction
            // 
            this.btnAddProduction.Location = new System.Drawing.Point(16, 393);
            this.btnAddProduction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAddProduction.Name = "btnAddProduction";
            this.btnAddProduction.Size = new System.Drawing.Size(243, 28);
            this.btnAddProduction.TabIndex = 0;
            this.btnAddProduction.Text = "Додади ТВ";
            this.btnAddProduction.UseVisualStyleBackColor = true;
            this.btnAddProduction.Click += new System.EventHandler(this.btnAddProduction_Click);
            // 
            // lblTV
            // 
            this.lblTV.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTV.Location = new System.Drawing.Point(9, 25);
            this.lblTV.Name = "lblTV";
            this.lblTV.Size = new System.Drawing.Size(387, 43);
            this.lblTV.TabIndex = 7;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnAddProgram;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 436);
            this.Controls.Add(this.btnAddProduction);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "ТВ Серии";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudDuration)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudDuration;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTVS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddProgram;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.ListBox lbProgram;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAddProduction;
        private System.Windows.Forms.Label lblTV;
    }
}

