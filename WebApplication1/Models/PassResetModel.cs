using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class PassResetModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string Message { get; set; }

        public string Code { get; set; }
    }
}