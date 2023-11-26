using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P01_MvcConcept.Models
{
    public class Product
    {
        [Display(Name = "[ รหัสสินค้า ]")]
        [Required(ErrorMessage = "ตาบอดเหรอครับ ข้อมูลยังไม่ครบเลย")]
        public int Id { get; set; }

        [Display(Name = "[ ชื่อสินค้า ]")]
        [Required(ErrorMessage = "ตาบอดเหรอครับ ข้อมูลยังไม่ครบเลย")]
        [StringLength(100,MinimumLength = 3)]
        public string Name { get; set; }

        [Display(Name = "[ ราคาสินค้า ]")]
        [Range(5,double.MaxValue, ErrorMessage = "กรอกข้อมูลขั้นต่ำ [5]")]
        public double Price { get; set; }

        [Display(Name = "[ จำนวนสินค้า ]")]
        [Range(1, 100, ErrorMessage = "กรอกข้อมูลขั้นต่ำ [1] เต็ม [100]")]
        public int Amount { get; set; }
    }
}
