using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Turtle
{
    class field
    {
        static void Field(string[] args)
        {
            int z = 0;
            int x = 0;
            int s = 0;
            int c = 0;
            using (StreamReader sr = new StreamReader("Матрица.txt"))
                c = Convert.ToInt32(sr.ReadLine());

            int[,] array;
            array = new int[c, c];

            for (int i = 0; i < c; i++)
            {
                for (int q = 0; q < c; z++)
                {
                    array[i, z] = 0;
                }
            }
            for (int i = 0; i < c; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(array[i, j]);
                }
                Console.WriteLine();
            }

            using (StreamReader sr = new StreamReader("Матрица.txt"))
                z = Convert.ToInt32(sr.ReadLine());

            using (StreamReader sr = new StreamReader("Матрица.txt"))
                x = Convert.ToInt32(sr.ReadLine());

            if (s != 0)
            {
                Console.Clear();
            }
            Console.ReadLine();
        }
    }
}