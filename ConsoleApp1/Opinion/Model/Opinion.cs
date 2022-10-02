using ConsoleApp1.Model;

namespace ConsoleApp1.Opinion.Model
{
    public class Opinion : IOpinion
    {
        public string Content { get; set; }
        public OpinionStars Stars { get; set; }
        public string[] Photos { get; set; }
    }
}