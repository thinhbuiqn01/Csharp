using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiemDanh10_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr262 = new int[100];
           int n262;
            n262 = 10;
            Console.Write("Nhap {0} phan tu vao trong mang:\n", n262);
            for (int i = 0; i < n262; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                arr262[i] = Convert.ToInt32(Console.ReadLine());
            }
            minMax(arr262);
            Console.WriteLine("Mảng sắp xếp tăng dần");
            mangTang(arr262);
            Console.ReadKey();
        }
        static void minMax(int[] arr262)
        {
            int max262, min262;


            max262 = arr262[0];
            min262 = arr262[0];

            for (int i = 1; i < 10; i++)
            {
                if (arr262[i] > max262)
                {
                    max262 = arr262[i];
                }


                if (arr262[i] < min262)
                {
                    min262 = arr262[i];
                }
            }
            Console.Write("Phan tu lon nhat trong mang la: {0}\n", max262);
            Console.Write("Phan tu nho nhat trong mang la: {0}\n\n", min262);
        }
        static void countXuatHien(int[] arr262)
        {

        }
        static void mangTang(int[] arr262)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr262[i] > arr262[j])
                    {
                        int temp262 = arr262[i];
                        arr262[i] = arr262[j];
                        arr262[j] = temp262;
                    }
                }

            }
            for (int i = 0; i < 10; i++)
            {
                Console.Write(arr262[i]+ " ");
            }
        }
    }
}
