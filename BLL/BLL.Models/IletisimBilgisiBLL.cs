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
    public class IletisimBilgisiBLL : ICRUD<IletisimBilgisi>
    {
        public IletisimBilgisiBLL()
        {
            dbContext = new PersonelDb();
        }
        public PersonelDb dbContext;

        public bool Ekle(IletisimBilgisi iletisimBilgisi)
        {
            dbContext.IletisimBilgileri.Add(iletisimBilgisi);
            return dbContext.SaveChanges() > 0;
        }

        public bool Sil(int id)
        {
            IletisimBilgisi iletisimBilgisi = IdGetir(id);
            dbContext.IletisimBilgileri.Remove(iletisimBilgisi);
            return dbContext.SaveChanges() > 0;
        }
        public bool Guncelle(IletisimBilgisi iletisimBilgisi)
        {
            dbContext.IletisimBilgileri.Update(iletisimBilgisi);
            return dbContext.SaveChanges() > 0;
        }
        public IletisimBilgisi IdGetir(int id)
        {
            IletisimBilgisi iletisimBilgisi = dbContext.IletisimBilgileri.Find(id);
            return iletisimBilgisi;
        }

        public IletisimBilgisi TelNoGetir(string telNo)
        {
            return dbContext.IletisimBilgileri.FirstOrDefault(a => a.TelefonNo == telNo);
        }

        public IletisimBilgisi MailGetir(string mail)
        {
            return dbContext.IletisimBilgileri.FirstOrDefault(a => a.MailAdresi == mail);
        }

        public List<IletisimBilgisi> IletisimBilgisiListele(int id)
        {
            return dbContext.IletisimBilgileri.Where(i => i.KisiID == id).ToList();
        }

        public IletisimBilgisi IletisimBilgisiDoldur(int kullaniciID)
        {
            IletisimBilgisi iletisimBilgisi = dbContext.IletisimBilgileri.Find(kullaniciID);
            return iletisimBilgisi;
        }
    }
}
