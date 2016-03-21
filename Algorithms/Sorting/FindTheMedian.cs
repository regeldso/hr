// using counting sort
using System;
class Solution
{
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar_val = new int[n];
        int[] ar_n = new int[n];
        int current_value = 0;
        string[] split_elements = Console.ReadLine().Split(' ');
        for (int y = 0; y < n; y++)
        {
            current_value = Convert.ToInt32(split_elements[y]);
            ar_val[y] = current_value;
            ar_n[current_value]++;
        }
        int half = n / 2;
        int i = 0;
        int j = 0;
        int count = 0;
        bool isFind = false;
        while (i < n && !isFind)
        {
            if (ar_n[i] != 0)
            {
                j = 0;
                while (j < n && !isFind)
                {
                    if (ar_val[j] == i)
                    {
                        if (count == half)
                        {
                            Console.WriteLine(ar_val[j].ToString());
                            isFind = true;
                        }
						count++;
                    }
                    j++;
                }
            }
            i++;
        }
    }
}
// native
using System;
using System.Collections.Generic;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        List<int> digits = new List<int>();
        string elements = Console.ReadLine();    
        string[] split_elements = elements.Split(' ');
        for (int i = 0; i < n; i++) 
            digits.Add(Convert.ToInt32(split_elements[i]));
        digits.Sort();
        Console.WriteLine(digits[n/2].ToString());
    }
}