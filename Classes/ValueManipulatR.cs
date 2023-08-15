namespace Calculator.Classes;

    public static class ValueManipulatR
    {
        public static string GetUserValueByMessage(string message)
        {
        Console.Write(message);
        return Console.ReadLine()!;
        }
    }