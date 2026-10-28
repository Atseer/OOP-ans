using System.Reflection;

namespace Solution.Computers;
public class Computer
{
    private Processor _processor;
    private Memory _memory;

    public Computer(Processor processor, Memory memory)
    {
        _processor = processor;
        _memory = memory;
    }
    public Processor Processor
    {
        get {return _processor;}
        set {_processor = value;}
    }
    public Memory Memory
    {
        get {return _memory;}
        set {_memory = value;}
    }
    public void GetInfo()
    {
        Console.WriteLine($"Processor Brand: [{_processor.Brand}], Kecepatan: [{_processor.Speed}] GHz, Memory Kapasitas: [{_memory.Capacity}] GB, Tipe: [{_memory.MemoryType}]");
    }

}