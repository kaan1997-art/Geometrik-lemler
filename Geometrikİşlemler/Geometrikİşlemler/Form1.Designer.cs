
namespace Geometrikİşlemler
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
            this.lTaban = new System.Windows.Forms.Label();
            this.tbTaban = new System.Windows.Forms.TextBox();
            this.lYukseklik = new System.Windows.Forms.Label();
            this.tbYukseklik = new System.Windows.Forms.TextBox();
            this.cbKare = new System.Windows.Forms.CheckBox();
            this.cbDikdortgen = new System.Windows.Forms.CheckBox();
            this.cbEskenarUcgen = new System.Windows.Forms.CheckBox();
            this.cbDikUcgen = new System.Windows.Forms.CheckBox();
            this.cbDaire = new System.Windows.Forms.CheckBox();
            this.lbAlan = new System.Windows.Forms.Label();
            this.lbCevre = new System.Windows.Forms.Label();
            this.bSonuc = new System.Windows.Forms.Button();
            this.bTemizle = new System.Windows.Forms.Button();
            this.lYariCap = new System.Windows.Forms.Label();
            this.tbYariCap = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lTaban
            // 
            this.lTaban.AutoSize = true;
            this.lTaban.Location = new System.Drawing.Point(13, 44);
            this.lTaban.Name = "lTaban";
            this.lTaban.Size = new System.Drawing.Size(54, 20);
            this.lTaban.TabIndex = 0;
            this.lTaban.Text = "Taban";
            // 
            // tbTaban
            // 
            this.tbTaban.Location = new System.Drawing.Point(112, 41);
            this.tbTaban.Name = "tbTaban";
            this.tbTaban.Size = new System.Drawing.Size(160, 26);
            this.tbTaban.TabIndex = 1;
            // 
            // lYukseklik
            // 
            this.lYukseklik.AutoSize = true;
            this.lYukseklik.Location = new System.Drawing.Point(17, 90);
            this.lYukseklik.Name = "lYukseklik";
            this.lYukseklik.Size = new System.Drawing.Size(76, 20);
            this.lYukseklik.TabIndex = 2;
            this.lYukseklik.Text = "Yükseklik";
            // 
            // tbYukseklik
            // 
            this.tbYukseklik.Location = new System.Drawing.Point(112, 83);
            this.tbYukseklik.Name = "tbYukseklik";
            this.tbYukseklik.Size = new System.Drawing.Size(160, 26);
            this.tbYukseklik.TabIndex = 3;
            // 
            // cbKare
            // 
            this.cbKare.AutoSize = true;
            this.cbKare.Location = new System.Drawing.Point(21, 176);
            this.cbKare.Name = "cbKare";
            this.cbKare.Size = new System.Drawing.Size(68, 24);
            this.cbKare.TabIndex = 4;
            this.cbKare.Text = "Kare";
            this.cbKare.UseVisualStyleBackColor = true;
            this.cbKare.CheckedChanged += new System.EventHandler(this.cbKare_CheckedChanged);
            // 
            // cbDikdortgen
            // 
            this.cbDikdortgen.AutoSize = true;
            this.cbDikdortgen.Location = new System.Drawing.Point(140, 176);
            this.cbDikdortgen.Name = "cbDikdortgen";
            this.cbDikdortgen.Size = new System.Drawing.Size(113, 24);
            this.cbDikdortgen.TabIndex = 4;
            this.cbDikdortgen.Text = "Dikdörtgen";
            this.cbDikdortgen.UseVisualStyleBackColor = true;
            this.cbDikdortgen.CheckedChanged += new System.EventHandler(this.cbDikdortgen_CheckedChanged);
            // 
            // cbEskenarUcgen
            // 
            this.cbEskenarUcgen.AutoSize = true;
            this.cbEskenarUcgen.Location = new System.Drawing.Point(259, 176);
            this.cbEskenarUcgen.Name = "cbEskenarUcgen";
            this.cbEskenarUcgen.Size = new System.Drawing.Size(145, 24);
            this.cbEskenarUcgen.TabIndex = 4;
            this.cbEskenarUcgen.Text = "Eşkenar Üçgen";
            this.cbEskenarUcgen.UseVisualStyleBackColor = true;
            this.cbEskenarUcgen.CheckedChanged += new System.EventHandler(this.cbEskenarUcgen_CheckedChanged);
            // 
            // cbDikUcgen
            // 
            this.cbDikUcgen.AutoSize = true;
            this.cbDikUcgen.Location = new System.Drawing.Point(410, 176);
            this.cbDikUcgen.Name = "cbDikUcgen";
            this.cbDikUcgen.Size = new System.Drawing.Size(109, 24);
            this.cbDikUcgen.TabIndex = 4;
            this.cbDikUcgen.Text = "Dik Üçgen";
            this.cbDikUcgen.UseVisualStyleBackColor = true;
            this.cbDikUcgen.CheckedChanged += new System.EventHandler(this.cbDikUcgen_CheckedChanged);
            // 
            // cbDaire
            // 
            this.cbDaire.AutoSize = true;
            this.cbDaire.Location = new System.Drawing.Point(529, 176);
            this.cbDaire.Name = "cbDaire";
            this.cbDaire.Size = new System.Drawing.Size(73, 24);
            this.cbDaire.TabIndex = 4;
            this.cbDaire.Text = "Daire";
            this.cbDaire.UseVisualStyleBackColor = true;
            this.cbDaire.CheckedChanged += new System.EventHandler(this.cbDaire_CheckedChanged);
            // 
            // lbAlan
            // 
            this.lbAlan.AutoSize = true;
            this.lbAlan.Location = new System.Drawing.Point(21, 226);
            this.lbAlan.Name = "lbAlan";
            this.lbAlan.Size = new System.Drawing.Size(45, 20);
            this.lbAlan.TabIndex = 5;
            this.lbAlan.Text = "Alan:";
            // 
            // lbCevre
            // 
            this.lbCevre.AutoSize = true;
            this.lbCevre.Location = new System.Drawing.Point(255, 226);
            this.lbCevre.Name = "lbCevre";
            this.lbCevre.Size = new System.Drawing.Size(54, 20);
            this.lbCevre.TabIndex = 6;
            this.lbCevre.Text = "Çevre:";
            // 
            // bSonuc
            // 
            this.bSonuc.Location = new System.Drawing.Point(21, 325);
            this.bSonuc.Name = "bSonuc";
            this.bSonuc.Size = new System.Drawing.Size(75, 36);
            this.bSonuc.TabIndex = 7;
            this.bSonuc.Text = "Sonuç";
            this.bSonuc.UseVisualStyleBackColor = true;
            this.bSonuc.Click += new System.EventHandler(this.bSonuc_Click);
            // 
            // bTemizle
            // 
            this.bTemizle.Location = new System.Drawing.Point(102, 325);
            this.bTemizle.Name = "bTemizle";
            this.bTemizle.Size = new System.Drawing.Size(92, 36);
            this.bTemizle.TabIndex = 7;
            this.bTemizle.Text = "Temizle";
            this.bTemizle.UseVisualStyleBackColor = true;
            this.bTemizle.Click += new System.EventHandler(this.bTemizle_Click);
            // 
            // lYariCap
            // 
            this.lYariCap.AutoSize = true;
            this.lYariCap.Location = new System.Drawing.Point(17, 125);
            this.lYariCap.Name = "lYariCap";
            this.lYariCap.Size = new System.Drawing.Size(66, 20);
            this.lYariCap.TabIndex = 9;
            this.lYariCap.Text = "YarıÇap";
            // 
            // tbYariCap
            // 
            this.tbYariCap.Location = new System.Drawing.Point(112, 125);
            this.tbYariCap.Name = "tbYariCap";
            this.tbYariCap.Size = new System.Drawing.Size(160, 26);
            this.tbYariCap.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbYariCap);
            this.Controls.Add(this.lYariCap);
            this.Controls.Add(this.bTemizle);
            this.Controls.Add(this.bSonuc);
            this.Controls.Add(this.lbCevre);
            this.Controls.Add(this.lbAlan);
            this.Controls.Add(this.cbDaire);
            this.Controls.Add(this.cbDikUcgen);
            this.Controls.Add(this.cbEskenarUcgen);
            this.Controls.Add(this.cbDikdortgen);
            this.Controls.Add(this.cbKare);
            this.Controls.Add(this.tbYukseklik);
            this.Controls.Add(this.lYukseklik);
            this.Controls.Add(this.tbTaban);
            this.Controls.Add(this.lTaban);
            this.Name = "Form1";
            this.Text = "Geometrik İşlemler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTaban;
        private System.Windows.Forms.TextBox tbTaban;
        private System.Windows.Forms.Label lYukseklik;
        private System.Windows.Forms.TextBox tbYukseklik;
        private System.Windows.Forms.CheckBox cbKare;
        private System.Windows.Forms.CheckBox cbDikdortgen;
        private System.Windows.Forms.CheckBox cbEskenarUcgen;
        private System.Windows.Forms.CheckBox cbDikUcgen;
        private System.Windows.Forms.CheckBox cbDaire;
        private System.Windows.Forms.Label lbAlan;
        private System.Windows.Forms.Label lbCevre;
        private System.Windows.Forms.Button bSonuc;
        private System.Windows.Forms.Button bTemizle;
        private System.Windows.Forms.Label lYariCap;
        private System.Windows.Forms.TextBox tbYariCap;
    }
}

