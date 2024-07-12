namespace Task3DelegatesEventsExceptions
{
    static class DaysOfWeek
    {
        private static int count;
        private static string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public static string GetDay()
        {
            if (count == days.Length)
            {
                count = 0;
            }
            return days[count++];
        }
    }
}
