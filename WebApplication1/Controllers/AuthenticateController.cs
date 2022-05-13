using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SpartaOficinas.Models;
using SpartaOficinas.Services;
using System.Threading.Tasks;

namespace SpartaOficinas.Controllers
{
    public class AuthenticateController : Controller
    {
        private IOficinaService _oficinaService;

        public AuthenticateController(IOficinaService oficinaService)
        {
            _oficinaService = oficinaService;
        }

        [HttpPost]
        [Route("login")]
        [AllowAnonymous]
        public async Task<ActionResult<dynamic>> Login(LoginDto model)
        {
            var oficina = _oficinaService.GetLoginAccess(model);

            if (oficina == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(oficina);
            return new
            {
                user = model.Cnpj,
                token = token
            };
        }
    }
}
