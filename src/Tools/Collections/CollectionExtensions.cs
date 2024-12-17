﻿namespace Collections;

public static class CollectionExtensions
{
    public static (int Index, long Value) MaxWithIndex(this IEnumerable<long> enumerable)
    {
        long maxValue = long.MinValue;
        int maxIndex = -1;
        int index = 0;
        foreach(var item in enumerable)
        {
            if(maxValue < item || item == maxValue && maxIndex == -1)
            {
                maxValue = item;
                maxIndex = index;
            }
            ++index;
        }
        return (maxIndex, maxValue);
    }

    public static (int Index, long Value) MinWithIndex(this IEnumerable<long> enumerable)
    {
        long minValue = int.MaxValue;
        int minIndex = -1;
        int index = 0;
        foreach (var item in enumerable)
        {
            if (item < minValue || item == minValue && minIndex == -1)
            {
                minValue = item;
                minIndex = index;
            }
            ++index;
        }
        return (minIndex, minValue);
    }
}