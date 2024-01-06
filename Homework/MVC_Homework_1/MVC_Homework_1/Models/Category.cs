using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Homework_1.Models
{
    public class Category
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("หมวดหมู่")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Name { get; set; }
    }
}
