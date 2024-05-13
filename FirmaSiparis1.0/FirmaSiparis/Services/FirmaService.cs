using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data;
using Models;

namespace Services
{
    
    public class FirmaService
{
    private readonly AppDbContext _context;

    public FirmaService(AppDbContext context)
    {
        _context = context;
    }

    // Tüm firmaları getiren metot
    public List<Firma> GetAll()
    {
        return _context.Firmalar.ToList();
    }

    // Firma eklemek için metot
    public void AddFirma(Firma firma)
    {
        _context.Firmalar.Add(firma);
        _context.SaveChanges();
    }
    public void FirmaGuncelle(int id, Firma firma)
    {
        var existingFirma = _context.Firmalar.FirstOrDefault(f => f.Id == id);
        if (existingFirma != null)
        {
            existingFirma.OnayDurumu = firma.OnayDurumu;
            existingFirma.SiparisIzinBaslangicSaati = firma.SiparisIzinBaslangicSaati;
            existingFirma.SiparisIzinBitisSaati = firma.SiparisIzinBitisSaati;
            
            _context.SaveChanges();
        }
    }
    
}
}