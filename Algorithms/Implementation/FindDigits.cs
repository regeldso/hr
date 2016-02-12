using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static string GetAnswer(int number)
    {
        int count = 0;
        string s = String.Empty;
        string numberStr = number.ToString();
        for (int i = 0; i < numberStr.Length; i++)
        {
            s = numberStr[i].ToString();
            if (s != "0")
            {
                if (number % Convert.ToInt32(s) == 0)
                {
                    count = count + 1;
                }
            }
        }
        return count.ToString();
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetAnswer(n));
        }
    }
}