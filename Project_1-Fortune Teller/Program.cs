﻿using System;
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
            Console.WriteLine("Fill out the questionnaire and see what your future holds!");

            Console.WriteLine("What is your first name?");
            string firstName = (Console.ReadLine());

            Console.WriteLine("What is your last name?");
            string lastName = (Console.ReadLine());

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());
            string retire = "";

            if (age % 2 == 0)
            {
                retire = ("You will retire in 30 years.");
            }
            else
            {
                retire = ("You will retire in 1 year!");   
            }

            Console.WriteLine("What month were you born? (\"1-12\")");
            int birthMonth = int.Parse(Console.ReadLine());
            float bank;

            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bank = 4.20f;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bank = 1.01f;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bank = 409.22f;
            }
            else
            {
                bank = 0.0f;
            }

            Console.WriteLine("Whats your favorite ROYGBIV color? \nNot sure what that means? \njust say \"Help.\"");
            string favColor = (Console.ReadLine());
            string favColorCaps = favColor.ToUpper();

            string newColor = "";

 
            if (favColorCaps == "HELP") 
            {
                Console.WriteLine("ROYGBIV stands for \"Red, Orange, Yellow, Green, Blue, Indigo, Violet\". Which is your favorite?");
                favColor = Console.ReadLine();
            }

            switch (favColorCaps)
            {
                case "RED":
                    newColor = ("you'll man a raft");
                    break;
                case "ORANGE":
                    newColor = ("you'll drive a Ferrari");
                    break;
                case "YELLOW":
                    newColor = ("you'll drive a Jeep");
                    break;
                case "GREEN":
                    newColor = ("you'll drive a new Tesla");
                    break;
                case "BLUE":
                    newColor = ("you'll fly in a Private Jet");
                    break;
                case "INDIGO":
                    newColor = ("you'll water whip on a hot jet ski dog");
                    break;
                case "VIOLET":
                    newColor = ("you'll ride a recumbent bike");
                    break;

            }   

            

            Console.WriteLine("How many siblings do you have?");
            int sib = int.Parse(Console.ReadLine());
            string vacation = "";

            
            if (sib == 0)
            {
                vacation = ("Maui");
                
            }
            else if (sib == 1)
            {
                vacation = ("Paris, France");
                
            }
            else if (sib == 2)
            {
                vacation = ("Youngstown,OH");
                
            }
            else if (sib == 3)
            {
                vacation = ("Sidney, Australia");
                
            }
            else
            {
                vacation = ("Your ex's parents backyard");
                
            }

            //final statement

            Console.WriteLine(firstName + " " +  lastName + "," + " your fortune is..." + retire + " With $" + bank + " million dollars in the bank," + "\n" + "a vacation home in " + vacation + ", and " + newColor + ".");

            Console.WriteLine("Thank you for playing!");



        }
    }
}
