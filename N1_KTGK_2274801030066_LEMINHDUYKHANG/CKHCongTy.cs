using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_KTGK_2274801030066_LEMINHDUYKHANG
{
    internal class CKHCongTy:CHoaDon
    {
        private int soLuongNV;

        public CKHCongTy()
        {
            this.soLuongNV = 5;


        }
        public CKHCongTy(string maKH, string tenKH, int soLuong, double giaBan, int soLuongNV) : base(maKH, tenKH, soLuong, giaBan)
        {
            this.soLuongNV = soLuongNV;


        }

        public override double thanhTien()
        {
            double vat = 0.1 * soLuong * giaBan;
            double chietKhau = 0;

            if (soLuongNV > 1000)
            {
                chietKhau = 0.03 * giaBan;  
            }
            else if (soLuongNV > 5000)
            {
                chietKhau = 0.05 * giaBan;  
            }

            return soLuong * giaBan - chietKhau + vat;
        }
        public override void nhaptt()
        {
            Console.WriteLine("Nhập mã khách hàng: ");
            maKH = Console.ReadLine();
            Console.WriteLine("Nhập tên khách hàng: ");
            tenKH = Console.ReadLine();
            Console.WriteLine("Nhập số lượng: ");
            int.TryParse(Console.ReadLine(), out soLuong);
            Console.WriteLine("Nhập giá bán: ");
            double.TryParse(Console.ReadLine(), out giaBan);
            Console.WriteLine("Nhập số lượng nhân viên: ");
            int.TryParse(Console.ReadLine(), out soLuongNV);
        }
        public double troGia()
        {
            return thanhTien() - (soLuong * 120000);
        }
        public virtual void xuat()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| mã khách hàng: {maKH,-10} | tên khách hàng: {tenKH,-10} | số lượng: {soLuong,-10} |trợ giá {troGia(),-10}  | số lượng nhân viên:{soLuongNV,-10}|thành tiền: {thanhTien(),-10} |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
