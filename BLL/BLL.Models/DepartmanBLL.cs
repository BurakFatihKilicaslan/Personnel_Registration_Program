using BLL.Interfaces;
using DAL.Context;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class DepartmanBLL
    {
        public DepartmanBLL()
        {
            dbContext = new PersonelDb();
        }
        PersonelDb dbContext;

        public List<Departman> Listele()
        {
            return dbContext.Departmanlar.ToList();
        }
        public string DepartmanBilgisi(int id)
        {
            Departman departman = dbContext.Departmanlar.Find(id);
            return departman.DepartmanAdi;
        }
    }
}
