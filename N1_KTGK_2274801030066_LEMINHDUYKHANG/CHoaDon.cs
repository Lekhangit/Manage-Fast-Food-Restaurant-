using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N1_KTGK_2274801030066_LEMINHDUYKHANG
{
    abstract class CHoaDon
    {
        protected string maKH;
        protected string tenKH;
        protected int soLuong;
        protected double giaBan;
      

        public string MaKH
        {
            get
            {
                return this.maKH;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    return;
                this.maKH = value;
            }
        }
        public string TenKH
        {
            get
            {
                return this.tenKH;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    return;
                this.tenKH = value;
            }
        }

        public int SoLuong
        {
            get { return soLuong; }
            set
            {
                if (value > 0)
                    this.soLuong = value;
                else
                    this.soLuong = 1;
            }
        }
        public double GiaBan
        {
            get { return giaBan; }
            set
            {
                if (value > 0)
                    this.giaBan = value;
                else
                    this.giaBan = 1;
            }
        }
        public CHoaDon(string maKH, string tenKH, int soLuong,double giaBan)
        {


            this.maKH = maKH;
            this.tenKH = tenKH;
            this.soLuong = soLuong;
            this.giaBan = giaBan;
        }

        public CHoaDon()
        {
            this.maKH = "KH001";
            this.tenKH = "khang";
            this.soLuong = 103;
            this.giaBan = 1000000;
        }
        public abstract double thanhTien();

        public abstract void nhaptt();
        public virtual void xuat()
        {
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine($"| mã khách hàng: {maKH,-10} | tên khách hàng: {tenKH,-10} | số lượng: {soLuong,-10} | thành tiền: {thanhTien(),-10}| ");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
        }
    }
}
