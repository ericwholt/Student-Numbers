using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
                new Student("Jimmy", 13),
                new Student("Hannah Banana", 21),
                new Student("Justin", 30),
                new Student("Sarah", 53),
                new Student("Hannibal", 15),
                new Student("Phillip", 16),
                new Student("Maria", 63),
                new Student("Abe", 33),
                new Student("Curtis", 10)
            };

            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            var drinkAgeList = students.Where(s => s.Age >= 21).ToList();
            Console.WriteLine("Students that can legally drink");
            foreach (Student student in drinkAgeList)
                student.PrintInfo();
            Console.WriteLine();
            Student oldestStudent = students.Where(s => s.Age == students.Max(x => x.Age)).ToList()[0];
            Console.WriteLine("Oldest Student");
            oldestStudent.PrintInfo();
            Console.WriteLine();
            Student youngestStudent = students.OrderByDescending(s => s.Age).ToList().Last();
            Console.WriteLine("Youngest Student");
            youngestStudent.PrintInfo();
            Console.WriteLine();
            Student oldestUnder25 = students.Where(s => s.Age < 25).OrderByDescending(x => x.Age).ToList().First();
            Console.WriteLine("Oldest Student Under 25");
            oldestUnder25.PrintInfo();
            Console.WriteLine();
            var evenAgedStudents = students.Where(s => s.Age % 2 == 0).Where(s => s.Age > 21);
            Console.WriteLine("Even Aged Students over 21");
            foreach (Student student in evenAgedStudents)
                student.PrintInfo();
            Console.WriteLine();
            var teenageStudents = students.Where(s => s.Age > 12 && s.Age < 20).ToList();
            Console.WriteLine("Teenage Students");
            foreach (Student student in teenageStudents)
                student.PrintInfo();
            Console.WriteLine();
            // Numbers
            var maxNumber = nums.Max();
            Console.WriteLine("Max Number: "+ maxNumber);
            Console.WriteLine();
            var minNumber = nums.Min();
            Console.WriteLine("Min Number: " + minNumber);
            Console.WriteLine();
            var maxLessThan10000 = nums.Where(n => n < 10000).Max();
            Console.WriteLine("Max < 10000: " + maxLessThan10000);
            Console.WriteLine();

            var maxOddNumber = nums.Max(n => n % 2 == 1);
            Console.WriteLine("Max Odd Number: " + maxOddNumber);
            Console.WriteLine();

            var numbersBetween10And100 = nums.Where(n => n > 10 && n < 100);
            Console.WriteLine("Numbers between 10 and 100");
            foreach (int number in numbersBetween10And100)
                Console.WriteLine($"{number},");
            Console.WriteLine();

            var numbersBetween100000And999999 = nums.Where(n => n >= 100000 && n <= 999999 ).ToList();
            Console.WriteLine("Numbers between 100000 and 999999");
            foreach (int number in numbersBetween100000And999999)
                Console.WriteLine($"{number},");
            Console.WriteLine();

            int countEvenNumbers = nums.Count(n => n % 2 == 0);
            Console.WriteLine("Number of even numbers: " + countEvenNumbers);
            Console.WriteLine();
        }
    }
}
