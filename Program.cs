using System;
namespace SimpleCalculatorCS
{
    class CalculatorOperation
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selamat Datang Di Kalkulator Simple Perhitungan 2 Angka");
            Console.WriteLine("Pilih Operasi Perhitungan dengan Input Nomor Dibawah");
            Console.WriteLine("Ketik 1 > Penjumlahan");
            Console.WriteLine("Ketik 2 > Pengurangan");
            Console.WriteLine("Ketik 3 > Perkalian");
            Console.WriteLine("Ketik 4 > Pembagian");

            double Nomor = 0;
            
            bool InputAngka = true;
            while (InputAngka)
            {
                Console.WriteLine("Ketik Operasi Yang Diinginkan : ");
                Nomor = Convert.ToInt32(Console.ReadLine());

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
                    Console.WriteLine("Inputan SALAH, Masukkan Inputan Yang BENAR Angka 1-4 !!");
                    continue;
                }
            }

            Console.WriteLine("Masukkan Angka Pertama : ");
            double Angka1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Masukkan Angka Kedua : ");
            double Angka2 = Convert.ToDouble(Console.ReadLine());

            double Hasil = 0;
            switch (Nomor)
            {
                case 1:
                    {
                        Hasil = Penjumlahan(Angka1, Angka2);
                        break;
                    }
                case 2:
                    {
                        Hasil = Pengurangan(Angka1, Angka2);
                        break;
                    }
                case 3:
                    {
                        Hasil = Perkalian(Angka1, Angka2);
                        break;
                    }
                case 4:
                    {
                        Hasil = Pembagian(Angka1, Angka2);
                        break;
                    }
            }

            Console.WriteLine("Hasilnya Adalah : {0}", Hasil);
    
        }

        public static double Penjumlahan(double Angka1, double Angka2)
        {
            double Hasil = Angka1 + Angka2;
            return Hasil;
        }

        public static double Pengurangan(double Angka1, double Angka2)
        {
            double Hasil = Angka1 - Angka2;
            return Hasil;
        }

        public static double Perkalian(double Angka1, double Angka2)
        {
            double Hasil = Angka1 * Angka2;
            return Hasil;
        }

        public static double Pembagian(double Angka1, double Angka2)
        {
            double Hasil = Angka1 / Angka2;
            return Hasil;
        }
    }
}