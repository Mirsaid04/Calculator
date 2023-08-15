using System.Runtime.CompilerServices;

namespace Calculator.Classes;

    public class CalculatR
    {
        public decimal Firstvalue { get; set; }
        public decimal SecondValue { get; set; }
        public string Operation { get;set; }

        public CalculatR()
        {
            string firstUservalue = ValueManipulatR.GetUserValueByMessage("Welcome to  Calculator Application,\nEnter first number: ");
            this.Operation=ValueManipulatR.GetUserValueByMessage("Choose operation that you need [+ , - , * , / , % ]: ");
            string secondUservalue = ValueManipulatR.GetUserValueByMessage("Second number: ");
            this.Firstvalue = Convert.ToDecimal(firstUservalue);
            this.SecondValue = Convert.ToDecimal(secondUservalue);
        }
        
       public void Calculate()
        {
            ReportR.ReportProgress("\nConverting value in progress...\n");

            string template = $"{this.Firstvalue} {this.Operation} {this.SecondValue} =";

            decimal result = this.Operation switch
            {
                "+" => Sum(this.Firstvalue,this.SecondValue),
                "-" => Subtract(this.Firstvalue,this.SecondValue),
                "*" => Multiply(this.Firstvalue,this.SecondValue),
                "/" => Divide(this.Firstvalue,this.SecondValue),
                "%" => CalculatorRemainder(this.Firstvalue,this.SecondValue),
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