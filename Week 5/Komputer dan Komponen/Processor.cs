namespace Solution.Computers;

public class Processor
{
    private string _brand;
    private double _speed;

    public string Brand
    {
        get {return _brand;}
        set {_brand = value;}
    }
    public double Speed
    {
        get {return _speed;}
        set {_speed = value;}
    }
}