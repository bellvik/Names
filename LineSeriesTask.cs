using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Names
{
    public class LineSeriesTask
    {
        public static LineData GetLineData(NameData[] names, string name)
        { 
            var count = new Dictionary<int, int>();
            var months = new int[12];
            for (int i = 0; i < months.Length; i++)
            {
                months[i] = i + 1;
            }
            var countOfBirths = new int[12];
            foreach (var human in names)
            {
                if (human.Name == name)
                    countOfBirths[human.BirthDate.Month - 1]++;
            }
            for (int i = 0; i < 12; i++)
            {
                count.Add(months[i], countOfBirths[i]);
            }
            return new LineData(
                $"Рождаемость людей с именем Татьяна",count);
        }
    }
}
