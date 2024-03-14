using System.ComponentModel.DataAnnotations;

namespace WebReAsset.Models
{
    public class NewHire
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string? Name { get; set; }

        [Required]
        [StringLength(255)]
        public string? Departement { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateDeploy { get; set; }

        [Required]
        [StringLength(255)]
        public string? DescriptionAsset { get; set; }

        [Required]
        public string? SerialNumber { get; set; }
    }
}