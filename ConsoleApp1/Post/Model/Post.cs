using ConsoleApp1.Model;

namespace ConsoleApp1.Post.Model
{
    public class Post : IModel
    {
        string Name { get; set; }
        string Content { get; set; }
        string Slug { get; set; }
    }
}