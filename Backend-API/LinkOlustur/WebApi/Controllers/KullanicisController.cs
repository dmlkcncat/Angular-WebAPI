using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KullanicisController : ControllerBase
    {
        IKullaniciService _kullaniciService;
        ILinkService _linkService;

        public KullanicisController(IKullaniciService kullaniciService, ILinkService linkService)
        {
            _kullaniciService = kullaniciService;
            _linkService = linkService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _kullaniciService.GetAll();
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }

        [HttpPost("add")]
        public IActionResult Add(Kullanici kullanici)
        {
            var result = _kullaniciService.Add(kullanici);
            if(result.Success)
            {
                Link link = new Link();
                Guid newG = Guid.NewGuid();
                kullanici.Guid = newG;
                link.KullaniciId = kullanici.KullaniciId;
                DateTime today = DateTime.Now;
                DateTime tomorrow = today.AddDays(1);
                link.OlusturmaTarihi = today;
                link.LinkGecerlilikTarihi = tomorrow;
                string tarih = today.ToString("MM/dd/yyyy");
                link.OdemeLinki = "http://localhost:4200/linkpayment/" + kullanici.Mail + "/" + tarih + "/" + kullanici.Guid;
                _linkService.Add(link);


                return Ok(result);
            }

            
            return BadRequest(result);
        }

    }
}