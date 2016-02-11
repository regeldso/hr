using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = "";
        for(int i = 0; i < n; i++){
            s = "";    
            for(int spaces = 1; spaces < n-i; spaces++){
              s = s + " "; 
            }
            for(int symbol = 0; symbol <= i; symbol++){
              s = s + "#"; 
            }            
            Console.WriteLine(s);
        }    
    }
}
