using System;
using ClassAndObject.Perpustakaan;
using ClassAndObject.Kendaraan;
using ClassAndObject.TokoLaptop;
using ClassAndObject.TokoSepeda;
using ClassAndObject.OperasiMatematika;
using System.Runtime.CompilerServices;
using System.Configuration.Assemblies;

namespace ClassAndObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Buku
            Buku buku1 = new Buku("Second Sister", "Chan Ho-Kei", "2020");
            buku1.TampilkanInfo();

            //Mobil 
            Mobil mobil1 = new Mobil("Daihatsu", "Sirion", "2023");
            mobil1.TampilkanSpesifikasi();

            //Laptop
            Laptop laptop1 = new Laptop("Lenovo", "AMD Ryzen 7","16", "512");
            laptop1.TampilkanSpesifikasi();

            //Sepeda
            Sepeda sepeda1 = new Sepeda("Polygon Lovina 20","Sepeda Kota","13.58");
            sepeda1.TampilkanInformasi();

            //Kalkulator 
            Kalkulator kalkulator1 = new Kalkulator();
            double resultPenjumlahan = kalkulator1.Tambah(1,2);
            double resultPengurangan = kalkulator1.Kurang(1,2);
            double resultPerkalian = kalkulator1.Kali(1,2);
            double resultPembagian = kalkulator1.Bagi(1,2);

            Console.WriteLine($"Hasil Tambah: {resultPenjumlahan}");
            Console.WriteLine($"Hasil Kurang: {resultPengurangan}");
            Console.WriteLine($"Hasil Kali: {resultPerkalian}");
            Console.WriteLine($"Hasil Bagi: {resultPembagian}");
        }
    }
}

