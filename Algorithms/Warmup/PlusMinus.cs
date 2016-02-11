using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int j = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int negative = 0;
        int positive = 0;
        int zeros = 0;

        for (int i = 0; i < j; i++)
        {
            if (arr[i] > 0) 
            {
                positive =  positive + 1;
            } else if (arr[i] < 0)
            {               
                negative = negative + 1;
            } else 
            {
                zeros = zeros + 1;
            }
        }
        double p,n,z;
        p = (double)positive/j;    
        n = (double)negative/j;
        z = (double)zeros/j;
        Console.WriteLine( Math.Round(p, 4));
        Console.WriteLine( Math.Round(n, 4));
        Console.WriteLine( Math.Round(z, 4));
    }
}
