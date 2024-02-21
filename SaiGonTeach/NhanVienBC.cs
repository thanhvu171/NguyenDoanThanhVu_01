using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiGonTeach
{
    class NhanVienBC : NhanVien
    {
        private string mucxeploai;
        public NhanVienBC() : base()
        {
        }
        public NhanVienBC(string maso, string hoten, int luongcung, string mucxeploai) : base(maso, hoten, luongcung)
        {
            this.mucxeploai = mucxeploai;
        }
        public string Mucxeploai
        {
            set { this.mucxeploai = value; }
            get { return this.mucxeploai; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.Write("Nhap xep loai cua nhan vien. Bao gom (A, B, C): ");
            this.mucxeploai = Console.ReadLine();
        }
        public override int tinhLuong()
        {
            double thuong = 0;
            if (this.mucxeploai == "A")
            {
                thuong = 1.8 * Luongcung;
            }
            else if (this.mucxeploai == "B")
            {
                thuong = 1.2 * Luongcung;
            }
            else if (this.mucxeploai == "C")
            {
                thuong = 0.8 * Luongcung;
            }
            else
                Console.WriteLine("Nhap sai muc xep loai!");
            double luongthuclanhBC = thuong + Luongcung;
            return (int)luongthuclanhBC;
        }
    }
}
