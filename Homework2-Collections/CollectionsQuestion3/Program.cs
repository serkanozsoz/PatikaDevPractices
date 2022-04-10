using System;

namespace CollectionsQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden Girilen Cümle İçerisindeki Sesli harfleri al
            //bir diziye aktar ve diziyi sıralı yazdır.
            char[] vowels = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> vowels1 = new();

            Console.WriteLine("Please enter a sentence!");
            string sentence = Console.ReadLine();
            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.Contains(sentence[i]))
                {
                    vowels1.Add(sentence[i]);
                }
            }

            vowels1.Sort();
            vowels1.ToArray();

            if (vowels1.Count == 0)
                Console.WriteLine("There are no vowels in the entered sentence!");
            else
            {
                Console.WriteLine("**** Vowels in sentence of entered ****");
                foreach (var item in vowels1)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}