using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Q1_FindMostCommonWord
{
    public static void Main()
    {
        Console.Write("Enter Common Word : ");
        var commonWord = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(commonWord))
        {
            FindMostCommonWord(commonWord);
        }
        else {
            Console.WriteLine("Input is empty");
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
        if (wordsDic.Any())
        {
            var mostWord = wordsDic.OrderByDescending(x => x.Value).FirstOrDefault();
            System.Console.WriteLine("Found \"{0}\" {1} time(s)", mostWord.Key, mostWord.Value);
        }
        else
        {
            Console.WriteLine("Words not valid");
        }

    }
}

