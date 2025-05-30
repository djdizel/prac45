using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person<int> tom = new Person<int>(546, "Tom");
            Person<string> bob = new Person<string>("a1", "Bob");
            Company < Person<int>> microsoft = new Company<Person<int>>(tom);
            //int tomId = (int)tom.Id; 
            //string bobId = (string)bob.Id; 
            int tomId = tom.Id;
            string bobId = bob.Id;
            Console.WriteLine($"Tom's ID: {tomId}, Name: {tom.Name}");
            Console.WriteLine($"Bob's ID: {bobId}, Name: {bob.Name}");
            Console.WriteLine($"Microsoft's CEO: {microsoft.CEO.Name}");
            Console.WriteLine($"Microsoft's CEO ID: {microsoft.CEO.Id}");

        }
    }
}
