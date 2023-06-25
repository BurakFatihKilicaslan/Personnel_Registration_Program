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
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }
        KisiBLL kisiBLL;

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mtbKimlikNo.Text) || string.IsNullOrWhiteSpace(txtSifre.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;
            }
            kisiBLL = new KisiBLL();
            Kisi kisi = kisiBLL.KimlikNoGetir(mtbKimlikNo.Text);
            if (kisi == null)
            {
                MessageBox.Show("Kullanıcı Bulunamadı.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (kisi.Sifre != txtSifre.Text)
            {
                MessageBox.Show("Şifre Yanlış");
            }
            else if (!kisi.AktifMi)
            {
                MessageBox.Show("Statünüz Uygulamaya Girmek İçin Yeterli Olmayabilir Veya Admin Hesabınızı Askıya Almış Olabilir. Lütfen Admin İle İletişime Geçiniz");
            }
            else
            {
                if (kisi.KisiTipi == Entities.Enums.KisiTipi.Admin)
                {
                    DialogResult dr = MessageBox.Show("Yönetici Paneline Giriş Yapmak İçin (Yes) Butonu İle Personel Bilgi Ekranına Giriş Yapmak İçin (No) Butonu İle İşleminize Devam Edebilirsiniz", "Bir Seçim Yapınız", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dr == DialogResult.Yes)
                    {
                        this.Hide();
                        AdminScreen adminScreen = new AdminScreen();
                        adminScreen.ShowDialog();
                        Helper.FormuTemizle(this.Controls);
                        this.Show();
                    }
                    else if (dr == DialogResult.No)
                    {
                        this.Hide();
                        EmployeeInformationScreen employeeInformationScreen = new EmployeeInformationScreen();
                        employeeInformationScreen.ShowDialog();
                        Helper.FormuTemizle(this.Controls);
                        this.Show();
                    }
                }
                else if (kisi.KisiTipi == Entities.Enums.KisiTipi.Calisan)
                {
                    this.Hide();
                    EmployeeInformationScreen employeeInformationScreen = new EmployeeInformationScreen();
                    employeeInformationScreen.ShowDialog();
                    Helper.FormuTemizle(this.Controls);
                    this.Show();
                }
            }
        }
    }
}
