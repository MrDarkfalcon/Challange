using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UrunController : ControllerBase
    {
         private readonly UrunService _urunService;

        public UrunController(UrunService urunService)
        {
            _urunService = urunService;
        }

        // Tüm ürünleri getiren
        [HttpGet]
        public IActionResult GetAllUrunler()
        {
            var urunler = _urunService.GetAll();
            return Ok(urunler);
        }

        // Yeni bir ürün eklemek için
        [HttpPost]
        public IActionResult AddUrun([FromBody] Urun urun)
        {
            _urunService.AddUrun(urun);
            return Ok("Ürün başarıyla eklendi.");
        }
    }
}