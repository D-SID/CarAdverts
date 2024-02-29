using Microsoft.EntityFrameworkCore;
using CarAdverts.Repository.Models; 

namespace CarAdverts.Repository;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    
    public DbSet<CarAdvert> CarAdverts { get; set; }
}
