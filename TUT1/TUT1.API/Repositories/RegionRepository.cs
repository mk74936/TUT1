using TUT1.API.Data;
using TUT1.API.Models.Domain;

namespace TUT1.API.Repositories
{
    public class RegionRepository : IRegionRepository
    {
        public RegionRepository(TUT1DBContext tUT1DBContext)
        {
            this.TUT1DBContext = tUT1DBContext;
        }

        public TUT1DBContext TUT1DBContext { get; }

        public IEnumerable<Region> GetAll()
        {
            return TUT1DBContext.Regions.ToList();
        }
    }
}
