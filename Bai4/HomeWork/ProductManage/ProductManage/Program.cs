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
    /// <summary>
    /// Cac ham thuong dung trong chuong trinh
    /// </summary>
    class Common
    {
        /// <summary>
        /// Ham nhap vao mot so nguyen
        /// </summary>
        /// <param name="mess">Doan text truyen vao </param>
        /// <returns></returns>
        public int enterIntNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
        /// <summary>
        /// Ham nhap vao mot so thuc
        /// </summary>
        /// <param name="mess">Doan text truyen vao ham</param>
        /// <returns></returns>
        public double enterDoubleNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
        /// <summary>
        /// Ham nhap vao mot doan text
        /// </summary>
        /// <param name="mess">Doan text truyen vao</param>
        /// <returns></returns>
        public string enterString(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
        /// <summary>
        /// Ham thoat ung dung Console
        /// </summary>
        public void exitCosole()
        {
            Console.WriteLine("\n\n**** Press any key to exit! ****");
            Console.ReadKey();
        }
        /// <summary>
        /// Ham nhap vao mot so nguyen trong mot khoang nao do
        /// </summary>
        /// <param name="mess">Tham so truyen vao</param>
        /// <param name="from">Gia tri nho nhat co the nhap</param>
        /// <param name="to">Gia tri lon nhat co the nhap</param>
        /// <returns></returns>
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
