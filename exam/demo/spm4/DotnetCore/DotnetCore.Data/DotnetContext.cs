using DotnetCore.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace DotnetCore.Data
{
    public class DotnetContext : DbContext
    {
        public DotnetContext(DbContextOptions<DotnetContext> options) : base(options) { }

        public DotnetContext() { }

        public DbSet<Pet> Pets { get; set; }
    }
}
