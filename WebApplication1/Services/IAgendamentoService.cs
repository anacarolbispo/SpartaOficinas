using System.Collections.Generic;
using SpartaOficinas.Entities;
using SpartaOficinas.Models;

namespace SpartaOficinas.Services
{
    public interface IAgendamentoService
    {
        IEnumerable<Agendamento> GetAll();
        void Create(AgendamentoDto model, int userId);
    }
}
