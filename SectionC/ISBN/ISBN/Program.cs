using System;
using System.Collections.Generic;
using Isbnmain;


namespace ISBNF
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a ISBN Number :");
            String mIsbn = Console.ReadLine();
            ISBNClass mClass = new ISBNClass();
            Console.WriteLine(mClass.ISBNCheck(mIsbn));
        }
    }
}
namespace Isbnmain
{
    public class ISBNClass
    {
        public string ISBNCheck(String ISBN)
        {
            if (ISBN.Length != 10 && ISBN.Length != 13)
            {
                Console.WriteLine("Not a Valid ISBN Number");
                return "INVALID";
            }
            if (ISBN.Length == 10)
            {
                if (ISBNTenCheck(ISBN) == true)
                {
                    return convert(ISBN);

                }

                else
                {
                    return "INVALID";
                }
            }
            else
            {
                if (ISBNThirteenCheck(ISBN) == true)
                {
                    Console.WriteLine("Valid ");
                    return "VALID";
                }
                else
                {
                    Console.WriteLine("Invalid");
                    return "INVALID";
                }
            }


        }
        //Function to check if a number is of ISBN10
        static bool ISBNTenCheck(String ISBN)
        {
            //Check if last character is an X
            String newISBN = ISBN.ToUpper();
            int sum = 0;
            int[] multiply = { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 };
            int temp;
            if (ISBN.EndsWith('X'))
            {
                newISBN = newISBN.Remove(9);
                sum = sum + 10;
            }
            int convert;
            for (int i = 0; i < newISBN.Length; i++)
            {
                temp = Int32.Parse(newISBN[i].ToString());
                convert = temp * multiply[i];
                sum = sum + convert;
            }

            if (sum % 11 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Function to check if a number is of ISBN13
        static bool ISBNThirteenCheck(String ISBN)
        {
            String newISBN = ISBN;
            int sum = 0;
            int convert;
            int temp;

            for (int i = 0; i < ISBN.Length; i++)
            {
                temp = Int32.Parse(newISBN[i].ToString());
                if (i % 2 == 1)
                {
                    convert = temp * 3;
                    sum = sum + convert;
                }

                else
                {
                    convert = temp * 1;
                    sum = sum + convert;
                }
            }

            if (sum % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Function to convert an ISBN10 number to ISBN13
        static string convert(String ISBN)
        {
            String newISBN = ISBN.Substring(0, ISBN.Length - 1);
            newISBN = "978" + newISBN;
            int convert;
            int sum = 0;
            int temp;
            for (int i = 0; i < newISBN.Length; i++)
            {
                if (i % 2 == 1)
                {
                    temp = Int32.Parse(newISBN[i].ToString());
                    convert = temp * 3;
                    sum = sum + convert;
                }

                else
                {
                    temp = Int32.Parse(newISBN[i].ToString());
                    convert = temp * 1;
                    sum = sum + convert;
                }
            }

            int remainder = sum % 10;
            int finaldigit = 10 - remainder;
            String conversion = newISBN + finaldigit.ToString();
            return conversion;
        }

    }
}
