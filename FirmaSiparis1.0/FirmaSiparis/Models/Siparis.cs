using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Controllers;

namespace Models
{
    public class Siparis
{
    public int Id { get; set; }
    public int FirmaId { get; set; }
    public int UrunId { get; set; }
    public string SiparisiVerenKisininAdi { get; set; } = string.Empty;
    public DateTime SiparisTarihi { get; set; }
}

}