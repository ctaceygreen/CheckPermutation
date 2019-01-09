using System;
// you can also use other imports, for example:
// using System.Collections.Generic;

// you can write to stdout for debugging purposes, e.g.
// Console.WriteLine("this is a debug message");

class Solution
{
    public int solution(int[] A)
    {
        // write your code in C# 6.0 with .NET 4.5 (Mono)
        int[] counter = new int[A.Length];
        int limit = A.Length;
        foreach(var item in A)
        {
            if(item < 1 || item > limit)
            {
                return 0;
            }
            else
            {
                if(counter[item - 1] != 0)
                {
                    return 0;
                }
                else
                {
                    counter[item - 1] = 1;
                }
            }
        }
        return 1;
    }
}