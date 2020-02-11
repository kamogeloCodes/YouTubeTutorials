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
            //VowelCounter.

            //Testing.
            string testString = "kamogelo";

            //Linq
            int vowelCount = testString.Count(c => "aeiou".Contains(Char.ToLower(c)));

            Console.WriteLine("Vowels found in that string : " + vowelCounter(testString));
            Console.WriteLine("Vowels found in that string : " + vowelCount);



            Console.ReadKey();



        }

        //owelCounter Method.
        public static int vowelCounter(string inputString)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelCounter = 0;

            for(int k =0; k < inputString.Length; k++)
            {
                for(int c=0; c < vowels.Length; c++)
                {
                    if(inputString[k] == vowels[c])
                    {
                        vowelCounter++;
                    }
                }
            }

            return vowelCounter;
        }
    }
}
