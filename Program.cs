namespace Calculator
{
    class Program
    {
        static void Main()
        {
            // type name =Value;
            Console.WriteLine("Enter values: ");
            Console.Write("First  number: ");
            string firstUservalue=Console.ReadLine()!;
            Console.Write("Second number: ");
            string secondUservalue=Console.ReadLine()!;

            Console.WriteLine("Converting value in progress...");
            decimal firstNumber=Convert.ToDecimal(firstUservalue);
            decimal secondNumber=Convert.ToDecimal(secondUservalue);

            Console.WriteLine("Here are your results: ");
            Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber+secondNumber}");
            Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber-secondNumber}");
            Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber*secondNumber}");
            Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber/secondNumber}");
            Console.WriteLine($"{firstNumber}%{secondNumber}={firstNumber%secondNumber}");
        }
    }
}