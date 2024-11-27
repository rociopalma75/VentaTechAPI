using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.ViewServices
{
    public class DepartamentoService : ViewService<Departamento, DepartamentoDTO>
    {
        public DepartamentoService(IViewRepository<Departamento> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
