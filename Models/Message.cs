using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

using System.Collections.Generic;

namespace TheWall.Models
{
    public class Message
    {
        [Key]
        public int MessageId { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string MessageText { get; set; }

        public User Author { get; set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


        public List<Comment> Comments { get; set; }

        public Message()
        {
            Comments = new List<Comment>();
        }
    }
}