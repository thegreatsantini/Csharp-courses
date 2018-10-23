using System;
using Mosh_course.Math;

namespace Mosh_course
{
    class Program
    {
        static void Main(string[] args)
        {
            var john = new Person();
            john.FristName = "John";
            john.LastName = "Smith";

            john.Introduce();

            Calculator calculator = new Calculator();
            var addNums = calculator.Add(2, 3);
            Console.WriteLine(addNums);
        }
    }
}
