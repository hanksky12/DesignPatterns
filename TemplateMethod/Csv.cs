namespace TemplateMethod;

public class Csv:AbstractDataProcessing
{
    public override void Open()
    {
        Console.WriteLine("Read Csv");
    }

    public override Data Read()
    {
        return new Data("csv data", 80000);
    }

    public override void Save(Data data)
    {
        Console.WriteLine($"Save Csv {data.Number}");
    }
}