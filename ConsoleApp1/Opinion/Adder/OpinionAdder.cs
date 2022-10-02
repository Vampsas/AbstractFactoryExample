using System;
using ConsoleApp1.Opinion.Model;

namespace ConsoleApp1.Opinion.Adder
{
    public class OpinionAdder: IOpinionAdder
    {
        public void Add(IOpinion opinion)
        {
            Console.WriteLine("I am adding new opinion");
            Console.WriteLine("====");
            Console.WriteLine("Content {0}", opinion.Content);
            Console.WriteLine("Stars: '{0}'", opinion.Stars);
            Console.WriteLine("Files:");
            foreach (string photo in opinion.Photos)
            {
                Console.WriteLine("Photo: {0}", photo);
            }
        }
    }
}