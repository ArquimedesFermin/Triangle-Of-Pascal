using System;
using System.Collections.Generic;

namespace Triangle_Of_Pascal
{
    class Program
    {
        //Cant Rows of triangle
        static int totalRows = 20;     //<-------- Put number of cant rows of triangle.
        //Var
        static int indexOne = 0;
        static int indexTwo = 1;
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
            Console.WriteLine("----------|   Triangle Of Pascal   |----------\n\n");

            for (increment = totalRows; increment != 0; increment--)
            {
                for (childrenWhiteIncrement = 0; childrenWhiteIncrement < increment; childrenWhiteIncrement++)
                    Console.Write(" ");

                for (childrenNumberIncrement = 0; childrenNumberIncrement <= totalRows - increment; childrenNumberIncrement++)
                {
                    if (increment == totalRows)
                    {
                        Console.Write($"  {numberOne}");
                        listOne.Add(numberOne);
                    }
                    else if (increment == totalRows - 1)
                    {
                        Console.Write($"  {numberOne}");
                        listOne.Add(numberOne);
                    }
                    if (increment != totalRows && increment != totalRows - 1)
                    {
                        if (childrenNumberIncrement == 0 || childrenNumberIncrement == totalRows - increment)
                        {
                            Console.Write($"  {numberOne}");
                            listOne.Add(numberOne);
                        }
                        else
                        {
                            resultOperations = listTwo[indexOne] + listTwo[indexTwo];
                            Console.Write($"  {resultOperations}");
                            listOne.Add(resultOperations);
                            indexOne++;
                            indexTwo++;
                        }
                    }
                }
                Console.WriteLine();
                listTwo.Clear();
                listOne.ForEach(x => listTwo.Add(x));
                listOne.Clear();
                indexOne = 0; // Reset Parameter
                indexTwo = 1; // Reset Parameter
            }
            
            Console.WriteLine("\n\n----------|    \"END\"    |----------");
            Console.Read();
        }
    }

}
