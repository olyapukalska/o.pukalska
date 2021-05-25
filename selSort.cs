using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class selSort
    {
//        Алгоритм сортування вибором складається з наступних кроків:
        //Для початку визначаємо позицію мінімального елементу масиву;
        //Здійснюємо обмін мінімального елементу з елементом на початку масиву.Виходить, що перший елемент масиву вже відсортовано;
//        Зменшуємо робочу область масиву, відкидаючи перший елемент, а для підмасиву, що залишився, повторюємо сортування.

        //метод для пошуку позиції мінімального елемента підмасиву, починаючи з індексу n
        static int IndexOfMin(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] < array[result])
                {
                    result = i;
                }
            }
            return result;
        }

        //метод для обміну елементів
        static void Swap(ref int x, ref int y)
        {
            var t = x;
            x = y;
            y = t;
        }
        //сортування вибором
        static int[] SelectionSort(int[] array, int currentIndex = 0)
        {
            if (currentIndex == array.Length)
                return array;
            var index = IndexOfMin(array, currentIndex);
            if (index != currentIndex)
            {
                Swap(ref array[index], ref array[currentIndex]);
            }
            return SelectionSort(array, currentIndex + 1);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортування вибором");
            Console.Write("Введіть елементи масиву: ");
            var s = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var a = new int[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                a[i] = Convert.ToInt32(s[i]);
            }
            Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", SelectionSort(a)));
            Console.ReadKey();
        }
    }
}

