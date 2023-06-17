namespace TemplateMethod;

public abstract class AbstractDataProcessing
{
    public void Run()
    {
        Open();
        Data data = Read();
        data = DataProcessing(data);
        Save(data);
    }

    public abstract void Open();
    public abstract Data Read();

    public Data DataProcessing(Data data)
    {
        Console.WriteLine($"Processing {data.Name} {data.Number}");
        data.Number -= 100;
        return data;
    }
    public abstract void Save(Data data);
}

