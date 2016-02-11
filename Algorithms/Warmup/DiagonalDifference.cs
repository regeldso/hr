using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static int PrimSecDiagonalDiff(int n, int[][] a) { 
        int j = 0;
        int summ = 0;
        for(int a_i = 0; a_i < n; a_i++){
            summ = summ + a[a_i][j] - a[a_i][n-1-j];
            j = j + 1;
        };
        return summ;
    }
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        int diff = 0;
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
       diff = Math.Abs(PrimSecDiagonalDiff(n, a));
       Console.WriteLine(diff);
    }
}