using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisionMaking
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = 5;
            int secondNumber = 3;
            int thirdNumber = 5;

            if(firstNumber > secondNumber)
            {
                if(firstNumber != thirdNumber)
                {
                    Console.WriteLine("Kamogelo");
                }

		else
		{
                    Console.WriteLine("Not Kamogelo");
                }

                
            }


	    int testNumber = 5;

            switch(testNumber)
            {
                case 1:
                    Console.WriteLine("Does not match");
                    break;
                case 3:
                    Console.WriteLine("Matches");
                    break;
                default:
                    Console.WriteLine("Does not match");
                    break;

            }


            Console.ReadKey();
        }
    }
}
