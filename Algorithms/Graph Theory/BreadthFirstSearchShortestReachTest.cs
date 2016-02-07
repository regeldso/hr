using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace ShortestDistanceTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ShortestDistanceTest()
        {
            int i = 0;
            string[] lines = File.ReadLines("c:\\in.txt").ToArray();         
            int t = Convert.ToInt32(lines[i]);
                for (int j = 0; j < t; j++)
                {
                    i = i + 1; 
                    string[] str = lines[i].Split(' ');
                    int n = Convert.ToInt32(str[0].ToString());
                    int m = Convert.ToInt32(str[1].ToString());
                    int[,] edges = new int[m, 3];
                    for (int k = 0; k < m; k++)
                    {
                        i = i + 1;
                        string[] str2 = lines[i].Split(' ');
                        edges[k, 0] = Convert.ToInt32(str2[0].ToString());
                        edges[k, 1] = Convert.ToInt32(str2[1].ToString());
                        edges[k, 2] = 0;
                    }
                    i = i + 1;
                    string[] str3 = lines[i].Split(' ');
                    int s = Convert.ToInt32(str3[0].ToString());
                    File.AppendAllText("c:\\out.txt", Solution.ShortestDistance(n, m, edges, s));
                    File.AppendAllText("c:\\out.txt", Environment.NewLine);
            }
        }
    }
}