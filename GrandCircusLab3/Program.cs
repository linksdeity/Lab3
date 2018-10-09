using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab3
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName;

            Console.WriteLine("Please enter your name: ");
            userName = Console.ReadLine();
            Console.WriteLine("Hello, {0}! Let's get started...\n\n\n", userName);

            while (true)
            {
                string userInput;
                char check;
                int user;

                while (true)
                {


                    Console.WriteLine("{0}, please enter a number between 1 and 100: ", userName);
                    userInput = Console.ReadLine();
                    user = int.Parse(userInput);

                    if (user < 1 || user > 100)
                    {
                        Console.WriteLine("Sorry, {0} - Incorrect value!", userName);
                        Console.Write("\n\n");
                    }
                    else
                    {
                        break;
                    }
                }

                if (user == 1)
                {
                    Console.WriteLine("1 and odd");
                }
                else if ((user % 2) == 0)
                {
                    if (user < 25)
                    {
                        Console.WriteLine("Even and less than 25");
                    }
                    else if (user <= 60)
                    {
                        Console.WriteLine("Even");
                    }
                    else if (user > 60)
                    {
                        Console.WriteLine("{0} and Even", user);
                    }
                }
                else
                {
                    Console.WriteLine("{0} and odd", user);
                }

                Console.WriteLine("\n\n{0}, would you like to go again? Type 'y' to go again!", userName);
                check = Console.ReadKey(true).KeyChar;

                if (check != 'y')
                {
                    Console.Clear();
                    Console.WriteLine(" Goodbye, {0}!", userName);
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
