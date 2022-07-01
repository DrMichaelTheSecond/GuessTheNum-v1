using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritum
{
    class Program
    {
        static void Main(string[] args)
        {
            Loop:
            bool playagain = true;
            while (playagain)
            {
                int m = 100;
                Console.WriteLine("Type 'Start' to start the code:\n");
                string str = Console.ReadLine().ToLower();
                if (str == "start")
                {
                    int y = m / 2;
                    Console.WriteLine("I guess 50! Tell me if it's lower or higher or I guessed:\n");
                    string lh = Console.ReadLine().ToLower();
                    if (lh == "lower")
                    {
                        int x = y / 2;
                        Console.WriteLine("I guess " + x + "! Tell me if it's lower or higher or I guessed:\n");
                        string lh1 = Console.ReadLine().ToLower();
                        if (lh1 == "lower")
                        {
                            int a = y / 2;
                            Console.WriteLine("I guess " + x + "! Tell me if it's lower or higher or I guessed:\n");
                            string lh2 = Console.ReadLine().ToLower();
                            if (lh2 == "lower")
                            {

                            }
                            else if (lh2 == "higher")
                            {

                            }
                            else if (lh2 == "guessed")
                            {

                            }
                        }
                    }
                    else if(lh == "higher")
                    {
                        int z = y + (y / 2);
                        Console.WriteLine("I guess " + z + "! Tell me if it's lower or higher or I guessed:\n");
                        string lh2 = Console.ReadLine().ToLower();
                    }
                    else if(lh == "guessed")
                    {
                        Console.WriteLine("Cool! Do you want to play again?\nType 'Yes' or 'No':\n");
                        string pa = Console.ReadLine().ToLower();
                        if(pa == "yes")
                        {
                            playagain = true;
                            goto Loop;
                        }
                        if(pa == "no")
                        {
                            playagain = false;
                            goto end;
                        }
                    }





                }

            }
            end:
            Console.WriteLine("Goodbye!");
            Environment.Exit(0);
            //this.Close();
        }
    }
}
