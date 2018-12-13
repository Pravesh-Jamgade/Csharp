using System;
using System.Collections.Generic;

namespace learn
{
    public static class IteratorMethods
    {
        public static IEnumerable<int> GetSingleDigitNumbers()
        {
            yield return 0;
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
        }

        public static IEnumerable<int> GetSingleDigitNumbersV2()
        {
            int index = 0;
            while(index++ < 10)
                yield return index;

        }

        // public static IEnumerable<int> GetSingleDigitNumbersAndNumbersOver100()
        // {
        //     int index = 0;
        //     while(index++ < 10)
        //         yield return index;
            

        // }
    }
}