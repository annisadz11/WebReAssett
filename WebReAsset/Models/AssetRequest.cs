using System.ComponentModel.DataAnnotations;

namespace WebReAsset.Models
{
    public class AssetRequest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string? Name { get; set; }

        [Required]
        public string? Departement { get; set; }

        [Required]
        [StringLength(500)]
        public string? DescriptionAsset { get; set; }

        [Required]
        public string? Old_SerialNumber { get; set; }

        [Required]
        public string? New_SerialNumber { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

    }
}
