using AutoMapper;
using VentaTechAPI.Models;
using VentaTechAPI.Models.DTO.ViewsDTO;
using VentaTechAPI.Repositories.Contracts;

namespace VentaTechAPI.Services.ViewServices
{
    public class DetalleRankingService : ViewService<DetalleRanking, DetalleRankingDTO>
    {
        public DetalleRankingService(IViewRepository<DetalleRanking> repository, IMapper mapper) : base(repository, mapper)
        {
        }
    }
}
