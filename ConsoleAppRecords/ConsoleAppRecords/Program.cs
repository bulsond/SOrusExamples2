using ConsoleAppRecords.Services;

namespace ConsoleAppRecords
{
    class Program
    {
        static void Main(string[] args)
        {
            var ui = new UiService(new RecordsService());

            while (ui.PrintMenu())
            {
                ui.Execute();
            }
        }
    }
}
