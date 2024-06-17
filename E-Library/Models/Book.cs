using System.ComponentModel.DataAnnotations.Schema;

namespace E_Library.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Shortcut { get; set; }
        public string ImagePath { get; set; }
        public int Category { get; set; }

        [NotMapped]
        public bool IsAvailable { get; set; }
    }
}
