using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace webapi.Models
{
    public class Providers
    {
        public int id { get; set; }
        [Required]
        public string ProviderName { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
