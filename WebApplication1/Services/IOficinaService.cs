using System.Collections.Generic;
using SpartaOficinas.Entities;
using SpartaOficinas.Models.Oficinas;

namespace SpartaOficinas.Services
{
    public interface IOficinaService
    {
        IEnumerable<Oficina> GetAll();
        void Create(Create model);
    }
}
