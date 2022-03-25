using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static int Main(string[] args)

        {
            int attempts = 1;
            
            int guess;
            Console.Write("Please enter the value for the upper bound: ");
            int upperBound = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Console.Write("Please enter the value for the lower bound: ");
            int lowerBound = Int32.Parse(Console.ReadLine());

            Console.WriteLine();

            Random r = new Random();
            int rInt = r.Next(lowerBound, upperBound);
                do
                {
                    
 
                    Console.Write($"Please enter an integer between {lowerBound} and {upperBound}: ");
                
                    guess = Int32.Parse(Console.ReadLine());
                    if (attempts > 7)
                    {
                        Console.WriteLine("Oops, try again!!!");
                        Console.ReadLine();
                        
                        break;
                    }
                    else
                    {
                        if (guess > rInt)
                        {
                            Console.WriteLine("You guessed too high!");

                   
                        }
                        else if (guess < rInt)
                        {
                            Console.WriteLine("You guessed too Low!");

                    
                        }
                        else
                        {
                    
                    
                    
                            Console.WriteLine("Congrats!!! You gueesed correctly!!!");
                            Console.WriteLine($"attempts: {attempts + 1}");

                            Console.ReadLine();
                    
                    

                        }
                    }
                    attempts++;
                } while (guess != rInt);
                
                   
 
                    
        
            return 0; 
        }
    }
}
