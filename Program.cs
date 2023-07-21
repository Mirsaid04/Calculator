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

            Console.WriteLine("\nConverting value in progress...\n");
            decimal firstNumber=Convert.ToDecimal(firstUservalue);
            decimal secondNumber=Convert.ToDecimal(secondUservalue);

            Console.WriteLine("Here are your results: ");
            Console.WriteLine($"{firstNumber}+{secondNumber}={firstNumber+secondNumber}");
            Console.WriteLine($"{firstNumber}-{secondNumber}={firstNumber-secondNumber}");
            Console.WriteLine($"{firstNumber}*{secondNumber}={firstNumber*secondNumber}");
            Console.WriteLine($"{firstNumber}/{secondNumber}={firstNumber/secondNumber}");
            Console.WriteLine($"{firstNumber}%{secondNumber}={firstNumber%secondNumber}\n");

            Console.WriteLine("New project is starting....\n");

            System.Console.Write("Do you want to go to the army,please enter your age\nAge: ");
            string userAgeValue=Console.ReadLine()!;
            int ageValue=int.Parse(userAgeValue);

            if (ageValue>=18 && ageValue < 28)
            {
                System.Console.WriteLine("Your age is eligible to go");
            }
            else
            System.Console.WriteLine("Your age is not eligible to go\n");

            System.Console.WriteLine("This is also same project but in other way\n");

            System.Console.WriteLine("\nIt is starting now...\n");

            System.Console.Write("Enter your age: ");
            string secondAgevalue=Console.ReadLine()!;
            int secondAge=Convert.ToInt32(secondAgevalue);

            string message=(secondAge >= 18 && secondAge < 28)
                                ? "You can go to the army"
                                : "You can not go to the army";
            System.Console.WriteLine(message);
            System.Console.WriteLine("\n<--Thank you for yout attenton-->\n");
        }
    }
}