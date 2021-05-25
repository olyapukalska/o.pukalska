using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class InsSort
    {
        //        Алгоритм роботи сортування включенням наступний:
        //на початку роботи впорядкована частина порожня;
        //        додаємо в неї перший елемент масиву з не впорядкованих даних;
        //        переходимо до наступного елементу в невідсортованих даних, і знаходимо йому правильну позицію у
        //        відсортованій частині масиву, цим ми розширюємо область впорядкованих даних;
        //        повторюємо попередній крок для всіх елементів, що залишилися.
        //метод обміну елементів
        static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }

        //сортування вставками
        static int[] InsertionSort(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                var key = array[i];
                var j = i;
                while ((j > 1) && (array[j - 1] > key))
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }

                array[j] = key;
            }

            return array;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Сортування включенням");
            Console.Write("Введіть елементи масиву: ");
            var parts = Console.ReadLine().Split(new[] { " ", ",", ";" }, StringSplitOptions.RemoveEmptyEntries);
            var array = new int[parts.Length];
            for (int i = 0; i < parts.Length; i++)
            {
                array[i] = Convert.ToInt32(parts[i]);
            }

            Console.WriteLine("Впорядкований масив: {0}", string.Join(", ", InsertionSort(array)));

            Console.ReadLine();
        }
    }
}
