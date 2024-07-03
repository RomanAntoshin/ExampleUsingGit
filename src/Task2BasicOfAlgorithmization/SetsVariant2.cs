using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2BasicOfAlgorithmization
{
    static class SetsVariant2
    {
        /*private readonly string[] names;
        private readonly string[][] namesOfClasses;*/
        /*public SetsVariant2()
        {
            this.names = names;
            this.namesOfClasses = namesOfClasses;
        }*/
        public static void Check(string[] names, string[][] namesOfClasses)
        {
            int[] counts = new int[names.Length];
            for(int i=0; i<counts.Length; i++)
            {
                counts[i] = 0;
            }
            for(int i=0; i<names.Length; i++)
            {
                for(int j=0; j<namesOfClasses.Length; j++)
                {
                    if (namesOfClasses[j].Contains(names[i]))
                    {
                        counts[i] += 1;
                    }
                }
            }
            for(int i=0; i<counts.Length; i++)
            {
                if(counts[i]==namesOfClasses.Length)
                {
                    Console.WriteLine(names[i] + " встречается во всех классах параллели");
                }
                if(counts[i]<namesOfClasses.Length & counts[i]>0)
                {
                    Console.WriteLine(names[i] + " встречается в некоторых классах параллели");
                }
                if(counts[i]==0)
                {
                    Console.WriteLine(names[i] + " не встречается ни в одном классе параллели");
                }
            }
        }
    }
}
