using System;
using System.Collections.Generic;
using System.Linq;

public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        int ret = 0;
        for (int i = 1; i < max; i++) {
            if (multiples.Any(fact => fact != 0 && i%fact == 0)) {
                ret += i;
            }
        }
        return ret;
    }
}