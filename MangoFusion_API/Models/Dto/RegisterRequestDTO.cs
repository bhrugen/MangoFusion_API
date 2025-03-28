using System.ComponentModel.DataAnnotations;

namespace MangoFusion_API.Models.Dto
{
    public class RegisterRequestDTO
    {
        [Required]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string Password { get; set; } = string.Empty;
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
    }
}
