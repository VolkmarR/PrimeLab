using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime;

public static class PrimeNumbers
{
    public static bool IsPrimeNumber(int number)
    {
        if (number < 4)
        {
            if (number < 1)
                throw new ArgumentException("0 or negative numbers are invalid arguments");

            if (number == 1)
                return false;

            if (number == 2 || number == 3)
                return true;
        }

        if (number % 2 == 0 || number % 3 == 0)
            return false;

        var upperLimit = Math.Sqrt(number) + 1;
        for (int i = 5; i < upperLimit; i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    public static IEnumerable<int> Get(int fromNumber, int toNumber)
    {
        for (int i = fromNumber; i <= toNumber; i++)
        {
            if (IsPrimeNumber(i))
                yield return i;
        }
    }
}
