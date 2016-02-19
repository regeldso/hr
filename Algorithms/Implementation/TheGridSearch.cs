using System;
public class Solution
{
    public static string GetAnswer(string[] G, string[] P)
    {
        int sLine = 0;
        int pLine = 0;
        int pos = 0;
        int oldPos = 0;
        string rez = "NO";
        while (sLine < G.Length)
        {
            pos = G[sLine].IndexOf(P[pLine], pos);
            // if fnd pattern line
            if (pos != -1)
            {
                // if pattern line first or in the same pos as previous
                if (pLine == 0 | pos == oldPos)
                {
                    // if found all lines
                    if (pLine == P.Length - 1)
                    {
                        rez = "YES";
                        break;
                    }
                    else // else go next
                    {
                        sLine++;
                        pLine++;
                    }
                }
                else // line on diferent pos find again from first line
                {
                    sLine = sLine - pLine;
                    pLine = 0;
                }
            }
            else // if not found line
            {
                // if first pattern line go next
                if (pLine == 0)
                {
                    sLine++;
                    pos = 0;
                }
                else // begin new find from n-line
                {
                    sLine = sLine - (pLine - 1);
                    pLine = 0;
                    pos = 0;
                    oldPos = 0;
                }
            }
            oldPos = pos;
        }
        return rez;
    }


    static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        string s = string.Empty;
        for (int a0 = 0; a0 < t; a0++)
        {
            string[] tokens_R = Console.ReadLine().Split(' ');
            int R = Convert.ToInt32(tokens_R[0]);
            int C = Convert.ToInt32(tokens_R[1]);
            string[] G = new string[R];
            for (int G_i = 0; G_i < R; G_i++)
            {
                G[G_i] = Console.ReadLine();
            }
            string[] tokens_r = Console.ReadLine().Split(' ');
            int r = Convert.ToInt32(tokens_r[0]);
            int c = Convert.ToInt32(tokens_r[1]);
            string[] P = new string[r];
            for (int P_i = 0; P_i < r; P_i++)
            {
                P[P_i] = Console.ReadLine();
            }
            s = GetAnswer(G, P);
            Console.WriteLine(s);
        }
    }
}