using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FactoryPattern.ObserverPattern;

namespace FactoryPattern
{
    interface IRunPattern {
        void Run();
    }

    class Program
    {
        static void Main(string[] args)
        {
            //SimpleFactory simple_factory = new SimpleFactory();
            //simple_factory.Run();

            //FactoryMethod fm = new FactoryMethod();
            //fm.Run();

            IRunPattern pattern = new FactoryPattern.ObserverPattern.ObserverPattern();

            pattern.Run();
        }
    }
}
