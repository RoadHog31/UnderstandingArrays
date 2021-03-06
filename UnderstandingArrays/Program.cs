﻿using System;

namespace UnderstandingArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = new int[5];
            //numbers[0] = 1;
            //numbers[1] = 8;
            //numbers[2] = 15;
            //numbers[3] = 16;
            //numbers[4] = 23;

            int[] numbers = { 1, 8, 15, 16, 23 };

            for (int i = 0; i < numbers.Length; i++) 
            {
                Console.WriteLine(numbers[i].ToString());
            }

            string[] names = { "Bob", "Steve", "Brian", "Chuck" };

            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            string myText = "Hello how are you today?"; 
            char[] charArray = myText.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);

            //Console.WriteLine(numbers[1].ToString());
            Console.ReadLine();

        }
    }
}
