using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectEuler
{
    public static class Solutions
    {
        public static int Solution1(int max)
        {
            int sum = 0, num = 3;
            while (num < max)
            {
                sum += (num % 3 == 0 || num % 5 == 0 ? num : 0);
                num += 1;
            }
            return sum;
        }

        public static int Solution2(int max)
        {
            int sum = 2, first = 1, second = 2;
            while (first < max && second < max)
            {
                var temp = first + second;
                first = second; second = temp;
                sum += (second % 2 == 0 ? second : 0);
            }
            return sum;
        }

        public static int Solution3(int num)
        {
            int prime = int.MinValue;
            num = num / 2 + 1;
            while(num > 0)
            {

                
            }
            return prime;
        }
    }
}
