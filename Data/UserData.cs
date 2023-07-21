namespace Move_A_Block_API.Data
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class UserProgress
    {
        [Required]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int Id { get; set; }

        [Required]
        [Column(TypeName = "VARCHAR(256)")]
        [StringLength(256, MinimumLength = 3)]

        public string UserId { get; set; } = null!;

        public int Level { get; set; }

        public TimeOnly TimeTaken { get; set; }
    }
}
