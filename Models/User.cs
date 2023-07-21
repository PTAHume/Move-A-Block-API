namespace Move_A_Block_API.Models
{
    using System.ComponentModel.DataAnnotations;

    public class User
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Role { get; set; }

        [Required]
        public string BirthDay { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }
    }
}
