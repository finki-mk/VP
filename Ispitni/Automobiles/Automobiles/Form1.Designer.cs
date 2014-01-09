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
            this.label1 = new System.Windows.Forms.Label();
            this.cbMarka = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPotrosuvacka = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nudCena = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddAuto = new System.Windows.Forms.Button();
            this.lbMarki = new System.Windows.Forms.ListBox();
            this.btnAddMarka = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbAutos = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbProsek = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbNajekonomicen = new System.Windows.Forms.TextBox();
            this.tbNajskap = new System.Windows.Forms.TextBox();
            this.btnIzbrisi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrosuvacka)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnIzbrisi);
            this.groupBox1.Controls.Add(this.btnAddAuto);
            this.groupBox1.Controls.Add(this.nudCena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.nudPotrosuvacka);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbModel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMarka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 229);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Нов автомобил:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Марка:";
            // 
            // cbMarka
            // 
            this.cbMarka.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMarka.FormattingEnabled = true;
            this.cbMarka.Location = new System.Drawing.Point(6, 36);
            this.cbMarka.MaxDropDownItems = 20;
            this.cbMarka.Name = "cbMarka";
            this.cbMarka.Size = new System.Drawing.Size(305, 21);
            this.cbMarka.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Модел:";
            // 
            // tbModel
            // 
            this.tbModel.Location = new System.Drawing.Point(6, 81);
            this.tbModel.Name = "tbModel";
            this.tbModel.Size = new System.Drawing.Size(305, 20);
            this.tbModel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Потрошувачка:";
            // 
            // nudPotrosuvacka
            // 
            this.nudPotrosuvacka.DecimalPlaces = 1;
            this.nudPotrosuvacka.Location = new System.Drawing.Point(6, 125);
            this.nudPotrosuvacka.Name = "nudPotrosuvacka";
            this.nudPotrosuvacka.Size = new System.Drawing.Size(120, 20);
            this.nudPotrosuvacka.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена:";
            // 
            // nudCena
            // 
            this.nudCena.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudCena.Location = new System.Drawing.Point(6, 169);
            this.nudCena.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.nudCena.Name = "nudCena";
            this.nudCena.Size = new System.Drawing.Size(120, 20);
            this.nudCena.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddMarka);
            this.groupBox2.Controls.Add(this.lbMarki);
            this.groupBox2.Location = new System.Drawing.Point(13, 248);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(311, 200);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Марки на автомобили:";
            // 
            // btnAddAuto
            // 
            this.btnAddAuto.Location = new System.Drawing.Point(6, 195);
            this.btnAddAuto.Name = "btnAddAuto";
            this.btnAddAuto.Size = new System.Drawing.Size(176, 23);
            this.btnAddAuto.TabIndex = 8;
            this.btnAddAuto.Text = "Додади автомобил";
            this.btnAddAuto.UseVisualStyleBackColor = true;
            this.btnAddAuto.Click += new System.EventHandler(this.btnAddAuto_Click);
            // 
            // lbMarki
            // 
            this.lbMarki.FormattingEnabled = true;
            this.lbMarki.Location = new System.Drawing.Point(10, 20);
            this.lbMarki.Name = "lbMarki";
            this.lbMarki.Size = new System.Drawing.Size(295, 147);
            this.lbMarki.TabIndex = 0;
            // 
            // btnAddMarka
            // 
            this.btnAddMarka.Location = new System.Drawing.Point(135, 171);
            this.btnAddMarka.Name = "btnAddMarka";
            this.btnAddMarka.Size = new System.Drawing.Size(170, 23);
            this.btnAddMarka.TabIndex = 1;
            this.btnAddMarka.Text = "Додади нова марка";
            this.btnAddMarka.UseVisualStyleBackColor = true;
            this.btnAddMarka.Click += new System.EventHandler(this.btnAddMarka_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbNajskap);
            this.groupBox3.Controls.Add(this.tbNajekonomicen);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tbProsek);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lbAutos);
            this.groupBox3.Location = new System.Drawing.Point(337, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(307, 435);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Листа на автомобили:";
            // 
            // lbAutos
            // 
            this.lbAutos.FormattingEnabled = true;
            this.lbAutos.Location = new System.Drawing.Point(7, 20);
            this.lbAutos.Name = "lbAutos";
            this.lbAutos.Size = new System.Drawing.Size(294, 290);
            this.lbAutos.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Најекономичен:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 389);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Најскап:";
            // 
            // tbProsek
            // 
            this.tbProsek.Location = new System.Drawing.Point(166, 323);
            this.tbProsek.Name = "tbProsek";
            this.tbProsek.ReadOnly = true;
            this.tbProsek.Size = new System.Drawing.Size(135, 20);
            this.tbProsek.TabIndex = 5;
            this.tbProsek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Просечна потрошувачка:";
            // 
            // tbNajekonomicen
            // 
            this.tbNajekonomicen.Location = new System.Drawing.Point(10, 366);
            this.tbNajekonomicen.Name = "tbNajekonomicen";
            this.tbNajekonomicen.ReadOnly = true;
            this.tbNajekonomicen.Size = new System.Drawing.Size(291, 20);
            this.tbNajekonomicen.TabIndex = 7;
            // 
            // tbNajskap
            // 
            this.tbNajskap.Location = new System.Drawing.Point(10, 406);
            this.tbNajskap.Name = "tbNajskap";
            this.tbNajskap.ReadOnly = true;
            this.tbNajskap.Size = new System.Drawing.Size(291, 20);
            this.tbNajskap.TabIndex = 8;
            // 
            // btnIzbrisi
            // 
            this.btnIzbrisi.Location = new System.Drawing.Point(188, 195);
            this.btnIzbrisi.Name = "btnIzbrisi";
            this.btnIzbrisi.Size = new System.Drawing.Size(123, 23);
            this.btnIzbrisi.TabIndex = 9;
            this.btnIzbrisi.Text = "Избриши автомобил";
            this.btnIzbrisi.UseVisualStyleBackColor = true;
            this.btnIzbrisi.Click += new System.EventHandler(this.btnIzbrisi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 460);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Автомобили";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPotrosuvacka)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCena)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudCena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudPotrosuvacka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbModel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMarka;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddAuto;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAddMarka;
        private System.Windows.Forms.ListBox lbMarki;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbNajskap;
        private System.Windows.Forms.TextBox tbNajekonomicen;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbProsek;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbAutos;
        private System.Windows.Forms.Button btnIzbrisi;
    }
}

