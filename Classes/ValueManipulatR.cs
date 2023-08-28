namespace Calculator.Classes;

internal  class ValueManipulatR : IValueManipulator
    {
        public  decimal GetUserValueByMessage(string message)
        {
            Console.Write(message);
            return decimal.Parse(Console.ReadLine());
        }
        public  string GetInputByMessageToAction(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }
        
        public  void ShowMenu()
        {
            Console.Write("\nWelcome to my application\n1.Calculator" +
                          "\n2.Multiplicator" +
                          "\n3.Exit" +
                          "\nChoice: ");
        }
    }
    