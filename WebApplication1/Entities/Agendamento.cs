using System;
using System.ComponentModel.DataAnnotations;

namespace SpartaOficinas.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }

        [Required]
        public DateTime Data { get; set; }

        [Required]
        public int IdServico { get; set; }

        [Required]
        public int IdOficina { get; set; }
    }
}
