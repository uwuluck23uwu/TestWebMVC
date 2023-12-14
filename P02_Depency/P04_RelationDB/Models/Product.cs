using System.ComponentModel.DataAnnotations.Schema;

namespace P04_RelationDB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Amount { get; set; }
        public int TestId { get; set; }
        [ForeignKey("TestId")]
        public Category Category { get; set; }
    }
}
