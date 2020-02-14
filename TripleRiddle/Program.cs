using System;

namespace TripleRiddle
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi there!");

            Console.WriteLine("Welcome to TripleRiddle! Now enter a letter from 10 to 99");
            bool valid = false;
            int number = 0;
            while(valid == false)
            {
                string input = Console.ReadLine();
                if(int.TryParse(input, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out number))
                {
                    if(number >= 10 && number <100) 
                    {
                        valid = true;
                    } 
                    else
                    {
                        Console.WriteLine("10-99, please try again.");    
                    }
                    
                }
                else
                {
                    Console.WriteLine("It has to be a integra-number, please try again.");
                }
            }

            int number1 = number;
            
            Console.WriteLine("Is this a letter? " + number1);

            System.Threading.Thread.Sleep(5000);

            Console.WriteLine("No " + number1 + " is a number...");

            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Ok, sorry! Now for the real thing!");

            System.Threading.Thread.Sleep(2000);

            Console.WriteLine("Write two numbers {eg 42} and see what happens !!?");

            valid = false;
            while(valid == false)
            {
                string input = Console.ReadLine();
                if(int.TryParse(input, System.Globalization.NumberStyles.None, System.Globalization.CultureInfo.InvariantCulture, out number))
                {
                    if(number >= 10 && number <100) 
                    {
                        valid = true;
                    } 
                    else
                    {
                        Console.WriteLine("A number between 10-99, please try again.");    
                    }
                    
                }
                else
                {
                    Console.WriteLine("It has to be a integra-number, please try again.");
                }
            }

            int number2 = number;
            
            Console.WriteLine("Did you write " + number + "?");

            int number3 = number2%10; //= enerne.
            int number4 = number2/10; //= tierne.
            if (number2 == 42)
            {
                Console.WriteLine("UUh! You found the ultimate solution, I can't calculate anything better! Now just remember a...");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("Towel!");
                
            }
            else if (number3 == number4)
            {
                //TRIPPEL resultatet
                Console.WriteLine("Uh! SameSame! I've calculatet your special magic number");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("It is:");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine((number3 + number4) * 3);
            }
            else
            {
                //addition
                Console.WriteLine("Uh! I've calculatet your luck!");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine("It is:");
                System.Threading.Thread.Sleep(3000);
                Console.WriteLine(number3 + number4);
            }


        }
    }
}
