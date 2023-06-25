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

namespace Personnel_Registration_Program.Forms
{
    public partial class InformationEditScreen : Form
    {
        public InformationEditScreen(int ID)
        {
            InitializeComponent();
            this.id = ID;
            iletisimBilgisiBLL = new IletisimBilgisiBLL();
        }
        int id;
        IletisimBilgisiBLL iletisimBilgisiBLL;
        KisiBLL kisiBLL;

        private void InformationEditScreen_Load(object sender, EventArgs e)
        {
            TextBoxKontrol(true);
            ButonKontrol(false);
            kisiBLL = new KisiBLL();
            Kisi kisi = kisiBLL.IdGetir(id);
            if (kisi != null)
            {
                IletisimBilgisiDoldur();
                txtMevcutGorev.Text = kisi.Gorev.ToString();
            }
        }

        private void lstIletisimBilgileri_DoubleClick(object sender, EventArgs e)
        {
            if (lstIletisimBilgileri.SelectedItems.Count > 0)
            {
                IletisimBilgisi iletisimBilgisi = (IletisimBilgisi)lstIletisimBilgileri.FocusedItem.Tag;
                if (iletisimBilgisi is not null)
                {
                    txtMailAdresi.Text = iletisimBilgisi.MailAdresi.ToString();
                    txtAdres.Text = iletisimBilgisi.Adres.ToString();
                    mtbTelefonNo.Text = iletisimBilgisi.TelefonNo;
                    ButonKontrol(true);
                    TextBoxKontrol(true);
                }
            }
        }

        private void btnBilgiEkle_Click(object sender, EventArgs e)
        {
            if (IletisimBilgiKontrol())
            {
                IletisimBilgisi iletisimBilgisi = new IletisimBilgisi();
                iletisimBilgisi.KisiID = id;
                iletisimBilgisi.MailAdresi = txtMailAdresi.Text;
                iletisimBilgisi.TelefonNo = mtbTelefonNo.Text;
                iletisimBilgisi.Adres = txtAdres.Text;
                bool eklendiMi = iletisimBilgisiBLL.Ekle(iletisimBilgisi);
                if (eklendiMi)
                {
                    MessageBox.Show("İletişim Bilgileri Ekleme İşlemi Gerçekleştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Helper.FormuTemizle(gboxArananPersonelBolumu.Controls);
                    IletisimBilgisiDoldur();
                }
                else
                {
                    MessageBox.Show("İletişim Bilgileri Eklenirken Bir Hata Meydana Gelmiştir. Lütfen Daha Sonra Tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (lstIletisimBilgileri.SelectedItems.Count > 0)
            {
                IletisimBilgisi iletisimBilgisi = (IletisimBilgisi)lstIletisimBilgileri.FocusedItem.Tag;
                if (iletisimBilgisi is not null)
                {
                    iletisimBilgisi.MailAdresi = txtMailAdresi.Text;
                    iletisimBilgisi.Adres = txtAdres.Text;
                    iletisimBilgisi.TelefonNo = mtbTelefonNo.Text;
                    bool guncellendiMi = iletisimBilgisiBLL.Guncelle(iletisimBilgisi);
                    if (guncellendiMi)
                    {
                        MessageBox.Show("Güncelleme İşleminiz Başarıyla Gerçekleştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.FormuTemizle(gboxArananPersonelBolumu.Controls);
                        IletisimBilgisiDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Güncelleme İşlemi Sırasında Hata Meydana Gelmiştir. Daha Sonra Tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lstIletisimBilgileri.SelectedItems.Count > 0)
            {
                IletisimBilgisi iletisimBilgisi = (IletisimBilgisi)lstIletisimBilgileri.FocusedItem.Tag;
                if (iletisimBilgisi is not null)
                {
                    txtMailAdresi.Text = iletisimBilgisi.MailAdresi.ToString();
                    txtAdres.Text = iletisimBilgisi.Adres.ToString();
                    mtbTelefonNo.Text = iletisimBilgisi.TelefonNo;
                    bool silindiMi = iletisimBilgisiBLL.Sil(iletisimBilgisi.ID);
                    if (silindiMi)
                    {
                        MessageBox.Show("Silme İşleminiz Başarıyla Gerçekleştirilmiştir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Helper.FormuTemizle(gboxArananPersonelBolumu.Controls);
                        IletisimBilgisiDoldur();
                    }
                    else
                    {
                        MessageBox.Show("Silme İşlemi Sırasında Hata Meydana Gelmiştir. Daha Sonra Tekrar Deneyiniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private bool IletisimBilgiKontrol()
        {
            if (string.IsNullOrWhiteSpace(mtbTelefonNo.Text) || string.IsNullOrWhiteSpace(txtMailAdresi.Text) || string.IsNullOrWhiteSpace(txtAdres.Text))
            {
                MessageBox.Show("Gerekli Bilgileri Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            string eposta = txtMailAdresi.Text;
            string model = @"^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            if (!Regex.IsMatch(eposta, model) && !eposta.EndsWith(".com"))
            {
                MessageBox.Show("Kullanıcı Adınızı Doğru Formatta Giriniz", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (iletisimBilgisiBLL.MailGetir(txtMailAdresi.Text) != null)
            {
                MessageBox.Show("Girilen Mail Bilgisi Farklı Olmalıdır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!(mtbTelefonNo.Text.Length == 11))
            {
                MessageBox.Show("Telefon Numarası 11 Haneden Oluşmalıdır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (iletisimBilgisiBLL.TelNoGetir(mtbTelefonNo.Text) != null)
            {
                MessageBox.Show("Girilen Telefon Bilgisi Farklı Olmalıdır", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            if (!(txtAdres.Text.Length >= 10))
            {
                MessageBox.Show("Adres Bilgileri Detaylı Girilmelidir", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            return true;
        }

        private void IletisimBilgisiDoldur()
        {
            lstIletisimBilgileri.Items.Clear();
            List<IletisimBilgisi> iletisimBilgileri = iletisimBilgisiBLL.IletisimBilgisiListele(id);
            foreach (IletisimBilgisi bilgi in iletisimBilgileri)
            {
                ListViewItem lvi = new();
                lvi.Text = bilgi.MailAdresi.ToString();
                lvi.SubItems.Add(bilgi.TelefonNo);
                lvi.SubItems.Add(bilgi.Adres);
                lvi.Tag = bilgi;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                lstIletisimBilgileri.Items.Add(lvi);
            }
        }

        private void TextBoxKontrol(bool durum)
        {
            txtMailAdresi.Enabled = durum;
            txtAdres.Enabled = durum;
            txtMevcutGorev.Enabled = false;         //Degisiklik Yapilamayacak
            mtbTelefonNo.Enabled = durum;
        }
        private void ButonKontrol(bool butonDurum)
        {
            btnBilgiEkle.Enabled = !butonDurum;
            btnGuncelle.Enabled = butonDurum;
            btnSil.Enabled = butonDurum;
        }
    }
}
