using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Orders
    {
        public int id { get; set; }
        [Required]
        public string FavorName { get; set; }
        [Required]
        public string Tarif { get; set; }
        [Required]
        public string DateStart { get; set; }
        public string DateEnd { get; set; }
    }
}
