using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) { 
        int v = Convert.ToInt32(Console.ReadLine());
        int n = Convert.ToInt32(Console.ReadLine());
        string[] str_numbers = Console.ReadLine().Split(' ');
        int[] numbers = Array.ConvertAll(str_numbers,Int32.Parse);
        int index  = 0;
        for(int i = 0; i < n; i++){
            if (numbers[i] == v){
                index = i;
            }
        }
        Console.WriteLine(index.ToString());
    }
}