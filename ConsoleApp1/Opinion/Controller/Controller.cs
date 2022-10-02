using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Model;
using ConsoleApp1.Opinion.Adder;
using ConsoleApp1.Opinion.Factory;
using ConsoleApp1.Opinion.Model;

namespace ConsoleApp1.Opinion.Controller
{
    public class Controller
    {
        private readonly IOpinionAdder _opinionAdder;
        private readonly IOpinionFactory _opinionFactory;

        public Controller(IOpinionAdder opinionAdder, IOpinionFactory opinionFactory)
        {
            _opinionAdder = opinionAdder;
            _opinionFactory = opinionFactory;
        }

        public void Invoke(Request request)
        {
            List<string> files = new List<string>
            {
                "/upload/test-file.jpg",
                "/upload/test-file2.jpg"
            };

            string content = request.Content.GetValueOrDefault("content", "");
            int stars = int.Parse(request.Content.GetValueOrDefault("stars", "0"));

            IOpinion opinion = (IOpinion)_opinionFactory.CreateWithData(content,
                (OpinionStars)stars, files.ToArray());

            _opinionAdder.Add(opinion);
        }
    }
}