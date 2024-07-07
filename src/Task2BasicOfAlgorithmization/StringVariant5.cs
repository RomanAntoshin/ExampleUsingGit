using System;
using System.Collections.Generic;
using System.Linq;


namespace Task2BasicOfAlgorithmization
{
    class StringVariant5
    {
        private readonly string[] words;

        public StringVariant5(string text)
        {
            this.words = text.Split(' ');
        }
        public bool Check()
        {
            if (words[0].Length != words[1].Length)
            {
                return false;
            }
            Dictionary<char, int> one = new Dictionary<char, int>();
            Dictionary<char, int> two = new Dictionary<char, int>();
            MakeDictionary(words[0], out one);
            MakeDictionary(words[1], out two);
            //MakeDictionary(one, words[0]);
            //MakeDictionary(two, words[1]);
            return !one.Any(s => two.Contains(s) == false);
        }
        private void MakeDictionary(string s, out Dictionary<char, int> keyValuePairs)
        {
             keyValuePairs= s.GroupBy(it => char.ToLower(it)).ToDictionary(it => it.Key, it => it.Count());
            /*for (int i = 0; i < s.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(char.ToLower(s[i])))
                {
                    keyValuePairs.Add(char.ToLower(s[i]), 1);
                }
                else
                {
                    keyValuePairs[char.ToLower(s[i])] += 1;
                }
            }*/
        }
    }
}
