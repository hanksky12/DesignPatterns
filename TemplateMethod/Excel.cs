namespace TemplateMethod;

public class Excel:AbstractDataProcessing
{
    public override void Open()
    {
        Console.WriteLine("Read Excel");
    }

    public override Data Read()
    {
        return new Data("excel data", 10000);
    }

    public override void Save(Data data)
    {
        Console.WriteLine($"Save Excel {data.Number}");
    }
}