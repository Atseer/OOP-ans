namespace Solution.Computers;

public class Memory
{
    private int _capacity;
    private string _memoryType;

    public int Capacity
    {
        get {return _capacity;}
        set {_capacity = value;}
    }
    public string MemoryType
    {
        get {return _memoryType;}
        set {_memoryType = value;}
    }
    public Memory(int capacity, string memoryType)
    {
        _capacity = capacity;
        _memoryType = memoryType;
    }

}