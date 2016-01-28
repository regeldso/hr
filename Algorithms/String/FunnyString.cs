using System;
using System.Collections.Generic;
using System.IO;
class Solution {
        public static string FunnyOrNot(string s)
        {
            bool isFunny = true;
            for (int j = 1; j < s.Length; j++)
            {
                if (Math.Abs(s[j] - s[j - 1]) != Math.Abs(s[s.Length - j - 1] - s[s.Length - j]))
                {
                    isFunny = false;
                    break;
                }
            }
            if (isFunny) 
            {
                return "Funny";
            }
            else
            {
                return "Not Funny";
            }
        }
    
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string str = String.Empty;
        bool isFunny = true;
        for (int i = 0; i < n ; i++)
        {
            str = Console.ReadLine();
            Console.WriteLine(FunnyOrNot(str));
        } 
    }
}