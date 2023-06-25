using BLL.BLL.Models;
using Entities.Models;
using Personnel_Registration_Program.Others;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Personnel_Registration_Program.Forms
{
    public partial class EmployeeRegistrationScreen : Form
    {
        public EmployeeRegistrationScreen()
        {
            InitializeComponent();
            kisiBLL = new KisiBLL();
            departmanBLL = new DepartmanBLL();
        }
        KisiBLL kisiBLL;
        DepartmanBLL departmanBLL;

        private void EmployeeRegistrationScreen_Load(object sender, EventArgs e)
        {
            cmbDepartman.DisplayMember = "DepartmanAdi";
            cmbDepartman.ValueMember = "ID";
            cmbDepartman.DataSource = departmanBLL.Listele();
        }

        private void btnKaydol_Click(object sender, EventArgs e)
        {
            if (BilgiKontrol())
            {
                Kisi kisi = new Kisi();
                kisi.Ad = txtAd.Text;
                kisi.Soyad = txtSoyad.Text;
                kisi.TcNo = mtbKimlikNo.Text;
                kisi.DogumTarihi = dtpDogumTarihi.Value;
                kisi.Cinsiyet = rbErkek.Checked ? Entities.Enums.Cinsiyet.Erkek : Entities.Enums.Cinsiyet.Kadın;
                kisi.Gorev = Entities.Enums.Gorev.Personel;
                kisi.KisiTipi = Entities.Enums.KisiTipi.Calisan;
                kisi.AktifMi = false;
                kisi.Sifre = kisiBLL.ComputeSha256Hash(txtSifre.Text);
                kisi.DepartmanID = (int)cmbDepartman.SelectedValue;
                bool eklendiMi = kisiBLL.Ekle(kisi);
                if (eklendiMi)
                {
                    MessageBox.Show("Personelin Temel Bilgileri Kaydedilmiştir. Personelin Ayrıntılı Bilgilerini Eklemek İçin Personel Bilgi Ekranından Gerekli işlemleri Yaparak Gerçekleştireblirsiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Helper.FormuTemizle(this.Controls);
                }
                else
                {
                    MessageBox.Show("Sistemde Hata Meydana Gelmiştir. Sonra Tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private bool SifreDogrulama(string sifre)
        {
            int karakterUzunluk = 8; int buyukHarf = 2; int kucukHarf = 3; int ozelKarakter = 2;
            if (sifre.Length < karakterUzunluk) { return false; }
            if (sifre.Count(char.IsUpper) < buyukHarf) { return false; }
            if (sifre.Count(char.IsLower) < kucukHarf) { return false; }
            if (sifre.Count(c => "!:+*".Contains(c)) < ozelKarakter) { return false; }
            return true;
        }

        private bool BilgiKontrol()
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text) || string.IsNullOrWhiteSpace(txtSoyad.Text) || string.IsNullOrWhiteSpace(mtbKimlikNo.Text))
            {
                MessageBox.Show("Gerekli Bilgileri Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (DateTime.Now.Year - dtpDogumTarihi.Value.Year < 18)
            {
                MessageBox.Show("18 Yaşından Büyük Olmalısınız", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtAd.Text.Length > 50)
            {
                MessageBox.Show("Ad En Fazla 50 Karakter İçerebilir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSoyad.Text.Length > 50)
            {
                MessageBox.Show("Soyad En Fazla 50 Karakter İçerebilir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (txtSifre.Text != txtSifreTekrar.Text)
            {
                MessageBox.Show("Şifreler uyuşmuyor");
                return false;
            }
            else if (!SifreDogrulama(txtSifre.Text))
            {
                MessageBox.Show("Şifreler uygun kriterlere sahip değil\n---Kriterler---\n•En az 8 karakter uzunluğunda olmalıdır.\n• En az 2 büyük harf içermelidir.\n• En az 3 küçük harf içermelidir.\n• En az 2 rakam içermelidir.\n• ! (ünlem), : (iki nokta üst üste), +(artı), *(yıldız) karakterlerinden en az 1 tanesini içermelidir.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                if (kisiBLL.KimlikNoGetir(mtbKimlikNo.Text) is not null)
                {
                    MessageBox.Show("Bu Kimlik Numarası İle Personel Mevcuttur\n•Kimlik Numarasının Doğruluğundan Emin Olunuz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                return true;
            }
        }
    }
}
