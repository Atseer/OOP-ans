namespace Solution.ElectronicDevices;

public class PerangkatElektronik
{
    protected string _brand;
    protected string _model;

    public string Brand
    {
        get {return _brand;} 
    }
    public string Model
    {
        get {return _model;} 
    }
    public PerangkatElektronik(string brand, string model)
    {
        _brand = brand;
        _model = model;
    }
    public void TampilkanIdentitas()
    {
        Console.WriteLine($"Perangkat Brand: {Brand}, Model: {Model}");
    }
}
public class Smartphone : PerangkatElektronik
{
    protected string _sistemOperasi;
    protected string _fiturDasar;

    public string SistemOperasi
    {
        get {return _sistemOperasi;}
    }
    public string FiturDasar
    {
        get {return _fiturDasar;}
    }
    public Smartphone(string brand, string model, string sistemOperasi, string fiturDasar)
    : base(brand, model)
    {
        _sistemOperasi = sistemOperasi;
        _fiturDasar = fiturDasar;
    }
    public void TampilkanFiturDasar()
    {
        Console.WriteLine($"Fitur Dasar: {FiturDasar}");
    }
}
public class FlagshipPhone : Smartphone
{
    protected string _fiturPremium;

    public string FiturPremium
    {
        get {return _fiturPremium;} 
    }
    public FlagshipPhone(string brand, string model, string sistemOperasi, string fiturDasar, string fiturPremium)
    : base (brand,model,sistemOperasi,fiturDasar)
    {
        _fiturPremium = fiturPremium;
    }
    public void TampilkanFiturPremium()
    {
        TampilkanFiturDasar();
        Console.WriteLine($"Fitur Premium: {FiturPremium}");
    }
}
public class BudgetPhone : Smartphone
{
    protected int _harga;

    public int Harga
    {
        get {return _harga;} 
    }
    public BudgetPhone(string brand, string model, string sistemOperasi, string fiturDasar, int harga)
    : base (brand, model, sistemOperasi, fiturDasar)
    {
        _harga = harga;
    }
}