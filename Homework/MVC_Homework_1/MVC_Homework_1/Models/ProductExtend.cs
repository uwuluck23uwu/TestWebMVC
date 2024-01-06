using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MVC_Homework_1.Models
{
    [Owned]
    public class ProductExtend
    {
        [DisplayName("สี")]
        public string? Color { get; set; }

        [DisplayName("น้ำหนัก")]
        public double? Weig { get; set; }
    }
}
