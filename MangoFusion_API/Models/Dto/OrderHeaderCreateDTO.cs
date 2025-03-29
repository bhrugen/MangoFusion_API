using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangoFusion_API.Models.Dto
{
    public class OrderHeaderCreateDTO
    {
        [Required]
        public string PickUpName { get; set; } = string.Empty;
        [Required]
        public string PickUpPhoneNumber { get; set; } = string.Empty;
        [Required]
        public string PickUpEmail { get; set; } = string.Empty;
        
        public string ApplicationUserId { get; set; } = string.Empty;
        
        public double OrderTotal { get; set; }
        
        public int TotalItem { get; set; }

        public List<OrderDetailsCreateDTO> OrderDetailsDTO { get; set; } = new();
    }
}
