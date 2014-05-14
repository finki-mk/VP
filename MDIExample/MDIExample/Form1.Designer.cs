namespace MDIExample
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.starFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleFormToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newFormToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newFormToolStripMenuItem
            // 
            this.newFormToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.starFormToolStripMenuItem,
            this.circleFormToolStripMenuItem});
            this.newFormToolStripMenuItem.Name = "newFormToolStripMenuItem";
            this.newFormToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.newFormToolStripMenuItem.Text = "New Form";
            // 
            // starFormToolStripMenuItem
            // 
            this.starFormToolStripMenuItem.Name = "starFormToolStripMenuItem";
            this.starFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.starFormToolStripMenuItem.Text = "Star Form";
            this.starFormToolStripMenuItem.Click += new System.EventHandler(this.starFormToolStripMenuItem_Click);
            // 
            // circleFormToolStripMenuItem
            // 
            this.circleFormToolStripMenuItem.Name = "circleFormToolStripMenuItem";
            this.circleFormToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.circleFormToolStripMenuItem.Text = "Circle Form";
            this.circleFormToolStripMenuItem.Click += new System.EventHandler(this.circleFormToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem starFormToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleFormToolStripMenuItem;

    }
}

