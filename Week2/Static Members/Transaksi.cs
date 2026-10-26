namespace Solution.Transaction

public class Transaksi
{
    private static int _counter = 0;
    private int _transaksiID;

    private int _jumlah;

    public Transaksi(int jumlah)
    {
        _jumlah = jumlah;
        _counter++;
        _transaksiID = _counter;

    }
    public int GetTransaksiID()
    {
        return _transaksiID;
    }

    public static int GetTotalTransaksiID()
    {
        return _counter;
    }

    public static ResetCounter()
    {
        _counter = 0;
    }
}