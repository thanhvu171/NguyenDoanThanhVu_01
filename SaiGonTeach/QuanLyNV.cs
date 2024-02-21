using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiGonTeach
{
    class QuanLyNV
    {
        private List<NhanVien> dsNV;
        public QuanLyNV()
        {
            dsNV = new List<NhanVien>();
        }

        //phuong thuc nhap danh sach giang vien
        public void NhapDS()
        {
            string tieptuc = "y";
            int chon;
            NhanVien nv;
            do
            {
                Console.Write("Chon loai nhan vien [1:Bien che, 2:Hop dong]: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        //Tạo đối tượng cho nhân viên biên chế.
                        nv = new NhanVienBC();
                        //Gọi phương thức nhập thông tin.
                        nv.Nhap();
                        //thêm nv vào danh sách.
                        dsNV.Add(nv);
                        break;
                    case 2:
                        //Tạo đối tượng nhân viên hợp đồng.
                        nv = new NhanVienHD();
                        //Gọi phương thức nhập thông tin.
                        nv.Nhap();
                        //Thêm nv vào danh sách.
                        dsNV.Add(nv);
                        break;
                    default:
                        Console.WriteLine("Ban chon sai. Vui long chon 1 hoac 2.");
                        break;
                }
                int dem = 1;
                Console.Write("Ban co muon tiep tuc khong? Y/N: ");
                tieptuc = Console.ReadLine();
                if (tieptuc == "y")
                    dem = dem + 1;
            } while (tieptuc.ToLower() == "y");
        }
        public void XuatDS()
        {
            Console.WriteLine($"{"Ma so",-10}  {"Ho Ten",20} {"Luong cung",15}  {"Luong thuc lanh",20}");
            foreach (NhanVien x in dsNV)
            {
                Console.WriteLine($"{x.Maso,-10}  {x.Hoten,20}  {x.Luongcung,15}  {x.tinhLuong(),20:#,##0 vnd}");
            }
        }
        public int tinhTongLuong()
        {
            int sum = 0;
            foreach (NhanVien nv in dsNV)
            {
                sum += nv.tinhLuong();
            }
            return sum;
        }
        public double tinhTrungBinhLuong()
        {
            double avg = 0;
            foreach (NhanVien nv in dsNV)
            {
                avg = tinhTongLuong() / 3;//Không biết số nhân viên đc nhập. Ghi đại 1 giá trị
            }
            return avg;
        }
    }
}
