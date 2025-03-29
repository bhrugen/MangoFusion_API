using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangoFusion_API.Models.Dto
{
    public class OrderHeaderUpdateDTO
    {
        [Required]
        public int OrderHeaderId { get; set; }
        public string PickUpName { get; set; } = string.Empty;
        public string PickUpPhoneNumber { get; set; } = string.Empty;
        public string PickUpEmail { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
    }
}
