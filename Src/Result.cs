using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Src
{
    public class Result
    {
        /*
         * Complete the 'flippingBits' function below.
         *
         * The function is expected to return a LONG_INTEGER.
         * The function accepts LONG_INTEGER n as parameter.
         */

        public static long flippingBits(long n)
        {            
            var biteList = new List<int>();

            if (n == 0)
            {
                biteList.Insert(0, 1);
            } else
            {
                while (n != 0)
                {                    
                    if ((n % 2) == 0)
                    {
                        biteList.Insert(0, 1);
                    }
                    else
                    {
                        biteList.Insert(0, 0);
                    }
                    n = n / 2;
                }
            }

            while (biteList.Count < 32)
            {
                biteList.Insert(0, 1);
            }

            long dec = 0;
            int exp = biteList.Count - 1;
            for (int i = 0; i < biteList.Count; i++)
            {
                dec = dec + biteList[i] * (long)Math.Pow(2, exp);
                exp--;
            }

            return dec;
        }
    }
}