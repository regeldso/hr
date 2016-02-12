using System;
using System.Collections.Generic;
using System.IO;
class Solution {
	static string GetAnswer(int min, int max)
	{
		int count = 0;
        int sqrt = (int)Math.Ceiling(Math.Sqrt(min));
		while (sqrt*sqrt <= max )
        {
            count++;
            sqrt++;
        } 
		return count.ToString();
	}
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            string[] str = Console.ReadLine().Split(' ');
            int min = Convert.ToInt32(str[0].ToString());
            int max = Convert.ToInt32(str[1].ToString());
            Console.WriteLine(GetAnswer(min, max));
        }    
    }
}