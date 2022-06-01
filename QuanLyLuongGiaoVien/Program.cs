using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyLuong
{
    class Program
    {
        static void Main(string[] args)
        {
            CBGV canBoGiaoVien = new CBGV();
            while (true)
            {
                Console.WriteLine("\nCHUONG TRINH QUAN LY giao VIEN C#");
                Console.WriteLine("*************************MENU**************************");
                Console.WriteLine("**  1. Them giao vien.                               **");
                Console.WriteLine("**  2. Cap nhat thong tin giao vien boi ID.          **");
                Console.WriteLine("**  3. Xoa giao vien boi ID.                         **");
                Console.WriteLine("**  4. Tim kiem giao vien theo ten.                  **");
                Console.WriteLine("**  5. Sap xep giao vien theo diem trung binh (GPA). **");
                Console.WriteLine("**  6. Sap xep giao vien theo ten.                   **");
                Console.WriteLine("**  7. Sap xep giao vien theo ID.                    **");
                Console.WriteLine("**  8. Hien thi danh sach giao vien.                 **");
                Console.WriteLine("**  0. Thoat                                         **");
                Console.WriteLine("*******************************************************");
                Console.Write("Nhap tuy chon: ");
                int key = Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Console.WriteLine("\n1. Them giao vien.");
                        canBoGiaoVien.nhapGiaoVien();
                        Console.WriteLine("\nThem giao vien thanh cong!");
                        break;
                    case 2:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n2. Cap nhat thong tin giao vien. ");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            // canBoGiaoVien.updateGiaoVien(id);
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 3:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            int id;
                            Console.WriteLine("\n3. Xoa giao vien.");
                            Console.Write("\nNhap ID: ");
                            id = Convert.ToInt32(Console.ReadLine());
                            if (canBoGiaoVien.DeleteByID(id))
                            {
                                Console.WriteLine("\ngiao vien co id = {0} da bi xoa.", id);
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 4:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            Console.WriteLine("\n4. Tim kiem giao vien theo ten.");
                            Console.Write("\nNhap ten de tim kiem: ");
                            string name = Convert.ToString(Console.ReadLine());
                            List<Nguoi> searchResult = canBoGiaoVien.FindByName(name);
                            canBoGiaoVien.ShowGiaoVien(searchResult);
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 5:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            Console.WriteLine("\n5. Sap xep giao vien theo Luong.");
                            canBoGiaoVien.SortByDiemTB();
                            canBoGiaoVien.ShowGiaoVien(canBoGiaoVien.getListGiaoVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 6:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep giao vien theo ten.");
                            canBoGiaoVien.SortByName();
                            canBoGiaoVien.ShowGiaoVien(canBoGiaoVien.getListGiaoVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 7:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            Console.WriteLine("\n6. Sap xep giao vien theo ID.");
                            canBoGiaoVien.SortByID();
                            canBoGiaoVien.ShowGiaoVien(canBoGiaoVien.getListGiaoVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 8:
                        if (canBoGiaoVien.soLuongGiaoVien() > 0)
                        {
                            Console.WriteLine("\n7. Hien thi danh sach giao vien.");
                            canBoGiaoVien.ShowGiaoVien(canBoGiaoVien.getListGiaoVien());
                        }
                        else
                        {
                            Console.WriteLine("\nSanh sach giao vien trong!");
                        }
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("\nKhong co chuc nang nay!");
                        Console.WriteLine("\nHay chon chuc nang trong hop menu.");
                        break;
                }
            }
        }
    }
    class Nguoi
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
        public double salary { get; set; }
        public double bonusSalary { get; set; }
        public double realSalary { get; set; }
        public double punishSalary { get; set; }
    }
    class CBGV: Nguoi
    {
        public List<Nguoi> nguois = null;
        public int GenerateID()
        {
            int max = 1;
            if(nguois != null && nguois.Count > 0)
            {
                max = nguois[0].ID;
                foreach(Nguoi nguoi in nguois)
                {
                    if(max < nguoi.ID)
                    {
                        max = nguoi.ID;
                    }
                }
                max++;
            }
            return max;
        }
        public int soLuongGiaoVien()
        {
            int countGV = 0;
            if(nguois != null)
            {
                countGV = nguois.Count;
            }
            return countGV;
        }
        public void nhapGiaoVien()
        {
            Nguoi nguoi = new Nguoi();
            nguoi.ID = GenerateID();
            Console.Write("Nhap ten Giao vien: ");
            nguoi.Name = Console.ReadLine();
            Console.Write("Nhap tuoi Giao vien: ");
            nguoi.Age = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi Giao vien: ");
            nguoi.Address = Console.ReadLine();
            Console.Write("Nhap Luong chinh thuc Giao vien: ");
            nguoi.realSalary = double.Parse(Console.ReadLine());
            Console.Write("Nhap Luong thuong Giao vien: ");
            nguoi.bonusSalary = double.Parse(Console.ReadLine());
            Console.Write("Nhap Luong phat Giao vien: ");
            nguoi.punishSalary = double.Parse(Console.ReadLine());
        }
        public void updateGiaoVien()
        {
            // search Nguoi
            Nguoi nguoi = FindByID(ID);
            if (nguoi != null)
            {
                Console.Write("Nhap ten giao vien: ");
                string name = Console.ReadLine();
                // Nếu không nhập gì thì không cập nhật tên
                if (name != null && name.Length > 0)
                {
                    nguoi.Name = name;
                }
                string ageStr = Convert.ToString(Console.ReadLine());
                if (ageStr != null && ageStr.Length > 0)
                {
                    nguoi.Age = Convert.ToInt32(ageStr);
                }
                Console.Write("Nhap dia chi Giao vien: ");
                string address = Convert.ToString(Console.ReadLine());
                {
                    nguoi.Address = address;
                }
                Console.Write("Nhap Luong chinh thuc Giao vien: ");
                string RealSalary = Convert.ToString(Console.ReadLine());
                if (RealSalary != null && RealSalary.Length > 0)
                {
                    nguoi.realSalary = Convert.ToDouble(RealSalary);
                }

                Console.Write("Nhap Luong thuong Giao vien: ");
                string BonusSalary = Convert.ToString(Console.ReadLine());
                if (BonusSalary != null && BonusSalary.Length > 0)
                {
                    nguoi.bonusSalary = Convert.ToDouble(BonusSalary);
                }
                Console.Write("Nhap Luong phat Giao vien: ");
                string PunishSalary = Convert.ToString(Console.ReadLine());
                if (PunishSalary != null && PunishSalary.Length > 0)
                {
                    nguoi.punishSalary = Convert.ToDouble(PunishSalary);
                }
                LuongNhan(nguoi);
            }
            else
            {
                Console.WriteLine("Giao vien co ID = {0} khong ton tai.", ID);
            }
        }
        private void LuongNhan(Nguoi nguoi)
        {
            double LuongNhan = (nguoi.bonusSalary + nguoi.realSalary - nguoi.punishSalary);
            nguoi.salary = Math.Round(LuongNhan, 2, MidpointRounding.AwayFromZero);
            
        }
        private Nguoi FindByID(int iD)
        {

            Nguoi searchResult = null;
            if (nguois != null && nguois.Count > 0)
            {
                foreach (Nguoi nguoi in nguois)
                {
                    if (nguoi.ID == ID)
                    {
                        searchResult = nguoi;
                    }
                }
            }
            return searchResult;
        }
        public void ShowGiaoVien(List<Nguoi> nguois)
        {
            // hien thi tieu de cot
            Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                  "ID", "Name", "Address", "Age", "realSalary", "bonusSalary", "punishSalary", "salary");
            // hien thi danh sach giao vien
            if (nguois != null && nguois.Count > 0)
            {
                foreach (Nguoi sv in nguois)
                {
                    Console.WriteLine("{0, -5} {1, -20} {2, -5} {3, 5} {4, 5} {5, 5} {6, 5} {7, 10} {8, 10}",
                                      sv.ID, sv.Name, sv.Address, sv.Age, sv.realSalary, sv.bonusSalary, sv.punishSalary, sv.salary
);
                }
            }
            Console.WriteLine();
        }
        public bool DeleteByID(int ID)
        {
            bool IsDeleted = false;
            //search Giao Vien theo ID
            Nguoi nguoi = FindByID(ID);
            if(nguoi != null)
            {
                IsDeleted = nguois.Remove(nguoi);

            }
            return IsDeleted;
        }
        // search by name
        public List<Nguoi> FindByName(String keyword)
        {
            List<Nguoi> searchResult = new List<Nguoi>();
            if (nguois != null && nguois.Count > 0)
            {
                foreach (Nguoi nguoi in nguois)
                {
                    if (nguoi.Name.ToUpper().Contains(keyword.ToUpper()))
                    {
                        searchResult.Add(nguoi);
                    }
                }
            }
            return searchResult;
        }
        /**
         * Hàm sắp xếp danh sach giao vien theo tên tăng dần
         */
        public void SortByName()
        {
            nguois.Sort(delegate (Nguoi ng1, Nguoi ng2) {
                return ng1.Name.CompareTo(ng2.Name);
            });
        }
        /**
         * Hàm sắp xếp danh sach giao vien theo Luong tăng dần
         */
        public void SortByDiemTB()
        {
            nguois.Sort(delegate (Nguoi ng1, Nguoi ng2) {
                return ng1.salary.CompareTo(ng2.salary);
            });
        }
        /**
         * Hàm sắp xếp danh sach giao vien theo ID tăng dần
         */
        public void SortByID()
        {
            nguois.Sort(delegate (Nguoi ng1, Nguoi ng2) {
                return ng1.ID.CompareTo(ng2.ID);
            });
        }
        /*
         * Hàm trả về danh sách GIao viên hiện tại
         */
        public List<Nguoi> getListGiaoVien()
        {
            return nguois;
        }
    }
    
}
