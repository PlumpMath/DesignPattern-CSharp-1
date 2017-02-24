using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class SimpleFactory : IRunPattern
    {
        public void Run()
        {
            Zoo shenzhenZoo = new Zoo();

            while (true)
            {
                Console.WriteLine("Please input a animal name:");
                string input = Console.ReadLine();

                Animal wanted = shenzhenZoo.sendOut(input);

                if (wanted != null)
                {
                    wanted.run();
                }
                else
                {
                    Console.WriteLine("Shenzhen Zoo has no " + input);
                }

                Console.WriteLine();
            }
        }
    }

    public interface Animal
    {
        void run();
    }

    public class Cat : Animal
    {
        public void run()
        {
            Console.WriteLine("A black cat comes over here");
        }
    }

    public class Cheetah : Animal
    {
        public void run()
        {
            Console.WriteLine("A spot cheetah comes over here");
        }
    }

    public class Tiger : Animal
    {
        public void run()
        {
            Console.WriteLine("A big tiger comes over here");
        }
    }

    public class Horse : Animal
    {
        public void run()
        {
            Console.WriteLine("A tall horse comes over here");
        }
    }

    public class Zoo
    {
        public Animal sendOut(string type)
        {
            switch (type.ToLower())
            { 
                case "cat":
                    return new Cat();  
                case "cheetah":
                    return new Cheetah();
                case "tiger":
                    return new Tiger();
                case "horse":
                    return new Horse();
                default:
                    return null;
            }
        }
    }
}
