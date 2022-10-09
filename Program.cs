using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bucketprogram
{
    internal class Program
    {
        // global variables 
        static int options;
        static void Main()
        {
           // CALLS THE METHOD 
            Menu();
           
        }
        static void Menu()
        {
            // WELCOME THE USER TO MACHINES AND PROVIDE IPTIONS 
            Console.WriteLine("*************************************");
            Console.WriteLine("welcome to koenas vending machine   &");
            Console.WriteLine("                                    &");
            Console.WriteLine("OPTION1; 250 ML DRINK               & ");
            Console.WriteLine("OPTION2; 350 ML DRINK               & ");
            Console.WriteLine("EXIT THE MACHINE                    &");
            Console.WriteLine("                                    &");
            Console.WriteLine("*************************************");
            Console.WriteLine();
            // ASK THE USER TO ENTER THE OPTIONS  AND ECHOS IT BACK 
            Console.WriteLine("please enter menu option ");
            options = Convert.ToInt32(Console.ReadLine());
            // THE USER WILL NOT LEAVE THE WHILE UNTIL THEY IMPUTE THE CORRECT MENU OPTIONS 
            while(options <1 || options >3)
            {
                Console.WriteLine("incorrect input try again");
                Console.ReadKey();
                Main();

            }
            while(options == 1)
            {
                //calls the method 
                option1();
                Console.WriteLine();
                Console.WriteLine("press 1 or 2 to but a drink or press 3 to exit  ");
                options = Convert.ToInt32(Console.ReadLine());
            }
            while (options == 2)
            {
                //calls the method 
                option2();
                Console.WriteLine();
                Console.WriteLine("press 1 or 2 to but a drink or press 3 to exit  ");
                options = Convert.ToInt32(Console.ReadLine());
               
            }

            // this statement is to exit the program
           if (options == 3)
            {
                ExitProgram();
           }
        }
        static void option1()
        {
            // prints the number of cycles that the stars must be 
            for (int couter = 0; couter < 5; couter++)
            {
                Console.Write("* ");

                for (int counter2 = 0; counter2 < 2; counter2++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("* ");
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write("* ");
                Console.WriteLine();
            }

            for (int couter3 = 0; couter3 < 4; couter3++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
            Console.WriteLine("250 ml of coke ");
        }
        static void option2()
        {
            //prints the 
                for (int couter = 0; couter < 7; couter++)
                {
                    Console.Write("* ");

                    for (int counter2 = 0; counter2 < 4; counter2++)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("* ");
                    }


                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.Write("* ");
                    Console.WriteLine();
                }

                for (int couter3 = 0; couter3 <6; couter3++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            Console.WriteLine("350 ml of coke ");
        }
        static void ExitProgram()
        {
            // prompt message when the user leaves the machine 
            Console.WriteLine("press any key to exit ");
            Console.ReadKey();
        }
    }
}
