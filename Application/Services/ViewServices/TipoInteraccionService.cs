using AutoMapper;
using Domain.Entities;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.ViewServices
{
    public class TipoInteraccionService : ViewService<TipoInteraccion, TipoInteraccionDTO>
    {
        public TipoInteraccionService(IViewRepository<TipoInteraccion> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
