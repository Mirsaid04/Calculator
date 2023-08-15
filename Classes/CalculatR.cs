namespace Calculator.Classes;

    public class CalculatR
    {
       public void Calculate()
        {
            string firstUservalue = ValueManipulatR.GetUserValueByMessage("Welcome to  Calculator Application,\nEnter first number: ");
            string operation = ValueManipulatR.GetUserValueByMessage("Choose operation that you need [+ , - , * , / , % ]: ");
            string secondUservalue = ValueManipulatR.GetUserValueByMessage("Second number: ");

            ReportR.ReportProgress("\nConverting value in progress...\n");

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
            ReportR.ReportResult($"{template} {result}");
        }
       public void ShowMultiplicationTable()
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
        
        private static decimal Sum(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber + secondnumber;
        }

        private static decimal Subtract(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber - secondnumber;
        }

        private static decimal Multiply(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber * secondnumber;
        }

        private static decimal Divide(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber / secondnumber;
        }

        private static decimal CalculatorRemainder(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber % secondnumber;
        }
    }