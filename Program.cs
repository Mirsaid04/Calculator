namespace Calculator
{
    class Program
    {
        static void Main()
        {
            string yesOrno="";
            do{
            Console.WriteLine("Welcome to  Calculator Application");
            Console.Write("Enter first number: ");
            int firstUservalue=int.Parse(Console.ReadLine()!);

            System.Console.Write("Choose operation that you need [+ , - , * , / , % ]: ");
            string operation = Console.ReadLine()!;

            Console.Write("Second number: ");
            int secondUservalue=int.Parse(Console.ReadLine()!);

            Console.WriteLine("\nConverting value in progress...\n");
            decimal firstNumber = Convert.ToDecimal(firstUservalue);
            decimal secondNumber = Convert.ToDecimal(secondUservalue);
            string template = $"{firstNumber} {operation} {secondNumber} =";

            decimal result = operation switch
            {
                "+" => firstNumber + secondNumber,
                "-" => firstNumber - secondNumber,
                "*" => firstNumber * secondNumber,
                "/" => firstNumber / secondNumber,
                "%" => firstNumber % secondNumber,
                _ =>0
            };
            Console.WriteLine($"{template} {result}");
            Console.WriteLine("\n<--Thank you for yout attenton-->\n");

            Console.WriteLine("Do you want to conitune : [y/n]");
            yesOrno=Console.ReadLine()!;
            }while(yesOrno=="y");

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
    }
}