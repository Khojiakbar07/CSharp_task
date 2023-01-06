using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Juan");
            Person person2 = new Person("Sara");
            Person person3 = new Person("Carlos");
            Console.WriteLine("Hello! My name is " + person1.name);
            Console.WriteLine("Hello! My name is " + person2.name);
            Console.WriteLine("Hello! My name is " + person3.name);

            Console.ReadLine();
        }
    }
}
