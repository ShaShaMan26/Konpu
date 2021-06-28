using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog_year_convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            int userAge = 0;
            string userName = "User";
            bool userHasEnteredAge = false;
            bool userHasEnteredName = false;
            while (true)
            {
                System.Threading.Thread.Sleep(2000);
                Console.WriteLine("");
                Console.WriteLine("Hello, please ask me a question! *Please don't capitalize any letters besides those of proper nouns*");
                string userQuestion = Console.ReadLine();
                switch (userQuestion)
                {
                    case "can you tell me my age in dog years?":
                    case "dog":
                    case "what is my age in dog years?":
                    case "how old am I in dog years?":
                        if (userHasEnteredAge == false)
                        {
                            Console.WriteLine("How old are you?");
                            string userAgeS = Console.ReadLine();
                            userHasEnteredAge = true;
                            userAge = Int32.Parse(userAgeS)/7;
                            Console.WriteLine(userName + "'s age in dog years is " + userAge + ".");
                        }
                        else if (userHasEnteredAge == true)
                        {
                            Console.WriteLine("Once again..." + userName + "'s age in dog years is " + userAge + ".");
                        }continue;

                    case "what is my name?":
                    case "do you know my name?":
                    case "name":
                        if(userHasEnteredName == false)
                        {
                            Console.WriteLine("I'm not sure... What is your name?");
                            userName = Console.ReadLine();
                            userHasEnteredName = true;
                            Console.WriteLine("Thank you " + userName + ", I will remember that.");
                        }
                        else if (userHasEnteredName == true)
                        {
                            Console.WriteLine("Once again... User name is " + userName + ".");
                        }continue;

                    case "what do you know?":
                    case "know":
                        if (userHasEnteredName == true && userHasEnteredAge == true)
                        {
                            Console.WriteLine("I know your name is " + userName + ".");
                            Console.WriteLine("And that you're " + userAge + " years old.");
                        }
                        else if (userHasEnteredName == false && userHasEnteredAge == true)
                        {
                            Console.WriteLine("I do not know your name.");
                            Console.WriteLine("However, I know that you're " + userAge + " years old.");
                        }
                        else if (userHasEnteredName == true && userHasEnteredAge == false)
                        {
                            Console.WriteLine("I know your name is " + userName + ".");
                            Console.WriteLine("However, I do not know your age.");
                        }
                        else if (userHasEnteredName == false && userHasEnteredAge == false)
                        {
                            Console.WriteLine("I know nothing of you, " + userName + ". I hope to soon, however. :)");
                        }continue;
                    
                    default:
                        Console.WriteLine("User input unknown");
                        continue;
                }
            }
        }
    }
}
