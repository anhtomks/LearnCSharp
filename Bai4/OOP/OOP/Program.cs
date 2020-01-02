using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            CommonFunc cm = new CommonFunc();
            //NhanVien nv = new NhanVien();
            HinhVuong hv = new HinhVuong();
            HinhChuNhat hcn = new HinhChuNhat();
            HinhTron ht = new HinhTron();
            hv.chieuDai = cm.enterDoubleNumber("Nhap vao canh cua hinh vuong");
            Console.WriteLine($"Hinh vuong co canh {hv.chieuDai} co chu vi la {hv.chuVi()}, va dien tich la {hv.dienTich()}");
            hcn.chieuDai = cm.enterDoubleNumber("Nhap vao chieu dai cua hinh chu nhat");
            hcn.chieuRong = cm.enterDoubleNumber("Nhap vao chieu rong cua hinh chu nhat");
            Console.WriteLine($"Hinh chu nhat co chieu dai {hcn.chieuDai} va chieu rong {hcn.chieuRong} co chu vi la: {hcn.chuVi()}, va dien tich la {hcn.dienTich()}");
            ht.banKinh = cm.enterDoubleNumber($"Nhap vao ban kinh cua hinh tron");
            Console.WriteLine($"Hinh tron co ban kinh {ht.banKinh} co chu vi la: {ht.chuVi()}, va dien tich la : {ht.dienTich()}");
            
            cm.eixtProgram();
        }
    }

}
