using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        if (number <= 0) {
            throw new ArgumentOutOfRangeException();
        }
        int steps = 0;
        while(number != 1) {
            steps += 1;
            number = collatz(number);
        }
        return steps;
    }

    private static int collatz(int number) {
        int ret;
        if (number%2 == 0) {
            ret = number/2;
        } else {
            ret = 3*number + 1;
        }
        return ret;
    }
}