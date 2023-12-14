using System.ComponentModel.DataAnnotations;

namespace MVC_Homework.Models
{
    public class Pets
    {
        [Display(Name = "[ รหัส ]")]
        public int Id { get; set; }

        [Display(Name = "[ ชื่อ ]")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Name { get; set; }

        [Display(Name = "[ รูป ]")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Img { get; set; }
    }
}
