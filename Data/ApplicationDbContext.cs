using Microsoft.EntityFrameworkCore;
using studentsMVC.Models.Entities;
using System.Data;

namespace studentsMVC.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options): base(options) 
        {
            
        }

        public DbSet<Student>Students { get; set; }
    }
}
