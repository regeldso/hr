using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        string [] str = Console.ReadLine().Split(' ');
        int n =  Convert.ToInt32(str[0].ToString());        
        int k =  Convert.ToInt32(str[1].ToString());
        int specialCount = 0;
        int page = 0;
        string [] problemsStr = Console.ReadLine().Split(' ');
        for (int i = 0; i < n; i++)
        {           
            int problemsCount =  Convert.ToInt32(problemsStr[i].ToString());
            int problemsOnPages = 0;
            while (problemsCount != 0)
            {
                if (problemsCount >= k)
                {
                    problemsOnPages = problemsOnPages + k;
                    problemsCount = problemsCount - k;
                    page = page + 1;
                    if (problemsOnPages >=page & problemsOnPages-k < page)
                        specialCount++;
                }
                else if (problemsCount > 0)
                {
                    problemsOnPages = problemsOnPages + problemsCount;
                    page = page + 1;
                    if (problemsOnPages >=page & problemsOnPages - problemsCount < page)
                        specialCount++;                   
                    problemsCount = 0;
                }
            } 
        }
        Console.WriteLine(specialCount);
    }
}