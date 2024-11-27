using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.ViewServices
{
    public class TipoInteraccionService : ViewService<TipoInteraccion, TipoInteraccionDTO>
    {
        public TipoInteraccionService(IViewRepository<TipoInteraccion> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
