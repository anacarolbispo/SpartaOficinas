using SpartaOficinas.Models.Validations;
using System;
using System.ComponentModel.DataAnnotations;

namespace SpartaOficinas.Models
{
    public class AgendamentoDto
    {
        [Required]
        [ValidaData(ErrorMessage = "Não é permitido realizar agendamentos aos fins de semanas")]
        public DateTime Data { get; set; }

        [Required]
        [Range(1, 5)]
        public int IdServico { get; set; }
    }
}
