using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SaoCungDuocStore.Models
{
    public class Category
    {
        

        [Key]
        public int CategoryId { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Thể Loại")]
        public string Name { get; set; }
        [DisplayName("Thứ Tự")]
        [Range(1, 100, ErrorMessage = "Thứ Tự Phải Là Số Tự Nhiên Từ 1 Đến 100")]
        public int DisplayOrder { get; set; }
    }
}
