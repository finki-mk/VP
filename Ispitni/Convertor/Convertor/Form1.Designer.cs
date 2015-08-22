namespace Convertor
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
            this.lblConvertors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudFrom = new System.Windows.Forms.NumericUpDown();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.nudTo = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConvertors
            // 
            this.lblConvertors.FormattingEnabled = true;
            this.lblConvertors.ItemHeight = 16;
            this.lblConvertors.Location = new System.Drawing.Point(15, 29);
            this.lblConvertors.Name = "lblConvertors";
            this.lblConvertors.Size = new System.Drawing.Size(182, 324);
            this.lblConvertors.TabIndex = 0;
            this.lblConvertors.SelectedIndexChanged += new System.EventHandler(this.lblConvertors_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Коневертори";
            // 
            // nudFrom
            // 
            this.nudFrom.DecimalPlaces = 3;
            this.nudFrom.Enabled = false;
            this.nudFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudFrom.Location = new System.Drawing.Point(209, 61);
            this.nudFrom.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nudFrom.Name = "nudFrom";
            this.nudFrom.Size = new System.Drawing.Size(239, 38);
            this.nudFrom.TabIndex = 2;
            this.nudFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudFrom.ValueChanged += new System.EventHandler(this.nudFrom_ValueChanged);
            // 
            // lblFrom
            // 
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFrom.Location = new System.Drawing.Point(204, 29);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(244, 29);
            this.lblFrom.TabIndex = 3;
            this.lblFrom.Text = "FROM";
            this.lblFrom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTo
            // 
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTo.Location = new System.Drawing.Point(204, 102);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(244, 29);
            this.lblTo.TabIndex = 5;
            this.lblTo.Text = "TO";
            this.lblTo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // nudTo
            // 
            this.nudTo.DecimalPlaces = 3;
            this.nudTo.Enabled = false;
            this.nudTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudTo.Location = new System.Drawing.Point(209, 134);
            this.nudTo.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nudTo.Name = "nudTo";
            this.nudTo.Size = new System.Drawing.Size(239, 38);
            this.nudTo.TabIndex = 4;
            this.nudTo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudTo.ValueChanged += new System.EventHandler(this.nudTo_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(182, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(13, 397);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(182, 32);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Избриши";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 431);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.nudTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.nudFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblConvertors);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lblConvertors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudFrom;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.NumericUpDown nudTo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
    }
}

