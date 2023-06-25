namespace Personnel_Registration_Program.Forms
{
    partial class EmployeeRegistrationScreen
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
            label5 = new Label();
            txtSifreTekrar = new TextBox();
            label1 = new Label();
            txtSifre = new TextBox();
            label3 = new Label();
            label2 = new Label();
            btnKaydol = new Button();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            gboxCinsiyetler = new GroupBox();
            rbKadin = new RadioButton();
            rbErkek = new RadioButton();
            label7 = new Label();
            label8 = new Label();
            mtbKimlikNo = new MaskedTextBox();
            dtpDogumTarihi = new DateTimePicker();
            label10 = new Label();
            cmbDepartman = new ComboBox();
            label4 = new Label();
            gboxCinsiyetler.SuspendLayout();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ActiveCaptionText;
            label5.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(12, 430);
            label5.Name = "label5";
            label5.Size = new Size(105, 23);
            label5.TabIndex = 46;
            label5.Text = "Şifre Tekrar";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.BackColor = SystemColors.ActiveCaptionText;
            txtSifreTekrar.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifreTekrar.ForeColor = SystemColors.ButtonHighlight;
            txtSifreTekrar.Location = new Point(153, 430);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(200, 27);
            txtSifreTekrar.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 384);
            label1.Name = "label1";
            label1.Size = new Size(51, 23);
            label1.TabIndex = 45;
            label1.Text = "Şifre:";
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.ActiveCaptionText;
            txtSifre.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.ForeColor = SystemColors.ButtonHighlight;
            txtSifre.Location = new Point(153, 384);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(200, 27);
            txtSifre.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(12, 70);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 43;
            label3.Text = "Soyad:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(12, 22);
            label2.Name = "label2";
            label2.Size = new Size(38, 23);
            label2.TabIndex = 42;
            label2.Text = "Ad:";
            // 
            // btnKaydol
            // 
            btnKaydol.BackColor = SystemColors.ActiveCaptionText;
            btnKaydol.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnKaydol.Location = new Point(13, 473);
            btnKaydol.Name = "btnKaydol";
            btnKaydol.Size = new Size(340, 42);
            btnKaydol.TabIndex = 41;
            btnKaydol.Text = "Personeli Kaydet";
            btnKaydol.UseVisualStyleBackColor = false;
            btnKaydol.Click += btnKaydol_Click;
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = SystemColors.ActiveCaptionText;
            txtSoyad.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSoyad.ForeColor = SystemColors.ButtonHighlight;
            txtSoyad.Location = new Point(153, 66);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(200, 27);
            txtSoyad.TabIndex = 37;
            // 
            // txtAd
            // 
            txtAd.BackColor = SystemColors.ActiveCaptionText;
            txtAd.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtAd.ForeColor = SystemColors.ButtonHighlight;
            txtAd.Location = new Point(153, 18);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(200, 27);
            txtAd.TabIndex = 36;
            // 
            // gboxCinsiyetler
            // 
            gboxCinsiyetler.BackColor = SystemColors.ActiveCaptionText;
            gboxCinsiyetler.Controls.Add(rbKadin);
            gboxCinsiyetler.Controls.Add(rbErkek);
            gboxCinsiyetler.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            gboxCinsiyetler.Location = new Point(152, 206);
            gboxCinsiyetler.Margin = new Padding(3, 4, 3, 4);
            gboxCinsiyetler.Name = "gboxCinsiyetler";
            gboxCinsiyetler.Padding = new Padding(3, 4, 3, 4);
            gboxCinsiyetler.Size = new Size(159, 112);
            gboxCinsiyetler.TabIndex = 78;
            gboxCinsiyetler.TabStop = false;
            // 
            // rbKadin
            // 
            rbKadin.AutoSize = true;
            rbKadin.BackColor = SystemColors.ActiveCaptionText;
            rbKadin.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbKadin.ForeColor = SystemColors.ButtonHighlight;
            rbKadin.Location = new Point(16, 76);
            rbKadin.Margin = new Padding(3, 4, 3, 4);
            rbKadin.Name = "rbKadin";
            rbKadin.Size = new Size(79, 27);
            rbKadin.TabIndex = 1;
            rbKadin.Text = "Kadın";
            rbKadin.UseVisualStyleBackColor = false;
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.BackColor = SystemColors.ActiveCaptionText;
            rbErkek.Checked = true;
            rbErkek.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rbErkek.ForeColor = SystemColors.ButtonHighlight;
            rbErkek.Location = new Point(16, 23);
            rbErkek.Margin = new Padding(3, 4, 3, 4);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(74, 27);
            rbErkek.TabIndex = 0;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.ActiveCaptionText;
            label7.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonHighlight;
            label7.Location = new Point(12, 121);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 82;
            label7.Text = "TC No:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.ActiveCaptionText;
            label8.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(13, 171);
            label8.Name = "label8";
            label8.Size = new Size(130, 23);
            label8.TabIndex = 83;
            label8.Text = "Doğum Tarihi:";
            // 
            // mtbKimlikNo
            // 
            mtbKimlikNo.BackColor = SystemColors.ActiveCaptionText;
            mtbKimlikNo.ForeColor = SystemColors.ButtonHighlight;
            mtbKimlikNo.Location = new Point(153, 121);
            mtbKimlikNo.Mask = "00000000000";
            mtbKimlikNo.Name = "mtbKimlikNo";
            mtbKimlikNo.Size = new Size(200, 23);
            mtbKimlikNo.TabIndex = 88;
            // 
            // dtpDogumTarihi
            // 
            dtpDogumTarihi.Location = new Point(153, 171);
            dtpDogumTarihi.Name = "dtpDogumTarihi";
            dtpDogumTarihi.Size = new Size(200, 23);
            dtpDogumTarihi.TabIndex = 89;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = SystemColors.ActiveCaptionText;
            label10.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ButtonHighlight;
            label10.Location = new Point(12, 229);
            label10.Name = "label10";
            label10.Size = new Size(82, 23);
            label10.TabIndex = 90;
            label10.Text = "Cinsiyet:";
            // 
            // cmbDepartman
            // 
            cmbDepartman.BackColor = SystemColors.InactiveCaptionText;
            cmbDepartman.Font = new Font("Segoe Script", 9F, FontStyle.Bold, GraphicsUnit.Point);
            cmbDepartman.ForeColor = SystemColors.ButtonHighlight;
            cmbDepartman.FormattingEnabled = true;
            cmbDepartman.Location = new Point(153, 337);
            cmbDepartman.Name = "cmbDepartman";
            cmbDepartman.Size = new Size(200, 28);
            cmbDepartman.TabIndex = 91;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaptionText;
            label4.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(12, 336);
            label4.Name = "label4";
            label4.Size = new Size(103, 23);
            label4.TabIndex = 92;
            label4.Text = "Departman:";
            // 
            // EmployeeRegistrationScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(381, 536);
            Controls.Add(label4);
            Controls.Add(cmbDepartman);
            Controls.Add(label10);
            Controls.Add(dtpDogumTarihi);
            Controls.Add(mtbKimlikNo);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(gboxCinsiyetler);
            Controls.Add(label5);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label1);
            Controls.Add(txtSifre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnKaydol);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "EmployeeRegistrationScreen";
            Text = "Personel Kayıt Ekranı";
            Load += EmployeeRegistrationScreen_Load;
            gboxCinsiyetler.ResumeLayout(false);
            gboxCinsiyetler.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox txtSifreTekrar;
        private Label label1;
        private TextBox txtSifre;
        private Label label3;
        private Label label2;
        private Button btnKaydol;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private GroupBox gboxCinsiyetler;
        private RadioButton rbKadin;
        private RadioButton rbErkek;
        private Label label7;
        private Label label8;
        private MaskedTextBox mtbKimlikNo;
        private DateTimePicker dtpDogumTarihi;
        private Label label10;
        private ComboBox cmbDepartman;
        private Label label4;
    }
}