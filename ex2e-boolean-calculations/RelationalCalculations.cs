using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2e_boolean_calculations
{
    public class RelationalCalculations
    {
        public static bool IsFrank(string input)
        {
            if (input == "Frank")
                return true;
            else
                return false;
        }
        public static bool IsEmpty(string input)
        {
            if (input == "")
                return true;
            else
                return false;
        }
        public static bool IsTwoPointThree(decimal input)
        {
            if (input == 2.3m)
                return true;
            else
                return false;
        }
        public static bool IsFalse(bool input)
        {
          if (input == false)
                return true;
          else
            return false;
        }
        public static bool AreEqual(decimal inputA, decimal inputB)
        {
            if (inputA == inputB)
                return true;
            else
                return false;
        }
        public static bool IsNotJones(string input)
        {
            if (input != "Jones")
                return true;
            else
                return false;
        }
        public static bool IsLargerThanZero(decimal input)
        {
            if (input > 0)
                return true;
            else
                return false;
        }
        public static bool IsLessThan(decimal inputA, decimal inputB)
        {
            if (inputA < inputB) 
                return true;
            else
                return false;
        }
        public static bool IsLargerOrEqualsThan500(decimal input)
        {
            if (input >= 500)
                return true;
            else
                return false;
        }
        public static bool IsLessOrEqualsThan(decimal inputA, decimal inputB)
        {
            if (inputA <= inputB)
                return true;
            else
                return false;
        }
    }
}
