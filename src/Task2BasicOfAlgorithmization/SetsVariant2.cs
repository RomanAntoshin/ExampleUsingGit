using System;
using System.Linq;

namespace Task2BasicOfAlgorithmization
{
    static class SetsVariant2
    {
        public static Popylarity[] Check(string[] names, string[][] namesOfClasses)
        {
            Popylarity[] data = new Popylarity[names.Length];
            for (int i = 0; i < data.Length; i++)
            {
                data[i] = new Popylarity(names[i]);
            }
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < namesOfClasses.Length; j++)
                {
                    if (namesOfClasses[j].Contains(names[i]))
                    {
                        data[i].Count = data[i].Count + 1;
                    }
                }
            }
            return data;
        }
        public struct Popylarity
        {
            public string Name { get; }
            public int Count { get; set; }
            public Popylarity(string name, int count = 0)
            {
                Name = name;
                Count = count;
            }
        }
    }
}
