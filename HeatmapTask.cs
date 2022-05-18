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

           /* var days2 = new double[30];
            for (var d = 0; d < 30; d++)
                days2[d] = (d + 2);

            var month2 = new double[12];
            for (var m = 0; m < 12; m++)
                month2[m] = (m + 1);*/

            double[,] twoDimensionalArray = new double[days.Length,month.Length];
            foreach (var imya in names)
            {
                if ( imya.BirthDate.Day != 1)
                    twoDimensionalArray[imya.BirthDate.Day - 2, imya.BirthDate.Month - 1]++;
            }

            //days.Length, month.Length
            return new HeatmapData(
                "Пример карты интенсивностей",
                twoDimensionalArray,
                days,
                month);
        }
    }
}