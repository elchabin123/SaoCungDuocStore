namespace SaoCungDuocStore.Models
{
    public class Author_Book
    {
        public int BooksId { get; set; }
        public Books Books { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
