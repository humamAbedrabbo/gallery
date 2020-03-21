using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class Photo
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(100)]
        [Display(Name = "File name")]
        public string FileName { get; set; }

        [StringLength(200)]
        [DataType(DataType.Url)]
        public string Url { get; set; }
        
        public long Length { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Owner { get; set; }

        [StringLength(100)]
        public string Company { get; set; }

        [Required]
        [StringLength(200)]
        [DataType(DataType.Url)]
        public string ActionUrl { get; set; }

        public List<PhotoCategory> PhotoCategories { get; set; } = new List<PhotoCategory>();
        public List<int> Categories { get; set; } = new List<int>();
    }
}
