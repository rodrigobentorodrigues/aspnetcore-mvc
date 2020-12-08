using CourseMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace CourseMVC.Data
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Category> Categories { get; set; }

    }
}
