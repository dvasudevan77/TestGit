using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGit
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a test for git repo.
            Console.WriteLine("Create an empty repository");
            Console.WriteLine("Hello! Have a great day!");
            
            //Call the function GetQuote
            Console.WriteLine("Calling function GetQuote " + GetQuote(2) );

            //Call the PRiceQuote
            Console.WriteLine("Calling function PriceQuote $" + GetPriceQuote(2));

            Console.WriteLine("I am in branch2");

            Console.ReadLine();
        }

        /// <summary>
        /// Method description for GetQuote
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static string GetQuote(int i)
        {
            int result = 0;
            try
            {
                //After clculation return quote
                 result = i * i;
            }
            catch (Exception ex)
            {
                return "Cannot return quote";
            }
            return (result.ToString());
        }

        /// <summary>
        /// Method description for Quote
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int GetPriceQuote(int i)
        {
            return (i * i * i);
        }
        
        /// <summary>
        /// A token method
        /// </summary>
        /// <param name="person"></param>
        /// <returns></returns>
        static string GetToken(string person)
        {
            return "Token 123";
        }
    }
}
