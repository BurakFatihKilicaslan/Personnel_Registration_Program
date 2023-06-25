using BLL.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BusinessLogicLayer
{
    public class BusinessLayer
    {
        public BusinessLayer()
        {
            Kisiler = new KisiBLL();
            IletisimBilgileri = new IletisimBilgisiBLL();
            Departmanlar = new DepartmanBLL();
        }
        public KisiBLL Kisiler { get; set; }
        public IletisimBilgisiBLL IletisimBilgileri { get; set; }
        public DepartmanBLL Departmanlar { get; set; }
    }
}
