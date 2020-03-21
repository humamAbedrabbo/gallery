using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gallery.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PhotoCategory> PhotoCategories { get; set; } = new List<PhotoCategory>();

    }
}
