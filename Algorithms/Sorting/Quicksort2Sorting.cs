using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
public class Solution
{
    public static int partition(int[] array, int start, int end)
    {
        int marker = start;
        for (int i = start; i <= end; i++)
        {
            if (array[i] < array[marker])
            {
                for (int j = i-1; j >= marker; j--)
                {
                    int temp = array[j+1];
                    array[j+1] = array[j];
                    array[j] = temp;
                }
                marker += 1;
            }         
        }
        return marker;
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
        Console.WriteLine(string.Join(" ", array.Skip(start).Take(end - start + 1).ToArray()));
    }

    static void Main(String[] args)
    {
        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int[] _ar = new int[_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
        {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }
        quicksort(_ar, 0, _ar_size - 1);
        //Console.ReadLine();
    }
}
