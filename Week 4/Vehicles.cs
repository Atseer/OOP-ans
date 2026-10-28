namespace Solution.Vehicles;

public class Kendaraaan
{
    protected string _merk;
    protected string _model;

    public string Merk
    {
        get {return _merk;}
        set {_merk = value;}
    }
    public string Model
    {
        get {return _model;}
        set{_model = value;}
    }
    public Kendaraaan(string merk, string model)
    {
        _merk = merk;
        _model = model;
    }
}
public class Mobil : Kendaraaan
{
    protected string _tipeBodi;
    
    public string TipeBodi{
        get {return _tipeBodi;}
        set {_tipeBodi = value;}
    }
    public Mobil(string merk, string model, string tipeBodi)
    : base (merk,model) 
    {
        _tipeBodi = tipeBodi;
    }
}
public class Motor : Kendaraaan
{
    protected string _tipeMesin;

    public string TipeMesin
    {
        get {return _tipeMesin ;}
        set {_tipeMesin = value;}
    }
    public Motor(string merk, string model, string tipeMesin)
    : base (merk, model)
    {
        _tipeMesin = tipeMesin;
    }
}