using Microsoft.CodeAnalysis.CSharp;

namespace Names;

internal static class HistogramTask
{
    public static HistogramData GetBirthsPerDayHistogram(NameData[] names, string name)
    {
        var months = new string[12];
        for (int i = 0; i < months.Length; i++)
        {
            months[i] = (i+1).ToString();
        }
        var countOfBirths = new double[12];
        foreach (var human in names)
        {
            if (human.Name == name )
                countOfBirths[human.BirthDate.Month - 1]++;
        }
        return new HistogramData(
            $"Рождаемость людей с именем '{name}'",
            months,
            countOfBirths);
    }
    
}