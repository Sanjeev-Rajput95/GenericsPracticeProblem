﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    public class GenericsMax
    {
        public static double MaxIntNumber (double firstNum, double secondNum, double thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) > 0 || firstNum.CompareTo(secondNum) >= 0 && firstNum.CompareTo(thirdNum) > 0 || firstNum.CompareTo(secondNum) > 0 && firstNum.CompareTo(thirdNum) >= 0 )
            {
                return firstNum;
            }

            if (secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) > 0 || secondNum.CompareTo(firstNum) >= 0 && secondNum.CompareTo(thirdNum) > 0 || secondNum.CompareTo(firstNum) > 0 && secondNum.CompareTo(thirdNum) >= 0)
            {
                return secondNum;
            }

            if (thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) > 0 || thirdNum.CompareTo(firstNum) >= 0 && thirdNum.CompareTo(secondNum) > 0 || thirdNum.CompareTo(firstNum) > 0 && thirdNum.CompareTo(secondNum) >= 0)
            {
                return thirdNum;
            }
            return thirdNum;
        }
    }
}
