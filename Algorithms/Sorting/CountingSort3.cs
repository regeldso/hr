using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[n];        
        int[] ar_count = new int[100];
        int[] helper_ar = new int[100];
        int current_value;
        for (int i = 0; i < n; i++)
        {
            string[] split_elements = Console.ReadLine().Split(' ');
            current_value = Convert.ToInt32(split_elements[0]);
            ar[i] = current_value;
            ar_count[current_value] = ar_count[current_value] + 1;
        }
        helper_ar[0] = ar_count[0];
        for (int b = 1; b < 100; b++)
        {
            if(ar_count[b] == 0)
                helper_ar[b] = helper_ar[b - 1];
            else
                helper_ar[b] = ar_count[b] + helper_ar[b - 1];
        }
        Console.WriteLine(string.Join(" ", helper_ar));
    }
}