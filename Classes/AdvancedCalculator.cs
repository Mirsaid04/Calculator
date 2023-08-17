using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculator.Classes;

public class AdvancedCalculator : CalculatR
{
        public AdvancedCalculator(decimal firstNumber, string option,decimal secondNumber)
            : base(firstNumber, option,secondNumber)
        {
        }
        public decimal powerOfTwo(decimal firstNumber, decimal secondNumber)
        {
            decimal formula = (firstNumber / 100) * secondNumber;
            return formula;
        }

        public override void Calculate()
        {
            decimal result = powerOfTwo(this.Firstvalue,this.SecondValue);
            Console.WriteLine($"{this.Firstvalue} of {SecondValue}% is ={result}");
        }
         
        }