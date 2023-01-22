using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ThesisZuordnen.Models;

namespace ThesisZuordnen.Data;

public class ThesisZuordnenContext : IdentityDbContext<IdentityUser>
{
    public DbSet<Thesis> Thesis { get; set; }
    public DbSet<Program> Program { get; set; }
    public ThesisZuordnenContext(DbContextOptions<ThesisZuordnenContext> options)
        : base(options)
{
}
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        IdentityRole role = new IdentityRole() { Id = Guid.NewGuid().ToString(), Name = "Supervisor" };
        role.NormalizedName = role.Name.ToUpper();
        builder.Entity<IdentityRole>().HasData(role);

        IdentityUserRole<string> ur = new IdentityUserRole<string>() { UserId = AppUser.Active, RoleId = role.Id };
    }
}
