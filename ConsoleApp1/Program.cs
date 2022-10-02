using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApp1.Model;
using ConsoleApp1.Opinion.Adder;
using ConsoleApp1.Opinion.Controller;
using ConsoleApp1.Opinion.Factory;
using ConsoleApp1.Post.Factory;
using ConsoleApp1.Product.Factory;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var request = CreateRequest();
            OpinionAdder opinionAdder = new OpinionAdder();
            OpinionFactory opinionFactory = new OpinionFactory();
            Controller controller = new Controller(opinionAdder, opinionFactory);
            
            controller.Invoke(request);

            ProductFactory productFactory = new ProductFactory();
            var product = productFactory.CreateNew();
            Console.WriteLine(product.GetType().FullName);
            

            Console.ReadLine();
        }

        private static Request CreateRequest()
        {
            Request request = new Request();
            Dictionary<string, string> requestContent = new Dictionary<string, string>
            {
                { "stars", "1" },
                { "content", "Totally piece of mud!" }
            };
            request.Content = requestContent;
            return request;
        }
    }
}