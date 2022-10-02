using ConsoleApp1.Factory;
using ConsoleApp1.Model;
using ConsoleApp1.Opinion.Model;

namespace ConsoleApp1.Opinion.Factory
{
    public interface IOpinionFactory : IFactory
    {
        IOpinion CreateWithData(string content, OpinionStars stars, string[] photos);
    }
}