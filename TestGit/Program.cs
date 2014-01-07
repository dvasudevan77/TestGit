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

            Console.ReadLine();
        }

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
        /// Get Price quote
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        static int GetPriceQuote(int i)
        {
            return (i * i * i);
        }
    }
}
