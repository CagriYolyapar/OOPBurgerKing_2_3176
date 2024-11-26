namespace OOPBurgerKing_2
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
            this.TxtIsim = new System.Windows.Forms.TextBox();
            this.RdbBuyuk = new System.Windows.Forms.RadioButton();
            this.RdbOrta = new System.Windows.Forms.RadioButton();
            this.RdbKucuk = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.NmrAdet = new System.Windows.Forms.NumericUpDown();
            this.LstSiparisler = new System.Windows.Forms.ListBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.BtnCiro = new System.Windows.Forms.Button();
            this.LblAciklama = new System.Windows.Forms.Label();
            this.CmbMenuler = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrAdet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menüler";
            // 
            // TxtIsim
            // 
            this.TxtIsim.Location = new System.Drawing.Point(47, 54);
            this.TxtIsim.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtIsim.Name = "TxtIsim";
            this.TxtIsim.Size = new System.Drawing.Size(91, 24);
            this.TxtIsim.TabIndex = 1;
            // 
            // RdbBuyuk
            // 
            this.RdbBuyuk.AutoSize = true;
            this.RdbBuyuk.Location = new System.Drawing.Point(47, 154);
            this.RdbBuyuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdbBuyuk.Name = "RdbBuyuk";
            this.RdbBuyuk.Size = new System.Drawing.Size(100, 22);
            this.RdbBuyuk.TabIndex = 2;
            this.RdbBuyuk.Text = "Büyük Boy";
            this.RdbBuyuk.UseVisualStyleBackColor = true;
            // 
            // RdbOrta
            // 
            this.RdbOrta.AutoSize = true;
            this.RdbOrta.Location = new System.Drawing.Point(47, 199);
            this.RdbOrta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdbOrta.Name = "RdbOrta";
            this.RdbOrta.Size = new System.Drawing.Size(88, 22);
            this.RdbOrta.TabIndex = 2;
            this.RdbOrta.Text = "Orta Boy";
            this.RdbOrta.UseVisualStyleBackColor = true;
            // 
            // RdbKucuk
            // 
            this.RdbKucuk.AutoSize = true;
            this.RdbKucuk.Checked = true;
            this.RdbKucuk.Location = new System.Drawing.Point(47, 246);
            this.RdbKucuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RdbKucuk.Name = "RdbKucuk";
            this.RdbKucuk.Size = new System.Drawing.Size(101, 22);
            this.RdbKucuk.TabIndex = 2;
            this.RdbKucuk.TabStop = true;
            this.RdbKucuk.Text = "Kucuk Boy";
            this.RdbKucuk.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox9);
            this.groupBox1.Controls.Add(this.checkBox6);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.checkBox8);
            this.groupBox1.Controls.Add(this.checkBox5);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.checkBox7);
            this.groupBox1.Controls.Add(this.checkBox4);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Location = new System.Drawing.Point(47, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 193);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(24, 51);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(76, 22);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "0.50";
            this.checkBox1.Text = "Ketcap";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(24, 79);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(91, 22);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "0.50";
            this.checkBox2.Text = "Mayonez";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(24, 107);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(73, 22);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "0.75";
            this.checkBox3.Text = "Hardal";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(129, 51);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(75, 22);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "0.80";
            this.checkBox4.Text = "Acısos";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(129, 79);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(85, 22);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "0.80";
            this.checkBox5.Text = "Barbekü";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(129, 107);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(73, 22);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "0.85";
            this.checkBox6.Text = "Ranch";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(235, 51);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(72, 22);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Tag = "1";
            this.checkBox7.Text = "Bufalo";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(235, 79);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(104, 22);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Tag = "1.25";
            this.checkBox8.Text = "Ballı Hardal";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(235, 107);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(164, 22);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Tag = "1.25";
            this.checkBox9.Text = "Sarımsaklı Mayonez";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // NmrAdet
            // 
            this.NmrAdet.Location = new System.Drawing.Point(252, 55);
            this.NmrAdet.Name = "NmrAdet";
            this.NmrAdet.Size = new System.Drawing.Size(83, 24);
            this.NmrAdet.TabIndex = 4;
            this.NmrAdet.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LstSiparisler
            // 
            this.LstSiparisler.FormattingEnabled = true;
            this.LstSiparisler.ItemHeight = 18;
            this.LstSiparisler.Location = new System.Drawing.Point(536, 55);
            this.LstSiparisler.Name = "LstSiparisler";
            this.LstSiparisler.Size = new System.Drawing.Size(686, 346);
            this.LstSiparisler.TabIndex = 5;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(557, 470);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(75, 23);
            this.BtnEkle.TabIndex = 6;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // BtnCiro
            // 
            this.BtnCiro.Location = new System.Drawing.Point(1028, 470);
            this.BtnCiro.Name = "BtnCiro";
            this.BtnCiro.Size = new System.Drawing.Size(75, 23);
            this.BtnCiro.TabIndex = 6;
            this.BtnCiro.Text = "Ciro";
            this.BtnCiro.UseVisualStyleBackColor = true;
            this.BtnCiro.Click += new System.EventHandler(this.BtnCiro_Click);
            // 
            // LblAciklama
            // 
            this.LblAciklama.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblAciklama.Location = new System.Drawing.Point(44, 550);
            this.LblAciklama.Name = "LblAciklama";
            this.LblAciklama.Size = new System.Drawing.Size(452, 112);
            this.LblAciklama.TabIndex = 7;
            // 
            // CmbMenuler
            // 
            this.CmbMenuler.FormattingEnabled = true;
            this.CmbMenuler.Location = new System.Drawing.Point(41, 123);
            this.CmbMenuler.Name = "CmbMenuler";
            this.CmbMenuler.Size = new System.Drawing.Size(193, 26);
            this.CmbMenuler.TabIndex = 8;
            this.CmbMenuler.SelectedIndexChanged += new System.EventHandler(this.CmbMenuler_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 704);
            this.Controls.Add(this.CmbMenuler);
            this.Controls.Add(this.LblAciklama);
            this.Controls.Add(this.BtnCiro);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LstSiparisler);
            this.Controls.Add(this.NmrAdet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.RdbKucuk);
            this.Controls.Add(this.RdbOrta);
            this.Controls.Add(this.RdbBuyuk);
            this.Controls.Add(this.TxtIsim);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NmrAdet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtIsim;
        private System.Windows.Forms.RadioButton RdbBuyuk;
        private System.Windows.Forms.RadioButton RdbOrta;
        private System.Windows.Forms.RadioButton RdbKucuk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.NumericUpDown NmrAdet;
        private System.Windows.Forms.ListBox LstSiparisler;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.Button BtnCiro;
        private System.Windows.Forms.Label LblAciklama;
        private System.Windows.Forms.ComboBox CmbMenuler;
    }
}

