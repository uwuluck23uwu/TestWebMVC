using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Homework_1.Models
{
    public class Component
    {
        [DisplayName("ID")]
        public int Id { get; set; }

        [DisplayName("ส่วนประกอบ")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public string Name { get; set; }

        public ProductExtend ProductExtend { get; set; }

        [DisplayName("คุณสมบัติ")]
        [Range(5, 8, ErrorMessage = "ป้อนค่าระหว่าง {1} ถึง {2}")]
        [Required(ErrorMessage = "กรุณาป้อนข้อมูล")]
        public int FeatureId { get; set; }
        public Feature? Feature { get; set; }
    }
}
