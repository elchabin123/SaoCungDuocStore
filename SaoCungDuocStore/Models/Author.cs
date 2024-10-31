using System.ComponentModel.DataAnnotations;

namespace SaoCungDuocStore.Models
{
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "Full Name")]

        public string FullName { get; set; }
        [Display(Name = "BioGraphy")]

        public string Bio {  get; set; }

        //relationship
        public List<Author_Book> Authors_Books { get; set; }
    }
}
