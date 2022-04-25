using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTKiemTra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("----------------------\n");
        come:
            Console.WriteLine("Bai 1: Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.");
            Console.WriteLine("Bai 2: Bai 2: Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *.\n");
            Console.WriteLine("Bai 3: Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.");
            Console.WriteLine("Bai 4: Viết phương thức in ra các thông tin của bản thân (họ tên, lớp, mã sv)). ");
            Console.Write("Chon bai: \n");
            double n262 = double.Parse(Console.ReadLine());
            switch (n262)
            {
                case 1:
                    Console.Clear();
                    Console.Write("Bai 1: Viết phương thức in ra tổng, hiệu, tích, thương của 2 số đc nhập vào bàn phím cho trước.\n ");
                    Bai1();
                    goto come;
                    break;
                case 2:
                    Console.Clear();
                    Console.Write("Bai 2: Viết phương thức In ra lá cờ Việt Nam bằng các dấu = và *.\n ");
                    Console.Write("\n ");
            
                    goto come;
                    break;
                case 3:
                    Console.Clear();
                    Console.Write("Bai 3:Viết phương thức đổi số thập phân thành số nhị phân từ một số thập phân nhập vào từ bàn phím.\n ");
                    Bai3();
                    goto come;
                    break;
                case 4:
                    Console.Clear();
                    Console.Write("Bai 4:Viết phương thức in ra các thông tin của bản thân (họ tên, lớp, mã sv)). \n ");
                    Bai4();
                    goto come;
                    break;
            }
        }
        static void Bai1()
        {
            double a62, b62, tong, hieu, tich, thuong;
            Console.Write("a62: ");
            a62 = double.Parse(Console.ReadLine());
            Console.Write("b62: ");
            b62 = double.Parse(Console.ReadLine());

            tong = a62 + b62;
            hieu = a62 - b62;
            tich = a62 * b62;
            thuong = a62 / b62;
            Console.WriteLine("Tong cua 2 so la: {0} + {1} = {2} ", a62, b62, tong);
            Console.WriteLine("Tich cua 2 so la: {0} * {1} = {2} ", a62, b62, tich);
            Console.WriteLine("Hieu cua 2 so la: {0} - {1} = {2} ", a62, b62, hieu);
            Console.WriteLine("Thuong cua 2 so la: {0} / {1} = {2} ", a62, b62, Math.Round(thuong, 2));
        }

        static void Bai3() {
            Console.Write("nhap so: ");
            int number62 = int.Parse(Console.ReadLine());
            string Result62 = string.Empty;
            for (int i = 0; number62 > 0; i++)
            {
                Result62 = number62 % 2 + Result62;
                number62 = number62 / 2;
            }
            Console.WriteLine($"ket qua: {Result62}");
        }

        static void Bai4()
        {
            string ten62, lop62, masv62;
            Console.WriteLine("Nhap thong tin ca nhan");
            Console.Write("nhap ten: ");
            ten62 = Console.ReadLine();
            Console.Write("nhap lop: ");
            lop62 = Console.ReadLine();
            Console.Write("Nhap ma sinh vien: ");
            masv62 = Console.ReadLine();
            Console.WriteLine("Ten sinh vien la: "+ ten62);
            Console.WriteLine("Lop sinh vien la: "+ lop62);
            Console.WriteLine("Ma sinh vien la: "+ masv62);

        }
    }
}
