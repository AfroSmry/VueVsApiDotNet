using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Models
{
    public class Supplies
    {
        public int id { get; set; }
        [Required]
        public int ProductBalance { get; set; }
        [Required]
        public DateTime DateStart { get; set; }
        public Product  Products { get; set; }
        public Providers Providers { get; set; }
    }
}
