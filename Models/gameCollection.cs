using System;
using System.ComponentModel.DataAnnotations;
namespace RazorPages_MasterDetailApp.Models
{
    public enum Genre
    {
        Adventure,
        OpenWorld,
        Fighting,
        Sports,
        Horror,
        FPS,
        Puzzle

    }
    public class GameCollection
    {
        [Required]
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public Genre GenreType { get; set; } = Genre.Adventure;
        public string Developer { get; set; } = String.Empty;
        public DateTime ReleaseDate{ get; set; }
        public double Price { get; set; } = 0;
    }



}
