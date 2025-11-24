using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyekAkhir_UMI_FADILAH_NUR_AISYAH_X_PPLG_1
{
    internal class Program
    {
        // Fungsi buatan sendiri untuk menghitung rata-rata
        static double HitungRataRata(int[] nilai)
        {
            int total = 0;
            for (int i = 0; i < nilai.Length; i++)
            {
                total += nilai[i];
            }
            return (double)total / nilai.Length;
        }
        static void Main(string[] args)
        {

            Console.WriteLine("=== APLIKASI NILAI SISWA ===\n");

            Console.Write("Masukkan jumlah siswa: ");
            int jumlahSiswa = int.Parse(Console.ReadLine());

            // Array untuk menyimpan nama dan nilai siswa
            string[] namaSiswa = new string[jumlahSiswa];
            int[] nilaiSiswa = new int[jumlahSiswa];

            // Input data siswa
            for (int i = 0; i < jumlahSiswa; i++)
            {
                Console.Write($"\nMasukkan nama siswa ke-{i + 1}: ");
                namaSiswa[i] = Console.ReadLine();
                Console.Write($"Masukkan nilai {namaSiswa[i]}: ");
                nilaiSiswa[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\n=== HASIL NILAI SISWA ===");
            for (int i = 0; i < jumlahSiswa; i++)
            {
                string keterangan = nilaiSiswa[i] >= 75 ? "Lulus" : "Tidak Lulus";
                Console.WriteLine($"{i + 1}. {namaSiswa[i]} - Nilai: {nilaiSiswa[i]} - {keterangan}"); 
            }

            // Hitung rata-rata seluruh nilai siswa
            double rataRata = HitungRataRata(nilaiSiswa);
            Console.WriteLine($"\nRata-rata nilai seluruh siswa: {rataRata:F2}");
            
            // Percabangan hasil umum
            if (rataRata >= 75)
                Console.WriteLine("Secara keseluruhan, hasil belajar baik.");
            else
                Console.WriteLine("Secara keseluruhan, hasil belajar perlu ditingkatkan.");

            Console.WriteLine("nProgram selesai. Tekan enter untuk keluar.");
            Console.ReadLine();
        
        }
    }
}
