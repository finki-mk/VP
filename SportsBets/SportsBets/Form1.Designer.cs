namespace SportsBets
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
            this.components = new System.ComponentModel.Container();
            this.lbTeams = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mtbCode = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAddNewTeam = new System.Windows.Forms.Button();
            this.nudCoef2 = new System.Windows.Forms.NumericUpDown();
            this.nudCoefX = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudCoef1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddToGames = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbGames = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbTip = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnAddGame = new System.Windows.Forms.Button();
            this.tbCodeToEnter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbTickets = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nudPayment = new System.Windows.Forms.NumericUpDown();
            this.btnPrint = new System.Windows.Forms.Button();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbTotalCoef = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoefX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTeams
            // 
            this.lbTeams.FormattingEnabled = true;
            this.lbTeams.Location = new System.Drawing.Point(12, 25);
            this.lbTeams.Name = "lbTeams";
            this.lbTeams.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbTeams.Size = new System.Drawing.Size(207, 251);
            this.lbTeams.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на тимови:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mtbCode);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnAddNewTeam);
            this.groupBox1.Controls.Add(this.nudCoef2);
            this.groupBox1.Controls.Add(this.nudCoefX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudCoef1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAddToGames);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 282);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 218);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Креирај билтен";
            // 
            // mtbCode
            // 
            this.mtbCode.Location = new System.Drawing.Point(61, 135);
            this.mtbCode.Mask = "0000";
            this.mtbCode.Name = "mtbCode";
            this.mtbCode.Size = new System.Drawing.Size(100, 20);
            this.mtbCode.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(10, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Шифра:";
            // 
            // btnAddNewTeam
            // 
            this.btnAddNewTeam.Location = new System.Drawing.Point(10, 189);
            this.btnAddNewTeam.Name = "btnAddNewTeam";
            this.btnAddNewTeam.Size = new System.Drawing.Size(184, 23);
            this.btnAddNewTeam.TabIndex = 5;
            this.btnAddNewTeam.Text = "Додади нов тим";
            this.btnAddNewTeam.UseVisualStyleBackColor = true;
            this.btnAddNewTeam.Click += new System.EventHandler(this.btnAddNewTeam_Click);
            // 
            // nudCoef2
            // 
            this.nudCoef2.DecimalPlaces = 2;
            this.nudCoef2.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCoef2.Location = new System.Drawing.Point(32, 109);
            this.nudCoef2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoef2.Name = "nudCoef2";
            this.nudCoef2.Size = new System.Drawing.Size(120, 20);
            this.nudCoef2.TabIndex = 2;
            this.nudCoef2.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudCoefX
            // 
            this.nudCoefX.DecimalPlaces = 2;
            this.nudCoefX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.nudCoefX.Location = new System.Drawing.Point(32, 83);
            this.nudCoefX.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoefX.Name = "nudCoefX";
            this.nudCoefX.Size = new System.Drawing.Size(120, 20);
            this.nudCoefX.TabIndex = 1;
            this.nudCoefX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "1";
            // 
            // nudCoef1
            // 
            this.nudCoef1.DecimalPlaces = 2;
            this.nudCoef1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.nudCoef1.Location = new System.Drawing.Point(32, 57);
            this.nudCoef1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCoef1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCoef1.Name = "nudCoef1";
            this.nudCoef1.Size = new System.Drawing.Size(120, 20);
            this.nudCoef1.TabIndex = 0;
            this.nudCoef1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Постави коефициенти";
            // 
            // btnAddToGames
            // 
            this.btnAddToGames.Location = new System.Drawing.Point(10, 160);
            this.btnAddToGames.Name = "btnAddToGames";
            this.btnAddToGames.Size = new System.Drawing.Size(184, 23);
            this.btnAddToGames.TabIndex = 4;
            this.btnAddToGames.Text = "Додади во билтен";
            this.btnAddToGames.UseVisualStyleBackColor = true;
            this.btnAddToGames.Click += new System.EventHandler(this.btnAddToGames_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Избери 2 тима од иста држава";
            // 
            // lbGames
            // 
            this.lbGames.FormattingEnabled = true;
            this.lbGames.Location = new System.Drawing.Point(226, 25);
            this.lbGames.Name = "lbGames";
            this.lbGames.Size = new System.Drawing.Size(279, 251);
            this.lbGames.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Билтен";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.cbTip);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.btnAddGame);
            this.groupBox2.Controls.Add(this.tbCodeToEnter);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(225, 285);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 201);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Додади натпревар во тикет";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 50);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 4;
            this.label15.Text = "Шифра:";
            // 
            // cbTip
            // 
            this.cbTip.AllowDrop = true;
            this.cbTip.FormattingEnabled = true;
            this.cbTip.Items.AddRange(new object[] {
            "1",
            "X",
            "2"});
            this.cbTip.Location = new System.Drawing.Point(10, 130);
            this.cbTip.Name = "cbTip";
            this.cbTip.Size = new System.Drawing.Size(121, 21);
            this.cbTip.TabIndex = 1;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Избери тип:";
            // 
            // btnAddGame
            // 
            this.btnAddGame.Location = new System.Drawing.Point(10, 172);
            this.btnAddGame.Name = "btnAddGame";
            this.btnAddGame.Size = new System.Drawing.Size(145, 23);
            this.btnAddGame.TabIndex = 2;
            this.btnAddGame.Text = "Додади натпревар";
            this.btnAddGame.UseVisualStyleBackColor = true;
            this.btnAddGame.Click += new System.EventHandler(this.btnAddGame_Click);
            // 
            // tbCodeToEnter
            // 
            this.tbCodeToEnter.Location = new System.Drawing.Point(10, 67);
            this.tbCodeToEnter.Name = "tbCodeToEnter";
            this.tbCodeToEnter.Size = new System.Drawing.Size(121, 20);
            this.tbCodeToEnter.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(259, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Избери натпревар од билтенот или внеси шифра:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(511, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Тикет";
            // 
            // lbTickets
            // 
            this.lbTickets.FormattingEnabled = true;
            this.lbTickets.Location = new System.Drawing.Point(512, 26);
            this.lbTickets.Name = "lbTickets";
            this.lbTickets.Size = new System.Drawing.Size(220, 251);
            this.lbTickets.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nudPayment);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.tbProfit);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.tbTotalCoef);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(514, 284);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 202);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Уплати тикет";
            // 
            // nudPayment
            // 
            this.nudPayment.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPayment.Location = new System.Drawing.Point(10, 85);
            this.nudPayment.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.nudPayment.Minimum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPayment.Name = "nudPayment";
            this.nudPayment.Size = new System.Drawing.Size(202, 20);
            this.nudPayment.TabIndex = 1;
            this.nudPayment.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudPayment.ValueChanged += new System.EventHandler(this.nudPayment_ValueChanged);
            this.nudPayment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nudPayment_KeyUp);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(10, 158);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(202, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Печати";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // tbProfit
            // 
            this.tbProfit.Location = new System.Drawing.Point(10, 130);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.ReadOnly = true;
            this.tbProfit.Size = new System.Drawing.Size(202, 20);
            this.tbProfit.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(13, 115);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Добивка:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 68);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Уплата:";
            // 
            // tbTotalCoef
            // 
            this.tbTotalCoef.Location = new System.Drawing.Point(10, 37);
            this.tbTotalCoef.Name = "tbTotalCoef";
            this.tbTotalCoef.ReadOnly = true;
            this.tbTotalCoef.Size = new System.Drawing.Size(202, 20);
            this.tbTotalCoef.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(110, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Вкупно коефициент:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 512);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.lbTickets);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbGames);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTeams);
            this.Name = "Form1";
            this.Text = "Спортска обложувалница";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoefX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoef1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTeams;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCoef2;
        private System.Windows.Forms.NumericUpDown nudCoefX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudCoef1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddToGames;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbGames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnAddNewTeam;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddGame;
        private System.Windows.Forms.TextBox tbCodeToEnter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lbTickets;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbTotalCoef;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbTip;
        private System.Windows.Forms.NumericUpDown nudPayment;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.MaskedTextBox mtbCode;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

