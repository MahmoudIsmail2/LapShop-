using System.ComponentModel.DataAnnotations;
using LapShop.Resources;
namespace LapShop.Models
{
    public class UsersModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Pleze Enter Your First Name")]
        public string FirstName { get; set; } = "";
        [Required(ErrorMessage = "Pleze Enter Your Last Name")]
        public string LastName { get; set; } = "";
        [Required(ErrorMessage ="Enter Password")]
        [StringLength(20,ErrorMessage ="Password Must Less Than 20")]
        public int Password { get; set; }
        [Required(ErrorMessage ="Enter Your EmailAdress")]
        [EmailAddress (ErrorMessage ="Enter A Valid Email")]
        public string Email { get; set; } = "";
    }
}
