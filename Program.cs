using System;
namespace SimpleCalculatorCS
{
    class CalculatorOperation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang Di Kalkulator Simple Perhitungan");
            Console.WriteLine("Pilih Operasi Perhitungan dengan Input Nomor Dibawah");
            Console.WriteLine("Ketik 1 > Penjumlahan");
            Console.WriteLine("Ketik 2 > Pengurangan");
            Console.WriteLine("Ketik 3 > Perkalian");
            Console.WriteLine("Ketik 4 > Pembagian");

            Console.WriteLine("Ketik Operasi Yang Diinginkan : ");
            int Nomor = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ketik Operasi Yang Diinginkan : ");
            bool InputAngka = true;
            while (InputAngka)
            {
                if (Nomor == 1)
                {
                    Console.WriteLine("Operasi > Penjumlahan");
                    break;
                }
                else if (Nomor == 2)
                {
                    Console.WriteLine("Operasi > Pengurangan");
                    break;
                }
                else if (Nomor == 3)
                {
                    Console.WriteLine("Operasi > Perkalian");
                    break;
                }
                else if (Nomor == 4)
                {
                    Console.WriteLine("Operasi > Pembagian");
                    break;
                }
                else
                {
                    Console.WriteLine("Inputan SALAH, Masukkan Inputan Yang BENAR!!");
                    continue;
                }
            }

            Console.WriteLine("Masukkan Angka Pertama : ");
            int Angka1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Angka Kedua : ");
            int Angka2 = Convert.ToInt32(Console.ReadLine());

            int hasil = 0;
            switch (Nomor)
            {
                case 1:
                {
                    break;
                }
                case 2:
                {
                    break;
                }
                case 3:
                {
                    break;
                }
                case 4:
                {
                    break;
                }
                default:
                {
                    break;
                }
            }

            Console.WriteLine("");
        }
    }
}