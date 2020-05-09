using System;

namespace CS4
{
    class SqrtProgram
    {
        static void Main(string[] args)
        {   
            // C# program to illustrate the 
            // Math.Sqrt() method 
            
            int val1;  
            int val2;
            string text; 
            int num; 
            
            
           
            Console.WriteLine("Please enter first value"); 
            
            val1 = int.Parse(Console.ReadLine()); 
            
            Console.WriteLine("The square root of this value is: " + Math.Sqrt(val1)); 
            
            Console.WriteLine("Please enter second value"); 
            
            val2 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("The square root of this value is: " + Math.Sqrt(val2)); 

            //If the numbers have the same square root
            
            if ( Math.Sqrt(val1) == Math.Sqrt(val2))
                {
                    Console.WriteLine("Please enter different values"); 
                }

            //If the value entered is not a number
            
            text = Console.ReadLine();
            
            if (!int.TryParse(text, out val1))
                {
                    Console.WriteLine("\n\t {0} is not a number  \n\n", text);
                }

            else if (!int.TryParse(text, out val2))
                {
                    Console.WriteLine("\n\t {0} is not a number  \n\n", text); 
                }
            
            //If a negative number is entered

            num = int.Parse(Console.ReadLine()); 

            if (num < 0)
                {
                     Console.WriteLine("{0} is a negative number. \n", num);
                }

        }   
    }
}
