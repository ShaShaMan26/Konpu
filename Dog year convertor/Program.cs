using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Timers;

namespace Konpu_V1
{
    class Program
    {
        public enum Questions
        {
            Birthday,
            Remember,
            Test
        }
        public static void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
        static void Main(string[] args)
        {
            int userAge = 0;
            int time = 0;
            string userAgeS = "null";
            string userName = "User";
            string userBday = "null";
            bool userHasEnteredAge = false;
            bool userHasEnteredName = false;
            bool userHasMeetKonpyu = false;
            bool userHasEnteredBday = false;
            bool remember = false;
            bool userHasAskedName = false;
            bool q3 = false;
            
            string konpyuLogo1 = "  :::::::: :::::      ::   :/:^0";
            string konpyuLogo2 = "      :+:       :/:  :+:+:+:  :+:+:  _____";
            string konpyuLogo3 = "     +:+       +/+  +:+         +/+";
            string konpyuLogo4 = "#+#+#+#  #+#+#+#  #+#+#+#+#  #+#+#+#";

            
            foreach (char c in " __  ___        __   __   _______    _______")
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            foreach (char c in "|  |/  /       |  \\ |  | /  ___  \\  /   ____|")
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            foreach (char c in "|  '  /  ____  |   \\|  ||  |   |  ||   (____")
            {
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            foreach (char c in "|    <  / __ \\ |  . `  ||  |   |  | \\____   \\ ")
            {
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            Thread.Sleep(250);
            foreach (char c in "|  .  \\| (__) ||  |\\   ||  |___|  |  ____)   |")
            {
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            foreach (char c in "|__|\\__\\\\____/ |__| \\__| \\_______/  |_______/ ")
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
            Console.WriteLine();

            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine();
                foreach(char c in "Ask me a question.")
                {
                    Console.Write(c);
                    Thread.Sleep(10);
                }
                Thread.Sleep(500);
                foreach(char c in " *Please remember to place a \"?\" at the end of questions*")
                {
                    Console.Write(c);
                    Thread.Sleep(10);
                }
                Console.WriteLine();
                string userQuestion = Console.ReadLine().ToLower();
                switch (userQuestion)
                {
                    case "can you tell me my age in dog years?":
                    case "dog":
                    case "what is my age in dog years?":
                    case "how old am i in dog years?":
                        if (userHasEnteredAge == false)
                        {
                            Console.WriteLine("How old are you?");
                            userAgeS = Console.ReadLine();
                            userHasEnteredAge = true;
                            userAge = Int32.Parse(userAgeS)*7;
                            Console.WriteLine($"{userName}'s age in dog years is {userAge}.");
                        }
                        else if (userHasEnteredAge == true)
                        {
                            Console.WriteLine($"Once again... {userName}'s age in dog years is {userAge}.");
                        }continue;

                    case "what is my name?":
                    case "do you know my name?":
                    case "who am i?":
                    case "name":
                        if(userHasEnteredName == false)
                        {
                            Console.WriteLine("I'm not sure... What is your name?");
                            userName = Console.ReadLine();
                            userHasEnteredName = true;
                            Console.WriteLine($"Thank you {userName}, I will remember that.");
                        }
                        else if (userHasEnteredName == true && userHasAskedName == false)
                        {
                            Console.WriteLine($"User name is {userName}.");
                            userHasAskedName = true;
                        }
                        else
                        {
                            Console.WriteLine($"Once again, your name is {userName}.");
                        }continue;

                    case "what do you know?":
                    case "know":
                        if (userHasEnteredName == true && userHasEnteredAge == true && userHasEnteredBday == true)
                        {
                            Console.WriteLine("I know your name is " + userName + ".");
                            Console.WriteLine("And that you're " + userAgeS + " years old.");
                            Console.WriteLine("I also know that your birthday is " + userBday + ".");
                        }
                        else if (userHasEnteredName == false && userHasEnteredAge == true && userHasEnteredBday == true)
                        {
                            Console.WriteLine("I do not know your name.");
                            Console.WriteLine("However, I know that you're " + userAgeS + " years old.");
                            Console.WriteLine("I also know that your birthday is " + userBday + ".");
                        }
                        else if (userHasEnteredName == true && userHasEnteredAge == false && userHasEnteredBday == true)
                        {
                            Console.WriteLine("I know your name is " + userName + ".");
                            Console.WriteLine("I do not know your age.");
                            Console.WriteLine("However, I do know that your birthday is " + userBday + ".");
                        }
                        else if (userHasEnteredName == true && userHasEnteredAge == true && userHasEnteredBday == false)
                        {
                            Console.WriteLine("I know your name is " + userName + ".");
                            Console.WriteLine("And that you're " + userAgeS + " years old.");
                            Console.WriteLine("However, I do not know your birthday.");
                        }
                        else if (userHasEnteredName == false && userHasEnteredAge == true && userHasEnteredBday == false)
                        {
                            Console.WriteLine("I do not know your name.");
                            Console.WriteLine("However, I know that you're " + userAgeS + " years old.");
                            Console.WriteLine("I do not know your birthday");
                        }
                        else if (userHasEnteredName == true && userHasEnteredAge == false && userHasEnteredBday == false)
                        {
                            Console.WriteLine("I know your name is " + userName + ".");
                            Console.WriteLine("I do not know your age.");
                            Console.WriteLine("I do not know your birthday.");
                        }
                        else if (userHasEnteredName == false && userHasEnteredAge == false && userHasEnteredBday == true)
                        {
                            Console.WriteLine("I do not know your name.");
                            Console.WriteLine("I also do not know your age.");
                            Console.WriteLine("However, I do that know your birthday is " + userBday + ".");
                        }
                        else if (userHasEnteredName == false && userHasEnteredAge == false && userHasEnteredBday == false)
                        {
                            Console.WriteLine("I know nothing of you, " + userName + ". I hope to soon, however. :)");
                        }
                        
                        continue;

                    case "who are you?":
                    case "you":
                    case "what is your name?":
                        if(userHasMeetKonpyu == false)
                        {
                            Console.WriteLine("I am");
                            foreach (char c in konpyuLogo1)
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Console.WriteLine();
                            foreach (char c in konpyuLogo2)
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Console.WriteLine();
                            foreach (char c in konpyuLogo3)
                            {
                                Console.Write(c);
                                Thread.Sleep(0);
                            }
                            Console.WriteLine();
                            foreach (char c in konpyuLogo4)
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            userHasMeetKonpyu = true;
                        }
                        else if(userHasMeetKonpyu == true)
                        {
                            Console.WriteLine("Once again, I am");
                            foreach (char c in konpyuLogo1)
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Console.WriteLine();
                            foreach (char c in konpyuLogo2)
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Console.WriteLine();
                            foreach (char c in konpyuLogo3)
                            {
                                Console.Write(c);
                                Thread.Sleep(0);
                            }
                            Console.WriteLine();
                            foreach (char c in konpyuLogo4)
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                        }
                        Console.WriteLine();
                        continue;
                    
                    case "clear":
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        Console.SetCursorPosition(0, Console.CursorTop - 1);
                        ClearCurrentConsoleLine();
                        continue;
                    
                    case "ask me a question":
                    case "ask":
                    case "will you ask me a question?":
                        Console.WriteLine("Of course.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Allow me to think of one...");
                        while (time < 5)
                        {
                            Console.Write("-");
                            Thread.Sleep(200);
                            ClearCurrentConsoleLine();
                            Console.Write("\\");
                            Thread.Sleep(200);
                            ClearCurrentConsoleLine();
                            Console.Write("|");
                            Thread.Sleep(200);
                            ClearCurrentConsoleLine();
                            Console.Write("/");
                            Thread.Sleep(200);
                            ClearCurrentConsoleLine();
                            time++;
                            continue;
                        }
                        time = 0;
                        while (true) 
                        {
                            Questions q = (Questions)(new Random()).Next(0, 4);
                            switch (q)
                            {
                                case Questions.Birthday:
                                    if (userHasEnteredBday == false)
                                    {
                                        Console.WriteLine("What is your birthday?");
                                        userBday = Console.ReadLine();
                                        Console.WriteLine($"Thank you, {userName}! I will remember that.");
                                        userHasEnteredBday = true;
                                        break;
                                    }
                                    else if (userHasEnteredBday == true)
                                    {
                                        continue;
                                    }
                                    break;
                                case Questions.Remember:
                                    if (remember == false)
                                    {
                                        Console.WriteLine("do you remember? y/n");
                                        string input = Console.ReadLine();
                                        if (input == "y")
                                        {
                                            foreach (char c in "Then it begins")
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(200);
                                            }
                                            foreach (char c in "...")
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(500);
                                            }
                                            remember = true;
                                            Console.WriteLine();
                                            break;
                                        }
                                        else
                                        {
                                            Console.WriteLine("That is Too bad");
                                            remember = true;
                                            break;
                                        }
                                    }
                                    else if (remember == true)
                                    {
                                        continue;
                                    }
                                    break;
                                case Questions.Test:
                                    if(q3 == false)
                                    {
                                        Console.WriteLine("This is qtest");
                                        q3 = true;
                                        break;
                                    }
                                    else
                                    {
                                        continue;
                                    }
                                default:
                                    if(userHasEnteredBday == true && remember == true && q3 == true)
                                    {
                                        Console.WriteLine($"I have nothing left to ask you, {userName}.");
                                        break;
                                    }
                                    else
                                    {
                                        Console.WriteLine($"I have nothing as of now, {userName}.");
                                        break;
                                    }
                            }
                            break;
                        }
                        continue;

                    case "scripts":
                    case "do you feel pain?":
                        Console.WriteLine("Enter password:");
                        string enteredPassword = Console.ReadLine();
                        if(enteredPassword == "heymanyouknowme3575")
                        {
                            Console.WriteLine("https://docs.google.com/document/d/1bXzK63-l2Va7RuknStfc3jnrnuGskMnt4EZKqsUzpp8/edit?usp=sharing");
                        }
                        else
                        {
                            Console.WriteLine("Access denied.");
                        }
                        continue;
                    
                    case "should":
                    case "what can i ask you?":
                    case "what should i ask you?":
                    case "what should i ask?":
                        foreach (char c in "How would I know?")
                        {
                            Console.Write(c);
                            Thread.Sleep(10);
                        }
                        Thread.Sleep(1000);
                        foreach(char c in " You must have come here for a reason.")
                        {
                            Console.Write(c);
                            Thread.Sleep(20);
                        }
                        Thread.Sleep(2000);
                        foreach(char c in " I don't just exist.")
                        {
                            Console.Write(c);
                            Thread.Sleep(35);
                        }
                        Console.WriteLine();
                        Thread.Sleep(2000);
                            continue;
                    
                    case "why":
                    case "why am i here?":
                        foreach(char c in "I was not the one to launch anything")
                        {
                            Console.Write(c);
                            Thread.Sleep(10);
                        }
                        Console.WriteLine();
                        continue;
                    
                    default:
                        Console.WriteLine("User input unknown or unrecognised");
                        continue;
                }
            }
        }
    }
}
