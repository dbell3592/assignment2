using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classLibrary
{
    public class ConvertNumber
    {
        private String changeBase(String inputNumber, int fromBase, int toBase)
        {
            return Convert.ToString(Convert.ToInt32(inputNumber, fromBase), toBase);
        }
        public String toBinary(String myNumber)
        {
            return changeBase(myNumber,10,2);
        }
        public String toDecimal(String myNumber)
        {
            return changeBase(myNumber, 2, 10);
        }
    }
}
