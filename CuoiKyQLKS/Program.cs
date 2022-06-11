using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cuoiky221
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            khachsan ks = new khachsan();
            while (true)
            {
                Console.WriteLine("Bài tập c# cuối kỳ");
                Console.WriteLine("1: Thêm người thuê phòng");
                Console.WriteLine("2: Xóa người thuê phòng");
                Console.WriteLine("3: Tính tiền theo CMND");
                Console.WriteLine("4: Hiển thị thông tin khách hàng");
                Console.WriteLine("5: Thoát");
                String line = Console.ReadLine();
                switch (line)
                {
                    case "1":
                        {
                            Console.WriteLine("Nhap tên");
                            String name262 = Console.ReadLine();
                            Console.WriteLine("Nhap tuổi");
                            int age262 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Nhap CMND");
                            String passport262 = Console.ReadLine();

                            Console.WriteLine("Chọn a:Loai phong A");
                            Console.WriteLine("Chọn b:Loai phong B");
                            Console.WriteLine("Chọn c:Loai phong C");
                            String choise = Console.ReadLine();
                            phong room262;
                            if (choise.Equals("a"))
                            {
                                room262 = new phongA();
                            }
                            else if (choise.Equals("b"))
                            {
                                room262 = new phongb();
                            }
                            else if (choise.Equals("c"))
                            {
                                room262 = new phongC();
                            }
                            else
                            {
                                continue;
                            }
                            Console.WriteLine("Nhập số ngày thuê");
                            int number262 = int.Parse(Console.ReadLine());
                            nguoi nx = new nguoi(name262, age262, passport262, room262, number262);
                            ks.add(nx);
                            break;
                        }
                    case "2":
                        {
                            Console.WriteLine("nhap CMND muon xoa: ");
                            String pass = Console.ReadLine();
                            if (!ks.delete(pass))
                            {
                                Console.WriteLine("Không tìm thấy CMND");
                            }
                            else
                            {
                                Console.WriteLine("Xóa thành công");
                            }
                            break;
                        }
                    case "3":
                        {
                            Console.WriteLine("Tính tiền phòng CMND: ");
                            String pass = Console.ReadLine();
                            Console.WriteLine("Tiền phòng: " + ks.calculator(pass));
                            break;
                        }
                    case "4":
                        {
                            ks.show();
                            break;
                        }
                    case "5":
                        {
                            return;
                        }
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        continue;
                }

            }
        }
    }
}

