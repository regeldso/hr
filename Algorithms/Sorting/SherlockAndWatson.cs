using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        string[] str = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(str[0]);
        int k = Convert.ToInt32(str[1]) % n;
        int q = Convert.ToInt32(str[2]);
        int[] ar_pos = new int[q]; 
        int[] ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        for(int i = 0; i < q; i++) 
            ar_pos[i] = Convert.ToInt32(Console.ReadLine());
        int j = 0;
        for(int i = 0; i < q; i++)
        {
            j = n -  k + ar_pos[i];
            if (j >= n )
            {
                j = j - n;
            }
            Console.WriteLine(ar[j].ToString());
        }
    }
}