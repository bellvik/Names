namespace Names;

internal static class HeatmapTask
{
    public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
    {   
        
        var days = GetArray(30,2);
        var months = GetArray(12,1);
        double[,] countOfBirths = new double[30,12];
        foreach (var man in names)
        {
            if (man.BirthDate.Day != 1)
            {
                int indexOfDay = man.BirthDate.Day - 2;
                int indexOfMonth = man.BirthDate.Month - 1;
                countOfBirths[indexOfDay, indexOfMonth]++;
            }
        }
        return new HeatmapData(
            "Пример карты интенсивностей",
            countOfBirths,
            days,
            months);
    }
    public static string[] GetArray(int size, int difference)
    { 
        var array = new string[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = (i + difference).ToString();
        }
        return array;
    }
}