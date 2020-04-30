using Aula38.Entities;
using System;

namespace Aula38
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment comment1 = new Comment();
            comment1.Text = "Tenha uma boa viagem";

            Comment comment2 = new Comment();
            comment2.Text = "Que bom";

            Post post = new Post();
            post.Moment = DateTime.Now;
            post.Title = "Partiu viajar";
            post.Content = "Visitar os parente";
            post.Likes = 20;

            post.AddComment(comment1);
            post.AddComment(comment2);

            Console.WriteLine(post);
        }
    }
}