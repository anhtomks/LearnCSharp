using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class CommonFunc
    {
        public void eixtProgram()
        {
            Console.WriteLine("\n\n***** Press any key to continue! ****");
            Console.ReadLine();
        }

        public string enterString(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }

        public int enterIntNumber(string mess) {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
        public double enterDoubleNumber(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
    }
    class Nguoi
    {
        public string Ten{get; set; }
        public int NamSinh { get; set; }
        public int Tuoi
        {
            get
            {
                return DateTime.Now.Year - NamSinh;
            }
        }
        public string GioiTinh { get; set; }
        public void Print(string ngheNghiep)
        {
            Console.WriteLine($"Ten cua {ngheNghiep} la {Ten}, tuoi {Tuoi}");
        }
        
        public int soNamConLai(string gioitinh, int tuoi)
        {
            if(gioitinh == "Nam")
            {
                return 65 - Tuoi;
            }
            return 60 - Tuoi;
        }
    }
    class NhanVien : Nguoi
    {
        public string ViTriCongTac { get; set; }
        public string TinhTrangHonNhan { get; set; }
        public void Print()
        {
            base.Print("Nhan Vien");
            Console.WriteLine($"Vi tri cong tac cua nhan vien {Ten} la: , tinh trang hon nhan la {TinhTrangHonNhan}");
        }
        public void Recall()
        {
            base.Print("Nhan Vien"); //Goi vao ham cua lop base
            this.Print(); // Goi vao ham cua lop Inheritance, o phien ban moi this ko con can thiet - co the bo di cung duoc
        }
    }
}
