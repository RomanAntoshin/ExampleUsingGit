namespace Task3DelegatesEventsExceptions
{
    class DaysOfWeek
    {
        private int count;
        private static string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
        public string GetDay()
        {
            if (count == days.Length)
            {
                count = 0;
            }
            return days[count++];
        }
    }
}
