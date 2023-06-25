using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class IletisimBilgisi : Genel
    {
        public string MailAdresi { get; set; }
        public string TelefonNo { get; set; }
        public string Adres { get; set; }

        //Relations
        public int KisiID { get; set; }                 //Kisi - IletisimBilgisi => 1-M
        public Kisi Kisi { get; set; }
    }
}
