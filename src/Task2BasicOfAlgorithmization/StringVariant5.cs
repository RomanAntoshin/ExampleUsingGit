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
            Dictionary<char, int> one = MakeDictionary(words[0]);
            Dictionary<char, int> two = MakeDictionary(words[1]);
            return !one.Any(s => two.Contains(s) == false);
        }
        private Dictionary<char, int> MakeDictionary(string s) => s.GroupBy(it => char.ToLower(it)).ToDictionary(it => it.Key, it => it.Count());
    }
}
