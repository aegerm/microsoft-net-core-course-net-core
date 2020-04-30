using System;
using System.Collections.Generic;
using System.Text;

namespace Aula38.Entities
{
    public class Post
    {
        public DateTime Moment { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int Likes { get; set; }
        public List<Comment> Comments { get; set; } = new List<Comment>();

        public void AddComment(Comment comment)
        {
            Comments.Add(comment);
        }

        public void RemoveComment(Comment comment)
        {
            Comments.Remove(comment);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(Title)
              .Append(Likes)
              .Append(" Likes - ")
              .AppendLine(Moment.ToString("dd/MM/yyyy HH:mm:ss"))
              .AppendLine(Content)
              .AppendLine("Comentários:");

            foreach (Comment item in Comments)
            {
                sb.AppendLine(item.Text);
            }

            return sb.ToString();
        }
    }
}