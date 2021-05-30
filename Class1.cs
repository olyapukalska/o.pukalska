using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    static class Class1
    {
        //В методе Main()


        public static void Main()
        {
            var s = new Student(
                new Person("Орк", "Рыжий", new DateTime(2000, 2, 2)),
                Education.SecondEducation,
                21
            );
            Console.WriteLine(s.ToShortString());
            Console.WriteLine("");

            foreach (Education element in Enum.GetValues(typeof(Education)))
                Console.WriteLine($"{element} = {s[element]}");

            Console.WriteLine("");

            Console.WriteLine(s);
            Console.WriteLine("");

            s.AddExams(
                new Exam("Плевание в потолок", 2, new DateTime(2005, 2, 2)),
                new Exam("Поедание конфет", 3, new DateTime(2005, 2, 2)),
                new Exam("Разбивание черепа врага", 10, new DateTime(2005, 2, 2)),
                new Exam("Сквернословие", 12, new DateTime(2005, 2, 2)),
                new Exam("", 3, new DateTime(2005, 2, 2)));

            Console.WriteLine(s);
            Console.WriteLine("");

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }

        public int BirthYear
        {
            get => this.Birthday.Year;
            set => this.Birthday = new DateTime(value, this.Birthday.Month, this.Birthday.Day);
        }

        public Person(string name, string surname, DateTime birthday)
        {
            this.Name = name;
            this.Surname = surname;
            this.Birthday = birthday;
        }

        public Person()
        {
            this.Name = "Вася";
            this.Surname = "Пупкин";
            this.Birthday = new DateTime(2000, 1, 1);
        }

        public override string ToString() => $"{this.Name} {this.Surname} [{this.Birthday:dd.MM.yy}]";

        public virtual string ToShortString() => $"{this.Name} {this.Surname}";
    }

    public enum Education
    {
        Specialist,
        Вachelor,
        SecondEducation
    }

    public class Exam
    {
        public string Subject { get; set; }
        public int Mark { get; set; }
        public DateTime Date { get; set; }

        public Exam(string subject, int mark, DateTime date)
        {
            this.Subject = subject;
            this.Mark = mark;
            this.Date = date;
        }

        public Exam()
        {
            this.Date = new DateTime(2000, 1, 1);
        }

        public override string ToString() => $"{this.Subject} [{this.Date:dd.MM.yy}] = {this.Mark} ";
    }
}
