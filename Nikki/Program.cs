using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nikki
{
    internal class Program
    {
        //hi chat
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int Oper;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("Osha's very cool homestuck classpect generator");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            while (true)
            {
                string clasSpect = classpectGenerator();
                System.Console.WriteLine(clasSpect);
                System.Console.ReadLine();
                    }
        }
        static string classpectGenerator() 
        {
            string[] bloodcaste = new string[12] { "Rust", "Orange", "Gold", "Lime", "Olive", "Jade", "Teal", "Blue", "Indigo", "Purple", "Violet", "Fuchsia" };
        string[] lunarSway = new string[2] { "Prospit", "Derse" };
        string[] Aspect = new string[12] { "Breath", "Life", "Light", "Time", "Doom", "Blood", "Space", "Void", "Rage", "Mind", "Hope", "heart" };
        string[] Class = new string[12] { "Knight", "Seer", "Mage", "Bard", "Witch", "Heir", "Theif", "Rouge", "Maid", "Sylph", "Prince", "Page" };
        Random rand = new Random();
            string blood = bloodcaste[rand.Next(bloodcaste.Length)];
            string Moon = lunarSway[rand.Next(lunarSway.Length)];
            string classpect2 = Aspect[rand.Next(Aspect.Length)];
            string classpect1 = Class[rand.Next(Class.Length)];
            return  (classpect1 + " of " + classpect2 + ", " +  blood + ", " + Moon);

        }
    }
}
