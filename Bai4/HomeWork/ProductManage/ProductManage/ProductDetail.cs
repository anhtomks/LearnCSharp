using System;

namespace Product.Details
{
    /// <summary>
    /// Class ProductDetail ke thua class Product o Namespace Product.Simple
    /// </summary>
    class ProductDetail: Product.Simple.Product
    {
        public int SoLuongTonKho { get; set; }
        public int SoLuongCoTheBan { get; set; }
        public double DonGia { get; set; }
        public string DonViTinh { get; set; }
        public void Print()
        {
            base.Print();
            Console.WriteLine($"\n\nSo luong ton kho: {SoLuongTonKho}, so luong co the ban: {SoLuongCoTheBan}, moi san pham co gia la: {DonGia.ToString("N2")} vnd/{DonViTinh}");
            Console.WriteLine($"\n\n======================== End Thong Tin San Pham ========================\n\n");
        }
    }
}
