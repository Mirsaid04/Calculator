namespace Calculator.Classes;

internal class MultiplicationTableR : IMultiplicationTableR
{
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
}