using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.ViewServices
{
    public class EstadoService : ViewService<Estado, EstadoDTO>
    {
        public EstadoService(IViewRepository<Estado> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
