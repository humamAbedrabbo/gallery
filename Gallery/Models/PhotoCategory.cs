namespace Gallery.Models
{
    public class PhotoCategory
    {
        public int PhotoId { get; set; }
        public Photo Photo { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
