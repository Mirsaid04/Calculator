using System.Runtime.CompilerServices;

namespace Calculator.Classes;

public class CalculatR
{
    public decimal Firstvalue { get; set; }
    public string Operation { get; set; }
    public decimal SecondValue { get; set; }

    public CalculatR(decimal firstNumber, string option, decimal secondNumber)
    {
        Firstvalue = firstNumber;
        SecondValue = secondNumber;
        Operation = option;
        Calculate();
    }

    // public CalculatR()
    // {
    //     string firstUservalue = ValueManipulatR.GetUserValueByMessage("Welcome to  Calculator Application,\nEnter first number: ");
    //     this.Operation=ValueManipulatR.GetUserValueByMessage("Choose operation that you need [+ , - , * , / , % ]: ");
    //     string secondUservalue = ValueManipulatR.GetUserValueByMessage("Second number: ");
    //     this.Firstvalue = Convert.ToDecimal(firstUservalue);
    //     this.SecondValue = Convert.ToDecimal(secondUservalue);
    // }
    //
    public virtual void Calculate()
    {
        ReportR.ReportProgress("\nConverting value in progress...\n");

        string template = $"{this.Firstvalue} {this.Operation} {this.SecondValue} =";

        decimal result = this.Operation switch
        {
            "+" => Sum(this.Firstvalue, this.SecondValue),
            "-" => Subtract(this.Firstvalue, this.SecondValue),
            "*" => Multiply(this.Firstvalue, this.SecondValue),
            "/" => Divide(this.Firstvalue, this.SecondValue),
            "%" => CalculatorRemainder(this.Firstvalue, this.SecondValue),
            _ => 0
        };
        ReportR.ReportResult($"{template} {result}");
    }

    static decimal Sum(decimal firstnumber, decimal secondnumber)
    {
        return firstnumber + secondnumber;
    }

    static decimal Subtract(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber - secondnumber;
        }

        static decimal Multiply(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber * secondnumber;
        }

        static decimal Divide(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber / secondnumber;
        }

        static decimal CalculatorRemainder(decimal firstnumber, decimal secondnumber)
        {
            return firstnumber % secondnumber;
        }
    }
