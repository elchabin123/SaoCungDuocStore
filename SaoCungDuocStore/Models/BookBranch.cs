using System.ComponentModel.DataAnnotations;

namespace SaoCungDuocStore.Models
{
    public class BookBranch
    {
        [Key]
        public int BranchId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        // relationships
        public List<Books> Books { get; set; }
    }
}
