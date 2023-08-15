using System;
using Calculator.Classes;

namespace Calculator
{
    public class Program
    {
        static void Main()
        {
            var calculator = new CalculatR();

            string yesOrno = "";
            do
            {
                calculator.Calculate();
                ReportR.ShowGratitude();
                
                Console.WriteLine("Do you want to continue : [y/n]");
                yesOrno = Console.ReadLine()!;
            } while (yesOrno == "y");

            ReportR.ShowGratitude();
            calculator.ShowMultiplicationTable();
        }
    }
}