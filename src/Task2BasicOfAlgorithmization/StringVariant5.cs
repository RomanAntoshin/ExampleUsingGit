using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2BasicOfAlgorithmization
{
    class StringVariant5
    {
        private string first;
        private string second;
        public StringVariant5(string first, string second)
        {
            this.first = first;
            this.second = second;
        }
        public bool Check()
        {
            if(first.Length!=second.Length)
            {
                return false;
            }
            Dictionary<char, int> one = new Dictionary<char, int>();
            Dictionary<char, int> two = new Dictionary<char, int>();
            MakeDictionary(one, first);
            MakeDictionary(two, second);
            if(one.Count!=two.Count)
            {
                return false;
            }
            foreach(var el in one)
            {
                if(!two.ContainsKey(el.Key) | two[el.Key]!=el.Value)
                {
                    return false;
                }
            }
            return true;
        }
        private void MakeDictionary(Dictionary<char, int> keyValuePairs, string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (!keyValuePairs.ContainsKey(char.ToLower(s[i])))
                {
                    keyValuePairs.Add(char.ToLower(s[i]), 1);
                }
                else
                {
                    keyValuePairs[char.ToLower(s[i])] += 1;
                }
            }
        }
    }
}
