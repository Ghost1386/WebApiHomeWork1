using Microsoft.EntityFrameworkCore;
using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.BusinessLogic.Context;

public sealed class RecordContext : DbContext
{
    public DbSet<Record?> Records { get; set; }
    public RecordContext(DbContextOptions<RecordContext> options)
        : base(options)
    { 
        Database.EnsureCreated();
    }
}