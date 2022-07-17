using Microsoft.EntityFrameworkCore;
using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.BusinessLogic.Context;

public sealed class UserContext : DbContext
{
    public DbSet<User?> Users { get; set; }
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    { 
        Database.EnsureCreated();
    }
}