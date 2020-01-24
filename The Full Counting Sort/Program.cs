using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution
{

    // Complete the countSort function below.
    static void countSort(List<List<string>> arr)
    {
        List<StringBuilder> sorted = new List<StringBuilder>();
        for (byte j = 0; j < 100; j++)
        {
            sorted.Add(new StringBuilder());
        }
        int i = 0;
        for (; i < arr.Count() / 2; i++)
        {
            sorted[Byte.Parse(arr[i][0])].Append("- ");
        }
        for (; i < arr.Count(); i++)
        {
            sorted[Byte.Parse(arr[i][0])].Append(arr[i][1]).Append(" ");
        }
        foreach (var inner in sorted)
        {
                Console.Write(inner);
        }

    }
    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<string>> arr = new List<List<string>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList());
        }

        countSort(arr);
    }
}
