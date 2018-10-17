using System;

namespace design.pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Singleton===========================");
            Singleton singleton = new Singleton();
            singleton.run();


            Console.WriteLine("Factory=============================");
            Factory factory = new Factory();
            factory.run();


            Console.WriteLine("Facade==============================");
            FacadePatternDemo facadePatternDemo = new FacadePatternDemo();
            facadePatternDemo.run();
                
        }
    }
}
