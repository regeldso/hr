using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

    [TestClass]
    public class TheGridSearchTest
{
    [TestMethod]
    public void TheGridSearchGetAnswerMethodTest()
    {
        int i = 0;
        string[] lines = File.ReadLines("c:\\in.txt").ToArray();
        int t = Convert.ToInt32(lines[i]);
        for (int a0 = 0; a0 < t; a0++)
        {
            i = i + 1;
            string[] tokens_R = lines[i].Split(' ');
            int R = Convert.ToInt32(tokens_R[0]);
            int C = Convert.ToInt32(tokens_R[1]);
            string[] G = new string[R];
            for (int G_i = 0; G_i < R; G_i++)
            {
                i = i + 1;
                G[G_i] = lines[i];
            }
            i = i + 1;
            string[] tokens_r = lines[i].Split(' ');
            int r = Convert.ToInt32(tokens_r[0]);
            int c = Convert.ToInt32(tokens_r[1]);
            string[] P = new string[r];
            for (int P_i = 0; P_i < r; P_i++)
            {
                i = i + 1;
                P[P_i] = lines[i];
            }
            File.AppendAllText("c:\\out.txt", Solution.GetAnswer(G, P));
            File.AppendAllText("c:\\out.txt", Environment.NewLine);
        }
    }
}