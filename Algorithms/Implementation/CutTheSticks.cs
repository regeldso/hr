using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution
{
    public static void getAnswer(int n, int[] arr)
    {
        int[] tmp = arr;
        int count = tmp.Count();
        while (count > 0)
        {
            Console.WriteLine(count);
            int min = tmp.Min();
            tmp = tmp
                .Where(x => x > min)
                .Select((x) => x - min)
                .ToArray();
            count = tmp.Count();
        }
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
        getAnswer(n, arr);
    }
}