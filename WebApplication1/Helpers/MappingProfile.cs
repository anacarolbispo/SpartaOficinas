using AutoMapper;
using SpartaOficinas.Entities;
using SpartaOficinas.Models.Oficinas;

namespace SpartaOficinas.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Create, Oficina>();
        }
    }
}
