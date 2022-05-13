using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using SpartaOficinas.Entities;
using SpartaOficinas.Helpers;
using SpartaOficinas.Models;

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

        public void Create(OficinaDto model)
        {
            if (_context.Oficinas.Any(x => x.Cnpj == model.Cnpj))
                throw new Exception("Já existe uma oficina cadastrada com o cnpj " + model.Cnpj);

            var oficina = _mapper.Map<Oficina>(model);

            _context.Oficinas.Add(oficina);
            _context.SaveChanges();
        }

        public IEnumerable<Oficina> GetAll()
        {
            return _context.Oficinas;
        }

        public Oficina GetLoginAccess(LoginDto model)
        {
            return _context.Oficinas.FirstOrDefault(x => x.Cnpj == model.Cnpj 
                && x.Senha == model.Senha);
        }
    }
}
