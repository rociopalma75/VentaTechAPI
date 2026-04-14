using AutoMapper;
using Domain.Entities;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.ViewServices
{
    public class EstadoService : ViewService<Estado, EstadoDTO>
    {
        public EstadoService(IViewRepository<Estado> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
