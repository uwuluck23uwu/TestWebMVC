using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Homework_1.Models
{
    public class Feature
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("คุณสมบัติ")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Name { get; set; }
        public Component? Component { get; set; }
    }
}
