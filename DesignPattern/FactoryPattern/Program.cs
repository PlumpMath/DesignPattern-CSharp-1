using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleFactory simple_factory = new SimpleFactory();
            //simple_factory.Run();

            //FactoryMethod fm = new FactoryMethod();
            //fm.Run();

            AbstractFactory af = new AbstractFactory();
            af.Run();
        }
    }
}
