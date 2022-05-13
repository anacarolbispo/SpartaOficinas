using System.ComponentModel.DataAnnotations;

namespace SpartaOficinas.Models
{
    public class OficinaDto
    {
        [Required]
        public string RazaoSocial { get; set; }

        [Required]
        public string Cnpj { get; set; }

        [Required]
        public int CargaTrabalho { get; set; }

        [Required]
        [MinLength(6)]
        public string Senha { get; set; }
    }
}
