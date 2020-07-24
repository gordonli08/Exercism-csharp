using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        if (number < 1) {
            throw new ArgumentOutOfRangeException();
        }
        int maxfact = (int) Math.Sqrt(number);
        int aliquot = 0;
        for (int i = 1; i <= maxfact; i++) {
            if (number%i == 0) {
                if (i*i == number) {
                    aliquot += i;
                } else {
                    aliquot += i + (number/i);
                }
            }
        }
        aliquot -= number;
        if (aliquot > number) return Classification.Abundant;
        if (aliquot < number) return Classification.Deficient;
        return Classification.Perfect;
    }
}
