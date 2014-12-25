using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorApp
{
    class Calculator
    {
        

        public double Add(double firstNumber,double secoundNumber)
        {
            return firstNumber + secoundNumber;
        }

        public double Subtract(double firstNumber, double secoundNumber)
        {
            return firstNumber - secoundNumber;
        }

        public double Multiply(double firstNumber, double secoundNumber)
        {
            return firstNumber*secoundNumber;
        }

        public double Divide(double firstNumber, double secoundNumber)
        {
            return firstNumber/secoundNumber;
        }
    }
}
