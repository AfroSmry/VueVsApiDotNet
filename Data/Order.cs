using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace Data
{
    public class Order
    {
        public int Id { get; set; }

        [Required]
        public DateTime DateStart { get; set; }

        public User User { get; set; }

        public virtual ICollection<OrderDetail> Details { get; set; } = new HashSet<OrderDetail>();
    }
}
