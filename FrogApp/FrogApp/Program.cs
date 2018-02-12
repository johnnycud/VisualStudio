using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int runningTotal = 0;
            bool keepGoing = true;

            while (keepGoing)
            {
                //Prompt the user for minutes exercised
                Console.Write("Enter How many minutes you exercised or type \"quit\" to exit:  ");

                string entry = Console.ReadLine();

                 if (entry == "quit")
                {
                keepGoing = false;

                }
                else
                {
                    int minutes = int.Parse(entry);
                    if (minutes <= 10)
                    {
                        Console.WriteLine("Better than nothing I suppose, am I right?");
                    }
                    else if (minutes <= 30)
                    {
                        Console.WriteLine("Way to go hot stuff!");
                    }
                    else if (minutes <= 60)
                    {
                    Console.WriteLine("You must be a ninja warrior in training!");
                    }
                     else
                    {
                        Console.WriteLine("Okay you're only showing off now!");
                    }

                     runningTotal = runningTotal + minutes;

                    //Add minuutes exercised to total
                    //Display total minutes exercised to screen
                    Console.WriteLine("You've entered " + runningTotal + " minutes");
                    //repreat until user quits
                }
            }
            Console.WriteLine("Goodbye!");
        }
    }
}
