using System;

class Program

{

    static void Main(string[] args)

    {

        string text = "asdf fgha jkla oiua "; // замініть на свій текст

        int maxCount = 0;

        char maxChar = ' ';

        foreach (char c in text)

        {

            int count = 0;

            foreach (char d in text)

            {

                if (c == d)

                {

                    count++;

                }

            }

            if (count > maxCount)

            {

                maxCount = count;

                maxChar = c;

            }

        }

        Console.WriteLine($"The most frequent character is '{maxChar}' with {maxCount} occurrences.");

    }

}