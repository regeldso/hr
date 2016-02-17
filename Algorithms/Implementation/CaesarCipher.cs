// use a sledge-hammer to crack nuts
using System;
using System.Text;
class Solution
{
    public sealed class CaesarCipher
    {
        public CaesarCipher(int k)
        {
            int asciiPos = (int)Convert.ToChar("A");
            for (int i = 0; i < letters.Length; i++)
            {
                this.letters[i] = (char)asciiPos;
                if (asciiPos == (int)Convert.ToChar("Z"))
                    asciiPos = (int)Convert.ToChar("a");
                else
                {
                    asciiPos = asciiPos + 1;
                }
            }
            this.Shift = k;
        }

        private char[] letters = new char[52];
        private char[] lettersShifted = new char[52];
        private int _shift;
        public int Shift
        {
            get { return _shift; }
            set
            {
                if (_shift != value)
                {
                    _shift = value;
                    CalcLettersShifted();
                }
            }
        }

        private void CalcLettersShifted()
        {
            if (_shift == 0)
            {
                lettersShifted = letters;
            }
            else
            {
                int littleACode = (int)Convert.ToChar("a");
                int bigACode = (int)Convert.ToChar("A");
                int littleZCode = (int)Convert.ToChar("z");
                int bigZCode = (int)Convert.ToChar("Z");
                int asciiNewPos;
                for (int i = 0; i < letters.Length; i++)
                {
                    asciiNewPos = (int)letters[i] + _shift;
                    if (i >= 0 & i < 26)
                    {
                        while (asciiNewPos > bigZCode)
                        {
                            asciiNewPos = bigACode + (asciiNewPos - bigZCode - 1);
                        }
                        lettersShifted[i] = (char)asciiNewPos;
                    }
                    else
                    {
                        while (asciiNewPos > littleZCode)
                        {
                            asciiNewPos = littleACode + (asciiNewPos - littleZCode - 1);
                        }
                        lettersShifted[i] = (char)asciiNewPos;
                    }
                }
            }
        }

        public string Encode(string s)
        {
            if (_shift != 0)
            {
                var sb = new StringBuilder(s);
                int index = -1;
                for (int i = 0; i < s.Length; i++)
                {
                    index = Array.IndexOf(letters, s[i]);
                    if (index != -1)
                    {
                        sb.Remove(i, 1);
                        sb.Insert(i, lettersShifted[index]);
                    }
                }
                return sb.ToString();
            }
            else
            {
                return s;
            }
        }
    }
    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int k = Convert.ToInt32(Console.ReadLine());
        CaesarCipher caesar = new CaesarCipher(k);
        string decodedStr = caesar.Encode(s);
        Console.WriteLine(decodedStr);
        Console.ReadLine();
    }
}