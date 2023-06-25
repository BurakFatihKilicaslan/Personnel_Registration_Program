using Entities.Abstracts;
using Entities.Enums;

namespace Entities.Models
{
    public class Kisi : Genel
    {
        public Kisi()
        {
            IletisimBilgileri = new List<IletisimBilgisi>();
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string TcNo { get; set; }
        public DateTime DogumTarihi { get; set; }
        public Cinsiyet Cinsiyet { get; set; }
        public Gorev Gorev { get; set; }
        public KisiTipi KisiTipi { get; set; }
        public bool AktifMi { get; set; }
        public string Sifre { get; set; }

        //Relations

        public ICollection<IletisimBilgisi> IletisimBilgileri { get; set; }     //Kisi - IletisimBilgisi => 1-M
        public int DepartmanID { get; set; }                                    //Kisi - Departman => 1-M
        public Departman Departman { get; set; }
    }
}