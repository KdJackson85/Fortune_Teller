using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1_Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, and welcome to Fortune Teller!");
            Console.WriteLine("Fill out the questionaire and see what your future holds!");
            
            Console.WriteLine("What is your first name?");
            string firstName = (Console.ReadLine());

            Console.WriteLine("What is your last name?");
            string lastName = (Console.ReadLine());

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("What month were you born? (\"MM\")");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Whats your favorite ROYGBIV color? \nNot sure what that means? \njust say \"Help.\"");
            string favColor = (Console.ReadLine());

            Console.WriteLine("How many siblings do you have?");
            int sib = int.Parse(Console.ReadLine());




        }
    }
}
