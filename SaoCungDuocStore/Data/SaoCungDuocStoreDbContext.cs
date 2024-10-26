using Microsoft.EntityFrameworkCore;
using SaoCungDuocStore.Models;

namespace SaoCungDuocStore.Data
{
    public class SaoCungDuocStoreDbContext:DbContext
    {
        public SaoCungDuocStoreDbContext(DbContextOptions<SaoCungDuocStoreDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Author_Book>().HasKey(ab => new
            {
                ab.AuthorId,
                ab.BooksId,
            });
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Books).WithMany;
            base.OnModelCreating(modelBuilder);
        }
    }
}
