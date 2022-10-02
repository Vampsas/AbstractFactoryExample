using ConsoleApp1.Model;

namespace ConsoleApp1.Factory
{
    public interface IFactory
    {
        public IModel CreateNew();
    }
}