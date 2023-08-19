namespace Calculator.Classes;

public class AdvancedReportR : IReportingContract
{
    public  void ShowGratitude()
    {
        Console.WriteLine("Thank you for using my application");
    } 
    public  void ReportProgress(string messages)
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine(messages);
        Console.ResetColor();
    }
    public void ReportResult(string result)
    {
        Console.WriteLine(result);
    }
}