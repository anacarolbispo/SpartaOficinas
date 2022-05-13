using System;

namespace SpartaOficinas.Entities
{
    public class Agendamento
    {
        public int Id { get; set; }

        public DateTime Data { get; set; }

        public int IdServico { get; set; }

        public int IdOficina { get; set; }
    }
}
