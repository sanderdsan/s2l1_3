using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {       
        string[] strings = { "kpi", "refrigerators", "molusk", "1804", "SacrificE" };

        var sortedChars = strings.Select(s => s.Length % 2 == 0 ? s.Last() : s.First()).OrderByDescending(c => (char)c);

        Console.WriteLine(string.Join(", ", sortedChars));
    }
}