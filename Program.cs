using System;
using Calculator.Classes;

namespace Calculator
{
    public class Program
    {
        static void Main()
        {
            var calculator = new CalculatR();
            
            string yesOrNo = "";
            do
            {
                calculator.Calculate();
                ReportR.ShowGratitude();
                
                Console.WriteLine("Do you want to continue : [y/n]");
                yesOrNo = Console.ReadLine()!;
            } while (yesOrNo == "y");

            ReportR.ShowGratitude();
            calculator.ShowMultiplicationTable();
        }
    }
}