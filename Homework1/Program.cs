using System;
using System.Collections.Generic;

namespace Homework1 // Note: actual namespace depends on the project name.
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Question 1

            Console.WriteLine("Please enter a positive integer!");
            int n = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Please enter {0} positive integers!", n);

            List<int> list = new();
            for (int i = 0; i < n; i++)
            {
                int number = Convert.ToInt32((Console.ReadLine()));
                if (Methods.IsPositiveEven(number) && number > 0)
                {
                    list.Add(number);
                }

            }

            if (list.Count == 0)
            {
                Console.WriteLine("There are no positive even integer!");
            }
            else
            {
                Console.WriteLine("Positive even integers entered:");
                foreach (int item in list)
                {
                    Console.WriteLine(item);
                }
            }

            //Question 2

            Console.WriteLine("Please enter 2 positive integers!");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter {0} positive integers!", x);
            int number2 = 0;
            List<int> list2 = new();
            for (int i = 0; i < x; i++)
            {
                number2 = Convert.ToInt32(Console.ReadLine());
                if (number2 > 0 && (number2 == y || number2 % y == 0))
                {
                    list2.Add(number2);
                }
            }
            Console.WriteLine("Integers divisible by or equal to the entered m:");
            foreach (int item2 in list2)
            {
                Console.WriteLine(item2);
            }

            //Question 3

            Console.WriteLine("Please enter a positive integer!");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter {0} words!", c);
            List<string> words = new();
            for (int i = 0; i < c; i++)
            {
                string text = Console.ReadLine().ToString();
                words.Add(Methods.reverseWords(text));

            }

            words.Reverse();
            System.Console.Write("Reverse words entered: ");
            foreach (string k in words)
            {
                if (k == words[words.Count - 1])
                {
                    System.Console.WriteLine(k);
                }
                else
                    System.Console.Write(k + " ");
            }

            //Question 4

            Console.WriteLine("Please enter a sentence!");
            string sentence = Console.ReadLine().ToString();
            string[] words1 = sentence.Split(" ");
            string space = " ";
            int CountLetters = 0;
            for (int d = 0; d < sentence.Length; d++)
            {
                CountLetters++;
                if (space.Contains(sentence[d]))
                {
                    CountLetters--;
                }
            }

            Console.WriteLine("amount of words entered : {0}", words1.Length);
            Console.WriteLine("amount of letters entered : {0}", CountLetters);




        }

    }


    public class Methods
    {
        public static bool IsPositiveEven(int number)
        {
            bool result = false;
            if (number % 2 == 0 && number > 0)
            {
                result = true;
            }
            return result;
        }
        public static string reverseWords(string text)
        {
            String txt = "";
            for (int i = text.Length; i > 0; i--)
            {
                txt += text[i - 1].ToString();
            }
            return txt;
        }



    }
}