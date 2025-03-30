using System.ComponentModel.DataAnnotations;

namespace MangoFusion_API.Models.Dto
{
    public class OrderDetailsUpdateDTO
    {
        [Required]
        public int OrderDetailId { get; set; }
        [Required]
        public int MenuItemId { get; set; }
        [Required]
        public int Rating { get; set; }
    }
}
