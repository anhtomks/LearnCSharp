using System;
using Product.Details;

namespace ProductManage
{
    /// <summary>
    /// Main class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Common cm = new Common();
            ProductDetail productDetail = new ProductDetail();
            productDetail.TenSanPham = cm.enterString("Nhap vao ten cua san pham: ");
            productDetail.NgaySanXuat = cm.enterNumberInRange("Nhap vao ngay san xuat (1 - 30): ", 1, 30);
            productDetail.ThangSanXuat = cm.enterNumberInRange("Nhap vao thang san xuat(1 - 12): ", 1, 12);
            productDetail.NamSanXuat = cm.enterNumberInRange("Nhap vao nam san xuat(1001 - 9999): ", 1001, 9999);
            productDetail.HanSuDung = cm.enterNumberInRange("Nhap vao han su dung (tinh theo thang): ", 0, 1000);
            productDetail.SoLuongCoTheBan = cm.enterIntNumber("Nhap vao so luong san pham co the ban");
            productDetail.SoLuongTonKho = cm.enterIntNumber("Nhap vao so luong san pham ton kho");
            productDetail.DonGia = cm.enterDoubleNumber("Nhap vao gia cua san pham");
            productDetail.DonViTinh = cm.enterString("Nhap vao don vi tinh cua san pham (cai, chiec, ....)");
            productDetail.Print();

            cm.exitCosole();
        }
    }
    class Common
    {
        public int enterIntNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
        public double enterDoubleNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
        public string enterString(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
        public void exitCosole()
        {
            Console.WriteLine("\n\n**** Press any key to exit! ****");
            Console.ReadKey();
        }
        public int enterNumberInRange(string mess, int from, int to)
        {
            int n;
            do
            {
                Console.WriteLine(mess);
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < from || n > to);
            return n;
        }
    }
}
