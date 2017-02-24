using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    class AbstractFactory : IRunPattern
    {
        public void Run()
        {
            IZoo zoo = new HaErBinZoo();
            zoo.GetTiger().Biting();
            zoo.GetBird().Flying();

            IZoo zoo2 = new ShenZhenZoo();
            zoo2.GetTiger().Biting();
            zoo2.GetBird().Flying();
        }

        public interface ITiger
        {
            void Biting();
        }

        public interface IBird
        {
            void Flying();
        }

        public interface IZoo
        {
            ITiger GetTiger();
            IBird GetBird();
        }

        public class HuaNanTiger : ITiger
        {
            public void Biting()
            {
                Console.WriteLine("A HuaNan-Tiger is biting");
            }
        }

        public class DongBeiTiger : ITiger
        {
            public void Biting()
            {
                Console.WriteLine("A DongBei-Tiger is biting");
            }
        }

        public class Petrel : IBird
        {
            public void Flying()
            {
                Console.WriteLine("A Petrel is flying");
            }
        }

        public class Swan : IBird
        {
            public void Flying()
            {
                Console.WriteLine("A Swan is flying");
            }
        }

        public class ShenZhenZoo : IZoo
        {
            public ITiger GetTiger()
            {
                return new HuaNanTiger();
            }

            public IBird GetBird()
            {
                return new Petrel();
            }
        }

        public class HaErBinZoo : IZoo
        {
            public ITiger GetTiger()
            {
                return new DongBeiTiger();
            }

            public IBird GetBird()
            {
                return new Swan();
            }
        }
    }
}
