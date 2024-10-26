using System.ComponentModel.DataAnnotations;

namespace SaoCungDuocStore.Models
{
    public class Producer
    {
        [Key]
        public int ProducerId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

        //relationships

        public List<Books> Books { get; set; }
    }
}
