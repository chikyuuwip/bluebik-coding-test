using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Q3_FindPairs
{
    public static void Main()
    {
        FindPairs(new int[] { 2, 4, 3, 7, 1, 9, 5 }, 10);
    }
    public static void FindPairs(int[] numbers, int target)
    {
        var read = new HashSet<int>();
        var pairs = new List<(int, int)>();

        foreach (int num in numbers)
        {
            int find = target - num;
            if (read.Contains(find))
            {
                pairs.Add((find, num));
                read.Remove(num);
            }
            else
            {
                read.Add(num);
            }

        }
        string result = "[" + string.Join(", ", pairs.Select(p => $"({p.Item1},{p.Item2})")) + "]";
        Console.Write(result);
    }
}

