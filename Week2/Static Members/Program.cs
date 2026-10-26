using System;
using Solution.Transaction;
using Solution.Registration;
using Solution.StockManager; 

namespace Solution
{
    internal class Program{
        static void Main(string [] Args)
        {
            //Transaksi
            Transaksi transaksi1 = new Transaksi(500000);
            Transaksi transaksi2 = new transaksi(120000);
            Transaksi transaksi3 = new transaksi(200000);

            Console.WriteLine($"ID Transaksi 1 : {transaksi1.GetTransaksiID()}");
            Console.WriteLine($"ID Transaksi 2 : {transaksi2.GetTransaksiID()}");
            Console.WriteLine($"ID Transaksi 3 : {transaksi3.GetTransaksiID()}");
            Console.WriteLine($"Total Transaksi Adalah: {Transaksi.GetTotalTransaksiID()}");
            
            //Pendaftaran Mhs
            Mahasiswa mahasiswa1 = new Mahasiswa("Anna");
            Mahasiswa mahasiswa2 = new Mahasiswa("Ben");
            Mahasiswa mahasiswa3 = new Mahasiswa("Clarence");

            Console.WriteLine($"Nomor Pendaftaran 1:{mahasiswa1.GetNomorPendaftaran()}");
            Console.WriteLine($"Nomor Pendaftaran 2:{mahasiswa2.GetNomorPendaftaran()}");
            Console.WriteLine($"Nomor Pendaftaran 3:{mahasiswa3.GetNomorPendaftaran()}");
            Console.WriteLine($"Total Mahasiswa adalah: {Mahasiswa.GetTotalRegistrant()}");
            
            
            //Stock Manager 

            Barang barang1 = new Barang(50);
            Console.WriteLine($"Stock awal: {Barang.TotalStock}"); //Stock awal

            int jumlahTerjual = 20; 
            Barang.JualBarang(jumlahTerjual);
            Console.WriteLine($"Menjual {jumlahTerjual} unit."); // Unit yg terjual
            
            Barang.TampilkanStock(); //Tampilkan Stock

            int jumlahRestock = 30; //Restock
            Barang.Restock(jumlahRestock);
            Console.WriteLine($"Restock {jumlahRestock} unit");

            Barang.TampilkanStock(); //Tampilkan stock lagi (2)

            int barangTerjual = 70;
            Console.WriteLine($"Percobaan menjual {barangTerjual} unit: ");
            Barang.JualBarang(barangTerjual);

            Barang.TampilkanStock(); //Tampilkan Stock lagi (3)

            
            /*
            Stok awal: 50
            Menjual 20 unit.
            Stok saat ini: 30
            Restok 30 unit.
            Stok saat ini: 60
            Percobaan menjual 70 unit: Gagal, stok tidak mencukupi.
            Stok saat ini: 60
            */
        }
    }

}
