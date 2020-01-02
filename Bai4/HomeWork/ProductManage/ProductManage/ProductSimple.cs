using System;
using System.Collections.Generic;
using System.Text;

namespace Product.Simple
{
    /// <summary>
    /// Class products
    /// ID: ID cua product
    /// 
    /// </summary>
    public class Product
    {
        private const int startFrom = 0;
        public int id = 0;
        public string TenSanPham { get; set; }
        public int NgaySanXuat { get; set; }
        public int ThangSanXuat { get; set; }
        public int NamSanXuat { get; set; }
        /// <summary>
        /// Han su dung cua san pham, tinh theo thang
        /// </summary>
        public int HanSuDung { get; set; }
        /// <summary>
        /// Ngay san xuat cua san pham, dua tren du lieu nguoi dung nhap vao
        /// </summary>
        public DateTime NgaySx
        {
            get
            {
                return new DateTime(NamSanXuat, ThangSanXuat, NgaySanXuat);
            }
        }
        /// <summary>
        /// Ngay het han cua san pham
        /// </summary>
        public DateTime NgayHetHan
        {
            get
            {
                return NgaySx.AddMonths(HanSuDung);
            }
        }
        /// <summary>
        /// Constructor
        /// </summary>
        public Product ()
        {
            id++;
        }
        /// <summary>
        /// Ham in thong tin cua san pham
        /// </summary>
        public void Print()
        {
            IFormatProvider viVn = null;
            Console.WriteLine("\n\n======================== Thong tin san pham ========================\n\n");
            Console.WriteLine($"{id}. San pham {TenSanPham} duoc san xuat vao ngay {NgaySx.ToString("D", viVn)}, san pham se het han vao ngay {NgayHetHan.ToString("D", viVn)}");
        }
        /// <summary>
        /// Ham tinh han su dung cua san pham
        /// </summary>
        /// <param name="end">Ngay Het Han cua san pham</param>
        /// <returns>
        ///    value < 0 => Chua het han
        ///    value > 0 => Da Het Han
        ///    value = 0 => Het Han Hom Nay
        /// </returns>
        public int checkDueDate(DateTime end)
        {
            return DateTime.Compare(DateTime.Now, end);
        }
    }
}
