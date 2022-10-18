using System.ComponentModel.DataAnnotations;

namespace LapShop.Models
{
    public class Player
    {
        [Key]
        public int   id { get; set; }
        [Required(ErrorMessage ="Enter Player Name")]        
        public string name { get; set; } = "";
        [Required(ErrorMessage = "Enter Player Number")]
        public int number { get; set; } 
    }
}
