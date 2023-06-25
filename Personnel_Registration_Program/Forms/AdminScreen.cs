using BLL.BLL.Models;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personnel_Registration_Program.Forms
{
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
        }
        KisiBLL kisiBLL;

        private void AdminScreen_Load(object sender, EventArgs e)
        {
            ButonKontrol();
            PersonelListesiDoldur();
        }

        private void lstYetkiliIsimleri_DoubleClick(object sender, EventArgs e)
        {
            ButonKontrol();
        }

        private void lstTumCalisanlar_DoubleClick(object sender, EventArgs e)
        {
            ButonKontrol();
        }

        private void btnYetkiVer_Click(object sender, EventArgs e)
        {
            Kisi kisi = lstTumCalisanlar.FocusedItem.Tag as Kisi;
            if (kisi is not null)
            {
                kisi.Gorev = Entities.Enums.Gorev.Yetkili;
            }
            bool yetkiVerildiMi = kisiBLL.Guncelle(kisi);
            if (yetkiVerildiMi)
            {
                MessageBox.Show("Kullanıcı Yetkisi Güncellendi.");
                PersonelListesiDoldur();
            }
            else
            {
                MessageBox.Show("Kullanıcı Yetkisi Güncellenirken Beklenmeyen Bir Hata Oluştu.");
            }
        }

        private void btnPersonelSil_Click(object sender, EventArgs e)
        {
            Kisi kisi = lstTumCalisanlar.FocusedItem.Tag as Kisi;
            if (kisi is not null)
            {
                bool kisiSilindiMi = kisiBLL.Sil(kisi.ID);
                if (kisiSilindiMi)
                {
                    MessageBox.Show("Personel Silme İşlemi Gerçekleştirilmiştir.");
                    PersonelListesiDoldur();
                }
                else
                {
                    MessageBox.Show("Personel Silme İşlemi Gerçekleştirilirken Beklenmeyen Bir Hata Oluştu.");
                }
            }
        }

        private void btnAktifPasif_Click(object sender, EventArgs e)
        {
            Kisi kisi = lstYetkiliIsimleri.FocusedItem.Tag as Kisi;
            if (kisi.AktifMi)
            {
                kisi.AktifMi = false;
            }
            else
            {
                kisi.AktifMi = true;
            }
            bool durumGuncellendiMi = kisiBLL.Guncelle(kisi);
            if (durumGuncellendiMi)
            {
                MessageBox.Show("Kullanıcı Durumu Güncellendi.");
                PersonelListesiDoldur();
            }
            else
            {
                MessageBox.Show("Kullanıcı Durumu Güncellenirken Beklenmeyen Bir Hata Oluştu.");
            }
        }

        private void btnYetkiSil_Click(object sender, EventArgs e)
        {
            Kisi kisi = lstYetkiliIsimleri.FocusedItem.Tag as Kisi;
            if (kisi is not null)
            {
                kisi.Gorev = Entities.Enums.Gorev.Personel;
            }
            bool yetkiSilindiMi = kisiBLL.Guncelle(kisi);
            if (yetkiSilindiMi)
            {
                MessageBox.Show("Kullanıcı Yetkisi Güncellendi.");
                PersonelListesiDoldur();
            }
            else
            {
                MessageBox.Show("Kullanıcı Yetkisi Güncellenirken Beklenmeyen Bir Hata Oluştu.");
            }
        }

        private void ButonKontrol()
        {
            btnYetkiVer.Enabled = false;
            btnPersonelSil.Enabled = false;
            btnYetkiSil.Enabled = false;
            btnAktifPasif.Enabled = false;
            if (lstTumCalisanlar.SelectedItems.Count > 0)
            {
                Kisi kisi = (Kisi)lstTumCalisanlar.FocusedItem.Tag;
                if (kisi is not null)
                {
                    btnYetkiVer.Enabled = true;
                    btnPersonelSil.Enabled = true;
                }
            }
            if (lstYetkiliIsimleri.SelectedItems.Count > 0)
            {
                Kisi kisi = (Kisi)lstYetkiliIsimleri.FocusedItem.Tag;
                if (kisi is not null)
                {
                    btnYetkiSil.Enabled = true;
                    btnAktifPasif.Enabled = true;
                }
            }
        }

        private void PersonelListesiDoldur()
        {
            lstTumCalisanlar.Items.Clear();
            lstYetkiliIsimleri.Items.Clear();
            kisiBLL = new KisiBLL();
            lstTumCalisanlar.Items.Clear();
            List<Kisi> kisiler = kisiBLL.KisileriGetir();
            foreach (Kisi kisi in kisiler)
            {
                ListViewItem lvi = new();
                if (kisi.Gorev == Entities.Enums.Gorev.Personel)
                {
                    lvi.Text = kisi.Ad;
                    lvi.SubItems.Add(kisi.Soyad);
                    lvi.SubItems.Add(kisi.TcNo);
                    lvi.SubItems.Add(kisi.Gorev.ToString());
                    lvi.Tag = kisi;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                    lstTumCalisanlar.Items.Add(lvi);
                }
                else
                {
                    lvi.Text = kisi.Ad;
                    lvi.SubItems.Add(kisi.Soyad);
                    lvi.SubItems.Add(kisi.TcNo);
                    lvi.SubItems.Add(kisi.AktifMi.ToString());
                    lvi.Tag = kisi;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                    lstYetkiliIsimleri.Items.Add(lvi);
                }
            }
        }

    }
}
