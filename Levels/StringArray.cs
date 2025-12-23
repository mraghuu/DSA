using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Levels
{
    internal class StringArray
    {
        public StringArray() { }

        //Beginner DSA Questions(Strings)
        // 1. Reverse a string.

        public void RevString()
        {
            Console.WriteLine("type the string and hit enter");
            string str =  Console.ReadLine();
            string revstring = "";
            //string revstring = new string (str.Reverse().ToArray());      
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstring += str[i];
            }

            Console.WriteLine("Reversed string is " + revstring);
        }


        // 2. Check if a string is a palindrome.

        public void Palin()
        {
            Console.WriteLine("type the string and hit enter");
            string str = Console.ReadLine() ;
            int start = 0;
            int end = str.Length-1;
            for(int i = start; i < end; i++) {
                if (str[i] != str[end])
                {
                    Console.WriteLine("Provided string is not Palindrome..");
                    return;
                }
                start++;
                end--;
            }
            Console.WriteLine("Provide string is a palindrome...");
        }

        // 3. Count vowels and consonants in a string.

        public void Vowels()
        {
            Console.WriteLine("type the string and hit enter");
            string str = Console.ReadLine().ToLower();
            int vowelcount = 0;
            int consonents = 0;
            
            foreach (char ch in str)
            {
                if (ch >= 'a' && ch <= 'z')
                {
                    if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
                    {
                        vowelcount++;
                    }
                    else
                    {
                        consonents++;
                    }
                }
            }
            Console.WriteLine("string has vowels : "+ vowelcount+ " and has consonents : "+ consonents);
        }

        // 4. Find the length of a string without using .Length.

        public void StringLength()
        {
            Console.WriteLine("type the string and hit enter");
            string str = Console.ReadLine().ToLower();
            int count = 0;
            foreach(char ch in str)
            {
                count++;
            }
            Console.WriteLine("String length is : " + count);
        }

        // 5. Convert a string to uppercase without using built-in functions.

        public void UpperString()
        {
            Console.WriteLine("type the string and hit enter");
            string str = Console.ReadLine();
            char[] result = new char[str.Length];
            for(int i =0; i < str.Length; i++)
            {
                char ch = str[i];
                if(ch >= 'a' && ch <= 'z')
                {
                    result[i] = (char)(ch-32);
                }
                else
                {
                    result[i] = ch;
                }
            }
            Console.WriteLine("Uppercase string : "+ result);
        }


        public void xyz()
        {
            Console.WriteLine("type the string and hit enter");
            string[] str = { "apple", "banana", "mango" };
            string[] str1 = { "cat", "dog", "monkey" };

            string[] result = new string[str.Length + str1.Length];
            for (int i = 0; i < str.Length; i++)
            {

                result[i] = str[i];
            }
            result[3] = str[1];
            Console.WriteLine("result Array : " + string.Join(" ,", result));

        }

        // 6. Remove spaces from a string.

        public void SpaceString()
        {
            Console.WriteLine("type the string and hit enter");
            string str = Console.ReadLine();
            string result = "";

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToString() == " ")
                {
                    continue;
                }
                else
                {
                    result += str[i];
                }
            }
            Console.WriteLine("string without spaces : " + result);
        }

        // 7. Count occurrences of a character in a string.

        public void CharCount()
        {


        }
    }
}
