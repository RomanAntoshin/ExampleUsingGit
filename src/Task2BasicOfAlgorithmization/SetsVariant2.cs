using System;
using System.Linq;

namespace Task2BasicOfAlgorithmization
{
    static class SetsVariant2
    {
        public static Popylarity[] Check(string[] names, string[][] namesOfClasses)
        {
            //int[] counts = new int[names.Length];
            Popylarity[] data = new Popylarity[names.Length];
            for (int i = 0; i < data.Length; i++)
            {
                //counts[i] = 0;
                data[i] = new Popylarity(names[i]);
            }
            for (int i = 0; i < names.Length; i++)
            {
                for (int j = 0; j < namesOfClasses.Length; j++)
                {
                    if (namesOfClasses[j].Contains(names[i]))
                    {
                        //counts[i] += 1;
                        data[i].Count = data[i].Count + 1;
                    }
                }
            }
            return data;
            /*for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] == namesOfClasses.Length)
                {
                    Console.WriteLine(names[i] + " встречается во всех классах параллели");
                }
                if (counts[i] < namesOfClasses.Length & counts[i] > 0)
                {
                    Console.WriteLine(names[i] + " встречается в некоторых классах параллели");
                }
                if (counts[i] == 0)
                {
                    Console.WriteLine(names[i] + " не встречается ни в одном классе параллели");
                }
            }*/
        }
        public struct Popylarity
        {
            private readonly string name;
            private int count;
            public string Name { get { return name; } }
            public int Count { get { return count; } set { count = value; } }
            public Popylarity(string name, int count=0)
            {
                this.name = name;
                this.count = count;
            }
        }
    }
}
