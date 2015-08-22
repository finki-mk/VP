namespace Convertor
{
    partial class AddConvertor
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
            this.lblFrom = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.to = new System.Windows.Forms.Label();
            this.nudMultiplier = new System.Windows.Forms.NumericUpDown();
            this.llb = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(12, 9);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(27, 17);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "Од";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(12, 29);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(235, 22);
            this.tbFrom.TabIndex = 1;
            this.tbFrom.Validating += new System.ComponentModel.CancelEventHandler(this.tbFrom_Validating);
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(12, 82);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(235, 22);
            this.tbTo.TabIndex = 3;
            this.tbTo.Validating += new System.ComponentModel.CancelEventHandler(this.tbTo_Validating);
            // 
            // to
            // 
            this.to.AutoSize = true;
            this.to.Location = new System.Drawing.Point(12, 62);
            this.to.Name = "to";
            this.to.Size = new System.Drawing.Size(27, 17);
            this.to.TabIndex = 2;
            this.to.Text = "До";
            // 
            // nudMultiplier
            // 
            this.nudMultiplier.DecimalPlaces = 3;
            this.nudMultiplier.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudMultiplier.Location = new System.Drawing.Point(15, 135);
            this.nudMultiplier.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudMultiplier.Name = "nudMultiplier";
            this.nudMultiplier.Size = new System.Drawing.Size(120, 22);
            this.nudMultiplier.TabIndex = 4;
            this.nudMultiplier.ValueChanged += new System.EventHandler(this.nudMultiplier_ValueChanged);
            this.nudMultiplier.Validating += new System.ComponentModel.CancelEventHandler(this.nudMultiplier_Validating);
            // 
            // llb
            // 
            this.llb.AutoSize = true;
            this.llb.Location = new System.Drawing.Point(12, 115);
            this.llb.Name = "llb";
            this.llb.Size = new System.Drawing.Size(60, 17);
            this.llb.TabIndex = 5;
            this.llb.Text = "Множач";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 182);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 26);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Додади";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(195, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Откажи";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddConvertor
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(282, 220);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.llb);
            this.Controls.Add(this.nudMultiplier);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.to);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.lblFrom);
            this.Name = "AddConvertor";
            this.Text = "AddConvertor";
            ((System.ComponentModel.ISupportInitialize)(this.nudMultiplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label to;
        private System.Windows.Forms.NumericUpDown nudMultiplier;
        private System.Windows.Forms.Label llb;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}