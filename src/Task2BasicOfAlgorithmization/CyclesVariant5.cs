using System;

namespace Task2BasicOfAlgorithmization
{
    static class CyclesVariant5
    {
        private const int rabbitLegCount = 4;
        private const int gooseLegCount = 2;
        public static void GetAnimalsCount(int allLegCount)
        {
            int rabbitCount = 0;
            int gooseCount = 0;
            for (int i = 0; i <= allLegCount / Math.Max(rabbitLegCount, gooseLegCount); i++)
            {
                rabbitCount = i;
                gooseCount = (allLegCount - rabbitCount * rabbitLegCount) / gooseLegCount;
                Console.WriteLine(rabbitCount + " - rabit " + gooseCount + " - goose");
            }
        }
    }
}
