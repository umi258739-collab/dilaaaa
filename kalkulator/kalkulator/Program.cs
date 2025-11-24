using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    internal class Program
    {
        // Method Main adalah titik awal eksekusi program
        static void Main(string[] args)
        {
            string hitungLagi; // Variabel untuk menyimpan pilihan pengguna (y/n)

            // Perulangan do-while akan menjalankan blok kode setidaknya satu kali
            // dan akan terus berjalan selama kondisi while terpenuhi.
            do
            {
                Console.Clear(); // Membersihkan layar konsol untuk setiap perhitungan baru
                Console.WriteLine("--- KALKULATOR SEDERHANA ---");

                // Memanggil fungsi untuk menampilkan menu 
                TampilkanMenu();

                Console.Write("Masukkan Pilihan operasi (1-4): ");
                string pilihan = Console.ReadLine();

                // variabel untuk menampung angka dan hasil
                double angka1, angka2, hasil = 0;

                // Memanggil fungsi untuk mendapatkan input angka dari user
                // dan memastikan input adalah angka yang valid 
                if (AmbilInputAngka(out angka1, out angka2))
                {
                    // struktur pilihan switch-case untuk menentukan operasi
                    switch (pilihan)
                    {
                        case "1": // Penjumlahan
                            hasil = Tambah(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} + {angka2} = {hasil}");
                            break;
                        case "2": // Pengurangan
                            hasil = Kurang(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} - {angka2} = {hasil}");
                            break;
                        case "3": // Perkalian
                            hasil = Kali(angka1, angka2);
                            Console.WriteLine($"\nHasil: {angka1} * {angka2} = {hasil}");
                            break;
                        case "4": // Pembagian
                            if (angka2 != 0)
                            {
                                hasil = (angka1)/ (angka2);
                                Console.WriteLine($"\nHasil: {angka1} / {angka2} = {hasil}");
                            }
                            else
                            {
                                Console.WriteLine("\nError: Pembagian dengan nol tidak diperbolehkan.");
                            }
                            break;
                        default: // Jika pilihan tidak ada di case 1-4
                            Console.WriteLine("\nPilihan yang anda masukan tidak valid.");
                            break;
                    }
                }
                // Menanyakan kepada pengguna apakah ingin melakukan perhitungan lagi
                Console.Write("\nApakah Anda ingin menghitung kembali? (y/n): ");
                hitungLagi = Console.ReadLine();
                // .ToLower() membuat input menjadi huruf kecil, sehingga 'Y' dan 'y' dianggap sama

            } while (hitungLagi.ToLower() == "y");

            // Pesan penutup jika pengguna memilih keluar
            Console.WriteLine("\nTerima kasih telah menggunakan kalkulator sederhana ini." +
                              "Tekan tombol apa saja untuk keluar.");
            Console.ReadKey();
        }

        // --- FUNGSI-FUNGSI BANTUAN ---

        // Fungsi untuk menampilkan menu pilihan 

        static void TampilkanMenu()
        {
            Console.WriteLine("Pilih Operasi:");
            Console.WriteLine("1. Penjumlahan (+)");
            Console.WriteLine("2. Pengurangan (-)");
            Console.WriteLine("3. Perkalian (*)");
            Console.WriteLine("4. Pembagian (/)");
        }

        // Fungsi untuk mengambil input angka dari pengguna
        // Menggunakan 'out' karena fungsi ini mengambilkan lebih dari satu nilai

        static bool AmbilInputAngka(out double angka1, out double angka2)
        {
            Console.Write("Masukkan angka pertama: ");
            // double.TryParse akan mencoba mengkonversi input string ke double
            // Jika berhasil, return true dan nilainya disimpan di variabel 'angka1'
            // Jika gagal, return false
            if (!double.TryParse(Console.ReadLine(), out angka1))
            {
                Console.WriteLine("Input untuk angka pertama tidak valid.");
                angka2 = 0; // Beri nilai default agar tidak error
                return false;
            }

            Console.Write("Masukkan angka kedua: ");
            if (!double.TryParse(Console.ReadLine(), out angka2))
            {
                Console.WriteLine("Input untuk angka kedua tidak valid.");
                return false;
            }
            return true; // Jika kedua input valid
        }

        // Fungsi untuk operasi penjumlahan
        static double Tambah(double a, double b)
        {
            return a + b;
        }

        // Fungsi untuk operasi pengurangan
        static double Kurang(double a, double b)
        {
            return a - b;
        }

        // Fungsi untuk operasi perkalian
        static double Kali(double a, double b)
        {
            return a * b;
        }
    }
}

