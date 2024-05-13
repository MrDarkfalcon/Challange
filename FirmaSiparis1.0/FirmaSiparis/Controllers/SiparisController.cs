using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Controllers;
using Services;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SiparisController : ControllerBase
    {
        private readonly SiparisService _siparisService;

        public SiparisController(SiparisService siparisService)
        {
            _siparisService = siparisService;
        }

        // Tüm siparişleri getiren
        [HttpGet]
        public IActionResult GetAllSiparisler()
        {
            var siparisler = _siparisService.GetAll();
            return Ok(siparisler);
        }

        // Yeni bir sipariş eklemek için
        [HttpPost]
        public IActionResult AddSiparis([FromBody] Models.Siparis siparis)
        {
            _siparisService.AddSiparis(siparis);
            return Ok("Sipariş başarıyla eklendi.");
        }

}
}