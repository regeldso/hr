// v1 too slow
using System;
public static class StringExtention
{
    public static string GetNextGreaterLex(this string str)
    {
        char symbol;
        int j = str.Length - 1;
        while (j > 0 && (int)str[j - 1] >= (int)str[j])
            j--;

        if (j <= 0)
            return str;

        int i = str.Length - 1;
        while ((int)str[i] <= (int)str[j - 1])
            i--;

        symbol = str[i];
        str = str.Remove(i, 1);
        str = str.Insert(i , str[j - 1].ToString());
        str = str.Remove(j - 1, 1);
        str = str.Insert(j - 1, symbol.ToString());

        i = str.Length - 1;
        while (j < i)
        {
            symbol = str[i];
            str = str.Remove(i, 1);
            str = str.Insert(i, str[j].ToString());
            str = str.Remove(j, 1);
            str = str.Insert(j, symbol.ToString());
            j++;
            i--;
        }
        return str;
    }
}
class Solution
{
    public static void getAnswer(string s)
    {
        string next_s = s.GetNextGreaterLex();
        if (s.Equals(next_s))
        {
            Console.WriteLine("no answer");
        }
        else
        {
            Console.WriteLine(next_s);
        }
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = string.Empty;
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            getAnswer(s);
        }
    }
}

// v2 Slower
using System;
class Solution
{
    public static void GetNextGreaterLexAsCodes(ref int[] str_codes)
    {
        int symbol;
        int j = str_codes.Length - 1;
        while (j > 0 && str_codes[j - 1] >= str_codes[j])
            j--;

        if (j <= 0)
            return;

        int i = str_codes.Length - 1;
        while (str_codes[i] <= str_codes[j - 1])
            i--;

        symbol = str_codes[i];
        str_codes[i] = str_codes[j - 1];
        str_codes[j - 1] = symbol;

        i = str_codes.Length - 1;
        while (j < i)
        {
            symbol = str_codes[i];
            str_codes[i] = str_codes[j];
            str_codes[j] = symbol;
            j++;
            i--;
        }
        return;
    }

    public static void getAnswer(string s)
    {
        int[] s_codes = new int[s.Length];
        int i = 0;
        foreach (char c in s)
        {
            s_codes[i] = (int)c;
            i++;
        }
        GetNextGreaterLexAsCodes(ref s_codes);
        string next_s = string.Empty;
        for (int j = 0; j < s_codes.Length; j++)
        {
            next_s = next_s + (char)s_codes[j];
        }
        if (s.Equals(next_s))
        {
            Console.WriteLine("no answer");
        }
        else
        {
            Console.WriteLine(next_s);
        }
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = string.Empty;
        for (int i = 0; i < n; i++)
        {
            s = Console.ReadLine();
            getAnswer(s);
        }
    }
}