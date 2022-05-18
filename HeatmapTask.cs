using System;

namespace Names
{
    internal static class HeatmapTask
    {
        public static HeatmapData GetBirthsPerDateHeatmap(NameData[] names)
        {
            var days = new string[30];
            for (var d = 0; d < 30; d++)
                days[d] = (d + 2).ToString();

            var month = new string[12];
            for (var m = 0; m < 12; m++)
                month[m] = (m + 1).ToString();

            double[,] twoDimensionalArray = new double[days.Length,month.Length];
            foreach (var imya in names)
            {
                if ( imya.BirthDate.Day != 1)
                    twoDimensionalArray[imya.BirthDate.Day - 2, imya.BirthDate.Month - 1]++;
            }
            //
            return new HeatmapData(
                "Пример карты интенсивностей",
                twoDimensionalArray,
                days,
                month);
        }
    }
}