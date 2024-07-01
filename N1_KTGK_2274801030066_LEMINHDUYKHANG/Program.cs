using N1_KTGK_2274801030066_LEMINHDUYKHANG;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<CHoaDon> danhSachHoaDon = new List<CHoaDon>();

        while (true)
        {
            Console.WriteLine("chương trình quản lí hóa đơn - lê minh duy khang");
            Console.WriteLine("1. nhập hóa đơn");
            Console.WriteLine("2. tính tổng thành tiền của tất cả hóa đơn:");
            Console.WriteLine("3. thông tin khách hàng mua nhiều nhất");
            Console.WriteLine("4. tính tổng sô tiền chiết khấu của công ty");
            Console.WriteLine("5. sắp xếp danh sách hóa đơn");
            Console.WriteLine("6. tìm mã hóa đơn theo yêu cầu");
            Console.WriteLine("0. Thoát");

            Console.Write("Chọn chức năng: ");
            int choice;
            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("lựa chọn không hợp lệ.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    Console.WriteLine("nhập số lượng hóa đơn:");
                    int n;
                    if (int.TryParse(Console.ReadLine(), out n))
                    {
                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Chọn loại khách hàng (1: Canhan, 2: Congty, 3: DaiLyC1):");
                            if (int.TryParse(Console.ReadLine(), out int luachon))
                            {
                                CHoaDon hoaDon;
                                if (luachon == 1)
                                {
                                    hoaDon = new CKHCaNhan();
                                }
                                else if (luachon == 2)
                                {
                                    hoaDon = new CKHCongTy();
                                }
                                else if (luachon == 3)
                                {
                                    hoaDon = new CDaiLyC1();
                                }
                                else
                                {
                                    Console.WriteLine("loại khách hàng không hợp lệ không tạo hóa đơn.");
                                    continue;
                                }
                                hoaDon.nhaptt();
                                danhSachHoaDon.Add(hoaDon);
                            }
                            else
                            {
                                Console.WriteLine("lựa chọn không hợp lệ.");
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("lựa chọn không hợp lệ.");
                    }
                    break;

                case 2:
                    double tongthanhtien = 0;
                    foreach (var hoaDon in danhSachHoaDon)
                    {
                        tongthanhtien += hoaDon.thanhTien();
                    }
                    Console.WriteLine($"tổng thành tiền của tất cả hóa đơn: {tongthanhtien}");
                    break;

                case 3:
                    if (danhSachHoaDon.Count == 0)
                    {
                        Console.WriteLine("Danh sach hoa don rong. Khong co thong tin khach hang.");
                    }
                    else
                    {
                        CHoaDon khachHangMuaNhieuNhat = danhSachHoaDon[0];

                        foreach (var hoaDon in danhSachHoaDon)
                        {
                            if (hoaDon.SoLuong > khachHangMuaNhieuNhat.SoLuong)
                            {
                                khachHangMuaNhieuNhat = hoaDon;
                            }
                        }

                        Console.WriteLine("Thong tin khach hang mua nhieu nhat:");
                        khachHangMuaNhieuNhat.xuat();
                    }
                    break;
                case 4:
                    double tongchietkhau = 0;
                    foreach (var hoaDon in danhSachHoaDon)
                    {
                        if (hoaDon is CKHCongTy)
                        {
                            tongchietkhau += hoaDon.thanhTien() - hoaDon.SoLuong * hoaDon.GiaBan;
                        }
                    }
                    Console.WriteLine($"tổng sô tiền chiết khấu của công ty: {tongchietkhau}");
                    break;

                case 5:
                    danhSachHoaDon.Sort((a, b) =>
                    {
                        if (a.SoLuong < b.SoLuong)
                        {
                            return -1;
                        }
                        else if (a.SoLuong > b.SoLuong)
                        {
                            return 1;
                        }
                        else
                        {
                            if (a.thanhTien() < b.thanhTien())
                            {
                                return -1;
                            }
                            else if (a.thanhTien() > b.thanhTien())
                            {
                                return 1;
                            }
                            return 0;
                        }
                    });

                    Console.WriteLine("Danh sách hóa đơn sau khi sắp xếp:");
                    foreach (var hoaDon in danhSachHoaDon)
                    {
                        hoaDon.xuat();
                    }
                    break;


                case 6:
                    Console.WriteLine(" tìm mã hóa đơn theo yêu cầu:");
                    string maKhachHang = Console.ReadLine();
                    bool found = false;
                    foreach (var hoaDon in danhSachHoaDon)
                    {
                        if (hoaDon.MaKH == maKhachHang)
                        {
                            hoaDon.xuat();
                            found = true;
                        }
                    }
                    if (!found)
                    {
                        Console.WriteLine("Khách hàng lạ");
                    }
                    break;

                case 0:
                    Console.WriteLine("cảm ơn đã sử dụng chương trình");
                    return;

                default:
                    Console.WriteLine("lựa chọn không hợp lệ.");
                    break;
            }
        }
    }
}
