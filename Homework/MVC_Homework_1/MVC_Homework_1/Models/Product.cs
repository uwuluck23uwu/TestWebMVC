using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Homework_1.Models
{
    public class Product
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ชื่อ")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Name { get; set; }

        [DisplayName("ราคา")]
        [Range(1, 99999, ErrorMessage = "ป้อนค่าระหว่าง {1} ถึง {2}")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public double Price { get; set; }

        [DisplayName("จำนวน")]
        [Range(1, 9999, ErrorMessage = "ป้อนค่าระหว่าง {1} ถึง {2}")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public int Amount { get; set; }

        public ProductExtend ProductExtend { get; set; }

        [DisplayName("หมวดหมู่")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

    }
}
