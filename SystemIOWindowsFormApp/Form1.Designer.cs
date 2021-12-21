
namespace SystemIOWindowsFormApp
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
            this.groupBoxPersonelListesi = new System.Windows.Forms.GroupBox();
            this.groupBoxPersonelDetaylari = new System.Windows.Forms.GroupBox();
            this.listBoxPersoneller = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.txtSoyisim = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtFirma = new System.Windows.Forms.TextBox();
            this.txtUlke = new System.Windows.Forms.TextBox();
            this.btnPersonelGetir = new System.Windows.Forms.Button();
            this.btnPersonelKaydet = new System.Windows.Forms.Button();
            this.groupBoxPersonelListesi.SuspendLayout();
            this.groupBoxPersonelDetaylari.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxPersonelListesi
            // 
            this.groupBoxPersonelListesi.Controls.Add(this.listBoxPersoneller);
            this.groupBoxPersonelListesi.Location = new System.Drawing.Point(83, 35);
            this.groupBoxPersonelListesi.Name = "groupBoxPersonelListesi";
            this.groupBoxPersonelListesi.Size = new System.Drawing.Size(270, 344);
            this.groupBoxPersonelListesi.TabIndex = 0;
            this.groupBoxPersonelListesi.TabStop = false;
            this.groupBoxPersonelListesi.Text = "Personel Listesi";
            // 
            // groupBoxPersonelDetaylari
            // 
            this.groupBoxPersonelDetaylari.Controls.Add(this.txtUlke);
            this.groupBoxPersonelDetaylari.Controls.Add(this.txtFirma);
            this.groupBoxPersonelDetaylari.Controls.Add(this.txtEmail);
            this.groupBoxPersonelDetaylari.Controls.Add(this.txtSoyisim);
            this.groupBoxPersonelDetaylari.Controls.Add(this.txtIsim);
            this.groupBoxPersonelDetaylari.Controls.Add(this.label5);
            this.groupBoxPersonelDetaylari.Controls.Add(this.label4);
            this.groupBoxPersonelDetaylari.Controls.Add(this.label3);
            this.groupBoxPersonelDetaylari.Controls.Add(this.label2);
            this.groupBoxPersonelDetaylari.Controls.Add(this.label1);
            this.groupBoxPersonelDetaylari.Location = new System.Drawing.Point(426, 35);
            this.groupBoxPersonelDetaylari.Name = "groupBoxPersonelDetaylari";
            this.groupBoxPersonelDetaylari.Size = new System.Drawing.Size(284, 289);
            this.groupBoxPersonelDetaylari.TabIndex = 1;
            this.groupBoxPersonelDetaylari.TabStop = false;
            this.groupBoxPersonelDetaylari.Text = "Personel Detayları";
            // 
            // listBoxPersoneller
            // 
            this.listBoxPersoneller.FormattingEnabled = true;
            this.listBoxPersoneller.ItemHeight = 16;
            this.listBoxPersoneller.Location = new System.Drawing.Point(24, 36);
            this.listBoxPersoneller.Name = "listBoxPersoneller";
            this.listBoxPersoneller.Size = new System.Drawing.Size(224, 292);
            this.listBoxPersoneller.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "İsim:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyisim:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ülke:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(103, 62);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(162, 22);
            this.txtIsim.TabIndex = 5;
            // 
            // txtSoyisim
            // 
            this.txtSoyisim.Location = new System.Drawing.Point(103, 102);
            this.txtSoyisim.Name = "txtSoyisim";
            this.txtSoyisim.Size = new System.Drawing.Size(162, 22);
            this.txtSoyisim.TabIndex = 6;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(103, 148);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(162, 22);
            this.txtEmail.TabIndex = 7;
            // 
            // txtFirma
            // 
            this.txtFirma.Location = new System.Drawing.Point(103, 194);
            this.txtFirma.Name = "txtFirma";
            this.txtFirma.Size = new System.Drawing.Size(162, 22);
            this.txtFirma.TabIndex = 8;
            // 
            // txtUlke
            // 
            this.txtUlke.Location = new System.Drawing.Point(103, 236);
            this.txtUlke.Name = "txtUlke";
            this.txtUlke.Size = new System.Drawing.Size(162, 22);
            this.txtUlke.TabIndex = 9;
            this.txtUlke.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // btnPersonelGetir
            // 
            this.btnPersonelGetir.Location = new System.Drawing.Point(83, 385);
            this.btnPersonelGetir.Name = "btnPersonelGetir";
            this.btnPersonelGetir.Size = new System.Drawing.Size(270, 53);
            this.btnPersonelGetir.TabIndex = 10;
            this.btnPersonelGetir.Text = "PERSONEL GETİR";
            this.btnPersonelGetir.UseVisualStyleBackColor = true;
            // 
            // btnPersonelKaydet
            // 
            this.btnPersonelKaydet.Location = new System.Drawing.Point(426, 334);
            this.btnPersonelKaydet.Name = "btnPersonelKaydet";
            this.btnPersonelKaydet.Size = new System.Drawing.Size(284, 45);
            this.btnPersonelKaydet.TabIndex = 2;
            this.btnPersonelKaydet.Text = "PERSONELİ KAYDET";
            this.btnPersonelKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.btnPersonelGetir);
            this.Controls.Add(this.btnPersonelKaydet);
            this.Controls.Add(this.groupBoxPersonelDetaylari);
            this.Controls.Add(this.groupBoxPersonelListesi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxPersonelListesi.ResumeLayout(false);
            this.groupBoxPersonelDetaylari.ResumeLayout(false);
            this.groupBoxPersonelDetaylari.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPersonelListesi;
        private System.Windows.Forms.ListBox listBoxPersoneller;
        private System.Windows.Forms.GroupBox groupBoxPersonelDetaylari;
        private System.Windows.Forms.TextBox txtUlke;
        private System.Windows.Forms.TextBox txtFirma;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtSoyisim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPersonelGetir;
        private System.Windows.Forms.Button btnPersonelKaydet;
    }
}

