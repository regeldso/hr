using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    public static void ShortestDistance(int n, int m, int[][] edges, int s)
    {

        string lensStr = String.Empty;
        bool unreachable = true;
        int ilen = -1;
        for (int i = 1; i <= n; i++)
        {
            ilen = -1;
            if (i != s)
            {
                unreachable = true;
                for (int y = 0; y < m; y++)
                {
                    if (edges[y][0] == i | edges[y][1] == i)
                    {
                        unreachable = false;
                    }
                }
                if (!unreachable)
                {
                    ilen = 0;
                    bool stop = false;
                    bool first_s = false;
                    List<int[]> ls = new List<int[]> ();
                    ls.Add(new int[] { s, 0, -1});

                    while (!stop)   
                    {
                        first_s = false;
                        for (int y = 0; y < m; y++)
                        {
                            if (!first_s) {
                                if (edges[y][0] == ls[ls.Count-1][0] & y != ls[ls.Count - 1][2])
                                {
                                    ls[ls.Count - 1][1] = edges[y][1];
                                    ls[ls.Count - 1][2] = y;
                                    first_s = true;
                                }
                            }
                            if (edges[y][0] == ls[ls.Count - 1][0] & edges[y][1] == i)
                            {
                                ilen = ilen + 6;
                                stop = true;
                            }
                        }

                        if (!stop)
                        {
                            if (first_s)
                            {
                                ilen = ilen + 6;
                                ls.Add(new int[] { ls[ls.Count - 1][1], 0, -1 });
                            }
                            else
                            {
                                ls.RemoveAt(ls.Count - 1);
                            }
                        }
                    }
                }
                lensStr = lensStr + ilen.ToString() + " ";
            }

        }
        Console.WriteLine(lensStr);
    }
    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < t; j++)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(str[0].ToString());
            int m = Convert.ToInt32(str[1].ToString());
            int[][] edges = new int[m][];
            for (int i = 0; i < m; i++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                int x = Convert.ToInt32(str2[0].ToString());
                int y = Convert.ToInt32(str2[1].ToString());
                edges[i] = new int[] { x, y };
             }
            string[] str3 = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(str3[0].ToString());
            ShortestDistance(n, m, edges, s);
        }
    }
}