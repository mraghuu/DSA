using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2.Levels
{
    internal class StringArray
    {
        public StringArray() { }


        #region Beginner DSA Questions(Strings)
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
            int count = 0;
            Console.WriteLine("type the string and hit enter");
            string str = Console.ReadLine();
            string jch = "";
            for (int i = 0;i < str.Length; i++)
            {
                if (str.IndexOf(str[i]) != i)
                    continue;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                        jch = str[j].ToString();
                    }
                }
                Console.WriteLine("index of Char " + str.IndexOf(str[i]) + " i = " + i + "");
                Console.WriteLine("Char " + str[i] + " occured " + count + " Times");
                
                count = 0;
                jch = "";
            }
        }


        // 8. Check if two strings are equal without using ==.

        public void StrEqual()
        {
            Console.WriteLine("type the 1st string and hit enter");
            string str1 = Console.ReadLine();
            Console.WriteLine("type the 2nd string and hit enter");
            string str2 = Console.ReadLine();

            if (str1.Equals(str2))
            {
                Console.WriteLine("Both string are equal");
            }
            else
            {
                Console.WriteLine("Both string aren't equal");

            }
        }

        #endregion


        #region 🟡 Intermediate DSA Questions (String Arrays)

        //1. Find the largest string in a string array.

        public void LargeString()
        {
            string[] str = { "arvind", "manish", "shrishti", "sudarshan", "raghunandan" };
            string str1 = "";
            int[] str2 = new int[str.Length];
            int len = 0;
            int index = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length > len)
                {
                    len = str[i].Length;
                    index = i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(str[index] + " is the largest string element in array having length " + len);
                
        }

        //2. Find the smallest string in a string array.
        public void SmallString()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan" };
            string str1 = "";
            int[] str2 = new int[str.Length];
            int len = str[0].Length;
            int index = 0;

            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].Length < len)
                {
                    len = str[i].Length;
                    index = i;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine(str[index] + " is the largest string element in array having length " + len);
        }


        //3. Count strings starting with a vowel.

        public void StartWithVow()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" };
            string[] vowel = { "a","e","i","o","u" };
            int count = 0;
            string ch  = "";

            for (int i = 0; i < str.Length; i++)
            {
                ch =(str[i]).ToLower();
                if (ch.StartsWith('a') ||ch.StartsWith('e') ||ch.StartsWith('i') ||ch.StartsWith('o') ||ch.StartsWith('u') )
                {
                    count++;
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine("count of string element in array starting with vowels is :" + count);
        }


        //4. Search for a given string in a string array.

        public void ArraySearch()
        {
            string[] str = { "arvind", "manish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" };
            Console.WriteLine("Array string elements are :" + string.Join(", ",str));
            Console.WriteLine("Type string to be found in array and its index in string: ");
            string str1 = Console.ReadLine();
            int index = 0;
                if (str.Contains(str1))
                {
                    Console.WriteLine("string found in array at index :" + Array.IndexOf(str,str1));
                }
                else
                {
                    Console.WriteLine("string is not found in array");
                }
        }

        //5. Remove duplicate strings from an array.

        public void ArraySearch2()
        {
            string[] str = { "arvind", "manish", "shrishti", "Ohm", "raghunandan", "Ohm", "ishant" };
            Console.WriteLine("Array string elements are :" + string.Join(", ", str));
            List<string> list = new List<string>();
            foreach (string str2 in str)
            {
                if (list.Contains(str2))
                {

                }
                else { list.Add(str2); }
            }
            Console.WriteLine("Array without any repitetive element " + string.Join(", ",list.ToArray()));
        }

        //6. Sort a string array lexicographically.(alphabetically)
        public void SortStrArray()
        {
            string[] str = { "banana", "apple", "cherry", "date" };
            Console.WriteLine("Array string elements are :" + string.Join(", ", str));
            for (int i = 0; i < str.Length - 1; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (string.Compare(str[i], str[j]) > 0)                                 // string.Compare(str[i], str[j])  compares two strings lexicographically.
                    {                                                                       // It returns > 0 if str[i] comes after str[j] alphabetically
                        string temp = str[i];                                               // It returns< 0 if str[i] comes before str[j]
                        str[i] = str[j];                                                    // It returns 0 if both strings are equal
                        str[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array is " + string.Join(", ", str));
        }


        //7. Reverse each string in a string array.
        public void ArrayStrReverse()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" };
            
            Console.WriteLine(string.Join(", ", str));
            for(int i = 0;i < str.Length; i++)
            {
                string temp = "";
                for (int j = str[i].Length -1; j >= 0; j--) {
                    temp += str[i][j];
                }
                str[i] = temp;
            }

            Console.WriteLine("Reversed string array is: " + string.Join(", ", str));
            //Console.WriteLine(str[1^1]);        XOR
            //Console.WriteLine(str[^1]);         

        }

        //8. Find common strings between two string arrays.
        public void CommonStrArray()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" };
            string[] str2 = { "arvind", "shanti", "shrishti", "xyz", "raghunandan", "shal", "ishant" };

            Console.WriteLine(string.Join(", ", str));
            Console.WriteLine(string.Join(", ", str2));
            for (int i = 0; i < str.Length; i++)
            {
                if(str2.Contains(str[i]))
                {
                    Console.WriteLine("Common string found : " + str[i]);
                }
            }    
        }

        //9. Merge two string arrays.
        public void MergeStrArray()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" };
            string[] str2 = { "arvind", "shanti", "shrishti", "xyz", "raghunandan", "shal", "ishant" };
            string[] str3 = new string [str.Length+str2.Length];
            int index= 0;

            Console.WriteLine(string.Join(", ", str));
            Console.WriteLine(string.Join(", ", str2));
            for (int i = 0; i < str3.Length; i++)
            {
                if (i < str.Length)
                {
                    str3[i] = str[i];
                }
                else
                {
                    str3[i] = str2[index];
                    index++;
                }
            }
            
            
            var xyz = str.Concat(str2).Distinct().ToArray();


            
            Console.WriteLine("Merged array is : " + string.Join(", ", str3));
            Console.WriteLine("Merged array is : " + string.Join(", ", str.Concat(str2).Distinct().ToArray()));

        }

        //10. Find the most frequent string in an array.

        public void FreqStrArray()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" ,"arvind", "shanti", "shrishti", "xyz", "raghunandan", "shal", "ishant", "arvind" };
            int max = 0;
            int hold = 0;
            string temp = "";

            Console.WriteLine(string.Join(", ", str));
            for (int i = 0; i < str.Length; i++)
            {
                temp = str[i];
                for (int j = 0; j < str.Length; j++)
                {
                    if(str[j] == temp) { 
                        max++;
                    }
                }
                if (max > hold)
                {
                    hold = max;
                    temp = str[i];
                }
            }
            Console.WriteLine("Frequent string is : " + temp );
        }
        public void FreqStrArrayDict()
        {
            string[] str = { "arvind", "mnish", "shrishti", "sudarshan", "raghunandan", "Ohm", "ishant" ,"arvind", "shanti", "shrishti", "xyz", "raghunandan", "shal", "ishant", "arvind" };

            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (string s in str)
            {
                if (freq.ContainsKey(s)) freq[s]++;
                else freq[s] = 1;
            }
            string result = "";
            int max = 0;
            foreach (var item in freq)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                    result = item.Key;
                }
            }
            Console.WriteLine($"{result} appears {max} times");
        }
        #endregion


        #region 🟠 Advanced DSA Questions(Algorithms on Strings)

        //1. Check if two strings are anagrams.

        public void AnagramStr()
        {
            Console.WriteLine("Enter the first string and hit enter");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the Second string and hit enter");
            string str2 = Console.ReadLine();
            Console.WriteLine($"string 1 is : {str1} and string 2 is : {str2}");

            if (str1.Length != str2.Length)
            {
                Console.WriteLine("Both given strings aren't anagrams");
                return;
            }

            foreach (char ch in str1)
            {
                if (str2.Contains(ch))
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("both given string aren't anagrams");
                    return;
                }
            }
            Console.WriteLine("both given string are anagrams");
        }


        //2. Find the first non-repeating character in a string.
        public void FirstNonRepStr()
        {
            Console.WriteLine("Enter the first string and hit enter");
            string str1 = Console.ReadLine();
            Console.WriteLine($"string 1 is : {str1}");
            Dictionary<char, int> freq = new Dictionary<char, int>(); // use Hashing to keep time complexity efficient

            foreach (char ch in str1)
            {
                if (freq.ContainsKey(ch))
                    freq[ch]++;
                else
                    freq[ch] = 1;
            }

            foreach(char ch in str1)
            {
                if (freq[ch] == 1)
                {
                    Console.WriteLine($"First non-repeating character: {ch}");
                    return;
                }
            }
        }

        //3. Find the longest common prefix in a string array.
        public void LongestPrefixStr()
        {
            string[] str = {"rama", "ram", "ramayana",  };
            Console.WriteLine("Array elements are : " + string.Join(", ",str));

            string first = str[0];

            for(int i = 0;i < str.Length; i++)
            {
                char ch = first[i];
                for(int j =0; j < str.Length; j++)
                {
                    if(i >= str[j].Length ||  str[j][i] != ch)
                    {
                        Console.WriteLine(first.Substring(0,i));
                        return;
                    }
                }
            }
            Console.WriteLine(first);
        }


        //4. Group anagrams together.

        //5. Check if one string is a rotation of another.

        //6. Implement substring search (without using Contains).

        //7. Find all palindromic substrings.

        //8. Compress a string (e.g., aaabbc → a3b2c1).

        #endregion

    }

}
