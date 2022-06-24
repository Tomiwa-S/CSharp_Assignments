using System;
using System.Numerics;

namespace Delegates
{
    delegate BigInteger MyDelegate(int a);
    delegate T genericDelegate<T>(T a, T b);
    class Program
    {
        static void Main()
        {
            MyDelegate fact = factorial;
            Console.WriteLine("50! is  "+fact.Invoke(50));
            Func<int, int> sum =summer;
            Console.WriteLine("The sum from 1 to 100 is " + sum(100));
            genericDelegate<string> hello = Greet;
            Console.WriteLine(hello("Tomiwa","Samuel"));
        }

        static BigInteger factorial(int a) => (a < 2) ? 1 : a * factorial(a - 1);
        static int summer(int a) => (a < 2) ? 1 : a + summer(a - 1);
        static string Greet(string Firstname, string LastName) => $"Hello {Firstname} {LastName}";
    }
}
