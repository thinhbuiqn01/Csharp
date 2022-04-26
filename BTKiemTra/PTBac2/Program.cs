using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap a,b,c: ");
            double a262 = Int32.Parse(Console.ReadLine());
            double b262 = Int32.Parse(Console.ReadLine());
            double c262 = Int32.Parse(Console.ReadLine());
            ptb2 pt = new ptb2(a262, b262, c262);

            double delta = pt.delta(a262, b262, c262);
            int check262 = pt.nghiem(delta);
            if (check262 < 0)
            {
                Console.WriteLine("Pt vo nghiem");
            }
            else if (check262 == 0)
            {
                double x = -b262 / (2 * a262);
                Console.WriteLine("pt co nghiem kep: ", x);
            }
            else
            {
                double x1 = (-b262 - Math.Sqrt(delta)) / (2 * a262);
                double x2 = (-b262 + Math.Sqrt(delta)) / (2 * a262);

                Console.WriteLine("Pt co 2 nghiem x1={0} , x2={1}: ", x1, x2);
            }
        }
    }

    class ptb2
    {
        private double a262;
        private double b262;
        private double c262;

        public ptb2()
        {
        }

        public ptb2(double a262, double b262, double c262)
        {
            A = a262;
            B = b262;
            C = c262;
        }

        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }

        public double delta(double a262, double b262, double c262)
        {
            return b262 * b262 - 4 * a262 * c262;
        }

        public int nghiem(double delta262)
        {
            if (delta262 < 0)
            {
                return -1;
            }
            else if (delta262 == 0)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}