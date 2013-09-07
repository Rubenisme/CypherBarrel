using System;
using System.Linq;

namespace CypherBarrel
{
    internal class Encrypter
    {
        private static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines(args[0]);
            string key = null;

            foreach (var line in lines.Skip(1).Select((s, i) =>
            {
                if (i % 2 == 0)
                {
                    key = s;
                    return lines[i + 2];
                }
                return null;
            }).Where(line => line != null))
            {
                var keypos = 0;
                foreach (var letter in line)
                {
                    if (keypos >= key.Length)
                    {
                        key = string.Concat(Enumerable.Reverse(key));
                        keypos = 0;
                    }
                    if (letter == ' ')
                        Console.Write(' ');
                    else
                    {
                        var newkey = letter + Char.GetNumericValue(key[keypos++]);
                        if (newkey > 'z')
                            newkey -= 26;
                        Console.Write((char)newkey);
                    }
                }
                Console.Write("\n");
            }
        }
    }
}