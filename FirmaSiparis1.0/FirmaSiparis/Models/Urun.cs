using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Controllers;

namespace Models
{
    public class Urun
{
    public int Id { get; set; }
    public int FirmaId { get; set; }
    public string Adi { get; set; } = string.Empty;
    public int Stok { get; set; }
    public decimal Fiyat { get; set; }
}

}