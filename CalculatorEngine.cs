using System;
using System.Globalization;


namespace SimpleCalculator
{
   public class CalculatorEngine
    {
        public double Calculate(string argOperation,double firstNumber,double secondNumber)
        {
            double result;
            switch (argOperation.ToLower())
            {
                //For Addition
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;

                //For Subtraction
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;

                //For Multiplication
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;

                //For Division
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;

                //For Invalid Input Operation
                default:
                    throw new InvalidOperationException("Specified Operation Not Recognized");
            }
            return result;
        }
    }
}
