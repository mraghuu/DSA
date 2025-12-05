using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2.Levels
{
    internal class LowT
    {

        public LowT() { }


        // 1. Hello world program

        public void HelloWorld() {
            Console.WriteLine("Hello World!");
        }


        //2. Find Maximum in an Array( Write a program to find the largest element in a given array of integers.)

        public void MaxInArray() {

            int number;

            string input;
            int[] arr = { 4, 5, 6, 15, 7, 9, 10};
            Console.WriteLine("we have an array with elements :" + string.Join(", ", arr));
            Console.WriteLine("If you want to go with Array we have then press 'y' and if want to continue with elements you would pass, press 'n'");
            do
            {
                input = Console.ReadLine().ToLower();
                if (input != "y" && input != "n")
                {
                    Console.WriteLine("Invalid input! Please enter 'y' or 'n'.");
                }

            } while (input != "y" && input != "n");

            if (input == "y")
            {
                int max = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] > max){ max = arr[i]; }
                }
                Console.WriteLine("Max element in array is : " + max);
            }
            else
            {
                List<int> list = new List<int>();

                Console.WriteLine("Enter Elements (press 'x' to finish):");

                while (true)
                {
                    Console.Write("Enter integer or 'x': ");
                    input = Console.ReadLine().ToLower();

                    if (input == "x")
                        break;

                    if (int.TryParse(input, out number))
                    {
                        list.Add(number);
                    }
                    else
                    {
                        Console.WriteLine("Invalid integer. Try again.");
                    }
                }
                arr = list.ToArray();

                Console.WriteLine("Updated array: " + string.Join(", ", arr));

                int max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max) max = arr[i];
                }

                Console.WriteLine("Maximum element in your array is: " + max);
            }

        }

    }
}
