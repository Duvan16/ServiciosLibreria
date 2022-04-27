using AutoMapper;
using Servicios.api.Seguridad.Core.Entities;

namespace Servicios.api.Seguridad.Core.DTO
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Usuario, UsuarioDto>();
        }

    }
}
