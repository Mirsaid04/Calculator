namespace Calculator
{
    class Program
    {
        static void Main()
        {
            string yesOrno="";
            do{

            Calulate();
            ShowGratitude();

            Console.WriteLine("Do you want to conitune : [y/n]");
            yesOrno=Console.ReadLine()!;
            }while(yesOrno=="y");

            ShowMultiplicationTable();
        }
    
        static void Calculate()
        {
            string firstUservalue = GetUserValueByMessage("Welcome to  Calculator Application,\nEnter first number: ");
            string operation = GetUserValueByMessage("Choose operation that you need [+ , - , * , / , % ]: ");
            string secondUservalue = GetUserValueByMessage("Second number: ");

            ReportProgress("\nConverting value in progress...\n");

            decimal firstNumber = Convert.ToDecimal(firstUservalue);
            decimal secondNumber = Convert.ToDecimal(secondUservalue);
            string template = $"{firstNumber} {operation} {secondNumber} =";

            decimal result = operation switch
            {
                "+" => Sum(firstNumber, secondNumber),
                "-" => Subtract(firstNumber, secondNumber),
                "*" => Multiply(firstNumber, secondNumber),
                "/" => Divide(firstNumber, secondNumber),
                "%" => CalculatorRemainder(firstNumber, secondNumber),
                _ =>0
            };
            Console.WriteLine($"{template} {result}");
        }

        static void ShowGratitude()
        {
             Console.WriteLine("\n<--Thank you for your attenton-->\n");
        }

        static void ShowMultiplicationTable()
        {
            Console.WriteLine("\nWelcome to multiplication table");
            System.Console.WriteLine("Enter the number that you want to know it's multiplication table\n");

            Console.Write("Please enter the firstNumber: ");
            long initialNumber=long.Parse(Console.ReadLine()!);

            Console.Write("Please enter the lastNumber: ");
            long lastNumber=long.Parse(Console.ReadLine()!);

            Console.Write("Please enter the First Multiple Number : ");
            long multipleFirst=long.Parse(Console.ReadLine()!);

            Console.Write("Please enter the last Multiple Number: ");
            long multiplelast=long.Parse(Console.ReadLine()!);

            for(long outeriteration=initialNumber; outeriteration<=lastNumber; outeriteration++)
            {
                Console.WriteLine("/\\/\\/\\/\\/\\");
                for(long iteration= multipleFirst; iteration<=multiplelast; iteration++)
                {
                    Console.WriteLine($"{outeriteration} * {iteration} = {outeriteration*iteration} ");
                }
            }
        }

        static decimal Sum(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber + secondnumber;
        }

        static decimal Subtract(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber - secondnumber;
        }

        static decimal Multiply(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber * secondnumber;
        }

        static decimal Divide(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber / secondnumber;
        }

        static decimal CalculatorRemainder(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber % secondnumber;
        }

        static string GetUserValueByMessage(string message)
        {
            Console.Write(message);
            return Console.ReadLine()!;
        }
        static void ReportProgress(string messages)
        {
            Console.WriteLine(messages);
        }
    }
}