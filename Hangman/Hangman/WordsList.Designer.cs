namespace Hangman
{
    partial class WordsList
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
            this.components = new System.ComponentModel.Container();
            this.clbWords = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // clbWords
            // 
            this.clbWords.FormattingEnabled = true;
            this.clbWords.Items.AddRange(new object[] {
            "Argentina",
            "Australia",
            "Greenland",
            "Guatemala",
            "Indonesia",
            "Lithuania",
            "Macedonia",
            "Mauritius",
            "Nicaragua",
            "Venezuela"});
            this.clbWords.Location = new System.Drawing.Point(13, 13);
            this.clbWords.Name = "clbWords";
            this.clbWords.Size = new System.Drawing.Size(160, 229);
            this.clbWords.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.tbWord);
            this.groupBox1.Location = new System.Drawing.Point(179, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 82);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади нов збор";
            // 
            // tbWord
            // 
            this.tbWord.Location = new System.Drawing.Point(7, 20);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(152, 20);
            this.tbWord.TabIndex = 0;
            this.tbWord.Validating += new System.ComponentModel.CancelEventHandler(this.tbWord_Validating);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(7, 47);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(152, 23);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.Location = new System.Drawing.Point(180, 101);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(158, 23);
            this.btnSelectAll.TabIndex = 2;
            this.btnSelectAll.Text = "Избери ги сите";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            // 
            // WordsList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 252);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.clbWords);
            this.Name = "WordsList";
            this.Text = "Листа на зборови";
            this.Load += new System.EventHandler(this.WordsList_Load);
            this.Leave += new System.EventHandler(this.WordsList_Leave);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbWords;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnSelectAll;

    }
}