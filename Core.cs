using System;

namespace SimpleCalculator
{
    class Core
    {
        static void Main(string[] args)
        {
            bool Decision = true;  //Variable declared for Re-executing the code from users choice

            do
            {     
           try
            {

            var inputConverter = new InputConverter();
            var calculatorEngine = new CalculatorEngine();
            Console.WriteLine(@"               Operation Guide
                        1.Addition-> 'add' or '+'
                        2.Subtraction-> 'subtract' or '-'
                        3.Multiplication-> 'multiply' or '*'
                        4.Division-> 'divide' or '/'
");
            Console.WriteLine("Enter First Number:");
            double firstNumber = inputConverter.ConvertInputToNumber(Console.ReadLine()); //Input 1
            Console.WriteLine("Enter Second Number:");
            double secondNumber = inputConverter.ConvertInputToNumber(Console.ReadLine()); //Input 2
            Console.WriteLine("Enter Operation from above specified:");
            string operation = Console.ReadLine(); //Operation (+,-,*,/)
                Console.WriteLine("----------Result----------");
            double result = calculatorEngine.Calculate(operation,firstNumber,secondNumber);
                                            
            Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

                //For Re-executing the code from users choice
                var continueProgram = string.Empty;
                Console.WriteLine();
                do
                {
                    Console.WriteLine("Do You Want To Continue? Y/N");
                    continueProgram = (Console.ReadLine() ?? string.Empty);
                } while (!continueProgram.Equals("Y",StringComparison.OrdinalIgnoreCase)&&
                        !continueProgram.Equals("N",StringComparison.OrdinalIgnoreCase));


                Decision = continueProgram.Equals("Y", StringComparison.OrdinalIgnoreCase);
            } while (Decision);
            Console.ReadKey();
        }
    }
    
}
