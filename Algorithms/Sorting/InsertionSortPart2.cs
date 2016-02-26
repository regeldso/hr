using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void insertionSort(int[] ar) {
        int ar_i;
        int i = 1;
        while (i < ar.Length)
        {
            if (ar[i-1] > ar[i])
            {
                ar_i = ar[i];
                for (int j = i; j >= 0; j--)
                {
                    if (j > 0 && ar[j - 1] > ar_i)
                    {
                        ar[j] = ar[j - 1];
                    }
                    else
                    {
                        ar[j] = ar_i;
                        break;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", ar));
            i++;
        }
    }
static void Main(String[] args) {
           
           int _ar_size;
           _ar_size = Convert.ToInt32(Console.ReadLine());
           int [] _ar =new int [_ar_size];
           String elements = Console.ReadLine();
           String[] split_elements = elements.Split(' ');
           for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
                  _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]); 
           }
           insertionSort(_ar);
    }
}