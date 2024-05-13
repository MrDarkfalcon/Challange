
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
    public class FirmaController : ControllerBase
    {
        private readonly FirmaService _firmaService;

        public FirmaController(FirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        // Tüm firmaları getiren 
        [HttpGet]
        public IActionResult GetAllFirmalar()
        {
            var firmalar = _firmaService.GetAll();
            return Ok(firmalar);
        }

        // Yeni bir firma eklemek için
        [HttpPost]
        public IActionResult AddFirma([FromBody] Firma firma)
        {
            _firmaService.AddFirma(firma);
            return Ok("Firma başariyla eklendi.");
        }

        [HttpPut("{id}")]
        public IActionResult FirmaGuncelle(int id, Firma firma)
        {
            _firmaService.FirmaGuncelle(id, firma);
            return Ok();
        }

    }
}
/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FirmaController : ControllerBase
    {
        private readonly FirmaService _firmaService;

        public FirmaController(FirmaService firmaService)
        {
            _firmaService = firmaService;
        }

        [HttpGet]
        public IActionResult GetAllFirmalar()
        {
            var firmalar = _firmaService.GetAll();
            return Ok(firmalar);
        }

        [HttpPost]
        public IActionResult AddFirma([FromBody] Firma firma)
        {
            _firmaService.AddFirma(firma);
            return Ok("Firma başariyla eklendi.");
        }

    }
}*/