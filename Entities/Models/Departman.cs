using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Departman : Genel
    {
        public Departman()
        {
            Kisiler = new List<Kisi>();
        }
        public string DepartmanAdi { get; set; }

        //Relations
        public ICollection<Kisi> Kisiler { get; set; }                   //Kisi - Departman => 1-M
    }
}
