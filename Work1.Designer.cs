
namespace WinDers1
{
    partial class Work1
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
            this.textBoxKatSayi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAltLimit = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxUstLimit = new System.Windows.Forms.TextBox();
            this.listBoxKatlar = new System.Windows.Forms.ListBox();
            this.buttonKat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonArtanKat = new System.Windows.Forms.RadioButton();
            this.radioButtonAzalanKat = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxFaktoriyel = new System.Windows.Forms.TextBox();
            this.buttonFaktoriyel = new System.Windows.Forms.Button();
            this.labelFaktoriyel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxS1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxS2 = new System.Windows.Forms.TextBox();
            this.buttonObeb = new System.Windows.Forms.Button();
            this.buttonOkek = new System.Windows.Forms.Button();
            this.labelOrtakKat = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listBoxSayilar = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxGirilenSayi = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxSirali = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Katlari yazilacak sayi";
            // 
            // textBoxKatSayi
            // 
            this.textBoxKatSayi.Location = new System.Drawing.Point(12, 25);
            this.textBoxKatSayi.Name = "textBoxKatSayi";
            this.textBoxKatSayi.Size = new System.Drawing.Size(100, 20);
            this.textBoxKatSayi.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alt Limit";
            // 
            // textBoxAltLimit
            // 
            this.textBoxAltLimit.Location = new System.Drawing.Point(12, 84);
            this.textBoxAltLimit.Name = "textBoxAltLimit";
            this.textBoxAltLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltLimit.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ust Limit";
            // 
            // textBoxUstLimit
            // 
            this.textBoxUstLimit.Location = new System.Drawing.Point(12, 123);
            this.textBoxUstLimit.Name = "textBoxUstLimit";
            this.textBoxUstLimit.Size = new System.Drawing.Size(100, 20);
            this.textBoxUstLimit.TabIndex = 5;
            // 
            // listBoxKatlar
            // 
            this.listBoxKatlar.FormattingEnabled = true;
            this.listBoxKatlar.Location = new System.Drawing.Point(124, 9);
            this.listBoxKatlar.Name = "listBoxKatlar";
            this.listBoxKatlar.Size = new System.Drawing.Size(100, 342);
            this.listBoxKatlar.TabIndex = 6;
            // 
            // buttonKat
            // 
            this.buttonKat.Location = new System.Drawing.Point(12, 217);
            this.buttonKat.Name = "buttonKat";
            this.buttonKat.Size = new System.Drawing.Size(100, 23);
            this.buttonKat.TabIndex = 7;
            this.buttonKat.Text = "Katlari Hesapla";
            this.buttonKat.UseVisualStyleBackColor = true;
            this.buttonKat.Click += new System.EventHandler(this.buttonKat_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonAzalanKat);
            this.panel1.Controls.Add(this.radioButtonArtanKat);
            this.panel1.Location = new System.Drawing.Point(2, 147);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(116, 64);
            this.panel1.TabIndex = 8;
            // 
            // radioButtonArtanKat
            // 
            this.radioButtonArtanKat.AutoSize = true;
            this.radioButtonArtanKat.Checked = true;
            this.radioButtonArtanKat.Location = new System.Drawing.Point(10, 3);
            this.radioButtonArtanKat.Name = "radioButtonArtanKat";
            this.radioButtonArtanKat.Size = new System.Drawing.Size(50, 17);
            this.radioButtonArtanKat.TabIndex = 0;
            this.radioButtonArtanKat.TabStop = true;
            this.radioButtonArtanKat.Text = "Artan";
            this.radioButtonArtanKat.UseVisualStyleBackColor = true;
            // 
            // radioButtonAzalanKat
            // 
            this.radioButtonAzalanKat.AutoSize = true;
            this.radioButtonAzalanKat.Location = new System.Drawing.Point(10, 26);
            this.radioButtonAzalanKat.Name = "radioButtonAzalanKat";
            this.radioButtonAzalanKat.Size = new System.Drawing.Size(57, 17);
            this.radioButtonAzalanKat.TabIndex = 1;
            this.radioButtonAzalanKat.Text = "Azalan";
            this.radioButtonAzalanKat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(237, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(2, 321);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sayi:";
            // 
            // textBoxFaktoriyel
            // 
            this.textBoxFaktoriyel.Location = new System.Drawing.Point(257, 25);
            this.textBoxFaktoriyel.Name = "textBoxFaktoriyel";
            this.textBoxFaktoriyel.Size = new System.Drawing.Size(100, 20);
            this.textBoxFaktoriyel.TabIndex = 11;
            // 
            // buttonFaktoriyel
            // 
            this.buttonFaktoriyel.Location = new System.Drawing.Point(257, 51);
            this.buttonFaktoriyel.Name = "buttonFaktoriyel";
            this.buttonFaktoriyel.Size = new System.Drawing.Size(100, 23);
            this.buttonFaktoriyel.TabIndex = 12;
            this.buttonFaktoriyel.Text = "Faktoriyel hesapla";
            this.buttonFaktoriyel.UseVisualStyleBackColor = true;
            this.buttonFaktoriyel.Click += new System.EventHandler(this.buttonFaktoriyel_Click);
            // 
            // labelFaktoriyel
            // 
            this.labelFaktoriyel.AutoSize = true;
            this.labelFaktoriyel.Location = new System.Drawing.Point(254, 84);
            this.labelFaktoriyel.Name = "labelFaktoriyel";
            this.labelFaktoriyel.Size = new System.Drawing.Size(13, 13);
            this.labelFaktoriyel.TabIndex = 13;
            this.labelFaktoriyel.Text = "0";
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(246, 106);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 2);
            this.label6.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(254, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Sayi 1:";
            // 
            // textBoxS1
            // 
            this.textBoxS1.Location = new System.Drawing.Point(257, 146);
            this.textBoxS1.Name = "textBoxS1";
            this.textBoxS1.Size = new System.Drawing.Size(100, 20);
            this.textBoxS1.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(254, 177);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Sayi 2:";
            // 
            // textBoxS2
            // 
            this.textBoxS2.Location = new System.Drawing.Point(257, 193);
            this.textBoxS2.Name = "textBoxS2";
            this.textBoxS2.Size = new System.Drawing.Size(100, 20);
            this.textBoxS2.TabIndex = 18;
            // 
            // buttonObeb
            // 
            this.buttonObeb.Location = new System.Drawing.Point(257, 230);
            this.buttonObeb.Name = "buttonObeb";
            this.buttonObeb.Size = new System.Drawing.Size(100, 23);
            this.buttonObeb.TabIndex = 19;
            this.buttonObeb.Text = "OBEB";
            this.buttonObeb.UseVisualStyleBackColor = true;
            this.buttonObeb.Click += new System.EventHandler(this.buttonObeb_Click);
            // 
            // buttonOkek
            // 
            this.buttonOkek.Location = new System.Drawing.Point(257, 259);
            this.buttonOkek.Name = "buttonOkek";
            this.buttonOkek.Size = new System.Drawing.Size(100, 23);
            this.buttonOkek.TabIndex = 20;
            this.buttonOkek.Text = "OKEK";
            this.buttonOkek.UseVisualStyleBackColor = true;
            this.buttonOkek.Click += new System.EventHandler(this.buttonOkek_Click);
            // 
            // labelOrtakKat
            // 
            this.labelOrtakKat.AutoSize = true;
            this.labelOrtakKat.Location = new System.Drawing.Point(254, 306);
            this.labelOrtakKat.Name = "labelOrtakKat";
            this.labelOrtakKat.Size = new System.Drawing.Size(13, 13);
            this.labelOrtakKat.TabIndex = 21;
            this.labelOrtakKat.Text = "0";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(372, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 321);
            this.label9.TabIndex = 22;
            // 
            // listBoxSayilar
            // 
            this.listBoxSayilar.FormattingEnabled = true;
            this.listBoxSayilar.Location = new System.Drawing.Point(380, 9);
            this.listBoxSayilar.Name = "listBoxSayilar";
            this.listBoxSayilar.Size = new System.Drawing.Size(44, 342);
            this.listBoxSayilar.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(430, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Sayi:";
            // 
            // textBoxGirilenSayi
            // 
            this.textBoxGirilenSayi.Location = new System.Drawing.Point(433, 25);
            this.textBoxGirilenSayi.Name = "textBoxGirilenSayi";
            this.textBoxGirilenSayi.Size = new System.Drawing.Size(54, 20);
            this.textBoxGirilenSayi.TabIndex = 25;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(433, 51);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(54, 46);
            this.buttonKaydet.TabIndex = 26;
            this.buttonKaydet.Text = "<= Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(433, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 184);
            this.button1.TabIndex = 27;
            this.button1.Text = "SIRALA\r\n\r\n=>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxSirali
            // 
            this.listBoxSirali.FormattingEnabled = true;
            this.listBoxSirali.Location = new System.Drawing.Point(493, 9);
            this.listBoxSirali.Name = "listBoxSirali";
            this.listBoxSirali.Size = new System.Drawing.Size(43, 342);
            this.listBoxSirali.TabIndex = 28;
            // 
            // Work1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 363);
            this.Controls.Add(this.listBoxSirali);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxGirilenSayi);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBoxSayilar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelOrtakKat);
            this.Controls.Add(this.buttonOkek);
            this.Controls.Add(this.buttonObeb);
            this.Controls.Add(this.textBoxS2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBoxS1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelFaktoriyel);
            this.Controls.Add(this.buttonFaktoriyel);
            this.Controls.Add(this.textBoxFaktoriyel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonKat);
            this.Controls.Add(this.listBoxKatlar);
            this.Controls.Add(this.textBoxUstLimit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAltLimit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxKatSayi);
            this.Controls.Add(this.label1);
            this.Name = "Work1";
            this.Text = "Work1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxKatSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAltLimit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxUstLimit;
        private System.Windows.Forms.ListBox listBoxKatlar;
        private System.Windows.Forms.Button buttonKat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioButtonAzalanKat;
        private System.Windows.Forms.RadioButton radioButtonArtanKat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxFaktoriyel;
        private System.Windows.Forms.Button buttonFaktoriyel;
        private System.Windows.Forms.Label labelFaktoriyel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxS1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxS2;
        private System.Windows.Forms.Button buttonObeb;
        private System.Windows.Forms.Button buttonOkek;
        private System.Windows.Forms.Label labelOrtakKat;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox listBoxSayilar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxGirilenSayi;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxSirali;
    }
}