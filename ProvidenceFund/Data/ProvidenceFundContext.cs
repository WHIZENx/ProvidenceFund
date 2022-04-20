using Microsoft.EntityFrameworkCore;
using ProvidenceFund.Models;

namespace ProvidenceFund.Data
{
    public class ProvidenceFundContext : DbContext
    {
        public ProvidenceFundContext (DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; } = default!;
        public DbSet<PvdFund> PvdFund { get; set; } = default!;
    }
}
