using BLL.Interfaces;
using DAL.Context;
using Entities.Models;
using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL.BLL.Models
{
    public class KisiBLL : ICRUD<Kisi>
    {
        public KisiBLL()
        {
            dbContext = new PersonelDb();
        }
        public PersonelDb dbContext;

        public Kisi IdGetir(int id)
        {
            Kisi kisi = dbContext.Kisiler.Find(id);
            return kisi;
        }

        public List<Kisi> KisileriGetir()
        {
            return dbContext.Kisiler.ToList();
        }

        public bool Ekle(Kisi kisi)
        {
            dbContext.Kisiler.Add(kisi);
            return dbContext.SaveChanges() > 0;
        }
        public bool Sil(int id)
        {
            Kisi kisi = IdGetir(id);
            dbContext.Kisiler.Remove(kisi);
            return dbContext.SaveChanges() > 0;
        }
        public bool Guncelle(Kisi kisi)
        {
            dbContext.Kisiler.Update(kisi);    
            return dbContext.SaveChanges() > 0;
        }

        public Kisi KimlikNoGetir(string kimlikNo)
        {
            return dbContext.Kisiler.FirstOrDefault(a => a.TcNo == kimlikNo);
        }

        public List<Kisi> IsmeGoreGetir(string isim)
        {
            return dbContext.Kisiler.Where(k => k.Ad.Contains(isim)).ToList();
        }
        public string ComputeSha256Hash(string input)
        {
            using (var sha256 = SHA256.Create())
            {
                var bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                var builder = new StringBuilder();
                foreach (var b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
    }
}
