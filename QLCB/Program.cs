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
            QLCB q = new QLCB();
            q.Menu();
            Console.ReadKey();
        }
    }
    class Utility
    {
        public static int Level()
        {
            int a;
            while (true)
            {
                try
                {
                    a = int.Parse(Console.ReadLine());
                    if (a > 7)
                    {
                        Console.WriteLine("cap bac khong hon 7!");
                        a = int.Parse(Console.ReadLine());
                    }
                    return a;
                }
                catch (System.Exception)
                {

                    Console.WriteLine("Nhap lai!!");
                }
            }
        }
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
    class Canbo
        {
            public string fullName;
            public string dob;
            public string gender;
            public Canbo() { }
            public Canbo(string name, string dob, string gendet)
            {
                this.fullName = name;
                this.dob = dob;
                this.gender = gender;
            }

        public virtual void Input()
        {
            Console.WriteLine("=====NHap du lieu Can bo=====");
            Console.WriteLine("Nhap Ho va Ten : ");
            fullName = Console.ReadLine();
            Console.WriteLine("Nhap ngay sinh: ");
            dob = Console.ReadLine();
            Console.WriteLine("Nhap gioi tinh:  ");
            gender = Console.ReadLine();
        }
        public virtual void Display()
        {
            Console.Write("Ho va Ten: {0} , Ngay sinh : {1} , Gioi tinh: {2} ", fullName, dob, gender);
        }
    }
    class CongNhan : Canbo
    {
        public int level { get; set; }
        public CongNhan() { }
        public CongNhan(string name, string dob, string gendet, int level) : base(name, dob, gendet)
        {
            this.level = level;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap cap bac: ");
            level = Utility.Level();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Cap Bac: " + level + "/10");
        }
    }
    class Kysu : Canbo
    {
        public string nganh { get; set; }
        public Kysu() { }
        public Kysu(string name, string dob, string gendet, string nganh) : base(name, dob, gendet)
        {
            this.nganh = nganh;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap nganh dao tao: ");
            nganh = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Nganh dao tao: " + nganh);
        }
    }
    class Nhanvien : Canbo
    {
        public string job { get; set; }
        public Nhanvien() { }
        public Nhanvien(string name, string dob, string gendet, string job) : base(name, dob, gendet)
        {
            this.job = job;
        }
        public override void Input()
        {
            base.Input();
            Console.WriteLine("Nhap Cong viec: ");
            job = Console.ReadLine();
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine(" , Nhan vien phuc vu: " + job);
        }
    }
    class QLCB
    {
        private List<Canbo> listCanbo = new List<Canbo>();
        public QLCB() { }
        public void Menu()
        {
            int choose;
            do
            {
                Console.WriteLine("1. Nhap thong tin moi cho can bo");
                Console.WriteLine("2. Tim kiem theo ho va ten");
                Console.WriteLine("3. Hien thi thong tin cua toan can bo");
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
                Console.WriteLine("1.Nhan vien");
                Console.WriteLine("2.Ki Su");
                Console.WriteLine("3.Cong nhan");
                Console.WriteLine("4.Thoat");
                int d = Utility.choose();
                num = d;
                switch (d)
                {
                    case 1:
                        Nhanvien nv = new Nhanvien();
                        nv.Input();
                        listCanbo.Add(nv);

                        break;
                    case 2:

                        Kysu ks = new Kysu();
                        ks.Input();
                        listCanbo.Add(ks);

                        break;
                    case 3:

                        CongNhan cn = new CongNhan();
                        cn.Input();
                        listCanbo.Add(cn);

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
            Console.WriteLine("Nhap ten can bo can tim: ");
            string name = Console.ReadLine();
            for (int i = 0; i < listCanbo.Count; i++)
            {
                if (listCanbo[i].fullName.Equals(name))
                {
                    listCanbo[i].Display();
                }
            }
        }
        public void View()
        {
            if (listCanbo.Count == 0)
            {
                Console.WriteLine("Khong co can bo trong danh sach , vui vong them can bo");
            }
            for (int i = 0; i < listCanbo.Count; i++)
            {
                listCanbo[i].Display();
            }
        }
    }

}
