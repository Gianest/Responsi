using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Responsi Pemrograman";
            Karyawan kar = new Karyawan("4324", "Paijo", 3000000);
            Karyawan kar2 = new Karyawan("3256", "Budi", -1000);

            Hasil(kar, kar2);

            
            Console.WriteLine("Asyiiiiikkkk Kenaikan Gaji 10%");
            Console.WriteLine();

            var result = (0.10 * kar.GajiBulanan) + kar.GajiBulanan;
            var result2 = (0.10 * kar2.GajiBulanan) + kar2.GajiBulanan;
            kar.GajiBulanan = Convert.ToInt32(result);
            kar2.GajiBulanan = Convert.ToInt32(result2);

            Hasil(kar, kar2);

            Console.ReadKey();
        }

        static void Hasil(Karyawan karyawan, Karyawan karyawan2)
        {
            Console.WriteLine("No. \tNik/Nama\t Gaji Bulanan");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("1. " + "\t{0} {1} \t {2}", karyawan.Nik, karyawan.Nama, karyawan.GajiBulanan);
            Console.WriteLine("2. " + "\t{0} {1} \t {2}", karyawan2.Nik, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.WriteLine();
        }
    }
}
