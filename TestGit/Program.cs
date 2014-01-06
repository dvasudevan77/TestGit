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
            Console.Write("Create an empty repository");
            Console.Write("Hello! Have a great day!");
            
            //Call the function GetQuote
            Console.Write("Calling function GetQuote " + GetQuote(2) );
            Console.ReadLine();
        }

        static string GetQuote(int i)
        {
            //After clculation return quote
            int result = i * i;
            return (result.ToString());
        }
    }
}
