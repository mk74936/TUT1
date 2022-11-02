using TUT1.API.Models.Domain;

namespace TUT1.API.Repositories
{
    public interface IRegionRepository
    {
       Task<IEnumerable<Region>> GetAllAsync();
    }
}
