using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    public static string WhoCanPass(int[] width, int start, int end )
    {
        int current_vihicle = 3;
        for (int i = start; i <= end; i++)
        {
           if (current_vihicle > width[i])
              current_vihicle = width[i];
           if (current_vihicle == 1)
                break;
        }
        return current_vihicle.ToString();
    }
    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        //int n = Convert.ToInt32(tokens_n[0]);
        int t = Convert.ToInt32(tokens_n[1]);
        string[] width_temp = Console.ReadLine().Split(' ');
        int[] width = Array.ConvertAll(width_temp,Int32.Parse);
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_i = Console.ReadLine().Split(' ');
            int i = Convert.ToInt32(tokens_i[0]);
            int j = Convert.ToInt32(tokens_i[1]);
            Console.WriteLine(WhoCanPass(width, i, j));
        }
    }
}