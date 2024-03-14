﻿using System.ComponentModel.DataAnnotations;

namespace WebReAsset.Models
{

    public class Scrap
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(500)]
        public string? DescriptionAsset { get; set; }

        [Required]
        public string? SerialNumber { get; set; }

        [Required]
        [StringLength(255)]
        public string? LocationAsset { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        [StringLength(100)]
        public string? Status { get; set; }
    }
}
