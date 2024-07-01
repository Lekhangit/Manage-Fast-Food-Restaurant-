using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_KTGK_2274801030066_LEMINHDUYKHANG
{
    internal class CDaiLyC1:CHoaDon
    {
        private int thoiGianHopTac;

        public CDaiLyC1()
        {
            this.thoiGianHopTac = 5;


        }
        public CDaiLyC1(string maKH, string tenKH, int soLuong, double giaBan, int thoiGianHopTac) : base(maKH, tenKH, soLuong, giaBan)
        {
            this.thoiGianHopTac = thoiGianHopTac;


        }

        public override double thanhTien()
        {
            double vat = 0.1 * soLuong * giaBan;
            double chietKhau = 0.3 * giaBan;
            if (thoiGianHopTac > 3)
            {
                int namhon3 = thoiGianHopTac - 3;
                if (namhon3 > 35)
                {
                    chietKhau += 0.35 * giaBan;  
                }
                else
                {
                    chietKhau += namhon3 * 0.01 * giaBan;
                }
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
            Console.WriteLine("Nhập khoảng thời gian hợp tác: ");
            int.TryParse(Console.ReadLine(), out thoiGianHopTac);
        }
        public virtual void xuat()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| mã khách hàng: {maKH,-10} | tên khách hàng: {tenKH,-10} | số lượng: {soLuong,-10} | khoảng thời gian hợp tác: {thoiGianHopTac,-10} |thành tiền: {thanhTien(),-10}| ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        }
    }
}
