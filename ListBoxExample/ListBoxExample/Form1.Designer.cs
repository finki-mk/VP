namespace ListBoxExample
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
            this.clbLeft = new System.Windows.Forms.CheckedListBox();
            this.lbRight = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // clbLeft
            // 
            this.clbLeft.CheckOnClick = true;
            this.clbLeft.FormattingEnabled = true;
            this.clbLeft.Items.AddRange(new object[] {
            "One",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine"});
            this.clbLeft.Location = new System.Drawing.Point(12, 12);
            this.clbLeft.Name = "clbLeft";
            this.clbLeft.Size = new System.Drawing.Size(218, 334);
            this.clbLeft.TabIndex = 0;
            // 
            // lbRight
            // 
            this.lbRight.FormattingEnabled = true;
            this.lbRight.Location = new System.Drawing.Point(327, 12);
            this.lbRight.Name = "lbRight";
            this.lbRight.Size = new System.Drawing.Size(196, 329);
            this.lbRight.TabIndex = 1;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(236, 182);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 23);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move >>";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 360);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lbRight);
            this.Controls.Add(this.clbLeft);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbLeft;
        private System.Windows.Forms.ListBox lbRight;
        private System.Windows.Forms.Button btnMove;
    }
}

