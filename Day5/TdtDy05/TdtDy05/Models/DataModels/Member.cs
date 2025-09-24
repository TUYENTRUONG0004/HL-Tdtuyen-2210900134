using System.ComponentModel.DataAnnotations;

namespace TdtDy04.Models.DataModels
{
    public class Member
    {
        [Key]
        public string MemberId { get; set; }

        [Required]
        public string Username { get; set; }

        [Required]
        public string Fullname { get; set; }

        [Required]
        public string Password { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}