using AutoMapper;
using Domain.Entities;
using Application.DTOs.ViewsDTO;
using Application.Interfaces.Repositories;

namespace Application.Services.ViewServices
{
    public class DetalleRankingService : ViewService<DetalleRanking, DetalleRankingDTO>
    {
        public DetalleRankingService(IViewRepository<DetalleRanking> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
