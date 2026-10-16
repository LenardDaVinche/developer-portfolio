using Microsoft.EntityFrameworkCore;

namespace EthicsWebApp.Data
{
    public class EthicsWebAppContext : DbContext
    {
        public EthicsWebAppContext(DbContextOptions<EthicsWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<EthicsWebApp.Models.User> User { get; set; } = default!;

        public DbSet<EthicsWebApp.Models.Variable> Variable { get; set; } = default!;

        public DbSet<EthicsWebApp.Models.Scenario> Scenario { get; set; } = default!;

        public DbSet<EthicsWebApp.Models.EthicAttribute> EthicAttribute { get; set; } = default!;

        public DbSet<EthicsWebApp.Models.Choice> Choice { get; set; } = default!;
    }
}
