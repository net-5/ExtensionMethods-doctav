using System;
using System.Text;

namespace ExtensionMethodsProject
{
    //Capital letter
    //Write an extension method to check if a string starts with a capital letter or not.

    //Pluralize
    //Write an extension method that appends an ‘s’ to a string.
    //Ex:
    //input : method
    //output:methods

    //Capitalize word
    //Write an extension method that will capitalize a word.
    //Input: mom
    //Output: Mom

    //Capitalize and pluralize
    //Write a program that will capitalize a string , and pluralize the same string.
    //You cand write a new extension method or use what you already have.

    //Character count
    //Write an extension method what will count the number of characters in a string.

    //Apply VAT
    //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Here are some extensions by DOCTAV");

            string mesaj = "to be or not to be, that's the question";
            //Capital letter
            //Write an extension method to check if a string starts with a capital letter or not.
            Console.WriteLine($"Starts with uppercase? : {mesaj.StartsWithUpperCase()}");

            //Pluralize
            //Write an extension method that appends an ‘s’ to a string.
            //Ex:
            //input : method
            //output:methods
            Console.WriteLine($"Pluralize:  {mesaj.Pluralize()}");

            //Capitalize word
            //Write an extension method that will capitalize a word.
            //Input: mom
            //Output: Mom
            Console.WriteLine($"Capitalize: {mesaj.Capitalize()}");

            //Capitalize and pluralize
            //Write a program that will capitalize a string , and pluralize the same string.
            //You cand write a new extension method or use what you already have.
            Console.WriteLine($"Capitalize and Pluralize: {mesaj.CapitalizeAndPluralize()}");
            //Character count
            //Write an extension method what will count the number of characters in a string.
            Console.WriteLine($"Number of characters: {mesaj.CharacterCount()}");

            //Apply VAT
            //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
            decimal price = 111;
            Console.WriteLine($"VAT for the price {price} is {price.VAT24()}");

            int priceInt = 120;
            Console.WriteLine($"VAT for the price {priceInt} is {priceInt.VAT24()}");
        }
    }

    static class ExtensionsDoctav
    {
        //Capital letter
        //Write an extension method to check if a string starts with a capital letter or not.
        public static bool StartsWithUpperCase(this string str)
        {
            if (str != string.Empty)
            {
                if (str[0] == char.ToUpper(str[0]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Pluralize
        //Write an extension method that appends an ‘s’ to a string.
        //Ex:
        //input : method
        //output:methods
        public static string Pluralize(this string str)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(str);
            sb.Append('s');
            return sb.ToString();
        }

        //Capitalize word
        //Write an extension method that will capitalize a word.
        //Input: mom
        //Output: Mom
        public static string Capitalize(this string str)
        {
            if(str != string.Empty)
            {
                char firstChar = str[0];
                firstChar = char.ToUpper(firstChar);
                StringBuilder sb = new StringBuilder();
                sb.Append(firstChar);
                sb.Append(str.Substring(1));
                return sb.ToString();
            }
            else
            {
                return str;
            }
        }

        //Capitalize and pluralize
        //Write a program that will capitalize a string , and pluralize the same string.
        //You cand write a new extension method or use what you already have.
        public static string CapitalizeAndPluralize(this string str)
        {
            return str.Capitalize().Pluralize();
        }

        //Character count
        //Write an extension method what will count the number of characters in a string.
        public static int CharacterCount(this string str)
        {
            return str.Length;
        }

        //Apply VAT
        //Write an extension method that will apply a VAT of 24% on an input.This input can be a decimal value, or an integer on
        public static decimal VAT24(this decimal value)
        {
            return 0.24m * value;
        }
        public static decimal VAT24(this int value)
        {
            return 0.24m * value;
        }
    }
}
