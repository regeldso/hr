using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class Solution
{
    public static string ShortestDistance(int n, int m, int[,] edges, int s)
    {
        int rank = 1;
        int pos = s;
        int[] nodesrank = new int[n];
        for (int j = 0;  j < n ; j++)
            nodesrank[j] = -1;
        string str = string.Empty;

        // Add one edge nodes
        for (int i = 0; i < m; i++)
        {
            if (edges[i, 2] != 1)
            {
                if (edges[i, 0] == pos)
                {
                    nodesrank[edges[i, 1]-1] = rank;
                    edges[i, 2] = 1;
                }
                else if (edges[i, 1] == pos)
                {
                    nodesrank[edges[i, 0]-1] = rank;
                    edges[i, 2] = 1;
                }
            }
        }
        // Add other nodes from edges
        bool isFind = true;
        int r = 0;
        rank = rank + 1;
        int current = 0;
        while (isFind)
        {
            isFind = false;
            if (nodesrank[r] != -1)
            {
                for (int t = 0; t < m; t++) {
                    if (edges[t, 2] != 1) {
                        if (edges[t, 0] == (r + 1))
                        {
                            current = edges[t, 1] - 1;
                            if (nodesrank[current] == -1)
                                nodesrank[current] = rank;
                            edges[t, 2] = 1;
                            isFind = true;
                        }
                        else if (edges[t, 1] == (r + 1))
                        {
                            current = edges[t, 0] - 1;
                            if (nodesrank[current] == -1)
                                nodesrank[current] = rank;
                            edges[t, 2] = 1;
                            isFind = true;
                        }
                    }
                }
            }

            if (r < n)
            {
                r++;
            } else
            {
                if (isFind)
                {
                    r = 0;
                    rank = rank + 1 ;
                }
            }
        }

        // Out
        for (int y = 0; y < n; y++)
        {
            if (y != s-1)
            {
                if (nodesrank[y] != -1)
                {
                    str = str + (nodesrank[y] * 6).ToString() + " ";

                }
                else
                {
                    str = str + nodesrank[y].ToString() + " ";
                }                
            }
        }
        return str;
    }
    public static void Main(String[] args)
    {
        int t = Convert.ToInt32(Console.ReadLine());
        for (int j = 0; j < t; j++)
        {
            string[] str = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(str[0].ToString());
            int m = Convert.ToInt32(str[1].ToString());
            int[,] edges = new int[m, 3];
            for (int k = 0; k < m; k++)
            {
                string[] str2 = Console.ReadLine().Split(' ');
                edges[k, 0] = Convert.ToInt32(str2[0].ToString());
                edges[k, 1] = Convert.ToInt32(str2[1].ToString());
                edges[k, 2] = 0;
            }
            string[] str3 = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(str3[0].ToString());
            Console.WriteLine(ShortestDistance(n, m, edges, s));
        }
    }
}