using System;
using System.Collections.Generic;
namespace Pascal_s_Triangle;
public static class PascalsTriangle
{
    public static IEnumerable<IEnumerable<int>> Calculate(int rows)
    {
        int[][] pyramid = new int[rows][];
        for (int i = 0; i < rows; i++)
        {
            var previousRow = i == 0 ? new int[1] : pyramid[i - 1];
            var currentRow = CreateRow(1 + i, previousRow);
            pyramid[i] = currentRow;
        }
        return pyramid;
    }
    public static int[] CreateRow(int rowLength, int[] previousRow)
    {
        int[] newRow = new int[rowLength];
        for (int i = 0; i < rowLength; i++)
        {
            newRow[i] =
                i == 0 || i == rowLength - 1 ? 1 : 
                    previousRow[i] + previousRow[i - 1];
        }
        return newRow;
    }
}