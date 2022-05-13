using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpartaOficinas.Models;
using SpartaOficinas.Services;
using System.Security.Claims;

namespace SpartaOficinas.Controllers
{
    [ApiController]
    [Authorize]
    [Route("[controller]")]
    public class AgendamentosController : ControllerBase
    {
        private IAgendamentoService _agendamentoService;

        public AgendamentosController(IAgendamentoService agendamentoService)
        {
            _agendamentoService = agendamentoService;
        }

        [HttpPost]
        public IActionResult Create(AgendamentoDto model)
        {
            _agendamentoService.Create(model, int.Parse(User.FindFirst(ClaimTypes.NameIdentifier).Value));
            return Ok(new { message = "Agendamento criado com sucesso" });
        }
    }
}
