using System.ComponentModel.DataAnnotations;

namespace TheWall.Models
{
    public class LoginUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email{get;set;}

        [Required]
        [DataType(DataType.Password)]
        public string Password{get;set;}
    }
}