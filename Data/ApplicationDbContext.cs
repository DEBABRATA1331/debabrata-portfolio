using Microsoft.EntityFrameworkCore;
using PortfolioWebsite.Models; // replace with your actual namespace

namespace PortfolioWebsite.Data  // replace with your root namespace
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // This line connects the ContactMessage model to a DB table
        public DbSet<ContactMessage> ContactMessages { get; set; }
    }
}