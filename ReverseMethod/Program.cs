using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter in a string of your choosing to be reversed.");
            string h = Console.ReadLine();                                              //user input

            Console.WriteLine('\n' + Reverse(h));                                      //calls method with arguments and prints out to screen

        }

        //Reverse Method
        static string Reverse(string j)
        {
            char[] charArray = j.ToCharArray();                                    //convert string to char array
            Array.Reverse(charArray);                                               //reverse chars in array
            string k = new string(charArray);                                       //new string reversed

            return k;
        }
    }
}
