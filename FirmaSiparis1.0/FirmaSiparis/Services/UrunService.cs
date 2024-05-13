using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    public class UrunService
    {
        private readonly AppDbContext _context;

        public UrunService(AppDbContext context)
        {
            _context = context;
        }

        // Tüm ürünleri getiren metot
        public List<Urun> GetAll()
        {
            return _context.Urunler.ToList();
        }

        // Ürün eklemek için metot
        public void AddUrun(Urun urun)
        {
            _context.Urunler.Add(urun);
            _context.SaveChanges();
        }

        
    }
}