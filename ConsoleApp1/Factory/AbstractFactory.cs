using System;
using System.Reflection;
using ConsoleApp1.Model;

namespace ConsoleApp1.Factory
{
    public abstract class AbstractFactory : IFactory

    {
        public virtual IModel CreateNew()
        {
            string name = Assembly.GetExecutingAssembly().GetName().Name;
            string modelName = this.GetType().Name.Replace("Factory", "");
            string modelNamespace = string.Format("{0}.{1}.Model.{1}", name, modelName);

            Type t = Type.GetType(modelNamespace);
            return (IModel)Activator.CreateInstance(t);
            
            // return new Post.Model.Post();
        }
    }
}