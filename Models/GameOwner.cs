using System.ComponentModel.DataAnnotations;

namespace RazorPages_MasterDetailApp.Models
{
    public class GameOwner
    {
        [Required]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;
    }
}
