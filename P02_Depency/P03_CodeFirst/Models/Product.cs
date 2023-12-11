using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace P03_CodeFirst.Models
{
    public class Product
    {
        [DisplayName("รหัส")]
        public int Id { get; set; } //Id มันจะอ้อโต้

        [DisplayName("ชื่อ")]
        public string Name { get; set; }

        [DisplayName("ราคา")]
        public double Price { get; set; }

        [DisplayName("จำนวน")]
        public int Amount { get; set; }
    }
}
