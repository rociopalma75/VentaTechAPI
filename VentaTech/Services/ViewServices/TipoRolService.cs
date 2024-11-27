using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.ViewServices
{
    public class TipoRolService : ViewService<TipoRol, TipoRolDTO>
    {
        public TipoRolService(IViewRepository<TipoRol> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
