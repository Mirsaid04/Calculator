namespace Calculator
{
    class Program
    {
        static void Main()
        {
            // type name =Value;
            Console.WriteLine("\nEnter values: ");
            Console.Write("\nFirst  number: ");
            string firstUservalue=Console.ReadLine()!;

            System.Console.Write("\nChoose operation that you need [+ , - , * , / , % ]: ");
            string operation = Console.ReadLine()!;

            Console.Write("\nSecond number: ");
            string secondUservalue=Console.ReadLine()!;

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
            System.Console.WriteLine($"{template} {result}");
            System.Console.WriteLine("\n<--Thank you for yout attenton-->\n");
        }
    }
}