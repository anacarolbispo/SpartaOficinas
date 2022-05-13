using System.ComponentModel.DataAnnotations;

namespace SpartaOficinas.Models
{
    public class LoginDto
    {

        [Required]
        public string Cnpj { get; set; }

        [Required]
        public string Senha { get; set; }
    }
}
