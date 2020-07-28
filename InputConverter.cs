using System;


namespace SimpleCalculator
{
    public class InputConverter
    {
        public double ConvertInputToNumber(string argTextInput)
        {
            double convertednumber;

            if(!double.TryParse(argTextInput,out convertednumber))
            {

                throw new ArgumentException("Expected Numeric Number");
            }
            return convertednumber;
        }
    }
}
