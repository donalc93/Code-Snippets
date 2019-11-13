using System;

namespace AdvancedCSTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }

        static void FizzBuzz()
        {

            for (int i = 1; i <= 100; i++)
            {
                int[] rule = { i % 3, i % 5, i % 7, i % 9 };
                string[] ruleOutput = { "Fizz", "Buzz", "Bizz", "Fuzz" };
                string output = "";

                for (int k = 0; k < rule.Length; k++)
                {
                    if (rule[k] == 0) { output += ruleOutput[k]; }
                }

                Console.WriteLine(i + " | " + output);
            }

        }

    }
}