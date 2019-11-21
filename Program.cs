using System;
using System.Collections.Generic;

namespace OverloadOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            UseGenericListOfPeople();
            string text = "12314";
            Console.WriteLine(text.IsPalindrome());
        }

        static void UseGenericListOfPeople()
        {
            List<Person> myPeople = new List<Person>();
            myPeople.Add(new Person("Lisa", "Simplson", 9));
            myPeople.Add(new Person("Bart", "Simplson", 7));
            myPeople[0] = new Person("Maggie", "Simpson", 2);
        }
    }
}
