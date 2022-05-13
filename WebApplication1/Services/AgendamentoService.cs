using AutoMapper;
using System;
using System.Collections.Generic;
using SpartaOficinas.Entities;
using SpartaOficinas.Helpers;
using SpartaOficinas.Models;

namespace SpartaOficinas.Services
{
    public class AgendamentoService : IAgendamentoService
    {
        private DataContext _context;
        private readonly IMapper _mapper;

        public AgendamentoService(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void Create(AgendamentoDto model, int userId)
        {
            var agendamento = _mapper.Map<Agendamento>(model);
            agendamento.IdOficina = userId;

            _context.Agendamentos.Add(agendamento);
            _context.SaveChanges();
        }

        IEnumerable<Agendamento> IAgendamentoService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
