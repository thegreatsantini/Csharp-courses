using System;
namespace Mosh_course
{
    public class Person
    {
        public string FristName;
        public string LastName;

        public void Introduce()
        {
            Console.WriteLine("my name is " + FristName + " " + LastName);
        }
    }
}
