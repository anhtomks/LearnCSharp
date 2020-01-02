using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Nguoi hh = new Nguoi();
            /*
                        double dayLon = hh.nhapSo("Nhap vao day lon cua hinh thang: ");
                        double dayNho = hh.nhapSo("Nhap vao day nho cua hinh thang: ");
                        double chieuCao = hh.nhapSo("Nhap vao chieu cao cua hinh thang: ");
                        Console.WriteLine($"Dien tich hinh thang co day lon {dayLon}, day nho {dayNho} va chieu cao {chieuCao} la: {hh.dienTichHinhThang(dayLon, dayNho, chieuCao)}");*/
            //Console.WriteLine($"Dien tich hinh thang co day lon {hh.dayLon}, day nho {hh.dayNho} va chieu cao {hh.chieuCao} la: {hh.dienTichHinhThang(hh.dayLon, hh.dayNho, hh.chieuCao)}");

            NhanVien nv = new NhanVien();
            nv.Ten = nv.nhapChuoi("Nhap vao ten cua ban: ");
            nv.NamSinh = nv.nhapSo("Nhap vao nam sinh cua ban: ");
            nv.QueQuan = nv.nhapChuoi("Nhap vao quen quan cua ban : ");
            nv.GioiTinh = nv.nhapChuoi("Nhap vao gioi tinh cua ban (Nam) - (Nu): ");

            if(nv.tinhTuoiNghiHuu(nv.GioiTinh, nv.Tuoi) == true)
            {
                Console.WriteLine($"*** {nv.Ten}, que quan {nv.QueQuan} da du tuoi nghi huu ***");
            }
            else{
                Console.WriteLine($"*** {nv.Ten}, que quan {nv.QueQuan} chua du tuoi nghi huu ***");
            }
            
            Console.ReadLine();
        }
    }
    class Nguoi
    {
        public string name;
        int bk;
        public double dayLon;
        public double dayNho;
        public double chieuCao;
        public Nguoi()
        {
            dayLon = 4;
            dayNho = 5;
            chieuCao = 6;

        }

        public double nhapSo(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToDouble(Console.ReadLine());
        }
        public double dienTichHinhThang(double a, double b, double c)
        {
            return (a + b) * c / 2;
        }
    }
    public class NhanVien
    {
        public string Ten { get; set; }
        public int NamSinh { get; set; }
        public int Tuoi{ 
            get{ return DateTime.Now.Year - NamSinh; } 
        }
        public string QueQuan { get; set; }
        public string GioiTinh{ get; set; }

        public string nhapChuoi(string mess)
        {
            Console.WriteLine(mess);
            return Console.ReadLine();
        }
        public int nhapSo(string mess)
        {
            Console.WriteLine(mess);
            return Convert.ToInt32(Console.ReadLine());
        }
        public bool tinhTuoiNghiHuu (string gt, int tuoi)
        {
            if ((gt == "Nam" && tuoi >= 65) || (gt == "Nu" && tuoi >= 60))
            {
                return true;
            }
            else
                return false;
        }

    }
}
