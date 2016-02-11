using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        string time = Console.ReadLine();
        string newtime;
        int hours;
        if (time.Substring(time.Length-2) == "AM"){
          hours = Convert.ToInt32(time.Substring(0, 2));
          if (hours == 12){
            newtime = "00" + time.Substring(2,time.Length-4);                
          }
          else {
              newtime = time.Substring(0, time.Length-2);
          }
        }
        else {
          hours = Convert.ToInt32(time.Substring(0, 2));
          if (hours != 12){            
            hours = hours + 12;
          }
          newtime = Convert.ToString(hours) + time.Substring(2,time.Length-4);           
        }
        Console.WriteLine(newtime);
    }
}