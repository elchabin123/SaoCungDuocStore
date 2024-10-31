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
                ab.BookId,
            });
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Books).WithMany(ab => ab.Authors_Books).HasForeignKey(b=>b.BookId);
            modelBuilder.Entity<Author_Book>().HasOne(b => b.Author).WithMany(ab => ab.Authors_Books).HasForeignKey(b => b.AuthorId);
          
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Author> Author { get; set; }
        public DbSet<Books> Books { get; set; }

        public DbSet<Author_Book> Authors_Books { get; set; }

        public DbSet<BookBranch> BookBranches { get; set; }

        public DbSet<Producer> Producers { get; set; }

    }
}
