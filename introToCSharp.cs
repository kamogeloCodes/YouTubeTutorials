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
            //Adding comments.
            /*Adding comments */
            
            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome to my YouTube Channel");
            
            //Accepting an input
            //Declaration
            string myName;
            
             Console.WriteLine("Please enter your name : ");
             myName = Console.ReadLine();
             Console.WriteLine("Hi" + myName);
             
             //Data types.
             int intType = 10;
             string stringType = "Kamogelo";
             bool boolType = false;
             char charType = 'K';
             double doubleType = 10.09;
             
             
             Console.WriteLine("int Type" + intType);
             Console.WriteLine("string Type" + stringType);
             Console.WriteLine("bool Type" + boolType);
             Console.WriteLine("char Type" + charType);
             Console.WriteLine("double Type" + doubleType);


            Console.ReadKey();

        }

     

    }
}

