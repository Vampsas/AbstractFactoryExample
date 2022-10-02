using ConsoleApp1.Factory;
using ConsoleApp1.Model;
using ConsoleApp1.Opinion.Model;

namespace ConsoleApp1.Opinion.Factory
{
    public class OpinionFactory : AbstractFactory, IOpinionFactory
    {
        public IOpinion CreateWithData(string content, OpinionStars stars, string[] photos)
        {
            IOpinion opinion = (IOpinion)CreateNew();
            opinion.Content = content;
            opinion.Stars = stars;
            opinion.Photos = photos;

            return opinion;
        }
    }
}