using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MVC_Homework_1.Models
{
    public class ProductDetail
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("คำอธิบาย")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Description { get; set; }

        [DisplayName("ภาพ")]
        public string? ImageUrl { get; set; }

        [DisplayName("เดือน/วันที่/ปี = เวลา")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        [DisplayName("สินค้า")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public int ProductId { get; set; }
        public Product? Product { get; set; }
    }
}
