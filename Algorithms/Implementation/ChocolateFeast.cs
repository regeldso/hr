using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    public static void getAnswer(int n, int c, int m)
    {
        int current = n;
        int total = 0;
        while (current >= c)
        {
            current = current - c;
            if (current >= 0)
            {
                total = total + 1;
                if (total % m == 0)
                {
                       total = total + 1;
                }
           }
        }
        Console.WriteLine(total);
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int c = Convert.ToInt32(tokens_n[1]);
            int m = Convert.ToInt32(tokens_n[2]);
            getAnswer(n, c, m);
        }
    }
}