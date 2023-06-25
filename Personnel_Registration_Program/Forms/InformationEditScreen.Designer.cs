namespace Personnel_Registration_Program.Forms
{
    partial class InformationEditScreen
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
            label1 = new Label();
            txtMevcutGorev = new TextBox();
            label9 = new Label();
            txtAdres = new TextBox();
            mtbTelefonNo = new MaskedTextBox();
            label6 = new Label();
            label4 = new Label();
            txtMailAdresi = new TextBox();
            btnBilgiEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            gboxIletisimBilgileri = new GroupBox();
            lstIletisimBilgileri = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            gboxArananPersonelBolumu = new GroupBox();
            gboxIletisimBilgileri.SuspendLayout();
            gboxArananPersonelBolumu.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(7, 92);
            label1.Name = "label1";
            label1.Size = new Size(129, 23);
            label1.TabIndex = 117;
            label1.Text = "Mevcut Görevi:";
            // 
            // txtMevcutGorev
            // 
            txtMevcutGorev.BackColor = SystemColors.ActiveCaptionText;
            txtMevcutGorev.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            txtMevcutGorev.ForeColor = SystemColors.ButtonHighlight;
            txtMevcutGorev.Location = new Point(148, 88);
            txtMevcutGorev.Name = "txtMevcutGorev";
            txtMevcutGorev.Size = new Size(209, 27);
            txtMevcutGorev.TabIndex = 116;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.ActiveCaptionText;
            label9.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonHighlight;
            label9.Location = new Point(7, 121);
            label9.Name = "label9";
            label9.Size = new Size(59, 23);
            label9.TabIndex = 115;
            label9.Text = "Adres:";
            // 
            // txtAdres
            // 
            txtAdres.BackColor = SystemColors.ActiveCaptionText;
            txtAdres.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAdres.ForeColor = SystemColors.ButtonHighlight;
            txtAdres.Location = new Point(148, 121);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(209, 96);
            txtAdres.TabIndex = 114;
            // 
            // mtbTelefonNo
            // 
            mtbTelefonNo.BackColor = SystemColors.ActiveCaptionText;
            mtbTelefonNo.ForeColor = SystemColors.ButtonHighlight;
            mtbTelefonNo.Location = new Point(148, 59);
            mtbTelefonNo.Mask = "09990000000";
            mtbTelefonNo.Name = "mtbTelefonNo";
            mtbTelefonNo.Size = new Size(209, 28);
            mtbTelefonNo.TabIndex = 113;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.ActiveCaptionText;
            label6.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(7, 58);
            label6.Name = "label6";
            label6.Size = new Size(99, 23);
            label6.TabIndex = 112;
            label6.Text = "Telefon No:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(7, 30);
            label4.Name = "label4";
            label4.Size = new Size(109, 23);
            label4.TabIndex = 111;
            label4.Text = "Mail Adresi:";
            // 
            // txtMailAdresi
            // 
            txtMailAdresi.BackColor = SystemColors.ActiveCaptionText;
            txtMailAdresi.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtMailAdresi.ForeColor = SystemColors.ButtonHighlight;
            txtMailAdresi.Location = new Point(148, 26);
            txtMailAdresi.Name = "txtMailAdresi";
            txtMailAdresi.Size = new Size(209, 27);
            txtMailAdresi.TabIndex = 110;
            // 
            // btnBilgiEkle
            // 
            btnBilgiEkle.BackColor = SystemColors.ActiveCaptionText;
            btnBilgiEkle.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnBilgiEkle.ForeColor = SystemColors.ButtonHighlight;
            btnBilgiEkle.Location = new Point(388, 17);
            btnBilgiEkle.Name = "btnBilgiEkle";
            btnBilgiEkle.Size = new Size(181, 59);
            btnBilgiEkle.TabIndex = 118;
            btnBilgiEkle.Text = "Bilgi Ekle";
            btnBilgiEkle.UseVisualStyleBackColor = false;
            btnBilgiEkle.Click += btnBilgiEkle_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ActiveCaptionText;
            btnSil.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSil.ForeColor = SystemColors.ButtonHighlight;
            btnSil.Location = new Point(388, 163);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(181, 59);
            btnSil.TabIndex = 119;
            btnSil.Text = "Bilgi Sil";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.ActiveCaptionText;
            btnGuncelle.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGuncelle.ForeColor = SystemColors.ButtonHighlight;
            btnGuncelle.Location = new Point(388, 89);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(181, 60);
            btnGuncelle.TabIndex = 120;
            btnGuncelle.Text = "Bilgi Güncelle";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // gboxIletisimBilgileri
            // 
            gboxIletisimBilgileri.BackColor = SystemColors.ActiveCaptionText;
            gboxIletisimBilgileri.Controls.Add(lstIletisimBilgileri);
            gboxIletisimBilgileri.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxIletisimBilgileri.ForeColor = SystemColors.ButtonHighlight;
            gboxIletisimBilgileri.Location = new Point(12, 234);
            gboxIletisimBilgileri.Name = "gboxIletisimBilgileri";
            gboxIletisimBilgileri.Size = new Size(557, 227);
            gboxIletisimBilgileri.TabIndex = 121;
            gboxIletisimBilgileri.TabStop = false;
            gboxIletisimBilgileri.Text = "İletişim Bilgileri";
            // 
            // lstIletisimBilgileri
            // 
            lstIletisimBilgileri.BackColor = SystemColors.ActiveCaptionText;
            lstIletisimBilgileri.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader1 });
            lstIletisimBilgileri.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstIletisimBilgileri.ForeColor = SystemColors.ButtonHighlight;
            lstIletisimBilgileri.FullRowSelect = true;
            lstIletisimBilgileri.GridLines = true;
            lstIletisimBilgileri.Location = new Point(6, 27);
            lstIletisimBilgileri.Name = "lstIletisimBilgileri";
            lstIletisimBilgileri.Size = new Size(545, 194);
            lstIletisimBilgileri.TabIndex = 18;
            lstIletisimBilgileri.UseCompatibleStateImageBehavior = false;
            lstIletisimBilgileri.View = View.Details;
            lstIletisimBilgileri.DoubleClick += lstIletisimBilgileri_DoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Mail Adresi";
            columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Telefon No";
            columnHeader6.Width = 180;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Adres";
            columnHeader1.Width = 180;
            // 
            // gboxArananPersonelBolumu
            // 
            gboxArananPersonelBolumu.Controls.Add(label4);
            gboxArananPersonelBolumu.Controls.Add(txtMailAdresi);
            gboxArananPersonelBolumu.Controls.Add(label6);
            gboxArananPersonelBolumu.Controls.Add(mtbTelefonNo);
            gboxArananPersonelBolumu.Controls.Add(txtAdres);
            gboxArananPersonelBolumu.Controls.Add(label1);
            gboxArananPersonelBolumu.Controls.Add(label9);
            gboxArananPersonelBolumu.Controls.Add(txtMevcutGorev);
            gboxArananPersonelBolumu.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxArananPersonelBolumu.ForeColor = SystemColors.ButtonHighlight;
            gboxArananPersonelBolumu.Location = new Point(12, 5);
            gboxArananPersonelBolumu.Name = "gboxArananPersonelBolumu";
            gboxArananPersonelBolumu.Size = new Size(363, 223);
            gboxArananPersonelBolumu.TabIndex = 122;
            gboxArananPersonelBolumu.TabStop = false;
            gboxArananPersonelBolumu.Text = "Aranan Personel Bölümü";
            // 
            // InformationEditScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(578, 468);
            Controls.Add(gboxArananPersonelBolumu);
            Controls.Add(gboxIletisimBilgileri);
            Controls.Add(btnGuncelle);
            Controls.Add(btnSil);
            Controls.Add(btnBilgiEkle);
            Name = "InformationEditScreen";
            Text = "Bilgi Düzenleme Ekranı";
            Load += InformationEditScreen_Load;
            gboxIletisimBilgileri.ResumeLayout(false);
            gboxArananPersonelBolumu.ResumeLayout(false);
            gboxArananPersonelBolumu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtMevcutGorev;
        private Label label9;
        private TextBox txtAdres;
        private MaskedTextBox mtbTelefonNo;
        private Label label6;
        private Label label4;
        private TextBox txtMailAdresi;
        private Button btnBilgiEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private GroupBox gboxIletisimBilgileri;
        public ListView lstIletisimBilgileri;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private GroupBox gboxArananPersonelBolumu;
    }
}