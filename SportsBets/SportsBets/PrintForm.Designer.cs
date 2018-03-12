namespace SportsBets
{
    partial class PrintForm
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
            this.dataGridTicket = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.lblUplata = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCoef = new System.Windows.Forms.Label();
            this.lblDobivka = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDanok = new System.Windows.Forms.Label();
            this.Code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Game = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(156, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "FINKI BET";
            // 
            // dataGridTicket
            // 
            this.dataGridTicket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTicket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Code,
            this.Game,
            this.Coefficient});
            this.dataGridTicket.Location = new System.Drawing.Point(5, 61);
            this.dataGridTicket.Name = "dataGridTicket";
            this.dataGridTicket.Size = new System.Drawing.Size(447, 174);
            this.dataGridTicket.TabIndex = 1;
            this.dataGridTicket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(74, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Уплата:";
            // 
            // lblUplata
            // 
            this.lblUplata.AutoSize = true;
            this.lblUplata.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblUplata.Location = new System.Drawing.Point(149, 265);
            this.lblUplata.Name = "lblUplata";
            this.lblUplata.Size = new System.Drawing.Size(51, 20);
            this.lblUplata.TabIndex = 3;
            this.lblUplata.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(33, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Коефициент:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(233, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Добивка:";
            // 
            // lblCoef
            // 
            this.lblCoef.AutoSize = true;
            this.lblCoef.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCoef.Location = new System.Drawing.Point(149, 295);
            this.lblCoef.Name = "lblCoef";
            this.lblCoef.Size = new System.Drawing.Size(51, 20);
            this.lblCoef.TabIndex = 6;
            this.lblCoef.Text = "label6";
            // 
            // lblDobivka
            // 
            this.lblDobivka.AutoSize = true;
            this.lblDobivka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDobivka.Location = new System.Drawing.Point(333, 265);
            this.lblDobivka.Name = "lblDobivka";
            this.lblDobivka.Size = new System.Drawing.Size(51, 20);
            this.lblDobivka.TabIndex = 7;
            this.lblDobivka.Text = "label7";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(251, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Данок:";
            // 
            // lblDanok
            // 
            this.lblDanok.AutoSize = true;
            this.lblDanok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDanok.Location = new System.Drawing.Point(333, 295);
            this.lblDanok.Name = "lblDanok";
            this.lblDanok.Size = new System.Drawing.Size(51, 20);
            this.lblDanok.TabIndex = 9;
            this.lblDanok.Text = "label7";
            // 
            // Code
            // 
            this.Code.HeaderText = "Шифра";
            this.Code.Name = "Code";
            // 
            // Game
            // 
            this.Game.HeaderText = "Натпревар";
            this.Game.MinimumWidth = 10;
            this.Game.Name = "Game";
            this.Game.Width = 200;
            // 
            // Coefficient
            // 
            this.Coefficient.HeaderText = "Коефициент";
            this.Coefficient.Name = "Coefficient";
            // 
            // PrintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 386);
            this.Controls.Add(this.lblDanok);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDobivka);
            this.Controls.Add(this.lblCoef);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblUplata);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridTicket);
            this.Controls.Add(this.label1);
            this.Name = "PrintForm";
            this.Text = "PrintForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicket)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridTicket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUplata;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblCoef;
        private System.Windows.Forms.Label lblDobivka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDanok;
        private System.Windows.Forms.DataGridViewTextBoxColumn Code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Game;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coefficient;
    }
}