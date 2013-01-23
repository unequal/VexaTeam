using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Turtle
{
    class Program
    {
         static void Main(string[] args)
        {
             turtle myTurtle = new turtle();
             field Matrica = new field();

             
            {
                int i = 0, j = 0;
                char Function = '0';
                int[,] array;
                array = new int[i, j];
                try
                {
                    do
                    {
                        Console.WriteLine("Enter Function: ");
                        Function = char.Parse(Console.ReadLine());

                        switch (Function)
                        {
                            case 'w':
                               
                            case 'a':
                               
                            case 's':
                                
                            case 'd':
                                
                            default:
                                {
                                    return;
                                }
                        }

                        Console.Clear();
                        Console.ReadLine();
                    }
                    while (Function != 'E');
                }
                catch
                {
                    Console.WriteLine("ERROR");
                    Console.ReadLine();
                }

                return;

            }
        }
    }
}
