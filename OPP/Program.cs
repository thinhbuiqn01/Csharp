using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat catd = new Cat();
            Cat catt = new Cat(20, 30);
            catd.info();
            catt.info();
            Console.ReadKey();
        }
    }
    class Animal
    {
        public double weight;
        public double height;
        public void info()
        {
            Console.WriteLine(" keeee " + height);
        }
    }
    class Cat
    {
        public double weight;
        public double height;
        public Cat()
        {
            weight = 800;
            height = 32;
        }
        public Cat(double w, double h)
        {
            weight = w;
            height = h;

        }
        public void info()
        {
            Console.WriteLine(" meo " + height);
        }
    }
}
