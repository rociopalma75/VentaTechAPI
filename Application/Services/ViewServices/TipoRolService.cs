using AutoMapper;
using Domain.Entities;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.ViewServices
{
    public class TipoRolService : ViewService<TipoRol, TipoRolDTO>
    {
        public TipoRolService(IViewRepository<TipoRol> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
