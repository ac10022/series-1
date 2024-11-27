/*
 2024 can be as the sum of consecutive positive integers in more than one way.
 Let n (where n > 1) be the number of consecutive positive integers in such a
 sum.
 What is the product of all the possible values of n?
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        int sum = 0;
        int p = 1;
        for (int i = 1; i < 2024; i++)
        {
            sum = 0;
            for (int n = i; n < 2024; n++)
            {
                sum += n;
                if (sum == 2024)
                {
                    p *= n + 1 - i;
                    Console.WriteLine($"{i} + {i + 1} + ... + {n - 1} + {n} = {sum}\n# of terms = {n + 1 - i}\n");
                    break;
                }
                else if (sum > 2024) break;
            }
        }
        Console.WriteLine($"product of all n = {p}");
    }
}