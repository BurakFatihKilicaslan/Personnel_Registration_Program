namespace Personnel_Registration_Program.Forms
{
    partial class LoginScreen
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
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnGiris = new Button();
            txtSifre = new TextBox();
            mtbKimlikNo = new MaskedTextBox();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaptionText;
            label3.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(8, 95);
            label3.Name = "label3";
            label3.Size = new Size(51, 23);
            label3.TabIndex = 34;
            label3.Text = "Şifre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaptionText;
            label2.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(8, 47);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 33;
            label2.Text = "Kullanıcı Adı (T.C.):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Firebrick;
            label1.Location = new Point(42, 9);
            label1.Name = "label1";
            label1.Size = new Size(296, 20);
            label1.TabIndex = 32;
            label1.Text = "Personel Kayıt Programına Hoş Geldiniz";
            // 
            // btnGiris
            // 
            btnGiris.BackColor = SystemColors.ActiveCaptionText;
            btnGiris.Font = new Font("Segoe Script", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnGiris.Location = new Point(14, 139);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(345, 41);
            btnGiris.TabIndex = 30;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = false;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.BackColor = SystemColors.InactiveCaptionText;
            txtSifre.Font = new Font("Segoe Script", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtSifre.ForeColor = SystemColors.ButtonHighlight;
            txtSifre.Location = new Point(182, 95);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.Size = new Size(177, 27);
            txtSifre.TabIndex = 29;
            // 
            // mtbKimlikNo
            // 
            mtbKimlikNo.BackColor = SystemColors.InactiveCaptionText;
            mtbKimlikNo.Font = new Font("Segoe Script", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            mtbKimlikNo.ForeColor = SystemColors.ButtonHighlight;
            mtbKimlikNo.Location = new Point(182, 48);
            mtbKimlikNo.Mask = "00000000000";
            mtbKimlikNo.Name = "mtbKimlikNo";
            mtbKimlikNo.Size = new Size(177, 28);
            mtbKimlikNo.TabIndex = 36;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(373, 200);
            Controls.Add(mtbKimlikNo);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "LoginScreen";
            Text = "Giriş Ekranı";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnGiris;
        private TextBox txtSifre;
        private MaskedTextBox mtbKimlikNo;
    }
}