using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Users
    {
        public int id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string SurName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Phone { get; set; }
    }
}
