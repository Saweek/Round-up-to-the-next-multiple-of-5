using System;

namespace Round_up_to_the_next_multiple_of_5_С_
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests.TestCase(Kata.RoundToNext5(0), 0);
            Tests.TestCase(Kata.RoundToNext5(1), 5);
            Tests.TestCase(Kata.RoundToNext5(3), 5);
            Tests.TestCase(Kata.RoundToNext5(5), 5);
            Tests.TestCase(Kata.RoundToNext5(7), 10);
            Tests.TestCase(Kata.RoundToNext5(39), 40);
        }
    }

    public class Kata
    {
        public static int RoundToNext5(int n)
        {
            //Your code goes here...
            while (n % 5 != 0) {
                n++;
            }
            return n;
        }
    }

    public class Tests
    {
        public static void TestCase(int a, int b) {
            if (a == b) {
                Console.WriteLine("True");
            } else Console.WriteLine("False");
        }
        //[Test]
        //[TestCase(0, ExpectedResult=0)]
        //[TestCase(1, ExpectedResult=5)]
        //[TestCase(3, ExpectedResult=5)]
        //[TestCase(5, ExpectedResult=5)]
        //[TestCase(7, ExpectedResult=10)]
        //[TestCase(39, ExpectedResult=40)]
    }
}
