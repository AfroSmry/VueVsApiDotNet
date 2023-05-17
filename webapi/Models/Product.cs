using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Product
    {
        public int id { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]
        public string Publishing { get; set; }
        [Required]
        public float Price { get; set; }
        public int ProductBalance { get; set; }

    }
}
