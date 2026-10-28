using System;
using System.Runtime.CompilerServices;
using Solution.Books;
using Solution.ElectronicDevices;
using Solution.SportsEquipment;
using Solution.Vehicles;

namespace Solution;

internal class Program
{
    static void Main(string[] args)
    {
        //Book
        BukuFiksi bukuFiksi = new BukuFiksi("Harry Potter","JK. Rowling","Fantasi");
        BukuPelajaran bukuPelajaran = new BukuPelajaran("Kalkulus","Purcell","Matematika");
        Console.WriteLine($"Judul: {bukuFiksi.Judul}, Pengarang: {bukuFiksi.Pengarang}, Genre: {bukuFiksi.Genre}"); 
        Console.WriteLine($"Judul: {bukuPelajaran.Judul}, Pengarang: {bukuPelajaran.Pengarang}, Genre: {bukuPelajaran.Subjek}");   
    
        //Vehicles
        Mobil mobil1 = new Mobil("Toyota","Camry","Sedan");
        Motor motor1 = new Motor("Yamaha", "RX-king", "2 stroke");

        Console.WriteLine($"Merk: {mobil1.Merk}, Model: {mobil1.Model}, Tipe Bodi: {mobil1.TipeBodi}");
        Console.WriteLine($"Merk: {motor1.Merk}, Model: {motor1.Model}, Tipe Mesin: {motor1.TipeMesin}");
    
        //Electronic Devices
        FlagshipPhone hp1 = new FlagshipPhone("Samsung", "S26","Android","LCD, RAM","Camera Telephoto");
        BudgetPhone hp2 = new BudgetPhone("Xiaomi", "Redmi 14C", "LCD", "2000000");
        
        hp1.TampilkanIdentitas();
        Console.WriteLine($"Sistem Operasi: {hp1.SistemOperasi}");
        hp1.TampilkanFiturPremium();

        hp2.TampilkanIdentitas();
        Console.WriteLine($"Sistem Operasi: {hp2.SistemOperasi}");
        hp2.TampilkanFiturDasar();
        Console.WriteLine($"Harga: {hp2.Harga}");

        //Sports Epquipment
        BolaProfesional bola1 = new BolaProfesional("Bola","Adidas","Sepakbola", "Kulit sintetiis", true);
        BolaLatihan bola2 = new BolaLatihan("Bola","Mikasa","Voli","Karet",150000);
        
        bola1.TampilkanInformasi();
        bola1.TampilkanStandar();

        bola2.TampilkanInformasi();
        bola2.TampilkanSpesifikasi();
        Console.WriteLine($"Harga: {bola2.Harga}");
    }
}