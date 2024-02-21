using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaiGonTeach
{
    class NhanVienHD : NhanVien
    {
        private int doanhthu;
        public NhanVienHD() : base()
        {
        }
        public NhanVienHD(string maso, string hoten, int luongcung, int doanhthu) : base(maso, hoten, luongcung)
        {
            this.doanhthu = doanhthu;
        }
        public int Doanhthu
        {
            set { this.doanhthu = value; }
            get{ return this.doanhthu; }
        }
        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("Nhap doanh thu cua nhan vien: ");
            this.doanhthu = int.Parse(Console.ReadLine());
        }
        public override int tinhLuong()
        {
            double luongthuclanhHD = 0.05 * doanhthu + Luongcung;
            return (int)luongthuclanhHD;
        }
    }
}
