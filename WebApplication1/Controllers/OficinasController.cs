using Microsoft.AspNetCore.Mvc;
using SpartaOficinas.Models;
using SpartaOficinas.Services;

namespace SpartaOficinas.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OficinasController : ControllerBase
    {
        private IOficinaService _oficinaService;

        public OficinasController(IOficinaService oficinaService)
        {
            _oficinaService = oficinaService;
        }

        [HttpPost]
        public IActionResult Create(OficinaDto model)
        {
            _oficinaService.Create(model);
            return Ok(new { message = "Oficina criada com sucesso" });
        }
    }
}
