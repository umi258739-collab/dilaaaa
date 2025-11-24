using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fungsi_hitung_luas_
{
    internal class Program
    {
        static double HitungLuas(double panjang, double lebar)
        {
            double luas = panjang * lebar;
            return luas;
        }
        static void Main(string[] args)
        {
            Console.Write("Masukkan Panjang");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Masukkan Lebar");
            double l = Convert.ToDouble(Console.ReadLine());

            double luas = HitungLuas(p, l);
            Console.WriteLine("Luas Persegi Panjang: " + luas);
        }
    }
}
