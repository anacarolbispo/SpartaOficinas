using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using SpartaOficinas.Entities;
using SpartaOficinas.Models.Oficinas;
using SpartaOficinas.Services;

namespace SpartaOficinas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OficinaController : ControllerBase
    {
        private IOficinaService _oficinaService;

        public OficinaController(IOficinaService oficinaService)
        {
            _oficinaService = oficinaService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<Oficina> result = _oficinaService.GetAll();
            return Ok(result);
        }

        [HttpPost]
        public IActionResult Create(Create model)
        {
            _oficinaService.Create(model);
            return Ok(new { message = "Oficina criada com sucesso" });
        }


    }
}
