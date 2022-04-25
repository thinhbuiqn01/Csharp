using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuyenSinh
{
    class thiSinhThi
    {
        static void Main(string[] args)
        {
            Tuyensinh q = new Tuyensinh();
            q.Menu();
            Console.ReadKey();
        }
    }
    class Utility
    {
       
        public static int choose()
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    return a;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Nhap lai!!");
                }
            }
        }
    }
    class Tuyensinh
    {
        private List<hocSinh> listTuyenSinh = new List<hocSinh>();
        public Tuyensinh() { }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Nhap thong tin moi cho hoc sinh");
                Console.WriteLine("2. Tim kiem theo so bao danh");
                Console.WriteLine("3. Hien thi thong tin cua toan thi sinh");
                Console.WriteLine("4. Thoat");
                choose = Utility.choose();
                switch (choose)
                {
                    case 1:
                        add();
                        break;
                    case 2:
                        search();
                        break;
                    case 3:
                        View();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!!");
                        break;
                }
            } while (choose != 4);
        }
        public void add()
        {
            int num;
            do
            {
                Console.WriteLine("===Chon vi tri muon them===");
                Console.WriteLine("1.Khoi A");
                Console.WriteLine("2.Khoi B");
                Console.WriteLine("3.khoi C");
                Console.WriteLine("4.Thoat");
                int d = Utility.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        khoiA kA = new khoiA();
                        kA.Input();
                        listTuyenSinh.Add(kA);

                        break;
                    case 2:

                        khoiB kB = new khoiB();
                        kB.Input();
                        listTuyenSinh.Add(kB);

                        break;
                    case 3:

                        khoiC kC = new khoiC();
                        kC.Input();
                        listTuyenSinh.Add(kC);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Nhap lai !!");
                        break;
                }
            } while (num != 4);
        }
        public void search()
        {
            Console.WriteLine("Nhap so bao danh thi sinh can tim: ");
            string sbd = Console.ReadLine();
            for (int i = 0; i < listTuyenSinh.Count; i++)
            {
                if (listTuyenSinh[i].sbd.Equals(sbd))
                {
                    listTuyenSinh[i].Display();
                }
            }
        }
        public void View()
        {
            if (listTuyenSinh.Count == 0)
            {
                Console.WriteLine("Khong co can bo trong danh sach , vui vong them can bo");
            }
            for (int i = 0; i < listTuyenSinh.Count; i++)
            {
                listTuyenSinh[i].Display();
            }
        }
    }
    class hocSinh
    {
        public string sbd;
        public string fullName;
        public string address;
        public string priority;
        public hocSinh() { }
        public hocSinh(string sbd, string fullName, string address, string priority)
        {
            this.sbd = sbd;
            this.fullName = fullName;
            this.address = address;
            this.priority = priority;
        }
        public virtual void Input()
        {
            Console.WriteLine("=====NHap du lieu Can bo=====");
            Console.WriteLine("Nhap Ho va Ten : ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.WriteLine("Nhap dia chi:  ");
            address = Console.ReadLine();
            Console.WriteLine("Nhap diem uu tien:  ");
            priority = Console.ReadLine();
        }

        public virtual void Display()
        {
            Console.Write("So bao danh: {0} ,ho ten : {1} , dia chi: {2}, muc uu tien: {3}", sbd, fullName, address, priority);
        }
    }
    class khoiA : hocSinh
    {
        public int toan { get; set; }
        public int ly { get; set; }
        public int hoa { get; set; }
        public khoiA() { }
        public khoiA(string sbd, string fullName, string address, string priority, int toan, int ly, int hoa) : base(sbd, fullName, address, priority)
        {
            this.toan = toan;
            this.ly = ly;
            this.hoa = hoa;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap diem toan: ");
            toan = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem ly: ");
            ly = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            hoa = int.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Toan: " + toan + " ly: " + ly + "hoa: " + hoa);
        }
    }
    class khoiB : hocSinh
    {
        public int toan { get; set; }
        public int hoa { get; set; }
        public int sinh { get; set; }
        public khoiB() { }
        public khoiB(string sbd, string fullName, string address, string priority, int toan, int hoa, int sinh) : base(sbd, fullName, address, priority)
        {
            this.toan = toan;
            this.hoa = hoa;
            this.sinh = sinh;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap diem toan: ");
            toan = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem hoa: ");
            hoa = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem sinh: ");
            sinh = int.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Toan: " + toan + " hoa: " + hoa + "sinh: " + sinh);
        }
    }
    class khoiC : hocSinh
    {
        public int van { get; set; }
        public int su { get; set; }
        public int dia { get; set; }
        public khoiC() { }
        public khoiC(string sbd, string fullName, string address, string priority, int van, int su, int dia) : base(sbd, fullName, address, priority)
        {
            this.van = van;
            this.su = su;
            this.dia = dia;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap diem van: ");
            van = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem su: ");
            su = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap diem dia: ");
            dia = int.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , van: " + van + " su: " + su + " dia: " + dia);
        }
    }
}
