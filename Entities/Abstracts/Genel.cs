using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstracts
{
    public abstract class Genel
    {
        public Genel()
        {
            CreationDate = new DateTime();
        }
        public int ID { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
