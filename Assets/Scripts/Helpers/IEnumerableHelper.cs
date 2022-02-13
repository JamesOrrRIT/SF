using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class IEnumerableHelper 
{
    public static void ForEach<T>(this IEnumerable<T> enumeration, Action<T> action)
    {
        foreach (T item in enumeration)
        {
            action(item);
        }
    }
}
