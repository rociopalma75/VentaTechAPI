using Microsoft.EntityFrameworkCore;
using Infraestructure.Data;
using Domain.Entities;

namespace Infraestructure.Repositories.View
{
    public class DetalleRankingRepository : ViewRepository<DetalleRanking>
    {
        public DetalleRankingRepository(VentaTechContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.DetallesRanking.AnyAsync(x => x.Id == id);
        }
    }
}
