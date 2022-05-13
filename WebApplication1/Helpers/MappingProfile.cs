using AutoMapper;
using SpartaOficinas.Entities;
using SpartaOficinas.Models;

namespace SpartaOficinas.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OficinaDto, Oficina>();
            CreateMap<Oficina, OficinaDto>();
            CreateMap<AgendamentoDto, Agendamento>();
        }
    }
}
