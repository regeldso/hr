using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
public class FibMod
{
    public FibMod(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public string GetN(int n)
    {
        BigInteger n0 = new BigInteger(this.a);
        BigInteger n1 = new BigInteger(this.b);
        BigInteger n2 = new BigInteger(0);
        int i = 2;
        while (i < n)
        {
            n2 = BigInteger.Add(BigInteger.Multiply(n1, n1), n0);
            n0 = n1;
            n1 = n2;
            i++;
        }
        return n1.ToString();
    }
    public int a;
    public int b;
}
class Solution
{
    static void Main(String[] args)
    {
        string[] str = Console.ReadLine().Split(' ');
        int a = Convert.ToInt32(str[0].ToString());
        int b = Convert.ToInt32(str[1].ToString());
        int n = Convert.ToInt32(str[2].ToString());
        FibMod fm = new FibMod(a, b);
        string rez = fm.GetN(n);
        Console.WriteLine(rez);
        Console.ReadLine();
    }
}
