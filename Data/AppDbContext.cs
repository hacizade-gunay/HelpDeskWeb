using Microsoft.EntityFrameworkCore;
using HelpDeskWeb.Models;

namespace HelpDeskWeb.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Ticket> Tickets { get; set; }
    }
}