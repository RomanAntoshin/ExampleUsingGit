using System;

namespace Task2BasicOfAlgorithmization
{
    static class CyclesVariant5
    {
        private const int rabbitLegCount = 4;
        private const int gooseLegCount = 2;
        public static GoouseAndRabbitCount[] GetAnimalsCount(int allLegCount)
        {
            try
            {
                if (allLegCount < 0 || allLegCount % 2 != 0)
                {
                    throw new Exception("Invalid data");
                }
                int rabbitCount;
                int gooseCount;
                var counts = new GoouseAndRabbitCount[allLegCount / Math.Max(rabbitLegCount, gooseLegCount) + 1];
                for (int i = 0; i <= allLegCount / Math.Max(rabbitLegCount, gooseLegCount); i++)
                {
                    rabbitCount = i;
                    gooseCount = (allLegCount - rabbitCount * rabbitLegCount) / gooseLegCount;
                    counts[i] = new GoouseAndRabbitCount(rabbitCount, gooseCount);
                }
                return counts;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
        }
        public struct GoouseAndRabbitCount
        {
            private readonly int rabbit;
            private readonly int goose;
            public GoouseAndRabbitCount(int rabbit, int goose)
            {
                this.rabbit = rabbit;
                this.goose = goose;
            }
            public int Rabbit { get { return rabbit; } }
            public int Goose { get { return goose; } }
        }
    }
}
