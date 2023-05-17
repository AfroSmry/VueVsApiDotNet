using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Worker
    {
        public int id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
