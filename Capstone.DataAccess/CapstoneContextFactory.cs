using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Capstone.DataAccess
{
    public class CapstoneContextFactory : IDesignTimeDbContextFactory<CapstoneContext>
    {
        public CapstoneContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CapstoneContext>();
            optionsBuilder.UseSqlServer("Server=DESKTOP-OF0V18H\\FANNABY;Database=Capstone;Trusted_Connection=True;MultipleActiveResultSets=true");

            return new CapstoneContext(optionsBuilder.Options);
        }
    }
}
