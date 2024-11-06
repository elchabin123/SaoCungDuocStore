using Microsoft.EntityFrameworkCore;
using SaoCungDuocStore.Models;

namespace SaoCungDuocStore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 2, Name="Cổ Tích", DisplayOrder=1 },
                new Category { CategoryId = 3, Name = "Kinh Dị", DisplayOrder = 2 },
                new Category { CategoryId = 4, Name = "Trinh Thám", DisplayOrder = 3 },
                new Category { CategoryId = 5, Name = "Anime", DisplayOrder = 4 },
                new Category { CategoryId = 6, Name = "Thiếu Nhi", DisplayOrder = 5 },
                new Category { CategoryId = 7, Name = "Nấu Ăn", DisplayOrder = 6 },
                new Category { CategoryId = 8, Name = "Khoa Học", DisplayOrder = 7 },
                new Category { CategoryId = 9, Name = "Tâm Lí", DisplayOrder = 7 }

                ); 
        }
    }
}
