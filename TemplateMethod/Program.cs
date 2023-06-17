using TemplateMethod;
static void Main()
{
    Excel excel = new Excel();
    excel.Run();
    Csv csv = new Csv();
    csv.Run();
}
Main();