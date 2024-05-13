using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Controllers;


namespace Models
{
    public class Firma
{
    public int Id { get; set; }
    public string Adi { get; set; } = string.Empty;
    public bool OnayDurumu { get; set; }
    public DateTime SiparisIzinBaslangicSaati { get; set; }
    public DateTime SiparisIzinBitisSaati { get; set; }
}

}