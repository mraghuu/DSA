using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2.Levels
{
    internal class LowT
    {
        public LowT() { }


        // Hello world program

        public void HelloWorld() {
            Console.WriteLine("Hello World!");
        }


        //1. Find Maximum in an Array( Write a program to find the largest element in a given array of integers.)

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

        // 2. Find Minimum in an Array( Write a program to find the smallest element in a given array of integers.)

        public void MinInArray()
        {
            int number;
            string input;
            int[] arr = { 4, 5, 6, 15, 7, 9, 10 };
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
                int min = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < min) { min = arr[i]; }
                }
                Console.WriteLine("Minimum element in array is : " + min);
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
                int min = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] < min) min = arr[i];
                }
                Console.WriteLine("Minimum element in your array is: " + min);
            }
        }

        // 3. Sum of Array Elements (Take an array of integers as input and calculate the sum of all elements.)

        public void SumOfArray()
        {
            int[] arr = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
            int sum = 0;
            for (int i = 0;i <arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Array : " + string.Join(" ,", arr));
            Console.WriteLine(sum);
        }

        // 4. Reverse an Array (Write a program to reverse the elements of an array without using built-in functions.)

        public void ReverseString()
        {
            string str = "raghunandan";
            string rev = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rev += str[i];
            }
            Console.WriteLine("string is : " + str);
            Console.WriteLine("Reversed string is : " + rev);
        }

        // 5. Check Palindrome String (Take a string input from the user and check if it is a palindrome(reads the same forwards and backwards).
        // using two pointer 
        
        public void PalindromeString()
        {
            Console.WriteLine("Enter the string: ");
            string str = Console.ReadLine();
            int left = 0;
            int right = str.Length - 1;
            bool isPalindrome = true;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    isPalindrome = false;
                    break;
                }
                left++;  right--;
            }

            if (isPalindrome)
                Console.WriteLine("The string is a palindrome.");
            else
                Console.WriteLine("The string is not a palindrome.");
        }

        // 6. Count Vowels in a String Write a program that counts the number of vowels(a, e, i, o, u) in a user-provided string.

        public void VowelsInstring()
        {
            Console.WriteLine("Enter the string :");
            string str = Console.ReadLine();
            string[] vowel = { "a", "e", "i", "o", "u" };
            int count = 0;
            for(int i =0;i < str.Length; i++)
            {
                if (vowel.Contains(str[i].ToString()))
                {
                    count++;
                }
            }


            Console.WriteLine("Number of vowels in given string : "+ count);
        }

        // 7. Linear Search in an Array ( Ask the user for a number and check if it exists in the array using linear search.Return the index if found.)

        public void IndexOfElement()
        {
            int[] arr = { 2, 45, 67, 3, 8, 9, 0, 1 };
            Console.WriteLine("Given array elements are : "+string.Join(",", arr));
            string input = Console.ReadLine();
            for(int i = 0; i < arr.Length; i++)
            {
                if(input.ToString() == arr[i].ToString())
                {
                    Console.WriteLine("Element is found and its index is " +i);
                    break;
                }
            }
        }

        // 8. Reverse a Number Take an integer input and reverse its digits. Example: 12345 → 54321

        public void ReverseNumber()
        {
            int num = 123456;
            Console.WriteLine("Given number is " + num);
            string str = num.ToString();
            string output = "";
            for(int i = str.Length -1; i >= 0; i--)
            {
                output += str[i].ToString();
            }
            Console.WriteLine("Reversed of given number is " + Convert.ToInt32(output));
        }

        // 9. Factorial of a Number Calculate the factorial of a given number using a for loop. (Example: 5! = 5×4×3×2×1 = 120)

        public void NumberFactorial()
        {
            int num = 9;
            Console.WriteLine("Given number is : " + num);
            int res = 1;
            for (int i = num;i > 0; i--)
            {
                res *= i;
            }
            Console.WriteLine("The factorial of given number is : " + res);
        }

        //10. Fibonacci Series  Print the first n numbers in the Fibonacci series.  Example: 0, 1, 1, 2, 3, 5, 8, ...

        public void FibonacciN()
        {

        }
    }
}
