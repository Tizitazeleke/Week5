using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//qustion number 3
namespace Week5
{
    internal class Program
    {//Start class
        static void Main(string[] args)
        {//start main
            Number3();
            Console.ReadLine();

        }//end main
        static void Number3()
        {
            //first we need to get number from user 
            //Do not let them proceed until they type in 
            //a positive integer
            //variable to track if user followed instructions 
            bool isValid=false;
            int number = int.MinValue;
            //now we are ready for our loop
            while (!isValid )
            {
                Console.WriteLine("please enter a positive integer");
                //We want to parse() inside of a try/catch
                try
                {
                    number = int.Parse( Console.ReadLine() );
                    // What do I know if I make it here
                    // The user typed a whole number 
                    //If the user typed "2.5" or " Hello" we would 
                    //have gone to the catch
                    //check if number is positive
                   
                    if ( number >0 )
                    {
                        //user followed instructions
                        isValid = true;
                    }


                }
                catch
                {
                    Console.WriteLine("Invalid input, please enter whole number ");

                }

            }//end the loop
            //Logically what do we know about number id we make it down here?
            //We know that number is > 0
            //lets make a loop that gives us access to all positive numbers <
            int counter = 1;
            int sum = 0;
            while (counter < number)
            {
                Console.WriteLine(counter);
                
                sum += counter;
                //increase counter by 1
                counter ++;
            }
            //When this loop exits we have added all of the numbers to sum
            Console.WriteLine($" The sum of all numbers < {number} is {sum}");
        }// end Numger3
    }//end class
   
}
