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
        if (number < 1)
            throw new ArgumentException("0 or negative numbers are invalid arguments");

        if (number == 1)
            return false;

        for (int i = 2; i < number; i++)
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
