using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class FactoryMethod
    {
        public void Run()
        {
            IZoo zoo = new HaErBinZoo();
            zoo.GetAnimal().Running();
        }
    }

    public interface IAnimal
    {
        void Running();
    }

    public interface IZoo
    {
        IAnimal GetAnimal();
    }

    public class HuaNanTiger : IAnimal
    {
        public void Running()
        {
            Console.WriteLine("A HuaNan-Tiger is running");
        }
    }

    public class DongBeiTiger : IAnimal
    {
        public void Running()
        {
            Console.WriteLine("A DongBei-Tiger is running");
        }
    }

    public class ShenZhenZoo : IZoo
    {
        public IAnimal GetAnimal()
        {
            return new HuaNanTiger();
        }
    }

    public class HaErBinZoo : IZoo
    {
        public IAnimal GetAnimal()
        {
            return new DongBeiTiger();
        }
    }
}
