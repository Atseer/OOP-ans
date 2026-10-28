namespace Solution.SportsEquipment;

public class PeralatanOlahraga
{
    protected string _jenis;
    protected string _merek;

    public string Jenis
    {
        get {return _jenis;}
    }
    public string Merek
    {
        get {return _merek;}
    }
    public PeralatanOlahraga(string jenis, string merk)
    {
        _jenis = jenis;
        _merek = merek;
    }
    public void TampilkanInformasi()
    {
        Console.WriteLine($"Peralatan Olahraga Jenis: {Jenis}, Merek: {Merek}");
    }
}
public class Bola : PeralatanOlahraga
{
    protected string _jenisOlahraga;
    protected string _bahan;

    public string JenisOlaraga
    {
        get {return _jenisOlahraga;}
    }
    public string Bahan
    {
        get {return _bahan;}
    }
    public Bola(string jenis, string merek, string jenisOlahraga, string bahan)
    : base(jenis, merek)
    {
        _jenisOlahraga = jenisOlahraga;
        _bahan = bahan;
    }
    public void TampilkanSpesifikasi()
    {
        Console.WriteLine($"Jenis Olahraga: {JenisOlahraga}, Bahan: {Bahan}");
    }
}
public class BolaProfessional : Bola
{
    protected bool _standarInternasional;

    public bool StandarInterasional
    {
        get {return _standarInternasional;}
    }
    public BolaProfessional(string jenis, string merek, string jenisOlahraga, string bahan, bool standarInternasional)
    : base (jenis, merek, jenisOlahraga, bahan)
    {
        _standarInternasional = standarInternasional;
    }
    public void TampilkanStandar()
    {
        TampilkanSpesifikasi();
        string statusStandar = StandarInterasional ? "Ya" : "Tidak";
        Console.WriteLine($"Standar Internasional: {statusStandar}");
    }
} 
public class BolaLatihan : Bola
{
    protected int _harga;

    public int Harga
    {
        get {return _harga;}
    }
    public BolaLatihan(string jenis, string merk, string jenisOlahraga, string bahan, int harga)
    : base(jenis, merk, jenisOlahraga, bahan)
    {
        _harga = harga;
    }
}