using Microsoft.EntityFrameworkCore;
using VentaTechAPI.Context;
using VentaTechAPI.Models;

namespace VentaTechAPI.Repositories.View
{
    public class DetalleRankingRepository : ViewRepository<DetalleRanking>
    {
        public DetalleRankingRepository(AppDbContext context) : base(context)
        {
        }

        public override async Task<bool> ExistsAsync(int id)
        {
            return await _context.DetalleRankings.AnyAsync(x => x.Id == id);
        }
    }
}
