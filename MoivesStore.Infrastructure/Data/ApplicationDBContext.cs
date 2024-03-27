using Microsoft.EntityFrameworkCore;
using MoivesStore.Domain.Models;

namespace MoivesStore.Infrastructure.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Movies> Movie {get; set;}

    }

}