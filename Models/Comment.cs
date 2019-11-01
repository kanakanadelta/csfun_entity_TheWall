using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;


namespace TheWall.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int MessageId { get; set; }
        public Message Message { get; set; }
        public string CommentText { get; set; }

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;


        public Comment(int userId, User user, int messageId, Message message, string commentText)
        {
            UserId = userId;
            User = user;
            MessageId = messageId;
            Message = message;
            CommentText = commentText;
        }
        public Comment(){}
    }
}