usint DoceApi.Models;
using Microsoft.EntityFrameworkCore;

class AppDpContext : DbContext
{
     public AppDpContext(DbContextOptions options) : base(options) { }
     public DbSet<Doce> Doces { get; set; } = null!; 
}