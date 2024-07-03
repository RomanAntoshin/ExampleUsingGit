using System;
using System.Collections.Generic;
using System.IO;


namespace Task2BasicOfAlgorithmization
{
    class StringVariant5
    {
        private readonly string[] words;

        public StringVariant5(string address)
        {
            var reader = new StreamReader(address);
            string text = reader.ReadLine();
            Console.WriteLine(text);
            this.words = text.Split(' ');
            reader.Close();
        }
        private bool Check()
        {
            if (words[0].Length != words[1].Length)
            {
                return false;
            }
            Dictionary<char, int> one = new Dictionary<char, int>();
            Dictionary<char, int> two = new Dictionary<char, int>();
            MakeDictionary(one, words[0]);
            MakeDictionary(two, words[1]);
            if (one.Count != two.Count)
            {
                return false;
            }
            foreach (var el in one)
            {
                if (!two.ContainsKey(el.Key) || two[el.Key] != el.Value)
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
        public void CheckAndWrite()
        {
            var writer = new StreamWriter("E:\\Git\\STM_labs_Practice\\STM_labs_Practice\\src\\Task2BasicOfAlgorithmization\\OUTPUT.txt");
            if (Check())
            {
                writer.WriteLine("Yes");
                Console.WriteLine("Yes");
            }
            else
            {
                writer.WriteLine("No");
                Console.WriteLine("No");
            }
            writer.Close();
        }
    }
}
