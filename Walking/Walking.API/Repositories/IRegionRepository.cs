using Walking.API.Models.Domain;

namespace Walking.API.Repositories
{
    public interface IRegionRepository
    {
        Task<IEnumerable<Region>> GetAllAsync();
        Task<Region> GetAsync(Guid Id);
        Task<Region> AddAsync(Region region);
        Task<Region> DeleteAsync(Guid Id);
    }
}
