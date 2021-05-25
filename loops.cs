using System;

namespace loops
{
    class loops
    {
        
        static void Main(string[] args)
        {
            Task_8_38();
            Task_7_38();
            Task_7_14();
            Task_6_62();
            Task_6_38();
            Task_6_14();
            Task_5_86();
            Task_5_62();
            Task_5_38();
            
            //Task 5.14
            //Вивести таблицю множення на 9
            for (int i = 1; i <= 9; i++)
            {               
                Console.WriteLine($"9 * {i} = { 9 * i}\t");
            }            
        }
        static void Task_5_38()
        {
            //Некий мужчина отправляется на работу, которая нахо-дится на расстоянии 1 км от дома.
            //Дойдя до места работы, он вдруг вспомина-ет, что перед уходом забыл поцеловать жену, и поворачивает назад.
            //Пройдя полпути, он меняет решение, посчитав, что правильнее вернуться на работу.
            //Пройдя 1/3 км по направлению к работе, он вдруг осознает, что будет на - стоящим подлецом, если так и не
            //поцелует жену.
            //На этот раз, прежде чем из - менить мнение, он проходит 1/4 км.Так он продолжает метаться, и после N-этапа,
            //пройдя 1 / N км, снова меняет решение.Определить:
            //а) на каком расстоянии от дома будет находиться мужчина после 100 - го этапа(если допустить, что такое
            //возможно);
            //б) какой общий путь он при этом пройдет.


            int way = 0;
            int distance = 0;

            for (int i = 1; i <= 101; i++)
            {
                if (i % 2 == 0)
                {
                    way -= (1 / i);
                    distance += (1 / i);
                }
                else if (i % 2 != 0)
                {
                    way += (1 / i);
                    distance += (1 / i);
                }
                Console.WriteLine($"Way = {way}");
                Console.WriteLine($"Distance = {distance}");
            }
            Console.ReadKey();
        }
        static void Task_5_62()
        {
            //Известны оценки  по физике  каждого ученика  двух классов.  Определить среднюю оценку в каждом классе.
            //Количество учащихся в каждом классе одинаковое. 
            int[] classs = { 5, 3, 2, 5, 5, 4, 2, 1, 5, 2, 4, 5, 5, 3, 2, 5, 4, 5, 3, 2 };
            float r = 0;
            foreach (int a in classs)
            {
                r += a;
            }
            Console.Write("Middle mark - " + r / classs.Length);
            Console.ReadKey();
        }
        static void Task_5_86()
        {
            //Составить программу возведения натурального числа в квадрат, учитывая следующую закономерность:
            //2 2 2 2 2 11 2 1 3 3 1 3 5 4 1 3 5 7... 1 3 5 7 9... 2 1.n
            Console.Write("n=");
            var n = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                result += i;
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
        static void Task_6_14()
        {
            //Дано число а(1 < а  1, 5).Найти такое наименьшее n, что в последовательно - сти чисел 1 1 2 ,
            //1 1 3 , ..., 1 1 nпоследнее число будет меньше а.
            Console.WriteLine("Input a");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 1;
            int n = 1;
            while (s<=a)
            {
                n += 1;
                s += 1 / n;
            }
            Console.WriteLine($"n = {n}, s = {s}");
            Console.ReadKey();
        }
        static void Task_6_38()
        {
            //Дано натуральное число.Определить, сколько раз в нем встречается первая цифра.
            long number = 7703247967;
            int count = 0;
            while (number != 0)
            {
                if (number % 10 == 7)
                    count++;
                number /= 10;
            }
            Console.WriteLine($"{ count}");
            Console.ReadKey();
        }
        static void Task_6_62()
        {
            //Дана непустая и упорядоченная по возрастанию последовательность целых чисел, оканчивающаяся числом 10 000.
            //Определить порядковый номер перво - го числа, большего заданного n.Если таких чисел в последовательности 
            //нет, то на экран должно быть выведено соответствующее сообщение.
            int Number = 9;
            int temp = 0;
            int[] Array = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10000 };
            for (int i = 0; i < Array.Length; i++)
            {
                if (Array[i] > Number)
                {
                    Console.WriteLine(Array[i] + ":" + i);
                    temp += 1;
                    break;
                }
                else if (temp == 0)
                {
                    Console.WriteLine($"Erorr");
                }
            }            
            Console.ReadLine();
        }
        static void Task_7_14()
        {
           // Даны вещественные числа 1 2 8 , ,..., .a a a Определить сумму тех из них, кото-рые больше 10,75.
            double sum = 0;
            Double[] arr = { 1, 2.3, 11.11, 11.11, 1, 1, 1, 1, 1, 1, 1, 1 };
            foreach (Double a in arr)
            {
                if (a > 10.75)
                {
                    sum += a;
                }
            }
            Console.WriteLine($"Sum = {sum}");
            Console.ReadKey();
        }
        static void Task_7_38()
        {
            //Задано n троек целых чисел a, b, c (a  b  c). 
            //Определить, сколько троек мо - жет быть использовано для построения треугольника со сторонами a, b, c.
            Console.WriteLine("Input a");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input c");
            int c = Convert.ToInt32(Console.ReadLine());
            int j = 0;
            int i = 1;
            for (; ;)
            {
                if ((a<(b+c)) && (a>Math.Abs(b-c)))
                {
                    j += 1;
                }
                Console.WriteLine($"{j}");
            }
            Console.ReadKey();
        }
        static void Task_8_38()
        {
            //два натуральных  числа называются дружественными,  если каждое  из них равно сумме всех делителей 
            //другого(само другое число в качестве делителя не  рассматривается).найти  все пары  натуральных 
            //дружественных  чисел, меньших 50 000.
            for (int i = 1; i < 300; i++)
            {
                int sum1 = 0;
                for (int k = 1; k < i; k++)
                {
                    if (i % k == 0)
                    {
                        sum1 += 1;
                    }
                }
                for (int j = 1; j <= 300; j++)
                {
                    int sum2 = 0;
                    for (int k = 1; k < j; k++)
                    {
                        if (j % k == 0)
                        {
                            sum2 += k;
                        }
                        if ((sum1 == j) && (sum2 == i))
                        {
                            Console.WriteLine($"{i}, {j}");
                        }
                    }
                }
            }
            Console.ReadKey();
        }

    }

}
