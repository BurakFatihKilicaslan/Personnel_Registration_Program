namespace Personnel_Registration_Program.Forms
{
    partial class EmployeeInformationScreen
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
            gboxTumCalisanlar = new GroupBox();
            btnTumPersoneliListele = new Button();
            gboxArananPersonel = new GroupBox();
            btnPersoneliAra = new Button();
            txtArananPersonel = new TextBox();
            lstPersoneller = new ListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            btnYeniPersonelGirisi = new Button();
            btnDetayliBilgi = new Button();
            gboxTumCalisanlar.SuspendLayout();
            gboxArananPersonel.SuspendLayout();
            SuspendLayout();
            // 
            // gboxTumCalisanlar
            // 
            gboxTumCalisanlar.BackColor = SystemColors.ActiveCaptionText;
            gboxTumCalisanlar.Controls.Add(btnTumPersoneliListele);
            gboxTumCalisanlar.Controls.Add(gboxArananPersonel);
            gboxTumCalisanlar.Controls.Add(lstPersoneller);
            gboxTumCalisanlar.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxTumCalisanlar.ForeColor = SystemColors.ButtonHighlight;
            gboxTumCalisanlar.Location = new Point(12, 12);
            gboxTumCalisanlar.Name = "gboxTumCalisanlar";
            gboxTumCalisanlar.Size = new Size(555, 459);
            gboxTumCalisanlar.TabIndex = 22;
            gboxTumCalisanlar.TabStop = false;
            gboxTumCalisanlar.Text = "Personeller";
            // 
            // btnTumPersoneliListele
            // 
            btnTumPersoneliListele.BackColor = SystemColors.ActiveCaptionText;
            btnTumPersoneliListele.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnTumPersoneliListele.ForeColor = SystemColors.ButtonHighlight;
            btnTumPersoneliListele.Location = new Point(367, 39);
            btnTumPersoneliListele.Name = "btnTumPersoneliListele";
            btnTumPersoneliListele.Size = new Size(169, 55);
            btnTumPersoneliListele.TabIndex = 44;
            btnTumPersoneliListele.Text = "Tüm Personeli Listele";
            btnTumPersoneliListele.UseVisualStyleBackColor = false;
            btnTumPersoneliListele.Click += btnTumPersoneliListele_Click;
            // 
            // gboxArananPersonel
            // 
            gboxArananPersonel.Controls.Add(btnPersoneliAra);
            gboxArananPersonel.Controls.Add(txtArananPersonel);
            gboxArananPersonel.ForeColor = SystemColors.ButtonHighlight;
            gboxArananPersonel.Location = new Point(6, 27);
            gboxArananPersonel.Name = "gboxArananPersonel";
            gboxArananPersonel.Size = new Size(335, 67);
            gboxArananPersonel.TabIndex = 45;
            gboxArananPersonel.TabStop = false;
            gboxArananPersonel.Text = "Aramak İstediğiniz Personelin Adı";
            // 
            // btnPersoneliAra
            // 
            btnPersoneliAra.BackColor = SystemColors.ActiveCaptionText;
            btnPersoneliAra.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnPersoneliAra.ForeColor = SystemColors.ButtonHighlight;
            btnPersoneliAra.Location = new Point(160, 27);
            btnPersoneliAra.Name = "btnPersoneliAra";
            btnPersoneliAra.Size = new Size(169, 28);
            btnPersoneliAra.TabIndex = 43;
            btnPersoneliAra.Text = "Personeli Ara";
            btnPersoneliAra.UseVisualStyleBackColor = false;
            btnPersoneliAra.Click += btnPersoneliAra_Click;
            // 
            // txtArananPersonel
            // 
            txtArananPersonel.BackColor = SystemColors.InactiveCaptionText;
            txtArananPersonel.ForeColor = SystemColors.ButtonHighlight;
            txtArananPersonel.Location = new Point(6, 27);
            txtArananPersonel.Name = "txtArananPersonel";
            txtArananPersonel.PlaceholderText = "Ad Giriniz";
            txtArananPersonel.Size = new Size(138, 28);
            txtArananPersonel.TabIndex = 19;
            // 
            // lstPersoneller
            // 
            lstPersoneller.BackColor = SystemColors.ActiveCaptionText;
            lstPersoneller.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader1 });
            lstPersoneller.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lstPersoneller.ForeColor = SystemColors.ButtonHighlight;
            lstPersoneller.FullRowSelect = true;
            lstPersoneller.GridLines = true;
            lstPersoneller.Location = new Point(4, 104);
            lstPersoneller.Name = "lstPersoneller";
            lstPersoneller.Size = new Size(545, 349);
            lstPersoneller.TabIndex = 18;
            lstPersoneller.UseCompatibleStateImageBehavior = false;
            lstPersoneller.View = View.Details;
            lstPersoneller.DoubleClick += lstPersoneller_DoubleClick;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Ad";
            columnHeader5.Width = 180;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Soyad";
            columnHeader6.Width = 180;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Departman";
            columnHeader1.Width = 180;
            // 
            // btnYeniPersonelGirisi
            // 
            btnYeniPersonelGirisi.BackColor = SystemColors.ActiveCaptionText;
            btnYeniPersonelGirisi.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnYeniPersonelGirisi.ForeColor = SystemColors.ButtonHighlight;
            btnYeniPersonelGirisi.Location = new Point(358, 477);
            btnYeniPersonelGirisi.Name = "btnYeniPersonelGirisi";
            btnYeniPersonelGirisi.Size = new Size(209, 42);
            btnYeniPersonelGirisi.TabIndex = 42;
            btnYeniPersonelGirisi.Text = "Personel Kaydı Oluştur";
            btnYeniPersonelGirisi.UseVisualStyleBackColor = false;
            btnYeniPersonelGirisi.Click += btnYeniPersonelGirisi_Click;
            // 
            // btnDetayliBilgi
            // 
            btnDetayliBilgi.BackColor = SystemColors.ActiveCaptionText;
            btnDetayliBilgi.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetayliBilgi.ForeColor = SystemColors.ButtonHighlight;
            btnDetayliBilgi.Location = new Point(12, 477);
            btnDetayliBilgi.Name = "btnDetayliBilgi";
            btnDetayliBilgi.Size = new Size(280, 42);
            btnDetayliBilgi.TabIndex = 43;
            btnDetayliBilgi.Text = "Personel Bilgisini Detaylandır";
            btnDetayliBilgi.UseVisualStyleBackColor = false;
            btnDetayliBilgi.Click += btnDetayliBilgi_Click;
            // 
            // EmployeeInformationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(581, 529);
            Controls.Add(btnDetayliBilgi);
            Controls.Add(btnYeniPersonelGirisi);
            Controls.Add(gboxTumCalisanlar);
            Name = "EmployeeInformationScreen";
            Text = "Personel Bilgi Ekranı";
            Load += EmployeeInformationScreen_Load;
            gboxTumCalisanlar.ResumeLayout(false);
            gboxArananPersonel.ResumeLayout(false);
            gboxArananPersonel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gboxTumCalisanlar;
        private TextBox txtArananPersonel;
        public ListView lstPersoneller;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader1;
        private Button btnYeniPersonelGirisi;
        private Button btnTumPersoneliListele;
        private GroupBox gboxArananPersonel;
        private Button btnPersoneliAra;
        private Button btnDetayliBilgi;
    }
}