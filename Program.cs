using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Calculator.Classes;

internal abstract class Program
{
    public static void Main(string[] args)
    {
        string yesOraNo = "";
        do
        {
            IValueManipulator valueManipulator = new ValueManipulatR();
            IReportingContract reportR = new ReportR();
            IMultiplicationTableR multiplicationTable = new MultiplicationTableR();
            valueManipulator.ShowMenu();
                
            int choiceOfOption = ReportR.choseedNumberConverted();
            switch (choiceOfOption)
            {
                case 1 :
                    decimal firstNumber = valueManipulator.GetUserValueByMessage("Welcome to  Calculator Application,\nEnter first number: ");
                    string option=valueManipulator.GetInputByMessageToAction("Choose operation that you need [+ , - , * , / , % , percent]: ");
                    if (option == "percent")
                    {
                        decimal secondNumber = valueManipulator.GetUserValueByMessage("\nPlease enter the Percent: ");
                        var calculator = new AdvancedCalculator(firstNumber,option,secondNumber);
                        break;
                    }
                    else
                    {
                        decimal secondNumber = valueManipulator.GetUserValueByMessage("\nSecond number: ");
                        new CalculatR(firstNumber, option, secondNumber);
                        break;
                    }
                
                case 2 :
                    multiplicationTable.ShowMultiplicationTable();
                    reportR.ShowGratitude();
                    break;
                
                case 3 :
                    ReportR.Exit();
                    break;
            }
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Do you want to continue : [y/n]");
            yesOraNo = Console.ReadLine()!;
            Console.ResetColor();
        } while (yesOraNo == "y");
    }
}