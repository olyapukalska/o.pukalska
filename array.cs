using System;

namespace ConsoleApp2
{
    class array
    {
        static void Main(string[] args)
        {
            Task_11_182();
            Task_11_110();
            Task_11_86();
            Task_11_38();

            //Task_11_14
            //Вывести элементы массива на экран в обратном порядке. 
            int[] myArray = { 1, 2, 3, 4, 5 };
            for (int i = myArray.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
        }
        static void Task_11_38()
        {
            //Дан массив натуральных чисел. Напечатать:
            //а) все элементы массива, являющиеся двузначными числами;
            //б) все элементы массива, являющиеся трехзначными числами.
            int[] myArray = { 2, 3, 200, 99, 64, 999, 77, 4, 42, 103, };
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] > 9 && myArray[i] <= 99)
                {
                    Console.WriteLine($"двузначными числами являющиеся {myArray[i]}");
                }
                else if (myArray[i] > 99 && myArray[i] <= 999)
                {
                    Console.WriteLine($"трехзначными числами являющиеся {myArray[i]}");
                }
            }
            Console.ReadKey();
        }
        static void Task_11_86()
        {
            //Масса каждого из 25 человек хранится в массиве.
            //Людей, имеющих массу более 100 кг, будем условно называть полными(известно, что есть, по меньшей мере,
            //один такой человек). Определить среднюю массу полных людей и среднюю массу остальных людей. 
            int[] people = { 60, 98, 107, 104, 90, 62, 97, 98, 44, 68, 105, 82, 94, 43, 69, 93, 67, 72, 56, 85, 64, 112, 49, 73 };
            int fatMass = 0;
            int thinMass = 0;
            float avg_fat = 0;
            float avg_thin = 0;
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i]>=100)
                {
                    fatMass += people[i];
                    avg_fat = fatMass/avg_fat;

                }
                else
                {
                    thinMass += people[i];
                    avg_thin = thinMass/avg_thin;
                }

            }
            Console.WriteLine($"Fat people: {avg_fat}");
            Console.WriteLine($"Thin people: {avg_thin}");
            Console.ReadKey();
        }
        static void Task_11_110()
        {
            int[] prices = {62, 97, 98, 44, 68, 105, 82, 94, 43, 69, 93, 67, 72, 56, 85, 64, 112, 49, 73 };
            int minValue = prices[0];
            for (int i=1; i<prices.Length; i++)
            {
                if (prices[i] < minValue)
                {
                    minValue = prices[i];
                }
            }
            Console.WriteLine(minValue);
            Console.ReadKey();
        }
        static void Task_11_182()
        {
            //Известно, что в массиве имеются нулевые элементы.
            //Напечатать
            //а) все элементы, кроме первого из них;
            //б) все элементы, кроме последнего из них.
            int[] myArray = new int[10];

            for (int i = 1; i < myArray.Length; i++)
            {
                Console.WriteLine(myArray[i]);
            }

            for (int i=0; i<myArray[9]; i++)
            {
                Console.WriteLine(myArray[i]);
            }
            Console.ReadKey();
        }
        //сортування вибором

    }
}