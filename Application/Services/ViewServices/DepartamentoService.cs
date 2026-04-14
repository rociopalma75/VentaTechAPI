using AutoMapper;
using Domain.Entities;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.ViewServices
{
    public class DepartamentoService : ViewService<Departamento, DepartamentoDTO>
    {
        public DepartamentoService(IViewRepository<Departamento> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
