using System;
using System.Text.RegularExpressions;

namespace ConversionCalculatorBL
{
    public class ConvertNumber
    {
        private static String changeBase(String inputNumber, int fromBase, int toBase)
        {
            return Convert.ToString(Convert.ToInt32(inputNumber, fromBase), toBase);
        }
        private static bool checkBinaryDigits(string myNumber)
        {
            bool result = false;
            result = Regex.IsMatch(myNumber, "^[01]+$");
            return result;
        }

        private static bool isValidNumber(String myNumber)
        {
            bool result = false;
            result = Regex.IsMatch(myNumber, "^[0-9]+$");
            return result;
        }

        public static String toBinary(String myNumber)
        {
            if (isValidNumber(myNumber))
                return changeBase(myNumber, 10, 2);
            else
                return "Not a valid number";
        }
        public static String toDecimal(String myNumber)
        {
            if (isValidNumber(myNumber))
                if (checkBinaryDigits(myNumber))
                    return changeBase(myNumber, 2, 10);
                else
                    return "Invalid Binary Number";
            else
                return "Not a valid number";
        }
    }
}
