using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using SpartaOficinas.Entities;
using SpartaOficinas.Helpers;
using SpartaOficinas.Models.Oficinas;

namespace SpartaOficinas.Services
{
    public class OficinaService : IOficinaService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public OficinaService (DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(Create model)
        {
            if (_context.Oficinas.Any(x => x.cnpj == model.cnpj))
                throw new Exception("Já existe uma oficina cadastrada com o cnpj " + model.cnpj);

            var oficina = _mapper.Map<Oficina>(model);

            _context.Oficinas.Add(oficina);
            _context.SaveChanges();
        }

        public IEnumerable<Oficina> GetAll()
        {
            return _context.Oficinas;
        }
    }
}
