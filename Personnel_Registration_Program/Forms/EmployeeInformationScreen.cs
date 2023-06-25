using BLL.BLL.Models;
using Entities.Models;
using Microsoft.VisualBasic.ApplicationServices;
using Personnel_Registration_Program.Others;
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
    public partial class EmployeeInformationScreen : Form
    {
        public EmployeeInformationScreen()
        {
            InitializeComponent();
            departmanBLL = new DepartmanBLL();
        }
        KisiBLL kisiBLL;
        DepartmanBLL departmanBLL;
        private void EmployeeInformationScreen_Load(object sender, EventArgs e)
        {
            Listele();
            ButonKontrol(true);
        }

        private void btnYeniPersonelGirisi_Click(object sender, EventArgs e)
        {
            this.Hide();
            EmployeeRegistrationScreen employeeRegistrationScreen = new EmployeeRegistrationScreen();
            employeeRegistrationScreen.ShowDialog();
            Listele();
            this.Show();
        }

        private void lstPersoneller_DoubleClick(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItems.Count > 0)
            {
                this.Hide();
                Kisi kisi = (Kisi)lstPersoneller.FocusedItem.Tag;
                if (kisi.ID != null)
                {
                    InformationEditScreen informationEditScreen = new InformationEditScreen(kisi.ID);
                    informationEditScreen.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Kişi Seçtiğinizden Emin Olunuz", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
        }

        private void btnPersoneliAra_Click(object sender, EventArgs e)
        {
            kisiBLL = new KisiBLL();
            lstPersoneller.Items.Clear();
            List<Kisi> kisiler = kisiBLL.IsmeGoreGetir(txtArananPersonel.Text);
            foreach (Kisi kisi in kisiler)
            {
                ListViewItem lvi = new();
                if (kisi.KisiTipi == Entities.Enums.KisiTipi.Calisan)
                {
                    lvi.Text = kisi.Ad;
                    lvi.SubItems.Add(kisi.Soyad);
                    lvi.SubItems.Add(departmanBLL.DepartmanBilgisi(kisi.DepartmanID));
                    lvi.Tag = kisi;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                    lstPersoneller.Items.Add(lvi);
                }
            }
            ButonKontrol(false);
        }

        private void btnTumPersoneliListele_Click(object sender, EventArgs e)
        {
            Listele();
            ButonKontrol(true);
            Helper.FormuTemizle(gboxArananPersonel.Controls);
        }

        private void btnDetayliBilgi_Click(object sender, EventArgs e)
        {
            if (lstPersoneller.SelectedItems.Count > 0)
            {
                this.Hide();
                Kisi kisi = (Kisi)lstPersoneller.FocusedItem.Tag;
                if (kisi is not null)
                {
                    PersonalInformationScreen personalInformationScreen = new PersonalInformationScreen(kisi.ID);
                    personalInformationScreen.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Kişi Seçtiğinizden Emin Olunuz", "Bilgilendirme", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void ButonKontrol(bool durum)
        {
            btnPersoneliAra.Enabled = durum;
            btnTumPersoneliListele.Enabled = !durum;
        }

        private void Listele()
        {
            kisiBLL = new KisiBLL();
            lstPersoneller.Items.Clear();
            List<Kisi> kisiler = kisiBLL.KisileriGetir();
            foreach (Kisi kisi in kisiler)
            {
                ListViewItem lvi = new();
                if (kisi.KisiTipi == Entities.Enums.KisiTipi.Calisan)
                {
                    lvi.Text = kisi.Ad;
                    lvi.SubItems.Add(kisi.Soyad);
                    lvi.SubItems.Add(departmanBLL.DepartmanBilgisi(kisi.DepartmanID));
                    lvi.Tag = kisi;  //Obje tuttugu icin userID yerine user atadık Tag'e..
                    lstPersoneller.Items.Add(lvi);
                }
            }
        }
    }
}
