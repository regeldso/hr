// v1
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void insertionSort(int[] ar) {
        int ar_i;
        int i = 1;
        int shiftCount = 0;
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
                        ar[j-1] = ar_i;
                        shiftCount++;
                    }
                }
            }
            i++;
        }
        Console.WriteLine(shiftCount);
    }
    static void Main(string[] args) { 
        Console.ReadLine(); 
        int [] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar); 
    }
}

// v2

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution { 
    public static void insertionSort (int[] A) { 
        var j = 0; 
        int shiftCount = 0;
        for (var i = 1  ; i < A.Length; i++) { 
            var value = A[i]; 
            j = i - 1; 
            while (j >= 0 && value < A[j]) { 
                A[j + 1] = A[j];
                shiftCount++;
                j = j - 1; 
            } 
            A[j + 1] = value; 
        } 
        Console.WriteLine(shiftCount); 
    }

    static void Main(string[] args) { 
        Console.ReadLine(); 
        int [] _ar = (from s in Console.ReadLine().Split() select Convert.ToInt32(s)).ToArray();
        insertionSort(_ar); 
    }
} 