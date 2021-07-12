
namespace WinDers1
{
    partial class Work2
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
            this.textBoxIsim = new System.Windows.Forms.TextBox();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.listBoxIsimler = new System.Windows.Forms.ListBox();
            this.radioButtonJunior = new System.Windows.Forms.RadioButton();
            this.radioButtonSenior = new System.Windows.Forms.RadioButton();
            this.listBoxEkipler = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Isim Soyisim";
            // 
            // textBoxIsim
            // 
            this.textBoxIsim.Location = new System.Drawing.Point(15, 25);
            this.textBoxIsim.Name = "textBoxIsim";
            this.textBoxIsim.Size = new System.Drawing.Size(132, 20);
            this.textBoxIsim.TabIndex = 1;
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(15, 164);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(132, 23);
            this.buttonKaydet.TabIndex = 2;
            this.buttonKaydet.Text = "kaydet =>";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // listBoxIsimler
            // 
            this.listBoxIsimler.FormattingEnabled = true;
            this.listBoxIsimler.Location = new System.Drawing.Point(153, 9);
            this.listBoxIsimler.Name = "listBoxIsimler";
            this.listBoxIsimler.Size = new System.Drawing.Size(175, 420);
            this.listBoxIsimler.TabIndex = 3;
            // 
            // radioButtonJunior
            // 
            this.radioButtonJunior.AutoSize = true;
            this.radioButtonJunior.Checked = true;
            this.radioButtonJunior.Location = new System.Drawing.Point(15, 66);
            this.radioButtonJunior.Name = "radioButtonJunior";
            this.radioButtonJunior.Size = new System.Drawing.Size(53, 17);
            this.radioButtonJunior.TabIndex = 4;
            this.radioButtonJunior.TabStop = true;
            this.radioButtonJunior.Text = "Junior";
            this.radioButtonJunior.UseVisualStyleBackColor = true;
            // 
            // radioButtonSenior
            // 
            this.radioButtonSenior.AutoSize = true;
            this.radioButtonSenior.Location = new System.Drawing.Point(15, 89);
            this.radioButtonSenior.Name = "radioButtonSenior";
            this.radioButtonSenior.Size = new System.Drawing.Size(55, 17);
            this.radioButtonSenior.TabIndex = 5;
            this.radioButtonSenior.Text = "Senior";
            this.radioButtonSenior.UseVisualStyleBackColor = true;
            // 
            // listBoxEkipler
            // 
            this.listBoxEkipler.FormattingEnabled = true;
            this.listBoxEkipler.Location = new System.Drawing.Point(398, 38);
            this.listBoxEkipler.Name = "listBoxEkipler";
            this.listBoxEkipler.Size = new System.Drawing.Size(245, 199);
            this.listBoxEkipler.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(398, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Yazilim ekiplerini olustur";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Work2
            // 
            this.AcceptButton = this.buttonKaydet;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxEkipler);
            this.Controls.Add(this.radioButtonSenior);
            this.Controls.Add(this.radioButtonJunior);
            this.Controls.Add(this.listBoxIsimler);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.textBoxIsim);
            this.Controls.Add(this.label1);
            this.Name = "Work2";
            this.Text = "Work2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Work2_FormClosing);
            this.Load += new System.EventHandler(this.Work2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxIsim;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.ListBox listBoxIsimler;
        private System.Windows.Forms.RadioButton radioButtonJunior;
        private System.Windows.Forms.RadioButton radioButtonSenior;
        private System.Windows.Forms.ListBox listBoxEkipler;
        private System.Windows.Forms.Button button1;
    }
}