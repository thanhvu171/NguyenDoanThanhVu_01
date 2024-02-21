using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiGonTeach
{
    class Program
    {
        static void Main(string[] args)
        {
            menu();
        }
        static void menu()
        {
            QuanLyNV ql = new QuanLyNV();
            int chon = 0;
            do
            {
                //in thuc don ra man hinh
                Console.WriteLine("--->CHUONG TRINH QUAN LY NHAN VIEN<---");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("1.Nhap danh sach nhan vien.");
                Console.WriteLine("2.Xuat thong tin nhan vien.");
                Console.WriteLine("3.Thong ke tong luong thuc lanh phai tra cho nhan vien.");
                Console.WriteLine("4.Thong ke trung binh luong thuc lanh phai tra cho nhan vien.");
                Console.WriteLine("0.Thoat chuong trinh.");
                Console.WriteLine("--------------------------------");
                Console.Write("Ban chon chuc nang: ");
                chon = int.Parse(Console.ReadLine());

                switch (chon)
                {
                    case 1:
                        ql.NhapDS();
                        break;

                    case 2:
                        ql.XuatDS();
                        break;
                    case 3:
                        Console.WriteLine($"Tong tien luong phai tra: {ql.tinhTongLuong():#,##0 vnd}");
                        break;
                    case 4:
                        Console.WriteLine($"Trung binh tien luong phai tra: {ql.tinhTrungBinhLuong():#,##0 vnd}");
                        break;
                    case 0:
                        Console.WriteLine("!!!_Hen gap lai_!!!");
                        Console.ReadLine();
                        break;
                }
            } while (chon != 0);
        }
    }
}

