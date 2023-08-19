using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Calculator.Classes;

namespace Calculator
{
    public class Program
    {
         static void Main()
         {
             IReportingContract reportR = new ReportR();
            string yesOrno = "";
            do
            {
                ValueManipulatR.ShowMenu();
            int choiceOfOption = ReportR.choseedNumberConverted();
            switch (choiceOfOption)
            {
                case 1 :
                    decimal firstNumber = ValueManipulatR.GetUserValueByMessage("Welcome to  Calculator Application,\nEnter first number: ");
                    string option=ValueManipulatR.GetInputByMessageToAction("Choose operation that you need [+ , - , * , / , % , percent]: ");
                    if (option == "percent")
                    {
                        decimal secondNumber = ValueManipulatR.GetUserValueByMessage("\nPlease enter the Percent: ");
                        var calculator = new AdvancedCalculator(firstNumber,option,secondNumber);
                        break;
                    }
                    else
                    {
                        decimal secondNumber = ValueManipulatR.GetUserValueByMessage("\nSecond number: ");
                        var calculatR = new CalculatR(firstNumber, option, secondNumber);
                        break;
                    }
                
                case 2 :
                    MultiplicationTableR.ShowMultiplicationTable();
                    reportR.ShowGratitude();
                    break;
                
                case 3 :
                    ReportR.Exit();
                    break;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Do you want to continue : [y/n]");
                yesOrno = Console.ReadLine()!;
            Console.ResetColor();
            } while (yesOrno == "y");
        }
    }
}