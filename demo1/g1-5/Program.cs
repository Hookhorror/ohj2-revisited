using System;
using System.Collections.Generic;

namespace g1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // int red = 1;
            // int green = 2;
            // int blue = 3;
            // int balls = 4;
            // int colours = 3;
            int[] test = { 0, 0, 0 };

            // testing
            Console.Write("Array:");
            printArray(test);
            Console.WriteLine("Leastsig: {0}", getLeastSignificant(test));
            Console.WriteLine("Index of leastsig: {0}", getIndexOfLeastSign(test));
            Console.Write("Raise binary by one:");
            test = raiseBinaryByone(test, 4);
            printArray(test);
            Console.Write("Raise binary by one:");
            test = raiseBinaryByone(test, 4);
            printArray(test);
            Console.Write("Raise binary by one:");
            test = raiseBinaryByone(test, 4);
            printArray(test);
            Console.Write("Raise binary by one:");
            test = raiseBinaryByone(test, 4);
            printArray(test);

            int[] test2 = new int[10];
            test2 = FillArray(test2, 1);
            printArray(test2);

            List<int[]> test3 = Combinations(3, 3);
            printArraysFromList(test3);

        }

        public static void printArray(int[] a)
        {
            foreach (int index in a)
            {
                Console.Write(" {0}", index);
            }
            Console.WriteLine();
        }

        public static void printArraysFromList(List<int[]> list)
        {
            foreach (var array in list)
            {
                printArray(array);
            }
        }

        public static int getIndexOfLeastSign(int[] a)
        {
            return a.Length - 1;
        }

        public static int getLeastSignificant(int[] a)
        {
            return a[getIndexOfLeastSign(a)];
        }

        public static int[] raiseBinaryByone(int[] a, int variables)
        {
            int[] raised = a;
            {
                for (int i = getIndexOfLeastSign(a); i >= 0; i--)
                {
                    if (raised[i] < (variables - 1))
                    {
                        raised[i]++;
                        return raised;
                    }
                    else
                    {
                        raised[i] = 0;
                    }
                }
                return raised;
            }
        }

        public static List<int[]> Combinations(int howMany, int variables)
        {
            List<int[]> combinations = new List<int[]>();

            int[] combination = new int[howMany];
            int[] lastCombination = FillArray(combination, (variables - 1));
            combinations.Add(combination);
            while (!combination.Equals(lastCombination))
            {
                combination = raiseBinaryByone(combination, variables);
                combinations.Add(combination);
            }
            combinations.Add(lastCombination);

            return combinations;
        }

        public static int[] FillArray(int[] array, int value)
        {
            int[] a = new int[array.Length];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = value;
            }
            Console.WriteLine("jee");
            printArray(array);
            printArray(a);

            return a;
        }
    }
}