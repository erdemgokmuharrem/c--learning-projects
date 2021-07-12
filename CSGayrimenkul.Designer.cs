
namespace WinDers1
{
    partial class CSGayrimenkul
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
            this.listBoxDaireler = new System.Windows.Forms.ListBox();
            this.comboBoxSiralama = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlt = new System.Windows.Forms.TextBox();
            this.textBoxUst = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxDaireler
            // 
            this.listBoxDaireler.FormattingEnabled = true;
            this.listBoxDaireler.Location = new System.Drawing.Point(12, 51);
            this.listBoxDaireler.Name = "listBoxDaireler";
            this.listBoxDaireler.Size = new System.Drawing.Size(324, 381);
            this.listBoxDaireler.TabIndex = 0;
            // 
            // comboBoxSiralama
            // 
            this.comboBoxSiralama.FormattingEnabled = true;
            this.comboBoxSiralama.Items.AddRange(new object[] {
            "Kata gore",
            "Fiyata gore",
            "Oda sayisina gore",
            "Metrekaresine gore"});
            this.comboBoxSiralama.Location = new System.Drawing.Point(85, 12);
            this.comboBoxSiralama.Name = "comboBoxSiralama";
            this.comboBoxSiralama.Size = new System.Drawing.Size(251, 21);
            this.comboBoxSiralama.TabIndex = 1;
            this.comboBoxSiralama.SelectedIndexChanged += new System.EventHandler(this.comboBoxSiralama_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Siralama:";
            // 
            // textBoxAlt
            // 
            this.textBoxAlt.Location = new System.Drawing.Point(389, 32);
            this.textBoxAlt.Name = "textBoxAlt";
            this.textBoxAlt.Size = new System.Drawing.Size(106, 20);
            this.textBoxAlt.TabIndex = 3;
            // 
            // textBoxUst
            // 
            this.textBoxUst.Location = new System.Drawing.Point(501, 32);
            this.textBoxUst.Name = "textBoxUst";
            this.textBoxUst.Size = new System.Drawing.Size(100, 20);
            this.textBoxUst.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(386, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fiyat araligi:";
            // 
            // buttonAra
            // 
            this.buttonAra.Location = new System.Drawing.Point(389, 58);
            this.buttonAra.Name = "buttonAra";
            this.buttonAra.Size = new System.Drawing.Size(212, 23);
            this.buttonAra.TabIndex = 6;
            this.buttonAra.Text = "ARA";
            this.buttonAra.UseVisualStyleBackColor = true;
            this.buttonAra.Click += new System.EventHandler(this.buttonAra_Click);
            // 
            // CSGayrimenkul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxUst);
            this.Controls.Add(this.textBoxAlt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxSiralama);
            this.Controls.Add(this.listBoxDaireler);
            this.Name = "CSGayrimenkul";
            this.Text = "CSGayrimenkul";
            this.Load += new System.EventHandler(this.CSGayrimenkul_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxDaireler;
        private System.Windows.Forms.ComboBox comboBoxSiralama;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAlt;
        private System.Windows.Forms.TextBox textBoxUst;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonAra;
    }
}