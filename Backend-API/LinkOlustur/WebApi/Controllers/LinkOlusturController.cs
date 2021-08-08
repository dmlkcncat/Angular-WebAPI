using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LinkOlusturController : ControllerBase
    {
        ILinkService _linkService;

        public LinkOlusturController(ILinkService linkService)
        {
            _linkService = linkService;
        }


        [HttpGet("getdetails")]
        public IActionResult GetDetails()
        {
            var result = _linkService.GetLinkDetails();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);

        }
        [HttpPost("add")]
        public IActionResult Add(Link link)
        {

            var result = _linkService.Add(link);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}