﻿using System;

namespace QuickSort2
{
    class Program
    {
        //array of integers to hold values
        private int[] arr = new int[20];
        private int cmp_count = 0; //number of comparasion
        private int mov_count = 0; //number of data movements

        // Number of elements in array
        private int n;


        void input()
        {
            while (true)
            {
                Console.Write("Enter the umber of elementsin the array :");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if (n <= 20)
                    break;
                else
                    Console.WriteLine("\nArray can have maximum 20 elements \n");
            }
            Console.WriteLine("\n================================");
            Console.WriteLine("Enter Array Elements");
            Console.WriteLine("\n================================");

            //get array elements
            for (int i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                string s1 = Console.ReadLine();
                arr[1] = Int32.Parse(s1);
            }
        }
        //swaps the element at index x with the element at i
            }

        }
    }
}