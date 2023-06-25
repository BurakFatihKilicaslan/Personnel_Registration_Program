namespace Personnel_Registration_Program.Forms
{
    partial class AdminScreen
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
            btnAktifPasif = new Button();
            lstYetkiliIsimleri = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            gboxYetkiliIsimler = new GroupBox();
            btnYetkiSil = new Button();
            gboxTumCalisanlar = new GroupBox();
            btnPersonelSil = new Button();
            lstTumCalisanlar = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            btnYetkiVer = new Button();
            gboxYetkiliIsimler.SuspendLayout();
            gboxTumCalisanlar.SuspendLayout();
            SuspendLayout();
            // 
            // btnAktifPasif
            // 
            btnAktifPasif.BackColor = SystemColors.ActiveCaptionText;
            btnAktifPasif.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAktifPasif.ForeColor = SystemColors.ButtonHighlight;
            btnAktifPasif.Location = new Point(396, 27);
            btnAktifPasif.Name = "btnAktifPasif";
            btnAktifPasif.Size = new Size(140, 33);
            btnAktifPasif.TabIndex = 19;
            btnAktifPasif.Text = "Aktif / Pasif";
            btnAktifPasif.UseVisualStyleBackColor = false;
            btnAktifPasif.Click += btnAktifPasif_Click;
            // 
            // lstYetkiliIsimleri
            // 
            lstYetkiliIsimleri.BackColor = SystemColors.InactiveCaptionText;
            lstYetkiliIsimleri.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lstYetkiliIsimleri.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstYetkiliIsimleri.ForeColor = SystemColors.ButtonHighlight;
            lstYetkiliIsimleri.FullRowSelect = true;
            lstYetkiliIsimleri.GridLines = true;
            lstYetkiliIsimleri.Location = new Point(0, 66);
            lstYetkiliIsimleri.Name = "lstYetkiliIsimleri";
            lstYetkiliIsimleri.Size = new Size(536, 349);
            lstYetkiliIsimleri.TabIndex = 18;
            lstYetkiliIsimleri.UseCompatibleStateImageBehavior = false;
            lstYetkiliIsimleri.View = View.Details;
            lstYetkiliIsimleri.DoubleClick += lstYetkiliIsimleri_DoubleClick;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 140;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Soyad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Kullanıcı Adı";
            columnHeader3.Width = 140;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Durum";
            columnHeader4.Width = 100;
            // 
            // gboxYetkiliIsimler
            // 
            gboxYetkiliIsimler.BackColor = SystemColors.ActiveCaptionText;
            gboxYetkiliIsimler.Controls.Add(btnYetkiSil);
            gboxYetkiliIsimler.Controls.Add(lstYetkiliIsimleri);
            gboxYetkiliIsimler.Controls.Add(btnAktifPasif);
            gboxYetkiliIsimler.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxYetkiliIsimler.ForeColor = SystemColors.ButtonHighlight;
            gboxYetkiliIsimler.Location = new Point(12, 12);
            gboxYetkiliIsimler.Name = "gboxYetkiliIsimler";
            gboxYetkiliIsimler.Size = new Size(543, 424);
            gboxYetkiliIsimler.TabIndex = 20;
            gboxYetkiliIsimler.TabStop = false;
            gboxYetkiliIsimler.Text = "Yetkili İsimler";
            // 
            // btnYetkiSil
            // 
            btnYetkiSil.BackColor = SystemColors.ActiveCaptionText;
            btnYetkiSil.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYetkiSil.ForeColor = SystemColors.ButtonHighlight;
            btnYetkiSil.Location = new Point(250, 27);
            btnYetkiSil.Name = "btnYetkiSil";
            btnYetkiSil.Size = new Size(140, 33);
            btnYetkiSil.TabIndex = 20;
            btnYetkiSil.Text = "Yetki Sil";
            btnYetkiSil.UseVisualStyleBackColor = false;
            btnYetkiSil.Click += btnYetkiSil_Click;
            // 
            // gboxTumCalisanlar
            // 
            gboxTumCalisanlar.BackColor = SystemColors.ActiveCaptionText;
            gboxTumCalisanlar.Controls.Add(btnPersonelSil);
            gboxTumCalisanlar.Controls.Add(lstTumCalisanlar);
            gboxTumCalisanlar.Controls.Add(btnYetkiVer);
            gboxTumCalisanlar.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxTumCalisanlar.ForeColor = SystemColors.ButtonHighlight;
            gboxTumCalisanlar.Location = new Point(561, 12);
            gboxTumCalisanlar.Name = "gboxTumCalisanlar";
            gboxTumCalisanlar.Size = new Size(543, 424);
            gboxTumCalisanlar.TabIndex = 21;
            gboxTumCalisanlar.TabStop = false;
            gboxTumCalisanlar.Text = "Tüm Çalışanlar";
            // 
            // btnPersonelSil
            // 
            btnPersonelSil.BackColor = SystemColors.ActiveCaptionText;
            btnPersonelSil.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPersonelSil.ForeColor = SystemColors.ButtonHighlight;
            btnPersonelSil.Location = new Point(250, 27);
            btnPersonelSil.Name = "btnPersonelSil";
            btnPersonelSil.Size = new Size(140, 33);
            btnPersonelSil.TabIndex = 20;
            btnPersonelSil.Text = "Personel Sil";
            btnPersonelSil.UseVisualStyleBackColor = false;
            btnPersonelSil.Click += btnPersonelSil_Click;
            // 
            // lstTumCalisanlar
            // 
            lstTumCalisanlar.BackColor = SystemColors.ActiveCaptionText;
            lstTumCalisanlar.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8 });
            lstTumCalisanlar.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstTumCalisanlar.ForeColor = SystemColors.ButtonHighlight;
            lstTumCalisanlar.FullRowSelect = true;
            lstTumCalisanlar.GridLines = true;
            lstTumCalisanlar.Location = new Point(0, 66);
            lstTumCalisanlar.Name = "lstTumCalisanlar";
            lstTumCalisanlar.Size = new Size(536, 349);
            lstTumCalisanlar.TabIndex = 18;
            lstTumCalisanlar.UseCompatibleStateImageBehavior = false;
            lstTumCalisanlar.View = View.Details;
            lstTumCalisanlar.DoubleClick += lstTumCalisanlar_DoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ad";
            columnHeader5.Width = 140;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Soyad";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Kullanıcı Adı";
            columnHeader7.Width = 140;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Pozisyon";
            columnHeader8.Width = 100;
            // 
            // btnYetkiVer
            // 
            btnYetkiVer.BackColor = SystemColors.ActiveCaptionText;
            btnYetkiVer.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYetkiVer.ForeColor = SystemColors.ButtonHighlight;
            btnYetkiVer.Location = new Point(396, 27);
            btnYetkiVer.Name = "btnYetkiVer";
            btnYetkiVer.Size = new Size(140, 33);
            btnYetkiVer.TabIndex = 19;
            btnYetkiVer.Text = "Yetki Ver";
            btnYetkiVer.UseVisualStyleBackColor = false;
            btnYetkiVer.Click += btnYetkiVer_Click;
            // 
            // AdminScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1112, 443);
            Controls.Add(gboxTumCalisanlar);
            Controls.Add(gboxYetkiliIsimler);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "AdminScreen";
            Text = "CEO Ekranı";
            Load += AdminScreen_Load;
            gboxYetkiliIsimler.ResumeLayout(false);
            gboxTumCalisanlar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnAktifPasif;
        public ListView lstYetkiliIsimleri;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox gboxYetkiliIsimler;
        private Button btnYetkiSil;
        private GroupBox gboxTumCalisanlar;
        public ListView lstTumCalisanlar;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private Button btnYetkiVer;
        private Button btnPersonelSil;
    }
}