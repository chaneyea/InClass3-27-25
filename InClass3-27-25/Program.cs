using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass20250311
{
    internal class Program
    {
        static void Main(string[] args) // This is the 'entry point' of our project
        {
            // Console.WriteLine("Hello");
            int result;
            result = Cube(42); // "Invoke or Call" the method
            Console.WriteLine("42 cubed is " + result);
        }
        /// <summary>
        /// Compute the cube of an integer
        /// </summary>
        /// <param name="num">The number to be cubed</param>
        /// <returns>The cube of num</returns>
        static int Cube(int num)  // The method 'signature'
        {
            return num * num * num;
        }
    }
}
