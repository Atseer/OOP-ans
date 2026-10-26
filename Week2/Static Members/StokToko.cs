namespace Solution.StockManager;

public class Barang
{
    public static int TotalStock; //menghitung total stok

    public Barang(int jumlahBarang) //jumlah barang yg masuk ke toko
    {
        TotalStock += jumlahBarang;
    }

    public static void JualBarang(int jumlahTerjual)
    {
        if(jumlahTerjual > TotalStock)
        {
            Console.WriteLine("Gagal, stock Tidak mencukupi");
        }
        else
        {
          TotalStock -= jumlahTerjual;  
        }
    }

    public static void Restok(int jumlahBarang)
    {
        TotalStock += jumlahBarang; 
    }

    public static void ResetStock()
    {
        TotalStock = 0;
    } 

    public static void TampilkanStock()
    {
        Console.WriteLine($"Stok saat ini:{TotalStock}");
    }
}