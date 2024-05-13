using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;


namespace Services
{
    public class SiparisService
    {
        private readonly AppDbContext _context;

        public SiparisService(AppDbContext context)
        {
            _context = context;
        }

        // Tüm siparişleri getiren metot
        public List<Siparis> GetAll()
        {
            return _context.Siparisler.ToList();
        }

        // Sipariş eklemek için metot
        public void AddSiparis(Siparis siparis)
        {
            _context.Siparisler.Add(siparis);
            _context.SaveChanges();
        }
    }
}