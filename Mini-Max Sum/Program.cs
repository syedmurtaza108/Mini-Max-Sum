/*
Given five positive integers, find the minimum and maximum values that can be calculated by summing exactly four of the five integers. Then print the respective minimum and maximum values as a single line of two space-separated long integers.

Input Format

A single line of five space-separated integers.

Each integer is in the inclusive range .
Output Format

Print two space-separated long integers denoting the respective minimum and maximum values that can be calculated by summing exactly four of the five integers. (The output can be greater than a 32 bit integer.)

Sample Input

1 2 3 4 5
Sample Output

10 14
*/

using System;
using System.Collections.Generic;

namespace Mini_Max_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            miniMaxSum(arr);
        }

        static void miniMaxSum(int[] arr)
        {
            long[] sum = new long[5];

            for(int i = 0; i<5;i++)
            {
                sum[i] = Sum(arr, i);
            }
            Array.Sort(sum);
            Console.Write(sum[0] + " " + sum[4]);

        }

        static long Sum(int[] arr, int point)
        {
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(i != point)
                    sum += arr[i];
            }

            return sum;
        }
    }
}
