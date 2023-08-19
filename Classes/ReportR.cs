namespace Calculator.Classes;

    internal class ReportR : IReportingContract
    {
        public void ShowGratitude()
        {
            Console.WriteLine("Thank you for using my application");

        }
        public void ReportProgress(string messages)
        {
            throw new NotImplementedException();
        }
        public void ReportResult(string result)
        {
            throw new NotImplementedException();
        }
        public static int choseedNumberConverted()
        {
            int firstOption=0;
            return firstOption = int.Parse(Console.ReadLine());
        }
        public static void Exit()
        {
            Console.WriteLine("Thanks for using my application");
        }
    }