namespace  Solution.Registration;

public class Mahasiswa
{
    private static int _registrantCounter = 0;
    private int _nomorPendaftaran;
    private string _nama;

    public Mahasiswa(string nama)
    {
        _nama = nama;
        _registrantCounter++;
        _nomorPendaftaran = _registrantCounter;
    }

    public int GetNomorPendaftaran()
    {
        return _nomorPendaftaran;
    }
    public static int GetTotalRegistrant()
    {
        return _registrantCounter;
    }
    public static ResetRegistrantCounter()
    {
        _registrantCounter = 0;
    }
    
}