using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar_count = new int[100];
        int[] ar = new int[n];
        string elements = Console.ReadLine();
        string[] split_elements = elements.Split(' ');
        int current_value;
        for (int i = 0; i < n; i++)
        {
            current_value = Convert.ToInt32(split_elements[i]);
            ar[i] = current_value;
            ar_count[current_value] = ar_count[current_value] + 1;
        }

        var sb = new StringBuilder("");       
        
        for (int j = 0; j < 100; j++)
        {
            for (int k = 0; k < ar_count[j]; k++)
            {
                sb.Append(j.ToString()).Append(" "); 
            }
        }
        Console.WriteLine(sb.ToString());
    }
}