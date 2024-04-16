﻿namespace LeedCode;

public class Problem_191
{
    public int HammingWeight(int n)
    {
        int result = 0;
        while (n != 0)
        {
            result += n & 1;
            n >>= 1;
        }

        return result;
    }
}