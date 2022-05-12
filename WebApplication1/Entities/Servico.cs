using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace SpartaOficinas.Entities
{
    public class Servico
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Descricao { get; set; }

        [Required]
        public int UnidadesTrabalho { get; set; }
    }
}
