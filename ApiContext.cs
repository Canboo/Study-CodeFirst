using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api;

public partial class ApiContext : DbContext
{

    public ApiContext() { }

    public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDBV15;Initial Catalog=Todo1;Integrated Security=True");
    }

    public DbSet<Post> Posts { get; set; }
    public DbSet<User> Users { get; set; }
}