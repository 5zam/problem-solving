
/*
"Problem of the day:
Birthday Cake Candles :
Count how many candles are the tallest
Candles = [4, 1, 4,3)-> The tallest candles are 4 unit high
there are 2 candles with this light
return th number of candles that are tallest

Sample input:

4 4 1 3 4 → space sparated integeos
3 2 1 3
1 2 3 4 5 5
7

Sample outpul:
3
2
2
1

solution: */


using System;

class Program
{
    static int CountTallestCandles(int[] candles)
    {
        int max = candles[0];
        int count = 1;

        for (int i = 1; i < candles.Length; i++)
        {
            if (candles[i] > max)
            {
                max = candles[i];
                count = 1;
            }
            else if (candles[i] == max)
            {
                count++;
            }
        }

        return count;
    }
}

 static void Main()
    {
        int[] candles = { 1, 2, 3, 2, 5, 1, 4, 5 }; //example random array

        int result = CountTallestCandles(candles);

        Console.WriteLine("Number of the tallest candles:" + result);
    }
