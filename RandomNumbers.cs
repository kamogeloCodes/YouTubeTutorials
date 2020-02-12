using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial02
{
    class Program
    {
        static void Main(string[] args)
        {

            Random randomNumbers = new Random();

            int randoms = randomNumbers.Next(0, 10);


            Console.WriteLine("Random Number : " + randoms);


            Console.ReadKey();

        }

     

    }
}
