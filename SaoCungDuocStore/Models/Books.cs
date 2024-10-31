using Microsoft.Identity.Client;
using SaoCungDuocStore.Data.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaoCungDuocStore.Models
{
    public class Books
    {
        [Key]
        public int BookId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public BookCatagory BookCatagory { get; set; }

        //relationshop

        public List<Author_Book> Authors_Books { get; set; }

        //bookstorebranch
        public int BookBranchId { get; set; }
        [ForeignKey("BookBranchId")]
        public BookBranch BookBranchs { get; set; }

        //Producer
        public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producers { get; set; }
    }
}