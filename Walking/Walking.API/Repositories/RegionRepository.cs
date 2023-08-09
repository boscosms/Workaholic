using Microsoft.EntityFrameworkCore;
using Walking.API.Data;
using Walking.API.Models.Domain;

namespace Walking.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        private readonly DataContext _context;

        public RegionRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<Region> AddAsync(Region region)
        {
            region.Id = Guid.NewGuid();
           await _context.AddAsync(region);
           await _context.SaveChangesAsync();
            return region;
        }

        public async Task<Region> DeleteAsync(Guid Id)
        {
            var region = await _context.Regions.FirstOrDefaultAsync(x => x.Id == Id);
           if(region == null)
            {
                return null;
            }
            _context.Regions.Remove(region);
            await _context.SaveChangesAsync();
            return region;
           
        }

        public async Task<IEnumerable<Region>> GetAllAsync()
        {
          return await _context.Regions.ToListAsync();
        }

        public async Task<Region> GetAsync(Guid id)
        {
            return await _context.Regions.FirstOrDefaultAsync(x => x.Id == id);
        }
    }
}
