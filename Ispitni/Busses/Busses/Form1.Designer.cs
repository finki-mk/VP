namespace Busses
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
            this.lbBussues = new System.Windows.Forms.ListBox();
            this.lbLines = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMostExpensive = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddLine = new System.Windows.Forms.Button();
            this.btnDeleteBuss = new System.Windows.Forms.Button();
            this.btnAddBus = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автобуси";
            // 
            // lbBussues
            // 
            this.lbBussues.FormattingEnabled = true;
            this.lbBussues.Location = new System.Drawing.Point(16, 29);
            this.lbBussues.Name = "lbBussues";
            this.lbBussues.Size = new System.Drawing.Size(258, 238);
            this.lbBussues.TabIndex = 1;
            this.lbBussues.SelectedIndexChanged += new System.EventHandler(this.lbAirports_SelectedIndexChanged);
            // 
            // lbLines
            // 
            this.lbLines.FormattingEnabled = true;
            this.lbLines.Location = new System.Drawing.Point(280, 29);
            this.lbLines.Name = "lbLines";
            this.lbLines.Size = new System.Drawing.Size(292, 238);
            this.lbLines.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Линии";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbAverage);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbMostExpensive);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(280, 273);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 113);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Линии";
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Просечна цена на линиите";
            // 
            // tbMostExpensive
            // 
            this.tbMostExpensive.Location = new System.Drawing.Point(10, 36);
            this.tbMostExpensive.Name = "tbMostExpensive";
            this.tbMostExpensive.ReadOnly = true;
            this.tbMostExpensive.Size = new System.Drawing.Size(276, 20);
            this.tbMostExpensive.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Најскапа линија";
            // 
            // btnAddLine
            // 
            this.btnAddLine.Enabled = false;
            this.btnAddLine.Location = new System.Drawing.Point(16, 363);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(258, 23);
            this.btnAddLine.TabIndex = 4;
            this.btnAddLine.Text = "Додади линија";
            this.btnAddLine.UseVisualStyleBackColor = true;
            this.btnAddLine.Click += new System.EventHandler(this.btnAddDestination_Click);
            // 
            // btnDeleteBuss
            // 
            this.btnDeleteBuss.Enabled = false;
            this.btnDeleteBuss.Location = new System.Drawing.Point(16, 323);
            this.btnDeleteBuss.Name = "btnDeleteBuss";
            this.btnDeleteBuss.Size = new System.Drawing.Size(258, 23);
            this.btnDeleteBuss.TabIndex = 5;
            this.btnDeleteBuss.Text = "Избриши автобус";
            this.btnDeleteBuss.UseVisualStyleBackColor = true;
            this.btnDeleteBuss.Click += new System.EventHandler(this.btnDeleteDestination_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.Location = new System.Drawing.Point(16, 283);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(258, 23);
            this.btnAddBus.TabIndex = 7;
            this.btnAddBus.Text = "Додади автобус";
            this.btnAddBus.UseVisualStyleBackColor = true;
            this.btnAddBus.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 399);
            this.Controls.Add(this.btnDeleteBuss);
            this.Controls.Add(this.btnAddBus);
            this.Controls.Add(this.btnAddLine);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbLines);
            this.Controls.Add(this.lbBussues);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Автобуси";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbBussues;
        private System.Windows.Forms.ListBox lbLines;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDeleteBuss;
        private System.Windows.Forms.Button btnAddLine;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMostExpensive;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddBus;
    }
}

