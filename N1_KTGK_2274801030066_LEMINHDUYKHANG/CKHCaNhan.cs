using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_KTGK_2274801030066_LEMINHDUYKHANG
{
    internal class CKHCaNhan : CHoaDon, ItroGia
    {
        private int khoangCachGiaoHang;

        public CKHCaNhan()
        {
            this.khoangCachGiaoHang = 5;


        }
        public CKHCaNhan(string maKH, string tenKH, int soLuong, double giaBan, int khoangCachGiaoHang) : base(maKH, tenKH, soLuong, giaBan)
        {
            this.khoangCachGiaoHang = khoangCachGiaoHang;


        }

        public override double thanhTien()
        {
            double vat = 0.1 * soLuong * giaBan;
            double chietKhau = 0;

            if (soLuong >= 5)
            {
                chietKhau = 0.03 * giaBan;
                if (khoangCachGiaoHang < 10)
                {
                    chietKhau += 20000;
                }
            }

            return soLuong * giaBan - chietKhau + vat;
        }

        public override void  nhaptt()
        {
            Console.WriteLine("Nhập mã khách hàng: ");
            maKH= Console.ReadLine();
            Console.WriteLine("Nhập tên khách hàng: ");
            tenKH = Console.ReadLine();
            Console.WriteLine("Nhập số lượng: ");
            int.TryParse(Console.ReadLine(), out soLuong);
            Console.WriteLine("Nhập giá bán: ");
            double.TryParse(Console.ReadLine(), out giaBan);
            Console.WriteLine("Nhập khoảng cách: ");
            int.TryParse(Console.ReadLine(), out khoangCachGiaoHang);
        }

        public double troGia()
        {
            double chietKhau = 0.02 * giaBan;
            if (soLuong > 2)
            {
                chietKhau += 100000;
            }
            return chietKhau;

            
        }
        public virtual void xuat()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| mã khách hàng: {maKH,-10} | tên khách hàng: {tenKH,-10} | số lượng: {soLuong,-10} |trợ giá {troGia(),-10}  | khoảng cách giao hàng:{khoangCachGiaoHang,-10}|thành tiền: {thanhTien(),-10} |");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}