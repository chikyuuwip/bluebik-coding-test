using System;
using System.Collections.Generic;
using System.Linq;

class Q2_RomanToInteger
{
    public static void Main()
    {

        Console.WriteLine(RomanToInteger("XIV"));
        Console.WriteLine(RomanToInteger("MCMXC"));

    }
    public static int RomanToInteger(string roman)
    {
        var romanNumerals = new Dictionary<char, int>
        { {'I' , 1},
          {'V' , 5},
          {'X' , 10 },
          {'L' , 50},
          {'C' , 100},
          {'D' , 500},
          {'M' , 1000}
        };

        int sum = 0;
        int prevValue = 0;
        for (int i = roman.Length - 1; i >= 0; i--)
        {
            int currentValue = romanNumerals[roman[i]];

            if (currentValue < prevValue)
            {
                sum -= currentValue;
            }
            else
            {
                sum += currentValue;
            }
            prevValue = currentValue;
        }
        return sum;
    }
}
