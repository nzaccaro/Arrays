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

            //a for loop to display each element within the created array
            for(int count = 1; count <= 25; count++)
            {
                numArray[count - 1] = count;
                Console.WriteLine("Element value = " + numArray[count-1].ToString());
            }

            //to allow user to press any key to exit program
            Console.ReadKey(true);
        }
    }
}
