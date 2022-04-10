using System;
using System.Collections.Generic;
using System.Collections;

namespace CollectionsQuestion1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Girilen 20 adet pozitif sayı al.
            //asal olan ve olmayan olarak ayrı ayrı 2 listeye at.
            //negatif ve numeric olamayan girişleri engelle.
            //Her bir dizininin elemanlarını büyükten küçüğe ekrana listele
            //her iki dizininde eleman sayısı ve ortalamasını ekrana yazdır.
            ArrayList primes = new ArrayList();

            ArrayList notPrimes = new ArrayList();

            Methods m = new Methods();

            for (int i = 0; i < 20; i++)
            {
                try
                {
                    Console.WriteLine("Please enter {0}. positive numbers : ", i + 1);
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (number <= 0)
                    {
                        throw new Exception("Number is not available.Please enter a positive number");
                        // Console.WriteLine("Number is not available.Please enter a positive number!");
                        i--;
                    }
                    else if (!m.IsPrime(number) || number == 1)
                    {
                        notPrimes.Add(number);
                    }
                    else
                    {
                        primes.Add(number);
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message.ToString());
                    i--;
                }
                Console.WriteLine("********************");
            }

            Console.WriteLine("**** Prime Numbers ****");

            foreach (int item in primes)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("**** notPrime Numbers ****");

            foreach (int item in notPrimes)
            {
                Console.WriteLine(item);
            }

        }
    }
    public class Methods
    {
        public bool IsPrime(int number)
        {
            bool n = false;
            if (FindDivisors(number).Length == 1)
            {
                n = true;
            }
            return n;
        }
        public int[] FindDivisors(int number)
        {
            List<int> divisors = new List<int>();
            int n = 0;
            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    n = i;
                    divisors.Add(n);
                }
            }
            int[] newDivisors = divisors.ToArray();
            return newDivisors;
        }
    }
}