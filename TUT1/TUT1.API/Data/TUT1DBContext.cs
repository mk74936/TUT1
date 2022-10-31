
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;
using TUT1.API.Models.Domain;

namespace TUT1.API.Data
{
    public class TUT1DBContext: DbContext
    {
        public TUT1DBContext(DbContextOptions<TUT1DBContext> options):base(options) 
        {

        }

        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<WalkDifficulty> WalkDifficulty { get; set; }

    }
}
