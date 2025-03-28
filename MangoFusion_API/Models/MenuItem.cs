using System.ComponentModel.DataAnnotations;

namespace MangoFusion_API.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string SpecialTag { get; set; } = string.Empty;
        [Range(1,1000)]
        public double Price { get; set; }
        [Required]
        public string Image { get; set; } = string.Empty;
    }
}
