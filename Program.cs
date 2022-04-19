using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResponsiPemrograman4272
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan = new Karyawan(21114272, "Fitria", 2000000);
            Karyawan karyawan2 = new Karyawan(21115964, "Amanda", 1500000);
           
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("No \tNIK \t   \t Nama\t    \t\t Gaji");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1    {0} \t   \t {1} \t    \t {2}      ", karyawan.nik, karyawan.nama, karyawan.gajiBulanan);
            Console.WriteLine("2    {0} \t   \t {1} \t    \t {2}      ", karyawan2.nik, karyawan2.nama, karyawan2.gajiBulanan);
            Console.WriteLine("--------------------------------------------------------");

            Console.WriteLine("\nAnda mendapatkan kenaikan gaji sebesar 10 %\n");

            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("No \tNIK \t   \t Nama\t    \t\t Gaji");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1    {0} \t   \t {1} \t    \t {2}      ", karyawan.nik, karyawan.nama, karyawan.naikGaji);
            Console.WriteLine("2    {0} \t   \t {1} \t    \t {2}      ", karyawan2.nik, karyawan2.nama, karyawan2.naikGaji);
            Console.WriteLine("--------------------------------------------------------");

            Console.ReadKey();
        }
    }
}
