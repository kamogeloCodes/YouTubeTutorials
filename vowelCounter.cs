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

            //Vowel Counter.
            //Testing string.
            string testString = "KAMOGELO"; //Answer is 5.

            //Using Linq.
            int vowelCounter_ = testString.Count(c => "aeiou".Contains(Char.ToLower(c)));

            Console.WriteLine("The number of vowels in that string is : " + vowelCounter(testString));
            Console.WriteLine("Using Linq -- The number of vowels in that string is : " + vowelCounter_);


            Console.ReadKey();

        }

            //VowelCounter Method.
        public static int vowelCounter(string inputString)
        {
            char[] vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelCount = 0;
            inputString = inputString.ToLower();

            for(int k = 0; k < inputString.Length; k++)
            {
                for(int c = 0; c < vowels.Length; c++)
                {
                    if(inputString[k] == vowels[c])
                    {
                        vowelCount++;
                    }
                }
            }

            return vowelCount;

        }

    }
}
