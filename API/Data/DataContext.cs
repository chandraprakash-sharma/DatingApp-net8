using API.Entites;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options) //need to register in program.cs file
{
    public DbSet<AppUser> Users { get; set; }
}
