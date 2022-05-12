using System.ComponentModel.DataAnnotations;

namespace SpartaOficinas.Models.Oficinas
{
    public class Create
    {
        [Required]
        public string razaoSocial { get; set; }

        [Required]
        public string cnpj { get; set; }

        [Required]
        public int cargaTrabalho { get; set; }

        [Required]
        public bool status { get; set; }

        [Required]
        [MinLength(6)]
        public string senha { get; set; }

        [Required]
        [Compare("senha")]
        public string confirmaSenha { get; set; }
    }
}
