using System;
using System.Numerics;
using System.Threading.Channels;

namespace _01_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Console App"; //sets console window title.

            // Set buffer and window width
            Console.BufferWidth = 200;  // Total width of buffer (horizontal scroll)
            Console.WindowWidth = 150;  // Visible window width

            // Set buffer and window height
            Console.BufferHeight = 40;
            Console.WindowHeight = 30;

            Console.ForegroundColor = ConsoleColor.Yellow;//Changes text colors.
            Console.WriteLine("Hi My Name is Abdullah Hussein.");//Writes data followed by a new line.

            Console.Clear();//Clears the screen.
            Console.BackgroundColor = ConsoleColor.Red; //Changes background colors.
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("I am ");//Writes data without a newline.
            Console.Write("Backend Developer.\n");

            Console.BackgroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.Beep();// plays a beep sound.                 
            Console.Beep(1000, 500);// You can also specify frequency and duration

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();//Reads a full line of text.
            Console.WriteLine($"Hi Mr {name}");

            Console.WriteLine("Enter your Class");
            int ascii = Console.Read();//Reads the next character (returns int ASCII code).
            char ch = (char)ascii;
            Console.WriteLine($"Your Class is {ch}");


            ConsoleKeyInfo key = Console.ReadKey();//Reads a single key input.
            Console.WriteLine("\nYou pressed: " + key.Key);
        }
    }
}
