using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangoFusion_API.Models
{
    public class OrderHeader
    {
        [Key]
        public int OrderHeaderId { get; set; }
        [Required]
        public string  PickUpName { get; set; } = string.Empty;
        [Required]
        public string PickUpPhoneNumber { get; set; } = string.Empty;
        [Required]
        public string PickUpEmail { get; set; } = string.Empty;
        public DateTime OrderDate { get; set; }

        public string ApplicationUserId { get; set; } = string.Empty;
        [ForeignKey("ApplicationUserId")]
        public ApplicationUser? ApplicationUser { get; set; }

        public double OrderTotal { get; set; }
        public string Status { get; set; }=string.Empty;
        public int TotalItem { get; set; }

        public List<OrderDetail> OrderDetails { get; set; } = new();
    }
}
