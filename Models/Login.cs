namespace Move_A_Block_API.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Login
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
