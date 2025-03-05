using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Q1_FindMostCommonWord
{
    public static void Main()
    {
        Console.Write("Enter Common Word : ");
        var commonWord = Console.ReadLine();
        if (commonWord != null)
        {
            FindMostCommonWord(commonWord);
        }
    }
    public static void FindMostCommonWord(string text)
    {
        var wordsDic = new Dictionary<string, int>();
        var words = text.ToLower().Split(new[] { ' ', '!', '?', ',', ';', '.' }, StringSplitOptions.RemoveEmptyEntries);
        foreach (var word in words)
        {
            if (wordsDic.ContainsKey(word))
                wordsDic[word]++;
            else
                wordsDic[word] = 1;
        }
        var most = wordsDic.OrderByDescending(x => x.Value).FirstOrDefault();
        System.Console.WriteLine("Found \"{0}\" {1} time(s)", most.Key, most.Value);

    }
}

