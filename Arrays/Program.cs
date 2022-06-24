using System;

namespace Arrays
{
    class Program
    {
        static bool IsPldrome(string str)
        {
            int min = 0;
            int max = str.Length - 1;
            while (true)
            {
                if (min > max) return true;
                if (str[min] != str[max]) return false;
                max--; min++;
            }
        }
        static void Main(string[] args)
        {
            Console.Write("Enter a word you think is a Palindrome : ");
            string word = Console.ReadLine();
            Console.WriteLine(IsPldrome(word.ToLower()));
            if (!IsPldrome(word.ToLower())) Console.WriteLine(word.ToLower() + " != " + Reverse(word));
        }

        static string Reverse(string str)
        {
            string word = "";
            for (int i = str.Length - 1; i >= 0; i--) word += str[i];
            return word.ToLower();
        }
    }
}
