using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    public static int partition(int[] array, int start, int end)
    {
        int marker = start;
        for (int i = start; i <= end; i++)
        {
            if (array[i] <= array[end])
            {
                int temp = array[marker];
                array[marker] = array[i];
                array[i] = temp;
                marker += 1;
            }
        }
        return marker - 1;
    }

    public static void quicksort(int[] array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }
        int bound = partition(array, start, end);
        quicksort(array, start, bound - 1);
        quicksort(array, bound + 1, end);
    }    

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[n];
        string elements = Console.ReadLine();
        string[] split_elements = elements.Split(' ');
        for (int i = 0; i < n; i++)
            ar[i] = Convert.ToInt32(split_elements[i]);
        // sort
        quicksort(ar, 0, n - 1);     
        //find closest numbers
		List<int> min_couples = new List<int>();
        int min_diff = ar[1] - ar[0];
        int new_min_diff = 0;
        for (int i = 2; i < n; i++)
        {
            new_min_diff = ar[i] - ar[i-1];
            if (min_diff > new_min_diff)
            {
                min_couples.Clear();
                min_couples.Add(ar[i-1]);
                min_couples.Add(ar[i]); 
                min_diff = new_min_diff;
            }
            else if (min_diff == new_min_diff)
            {
                min_couples.Add(ar[i-1]);
                min_couples.Add(ar[i]);                              
            }                    
        }
        if (min_couples.Count > 0)
        {
            Console.WriteLine(string.Join(" ", min_couples));
        }
    }
}