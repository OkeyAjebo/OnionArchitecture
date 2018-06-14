using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        public string Director { get; set; }
        public string ImageUrl { get; set; }

        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }
    }
}
