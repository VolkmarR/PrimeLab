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
        return false;
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
