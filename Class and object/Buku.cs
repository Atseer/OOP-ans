namespace ClassAndObject.Perpustakaan;

public class Buku //Class
{
    //property
    public string Judul {get ; set;}
    public string Penulis {get; set;}
    public int TahunTerbit {get; set;}

    //constructor
    public Buku(string judul, string penulis, int tahunTerbit)
    {
        Judul = judul;
        Penulis = penulis;
        TahunTerbit = tahunTerbit;
    }

    public void TampilkanInfo() //method public
    {
        Console.WriteLine($"Judul: {Judul}, Penulis: {Penulis}, Tahun Terbit: {TahunTerbit}");
    }

}



