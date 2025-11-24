using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Tugas_praktik6_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] nama = new string[3];
            char[] jk = new char[3];
            string[] kelas = new string[3];

            for (int i = 0; i < 3; i++)
            {
                Console.Write($"Masukan nama siswa ke-{i + 1}: ");
                nama[i] = Console.ReadLine();

                Console.Write($"Masukan jenis kelamin (L/P):   ");
                jk[i] = Convert.ToChar(Console.ReadLine());

                Console.Write($"Masukan kelas: ");
                kelas[i] = Console.ReadLine();

                Console.WriteLine();

            }

            Console.WriteLine("=== Data Siswa ===");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Nama: {nama[i]} | JK: {jk[i]} | kelas: {kelas[i]}");
            }

            Console.ReadKey();
        }
    }
}
