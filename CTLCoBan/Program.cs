using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau_truc_lenh_co_ban
{
    class Program
    {
        static void Main(string[] args)
        {
            #region kiểm tra số nguyên dương
            //int n262;

            //Console.Write("Kiem tra số dương trong C#:\n");
            //Console.Write("---------------------------------------");
            //Console.Write("\n\n");
            //Console.Write("Nhap mot so nguyen bat ky: ");
            //n262 = Convert.ToInt32(Console.ReadLine());

            //if (n262 > 0 )
            //    Console.WriteLine("{0} la so nguyen duong.\n", n262);
            //else
            //    Console.WriteLine("{0} la so nguyen am\n", n262);

            //Console.ReadKey();
            #endregion
            #region Nhap vao mot so va chuyen thanh chu
            //int n262;
            //Console.Write("Nhap vao mot so va chuyen thanh chu trong c# \n");
            //Console.Write("----------------------");
            //Console.Write("\n Nhap so: ");
            //n262 = Convert.ToInt32(Console.ReadLine());
            //switch (n262)
            //{
            //    case 1:
            //        Console.WriteLine("Mot");
            //        break;
            //    case 2:
            //        Console.WriteLine("Hai");
            //        break;
            //    case 3:
            //        Console.WriteLine("Ba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Bon");
            //        break;
            //    case 5:
            //        Console.WriteLine("Nam");
            //        break;
            //    case 6:
            //        Console.WriteLine("Sau");
            //        break;
            //    case 7:
            //        Console.WriteLine("Bay");
            //        break;
            //    case 8:
            //        Console.WriteLine("Tam");
            //        break;
            //    case 9:
            //        Console.WriteLine("Chín");
            //        break; 
            //    case 10:
            //        Console.WriteLine("So Lon Hon 10");
            //        break;
            //}
            //Console.ReadKey();
            #endregion
            #region Kiem Tra Tam Giac
            //Console.Write("Nhap vao canh a:");
            //int a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao canh b:");
            //int b = int.Parse(Console.ReadLine());
            //Console.Write("Nhap vao canh c:");
            //int c = int.Parse(Console.ReadLine());

            //if (a + b < c || a + c < b || b + c < a)
            //{
            //    //la tam giac
            //    Console.WriteLine("day khong phai la tam giac ");
            //}
            //else if (a == b && b == c)
            //{
            //    //tam giac deu
            //    Console.WriteLine("day la tam giac deu");
            //}
            //else if (a == b || a == c || b == c) // 2 canh bat ky bang nhau
            //{
            //    // tam giac can
            //    Console.WriteLine("day la tam giac can");
            //}
            //else
            //{
            //    // khong phai tam giac
            //    Console.WriteLine("la  TAM GIAC ");
            //}
            //Console.ReadKey();
            #endregion
            #region Giai phuong trinh ax + b = 0
            Console.WriteLine(" ******************************");
            Console.WriteLine(" GIAI CHUONG TRINH AX + B = 0");
            Console.WriteLine(" ******************************");
            string strA, strB;
            int a, b;
            double nghiem;
            Console.WriteLine("nhap a: ");
            strA = Console.ReadLine();
            Console.WriteLine("nhap b: ");
            strB = Console.ReadLine();
            if( int.TryParse(strA, out a) == false|| int.TryParse(strB, out b) == false) // kiem tra nguoi dung co nhap so hay ko
            {
                Console.WriteLine("Du lieu nhap sai!!!");
                return; // lenh nay se duoc hieu la chuong trinh dung lai ma khong thuc hien nhung cau lenh sau do nua

            }
            else
            {
                Console.WriteLine("chuong trinh cua ban vua nhan 2 gia tri: {0}x + {1} = 0", a, b);
                if(a == 0)
                {
                    Console.WriteLine("phuong trinh vo so nghiem");
                    
                }
                else if (b == 0)
                {
                    Console.WriteLine("phuong trinh co nghiem x = 0");

                }
                else
                {
                    nghiem = (double)b / a;// ep kieu de cho ket qua chinh xat;
                    Console.WriteLine("phuong trinh co nghiem x = " + nghiem);
                        
                }
                Console.ReadLine();
            }
            #endregion
        }

    }
}
