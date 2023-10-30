using Microsoft.EntityFrameworkCore;
using RepositoryPatternDemo.Models;

namespace RepositoryPatternDemo.Data
{
    
    
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> op) : base(op)
            {

            }

            public DbSet<Book> Books { get; set; }
            public DbSet<Student> Students { get; set; }
        }
    }

