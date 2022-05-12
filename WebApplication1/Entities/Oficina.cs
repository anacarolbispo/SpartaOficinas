using System.Text.Json.Serialization;

namespace SpartaOficinas.Entities
{
    public class Oficina
    {
        public int id { get; set; }
        public string razaoSocial { get; set; }
        public string cnpj { get; set; }
        public bool status { get; set; }
        public int cargaTrabalho { get; set; }

        [JsonIgnore]
        public string senha { get; set; }

    }
}
