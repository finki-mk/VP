namespace Airports
{
    partial class NewAirport
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDeleteAirport = new System.Windows.Forms.Button();
            this.tbShort = new System.Windows.Forms.TextBox();
            this.btnSaveAiroport = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAirport);
            this.groupBox1.Controls.Add(this.tbShort);
            this.groupBox1.Controls.Add(this.btnSaveAiroport);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbCity);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(258, 177);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Додади аеродром";
            // 
            // btnDeleteAirport
            // 
            this.btnDeleteAirport.CausesValidation = false;
            this.btnDeleteAirport.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnDeleteAirport.Location = new System.Drawing.Point(132, 148);
            this.btnDeleteAirport.Name = "btnDeleteAirport";
            this.btnDeleteAirport.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteAirport.TabIndex = 4;
            this.btnDeleteAirport.Text = "Откажи";
            this.btnDeleteAirport.UseVisualStyleBackColor = true;
            this.btnDeleteAirport.Click += new System.EventHandler(this.btnDeleteAirport_Click);
            // 
            // tbShort
            // 
            this.tbShort.Location = new System.Drawing.Point(10, 120);
            this.tbShort.Name = "tbShort";
            this.tbShort.Size = new System.Drawing.Size(100, 20);
            this.tbShort.TabIndex = 2;
            this.tbShort.Validating += new System.ComponentModel.CancelEventHandler(this.tbShort_Validating);
            // 
            // btnSaveAiroport
            // 
            this.btnSaveAiroport.Location = new System.Drawing.Point(10, 148);
            this.btnSaveAiroport.Name = "btnSaveAiroport";
            this.btnSaveAiroport.Size = new System.Drawing.Size(100, 23);
            this.btnSaveAiroport.TabIndex = 3;
            this.btnSaveAiroport.Text = "Зачувај";
            this.btnSaveAiroport.UseVisualStyleBackColor = true;
            this.btnSaveAiroport.Click += new System.EventHandler(this.btnSaveAiroport_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кратенка:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(10, 76);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(222, 20);
            this.tbName.TabIndex = 1;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Име:";
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(10, 37);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(222, 20);
            this.tbCity.TabIndex = 0;
            this.tbCity.Validating += new System.ComponentModel.CancelEventHandler(this.tbCity_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Град";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // NewAirport
            // 
            this.AcceptButton = this.btnSaveAiroport;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnDeleteAirport;
            this.ClientSize = new System.Drawing.Size(284, 201);
            this.Controls.Add(this.groupBox1);
            this.Name = "NewAirport";
            this.Text = "Нов аеродром";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteAirport;
        private System.Windows.Forms.TextBox tbShort;
        private System.Windows.Forms.Button btnSaveAiroport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}