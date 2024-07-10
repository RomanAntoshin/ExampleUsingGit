using System;

namespace Task2BasicOfAlgorithmization
{
    class DatesVariant11
    {
        private readonly DateTime[] dates;
        public DatesVariant11(DateTime[] dates)
        {
            this.dates = dates;
        }
        public DateTime GetNearestDate(DateTime dateTime)
        {
            long min = Math.Abs((dates[0] - dateTime).Ticks);
            int minInd = 0;
            for (int i = 1; i < dates.Length; i++)
            {
                if (Math.Abs((dates[i] - dateTime).Ticks) < min)
                {
                    min = Math.Abs(dates[i].Ticks - dateTime.Ticks);
                    minInd = i;
                }
            }
            return dates[minInd];
        }
    }
}
