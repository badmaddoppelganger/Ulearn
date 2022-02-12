namespace Names
{
    internal static class HistogramTask
    {
        public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
        {
            var days = new string[31];
            for (var y = 0; y < days.Length; y++)
                days[y] = (y + 1).ToString();
            var birthsCounts = new double[31];
            foreach (var nameM in names)
                if (nameM.Name == name && nameM.BirthDate.Day > 1)
                {
                    birthsCounts[nameM.BirthDate.Day - 1]++;
                }
            return new HistogramData(
                string.Format("Рождаемость людей с именем '{0}'", name),
                days,
                birthsCounts);
        }
    }
}