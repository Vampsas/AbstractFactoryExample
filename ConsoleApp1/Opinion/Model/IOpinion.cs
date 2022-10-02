using ConsoleApp1.Model;

namespace ConsoleApp1.Opinion.Model
{
    public interface IOpinion : IModel
    {
        string Content { get; set; }
        OpinionStars Stars { get; set; }
        string[] Photos { get; set; }
    }
}