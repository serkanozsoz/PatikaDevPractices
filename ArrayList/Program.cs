using System;
using System.Collections;

namespace arrayList // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //koleksiyonlar tek bir veri tipini değil birden fazla veri tipini barındırırlar. Dinamiktirler.Tam olarak bunun karşılığı ArrayList'dir.

            // System.Collections namespace
            ArrayList list = new ArrayList();
            // list.Add("Serkan");
            // list.Add(2);
            // list.Add(true);
            // list.Add('A');

            //içerisinde verilere erişim
            // Console.WriteLine(list[1]);

            // foreach ( var item in list)
            // Console.WriteLine(item);
            
            //AddRange
            Console.WriteLine("**** Add Range ****");
            // string[] renkler = {"kırmızı", "sarı", "yeşil"};

            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

            // list.AddRange(renkler);
            list.AddRange(sayilar);

            foreach(var item in list)
            Console.WriteLine(item);
            
            //Sort
            Console.WriteLine("**** Sort ****");
            list.Sort();

            foreach(var item in list)
            Console.WriteLine(item);

            //Binary Search
            Console.WriteLine("**** Binary Search ****");
            Console.WriteLine(list.BinarySearch(8));

            //Reverse 
            Console.WriteLine("**** Reverse ****");
            list.Reverse();
            
            foreach(var item in list)
            Console.WriteLine(item);
            
            //Clear
            Console.WriteLine("**** Clear ****");
            list.Clear();

            foreach(var item in list)
            Console.WriteLine(item);

            
        }
    }
}