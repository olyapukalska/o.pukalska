using System;

namespace ConsoleApp1
{
    class if_and_switch
    {
        static void Main(string[] args)
        {
            Task_4_124();
            Task_4_115();
            Task_4_46();
            Task_4_104();
            Metanit_1();
            Metanit_2();
            Metanit_3();
            Metanit_4();
            Metanit_5();
            Metanit_6();
            Metanit_7();
            Task_4_14();
            Task_4_30();

            //lab1
            string buf;

            Console.WriteLine("Input alfa");
            buf = Console.ReadLine();
            double a = double.Parse(buf);

            double z1 = (Math.Cos(a) + Math.Sin(a)) / (Math.Cos(a) - Math.Sin(a));
            double z2 = Math.Tan(2 * a) + (1 / Math.Cos(a));

            Console.WriteLine(a);
            Console.WriteLine("Result =" + z1);
            Console.WriteLine("Result =" + z2);
        }
         static void Metanit_1()
         {
             Console.WriteLine("Input a");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input b");
             int b = Convert.ToInt32(Console.ReadLine());

             if (a > b)
             {
                 Console.WriteLine("The first number is more than second number.");
             }
             else if (a < b)
             {
                 Console.WriteLine("The second number is more than first number.");
             }
             else
             {
                 Console.WriteLine("Both numbers are equal.");
             }
             Console.ReadKey();
         }
         static void Metanit_2()
         {
             Console.WriteLine("Input a number");
             int num = Convert.ToInt32(Console.ReadLine());

             if (num > 5 && num < 10)
             {
                 Console.WriteLine("The number is more 5 and less 10");
             }
             else
             {
                 Console.WriteLine("Unknown number");
             }
             Console.ReadKey();
         }
         static void Metanit_3()
         {
             Console.WriteLine("Input a number");
             int num = Convert.ToInt32(Console.ReadLine());
             if (num > 5 || num < 10)
             {
                 Console.WriteLine("The number equal 5 or equal 10");
             }
             else
             {
                 Console.WriteLine("Unknown number");
             }
             Console.ReadKey();
         }
         static void Metanit_4()
         {
             Console.WriteLine("Input amount");
             double sum = Convert.ToDouble(Console.ReadLine());

             if (sum < 100)
             {
                 sum += sum * 0.05;
             }
             else if (sum > 100 && sum < 200)
             {
                 sum += sum * 0.07;
             }
             else if (sum > 200)
             {
                 sum += sum * 0.1;
             }
             Console.WriteLine($"The amount is { sum }");
             Console.ReadKey();
         }
         static void Metanit_5()
         {
             Console.WriteLine("Input amount");
             double sum = Convert.ToDouble(Console.ReadLine());
             double bonus = 0;

             if (sum < 100)
             {
                 bonus = 0.05;
             }
             else if (sum > 100 && sum < 200)
             {
                 bonus = 0.07;
             }
             else if (sum > 200)
             {
                 bonus = 0.1;
             }
             sum += sum * bonus + 15;
             Console.WriteLine($"The amount is { sum }");
             Console.ReadKey();
         }
         static void Metanit_6()
         {
             Console.WriteLine("Input number of operation:");
             int num = Convert.ToInt32(Console.ReadLine());

             switch (num)
             {
                 case 1:
                     Console.WriteLine("Addition");
                     break;
                 case 2:
                     Console.WriteLine("Subtraction");
                     break;
                 case 3:
                     Console.WriteLine("Multiplication");
                     break;
                 default:
                     Console.WriteLine("Wrong operation");
                     break;
             }
             Console.ReadKey();
         }
         static void Metanit_7()
         {
             Console.WriteLine("Input number of operation:");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input a");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input b");
             int b = Convert.ToInt32(Console.ReadLine());

             int operation = Convert.ToInt32(Console.ReadLine());
             int res = 0;
             switch (num)
             {
                 case 1:
                     res = a + b;
                     Console.WriteLine("Addition");
                     break;
                 case 2:
                     res = a - b;
                     Console.WriteLine("Subtraction");
                     break;
                 case 3:
                     res = a * b;
                     Console.WriteLine("Multiplication");
                     break;
                 default:
                     Console.WriteLine("Wrong operation");
                     break;
             }
             Console.ReadKey();
         }
         static void Task_4_14()
         {
             Console.Write("Введіть коефіцієнт а");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.Write("Введіть коефіцієнт b");
             int b = Convert.ToInt32(Console.ReadLine());
             Console.Write("Введіть коефіцієнт c");
             int c = Convert.ToInt32(Console.ReadLine());

             double d = b * b - 4 * a * c;
             if (d > 0)
             {
                 double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                 double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                 Console.WriteLine($"Корені рівняння {x1}, {x2}");
             }
             else if (d == 0)
             {
                 double x = -b / (2 * a);
                 Console.WriteLine($"Корінь рівняння {x}");
             }
             else
             {
                 Console.WriteLine("Розв'язків немає");
             }
             Console.ReadKey();
         }
         static void Task_4_30()
         {
             Console.WriteLine("Input the number");
             int num = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input alpha");
             int a = Convert.ToInt32(Console.ReadLine());

             double b = num / 100;
             double c = num / 10;
             double x = a + b + c;
             double y = a * b * c;

             if ((x > 9) && (x < 100))
             {
                 Console.WriteLine($"Сума цифр є двозначним числом");
             }
             else if ((y > 99) && (y < 1000))
             {
                 Console.WriteLine($"Є трьохзначним числом");
             }
             else if (y > a)
             {
                 Console.WriteLine($"Альфа більше даного числа");
             }   
             Console.ReadKey();
         }
         static void Task_4_46()
         {
             Console.WriteLine("Input a");
             int a = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input b");
             int b = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("Input c");
             int c = Convert.ToInt32(Console.ReadLine());

             if ((a==b) && (a==c) && (b==c))
             {
                 Console.WriteLine($"The triangle is equilateral");
             }
             else
             {
                 Console.WriteLine($"Erorr");
             }
             Console.ReadKey();
         }
         static void Task_4_104()
         {
             Console.WriteLine("Input the numbers from 1 to 7");
             int num = Convert.ToInt32(Console.ReadLine());
             switch(num)
             {
                 case 1:
                     Console.WriteLine("Monday");
                     break;
                 case 2:
                     Console.WriteLine("Tuesday");
                     break;
                 case 3:
                     Console.WriteLine("Wednesday");
                     break;
                 case 4:
                     Console.WriteLine("Thursday");
                     break;
                 case 5:
                     Console.WriteLine("Friday");
                     break;
                 case 6:
                     Console.WriteLine("Saturday");
                     break;
                 case 7:
                     Console.WriteLine("Sunday");
                     break;
             }
             Console.ReadKey();
         }
         static void Task_4_115()
         {
             Console.WriteLine("Input year");
             int year = Convert.ToInt32(Console.ReadLine());

             switch ((year - 1984) % 12)
             {
                 case 1:
                     switch (year % 10)
                     {
                         case 0:
                             Console.WriteLine("The white mouse");
                             break;
                         case 6:
                             Console.WriteLine("The red mouse");
                             break;
                         case 8:
                             Console.WriteLine("The yellow mouse");
                             break;
                         case 4:
                             Console.WriteLine("The green mouse");
                             break;
                         case 2:
                             Console.WriteLine("The blue mouse");
                             break;
                     } 
                     break;
                 case 2:
                     switch (year % 10)
                     {
                         case 1:
                             Console.WriteLine("The white bull");
                             break;
                         case 7:
                             Console.WriteLine("The red bull");
                             break;
                         case 9:
                             Console.WriteLine("The yellow bull");
                             break;
                         case 5:
                             Console.WriteLine("The green bull");
                             break;
                         case 3:
                             Console.WriteLine("The blue bull");
                             break;
                     } 
                     break;
                 case 3:
                     switch (year % 10)
                     {
                         case 0:
                             Console.WriteLine("The white tiger");
                             break;
                         case 6:
                             Console.WriteLine("The red tiger");
                             break;
                         case 8:
                             Console.WriteLine("The yellow tiger");
                             break;
                         case 4:
                             Console.WriteLine("The green tiger");
                             break;
                         case 2:
                             Console.WriteLine("The blue tiger");
                             break;
                     } 
                     break;
                 case 4:
                     switch (year % 10)
                     {
                         case 1:
                             Console.WriteLine("The white rabit");
                             break;
                         case 7:
                             Console.WriteLine("The red rabit");
                             break;
                         case 9:
                             Console.WriteLine("The yellow rabit");
                             break;
                         case 5:
                             Console.WriteLine("The green rabit");
                             break;
                         case 3:
                             Console.WriteLine("The blue rabit");
                             break;
                     } 
                     break;
                 case 5:
                     switch (year % 10)
                     {
                         case 0:
                             Console.WriteLine("The white dragon");
                             break;
                         case 6:
                             Console.WriteLine("The red dragon");
                             break;
                         case 8:
                             Console.WriteLine("The yellow dragon");
                             break;
                         case 4:
                             Console.WriteLine("The green dragon");
                             break;
                         case 2:
                             Console.WriteLine("The blue dragon");
                             break;
                     } 
                     break;
                 case 6:
                     switch (year % 10) //змея
                     {
                         case 1:
                             Console.WriteLine("The white snake");
                             break;
                         case 7:
                             Console.WriteLine("The red snake");
                             break;
                         case 9:
                             Console.WriteLine("The yellow snake");
                             break;
                         case 5:
                             Console.WriteLine("The green snake");
                             break;
                         case 3:
                             Console.WriteLine("The blue snake");
                             break;
                     } 
                     break;
                 case 7:
                     switch (year % 10)
                     {
                         case 0:
                             Console.WriteLine("The white hourse");
                             break;
                         case 6:
                             Console.WriteLine("The red hourse");
                             break;
                         case 8:
                             Console.WriteLine("The yellow hourse");
                             break;
                         case 4:
                             Console.WriteLine("The green hourse");
                             break;
                         case 2:
                             Console.WriteLine("The blue hourse");
                             break;
                     } 
                     break;
                 case 8:
                     switch (year % 10)
                     {
                         case 1:
                             Console.WriteLine("The white sheep");
                             break;
                         case 7:
                             Console.WriteLine("The red sheep");
                             break;
                         case 9:
                             Console.WriteLine("The yellow sheep");
                             break;
                         case 5:
                             Console.WriteLine("The green sheepа");
                             break;
                         case 3:
                             Console.WriteLine("The blue sheep");
                             break;
                     } 
                     break;
                 case 9:
                     switch (year % 10)
                     {
                         case 0:
                             Console.WriteLine("The white monkey");
                             break;
                         case 6:
                             Console.WriteLine("The red monkey");
                             break;
                         case 8:
                             Console.WriteLine("The yellow monkey");
                             break;
                         case 4:
                             Console.WriteLine("The green monkey");
                             break;
                         case 2:
                             Console.WriteLine("The blue monkey");
                             break;
                     } 
                     break;
                 case 10:
                     switch (year % 10)
                     {
                         case 1:
                             Console.WriteLine("The white rooster");
                             break;
                         case 7:
                             Console.WriteLine("The red rooster");
                             break;
                         case 9:
                             Console.WriteLine("The yellow rooster");
                             break;
                         case 5:
                             Console.WriteLine("The green rooster");
                             break;
                         case 3:
                             Console.WriteLine("The blue rooster");
                             break;
                     } 
                     break;
                 case 11:
                     switch (year % 10)
                     {
                         case 0:
                             Console.WriteLine("The white dog");
                             break;
                         case 6:
                             Console.WriteLine("The red dog");
                             break;
                         case 8:
                             Console.WriteLine("The yellow dog");
                             break;
                         case 4:
                             Console.WriteLine("The green dog");
                             break;
                         case 2:
                             Console.WriteLine("The blue dog");
                             break;
                     } 
                     break;
                 case 12:
                     switch (year % 10)
                     {
                         case 1:
                             Console.WriteLine("The white pig");
                             break;
                         case 7:
                             Console.WriteLine("The red pig");
                             break;
                         case 9:
                             Console.WriteLine("The yelllow pig");
                             break;
                         case 5:
                             Console.WriteLine("The green pig");
                             break;
                         case 3:
                             Console.WriteLine("The blue pig");
                             break;
                     } 
                     break;
                 default:
                     break;
             }
             Console.ReadKey();
         }
        static void Task_4_124()
        {
            //Даны вещественные положительные числа a, b, c.Выяснить существует ли тре-
            //угольник со сторонами a, b, c. 
            Console.Write("Input а");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input c");
            int c = Convert.ToInt32(Console.ReadLine());

            //сума 2-х сторін має бути більша за третю
            if (((a > b) && (a > c) && (a < b + c)) || ((b > a) && (b > c) && (b < a + c)) || ((c > a) && (c > b) && (c < a + b)))
            {
                Console.WriteLine("The triangle exists");
            }
            else
            {
                Console.WriteLine("The triangle doesn't exist");
            }
            Console.ReadKey();
        }     
    }

}
