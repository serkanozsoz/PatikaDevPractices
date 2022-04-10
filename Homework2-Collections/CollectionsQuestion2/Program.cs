using System;

namespace CollectionsQuestion2
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen 20 adet sayının en küçük 3 değeri ve en büyük 3 değerini al
            //her iki grubunda ortalamasını ver ortalama toplamlarını yazdır!
            int[] numbers = new int[20];
            int[] arrMax = new int[3];
            int[] arrMin = new int[3];

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("Please Enter {0}. Number: ", i + 1);
                int number = Convert.ToInt32(Console.ReadLine());
                numbers[i] = number;
            }

            Array.Sort(numbers);
            for (int i = 0; i < 3; i++)
            {
                arrMin[i] = numbers[i];
            }
            Console.WriteLine("Dizideki En küçük 3 Eleman");
            foreach (var item in arrMin)
            {
                Console.WriteLine(item);
            }
            Array.Reverse(numbers);
            for (int i = 0; i < 3; i++)
            {
                arrMax[i] = numbers[i];
            }
            double sumMax = 0;
            foreach (var item in arrMax)
            {
                sumMax += item;
            }
            double sumMin = 0;
            foreach (var item in arrMin)
            {
                sumMin += item;
            }
            double avgMax = sumMax / 3;
            double avgMin = sumMin / 3;
            Console.WriteLine("arrMax's Average : " + avgMax.ToString("F"));
            Console.WriteLine("arrMin's Average : " + avgMin.ToString("F"));
            Console.WriteLine("Sums of Averages : " + (avgMax + avgMin));

        }
    }
}