namespace Calculator.Classes;

    public static class ReportR
    {
        public static void ShowGratitude()
        {
            Console.WriteLine("\n<--Thank you for your attenton-->\n");
        } 
        public static void ReportProgress(string messages)
        {
            Console.WriteLine(messages);
        }
        public static void ReportResult(string result)
        {
            Console.WriteLine(result);
        }
    }