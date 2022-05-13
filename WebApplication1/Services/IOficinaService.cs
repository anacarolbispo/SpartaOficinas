using System.Collections.Generic;
using SpartaOficinas.Entities;
using SpartaOficinas.Models;

namespace SpartaOficinas.Services
{
    public interface IOficinaService
    {
        IEnumerable<Oficina> GetAll();

        void Create(OficinaDto model);

        Oficina GetLoginAccess(LoginDto model);
    }
}
