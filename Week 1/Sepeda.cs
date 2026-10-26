namespace ClassAndObject.TokoSepeda;

public class Sepeda
{
    //properti dan get setter
    public string Merk {get; set;}
    public string Tipe {get; set;}
    public double Berat {get; set}

    public Sepeda(string merk, string tipe, double berat) //konstruktor
    {
        Merk = merk;
        Tipe = tipe;
        Berat = berat;
    }
    public void TampikanInformasi() //method 
    {
        Console.WriteLine($"Merek: {Merk}, Tipe: {Tipe}, Berat: {Berat} kg");
    }
}