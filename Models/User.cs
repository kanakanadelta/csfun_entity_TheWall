using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

using System.Collections.Generic;

namespace TheWall.Models
{
    public class User
    {
        [Key]
        public int UserId {get;set;}

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "First Name")]
        public string FirstName {get;set;}

        [Required]
        [MinLength(2)]
        [MaxLength(30)]
        [Display(Name = "Last Name")]
        public string LastName {get;set;}

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string Email {get;set;}

        [Required]
        [MinLength(8, ErrorMessage="Password must be 8 characters or longer!")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password {get;set;}

        // Will not be mapped to your users table!
        [NotMapped]
        [Compare("Password")]
        [DataType(DataType.Password)]
        public string Confirm {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;

        public List<Message> Messages { get; set; }
        public List<Comment> Comments { get; set; }

        public User()
        {
            Messages = new List<Message>();
            Comments = new List<Comment>();
            
        }
    }
}