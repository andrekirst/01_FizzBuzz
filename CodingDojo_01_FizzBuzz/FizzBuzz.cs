using System;

namespace CodingDojo_01_FizzBuzz
{
    public class FizzBuzz
    {
        public static bool IstDurch3Teilbar(int v)
        {
            return v > 0 && v % 3 == 0;
        }

        public static bool IstDurch5Teilbar(int v)
        {
            return v > 0 && v % 5 == 0;
        }

        public static string AusgabeTextGenerieren(bool durch3Teilbar, bool durch5Teilbar, int wert)
        {
            if (durch3Teilbar && durch5Teilbar)
            {
                return "FizzBuzz";
            }

            if (durch3Teilbar)
            {
                return "Fizz";
            }

            if (durch5Teilbar)
            {
                return "Buzz";
            }
            return wert.ToString();
        }
    }
}