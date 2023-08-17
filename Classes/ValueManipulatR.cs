namespace Calculator.Classes;

public static class ValueManipulatR
    {
        public static decimal GetUserValueByMessage(string message)
        {
            Console.Write(message);
            return decimal.Parse(Console.ReadLine());
        }
        public static string GetInputByMessageToAction(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        public static void ShowMenu()
        {
            Console.Write("\nWelcome.\n1.Calculator" +
                          "\n2.Multiplicator" +
                          "\n3.Exit" +
                          "\nChoice: ");
        }
    }
    