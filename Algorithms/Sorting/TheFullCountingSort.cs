using System;
using System.Collections;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar_val = new int[n];
        int[] ar_n = new int[n];
        string[] ar_str = new string[n];
        for (int i = 0; i < n; i++)
        {
            string[] split_elements = Console.ReadLine().Split(' ');
            ar_val[i] = Convert.ToInt32(split_elements[0]);
            ar_str[i] = split_elements[1];
            ar_n[ar_val[i]]++;        
        }
        var sb = new StringBuilder("");
        int half = n / 2;
        for (int i = 0; i < n; i++)
        {
            if (ar_n[i] != 0)
            {
                for (int j = 0; j < n; j++)
                {
                    if (ar_val[j] == i)
                    {
                        sb.Append(j < half ? "- " : ar_str[j] + " ");                        
                    }
                }                
            }
        }
        Console.WriteLine(sb.ToString());
    }
}