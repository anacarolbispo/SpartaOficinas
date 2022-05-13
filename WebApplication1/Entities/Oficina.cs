using System.Text.Json.Serialization;

namespace SpartaOficinas.Entities
{
    public class Oficina
    {
        public int Id { get; set; }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public int CargaTrabalho { get; set; }

        [JsonIgnore]
        public string Senha { get; set; }

    }
}
