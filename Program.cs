/*
 * Author: Nick Zaccaro
 * Date: 02/04/2020
 * Description: This application demonstrates the creation of an automatic filling array
 */
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //create an array to isplay
            int[] numArray = new int[25];

            //create an integer value to display the iteration the for loop will be in
            int pop_Array = 1;

            //a for loop to display each element within the created array
            for(int count = 0; count < 25; count++)
            {
                numArray[count] = pop_Array;
                Console.WriteLine("Element value = " + pop_Array.ToString());
                pop_Array++;
            }

            //to allow user to press any key to exit program
            Console.ReadKey(true);
        }
    }
}
