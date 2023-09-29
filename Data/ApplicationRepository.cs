using Microsoft.EntityFrameworkCore;
using CyberStore.Models;

namespace CyberStore.Data;

public class ApplicationRepository : DbContext
{
    public ApplicationRepository(DbContextOptions<ApplicationRepository> options) : base(options) {}
    public DbSet<Product> Products {get; set;}
}