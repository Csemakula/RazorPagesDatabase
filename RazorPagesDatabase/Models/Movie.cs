using System.ComponentModel.DataAnnotations;

namespace RazorPagesDatabase.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; } = default(DateTime);
        public string? Genre { get; set; }
        public decimal Price { get; set; } = decimal.Zero;
    }
}
