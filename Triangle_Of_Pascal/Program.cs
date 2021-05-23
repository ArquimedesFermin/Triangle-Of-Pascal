using System;
using System.Collections.Generic;

namespace Triangle_Of_Pascal
{
    class Program
    {
        //Cant Rows of triangle
        static int totalRows = 9;     //<-------- Put number of cant rows of triangle.

        //Var
        static int a = 0;
        static int b = 1;
        static int increment = 0;
        static int childrenWhiteIncrement = 0;
        static int childrenNumberIncrement = 0;
        static int resultOperations = 0;
        const int numberOne = 1;

        //Arrays
        static List<int> listOne = new List<int>(); //Main List 
        static List<int> listTwo = new List<int>(); //List One Duplicate
        static void Main(string[] args)
        {
            Console.WriteLine("----------|   Triangle Of Pascal   |----------");
            Console.WriteLine();
            Console.WriteLine();

            BuildTrianglePascal();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("----------|    END    |----------");
            Console.Read();
        }
        private static void BuildTrianglePascal()
        {
            for (increment = totalRows; increment != 0; increment--)
            {
                SpaceWhiteDraw();
                NumberTriangleDraw();
                Console.WriteLine();
                ListOneToListTwo();
            }
        }
        private static void NumberTriangleDraw()
        {
            for (childrenNumberIncrement = 0; childrenNumberIncrement <= totalRows - increment; childrenNumberIncrement++)
            {
                if (increment == totalRows)
                {
                    PutNumberOne();
                }
                else if (increment == totalRows - 1)
                {
                    PutNumberOne();
                }
                if (increment != totalRows && increment != totalRows - 1)
                {
                    if (childrenNumberIncrement == 0 || childrenNumberIncrement == totalRows - increment)
                    {
                        PutNumberOne();
                    }
                    else
                    {
                        DoCalculation();
                    }
                }
            }
        }
        private static void SpaceWhiteDraw()
        {
            for (childrenWhiteIncrement = 0; childrenWhiteIncrement < increment; childrenWhiteIncrement++)
                Console.Write(" ");
        }
        private static void DoCalculation()
        {
            resultOperations = listTwo[a] + listTwo[b];
            Console.Write($"  {resultOperations}");
            listOne.Add(resultOperations);
            a++;
            b++;
        }
        private static void PutNumberOne()
        {
            Console.Write($"  {numberOne}");
            listOne.Add(numberOne);
        }
        private static void ListOneToListTwo()
        {
            listTwo.Clear();
            listOne.ForEach(x => listTwo.Add(x));
            listOne.Clear();
            a = 0; // Reset Parameter
            b = 1; // Reset Parameter
        }
    }
}
