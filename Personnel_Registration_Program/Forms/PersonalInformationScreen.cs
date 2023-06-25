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
    public partial class PersonalInformationScreen : Form
    {
        public PersonalInformationScreen(int ID)
        {
            InitializeComponent();
            this.kisiID = ID;
            kisiBLL = new KisiBLL();
            departmanBLL = new DepartmanBLL();
        }
        int kisiID;
        KisiBLL kisiBLL;
        DepartmanBLL departmanBLL;

        private void PersonalInformationScreen_Load(object sender, EventArgs e)
        {
            TextBoxKontrol();
            Kisi kisi = kisiBLL.IdGetir(kisiID);
            if (kisi is not null)
            {
                txtAd.Text = kisi.Ad;
                txtSoyad.Text = kisi.Soyad;
                txtKimlikNo.Text = kisi.TcNo;
                txtDogumTarihi.Text = Convert.ToString(kisi.DogumTarihi);
                txtDepartman.Text = departmanBLL.DepartmanBilgisi(kisi.DepartmanID);
            }
        }

        private void btnIletisimBilgisiGoruntule_Click(object sender, EventArgs e)
        {
            this.Hide();
            InformationEditScreen informationEditScreen = new InformationEditScreen(kisiID);
            informationEditScreen.ShowDialog();
            this.Show();
        }

        private void TextBoxKontrol()
        {
            txtAd.Enabled = false;
            txtSoyad.Enabled = false;
            txtKimlikNo.Enabled = false;
            txtDogumTarihi.Enabled = false;
            txtDepartman.Enabled = false;
        }

    }
}
