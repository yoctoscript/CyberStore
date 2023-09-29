using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CyberStore.Data;

public class IdentityRepository : IdentityDbContext<IdentityUser>
{
    public IdentityRepository(DbContextOptions<IdentityRepository> options) : base(options) {}
}