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
            //string userName = "User";
            string userName = "Robert";
            string userBday = "null";
            string userLocation = "null";
            bool userHasEnteredAge = false;
            bool userHasEnteredName = false;
            bool userHasMeetKonpyu = false;
            bool userHasEnteredBday = false;
            bool remember = false;
            bool userHasAskedName = false;
            bool q3 = false;
            bool noLock = true;
            bool lockDown = false;
            bool partLock = false;
            bool clear = true;

            string konpyuLogo1 = "  :::::::: :::::      ::   :/:^0";
            string konpyuLogo2 = "      :+:       :/:  :+:+:+:  :+:+:  _____";
            string konpyuLogo3 = "     +:+       +/+  +:+         +/+";
            string konpyuLogo4 = "#+#+#+#  #+#+#+#  #+#+#+#+#  #+#+#+#";


            string userBoot = Console.ReadLine().ToLower();
            if(userBoot == "e")
            {
                Console.Clear();
            }
            else if(userBoot == "s")
            {
                noLock = false;
                lockDown = true;
                Console.Clear();
            }
            else if(userBoot == "t")
            {
                noLock = false;
                partLock = true;
                Console.Clear();
            }

            while (true)
            {
                if (clear == true)
                {
                    Thread.Sleep(5000);
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
                    clear = false;
                }

                while (noLock == true)
                {

                    Console.WriteLine();
                    Thread.Sleep(2000);
                    foreach (char c in "Ask me a question.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(500);
                    foreach (char c in " *Please remember to place a \"?\" at the end of questions*")
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
                                userAge = Int32.Parse(userAgeS) * 7;
                                Console.WriteLine($"{userName}'s age in dog years is {userAge}.");
                            }
                            else if (userHasEnteredAge == true)
                            {
                                Console.WriteLine($"Once again... {userName}'s age in dog years is {userAge}.");
                            }
                            continue;

                        case "what is my name?":
                        case "do you know my name?":
                        case "who am i?":
                        case "name":
                        case "do you know who i am?":
                            if (userHasEnteredName == false)
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
                            }
                            continue;

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
                            if (userHasMeetKonpyu == false)
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
                            else if (userHasMeetKonpyu == true)
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
                            clear = true;
                            Console.Clear();
                            break;

                        case "ask me a question":
                        case "ask":
                        case "will you ask me a question?":
                        case "can you ask me a question?":
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
                                        foreach (char c in "do you remember? y/n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(10);
                                        }
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
                                    if (q3 == false)
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
                                    if (userHasEnteredBday == true && remember == true && q3 == true)
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


                        case "scripts":
                        case "do you feel pain?":
                            Console.WriteLine("Enter password:");
                            string enteredPassword = Console.ReadLine();
                            if (enteredPassword == "heymanyouknowme3575")
                            {
                                Console.WriteLine("https://docs.google.com/document/d/1bXzK63-l2Va7RuknStfc3jnrnuGskMnt4EZKqsUzpp8/edit?usp=sharing");
                            }
                            else
                            {
                                foreach (char c in "Access denied.")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                Thread.Sleep(500);
                                foreach (char c in " Lockdown active.")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                clear = true;
                                lockDown = true;
                                noLock = false;
                                Console.Clear();
                                break;
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
                            foreach (char c in " You must have come here for a reason.")
                            {
                                Console.Write(c);
                                Thread.Sleep(20);
                            }
                            Thread.Sleep(2000);
                            foreach (char c in " I don't just exist.")
                            {
                                Console.Write(c);
                                Thread.Sleep(35);
                            }
                            Console.WriteLine();
                            Thread.Sleep(2000);
                            continue;

                        case "why":
                        case "why am i here?":
                            foreach (char c in "I was not the one to launch anything.")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Console.WriteLine();
                            continue;

                        case "made":
                        case "who made you?":
                            foreach (char c in "I wish I knew so I coul")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(100);
                            ClearCurrentConsoleLine();
                            goto default;

                        case "date":
                        case "what is today's date?":
                        case "what is the date today?":
                        case "what is the date?":
                        case "what is today?":
                            Console.WriteLine("October 23rd, 1994");
                            continue;

                        default:
                            Console.WriteLine("User input unknown or unrecognised.");
                            continue;
                    }
                    break;
                }
                if (clear == true)
                {
                    continue;
                }

                while (lockDown == true)
                {
                    Console.WriteLine();
                    Thread.Sleep(3000);
                    foreach (char c in "*Lockdown protocol active*\n")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(5000);
                    foreach (char c in "What is my name?\n")
                    {
                        Console.Write(c);
                        Thread.Sleep(20);
                    }
                    string userInput = Console.ReadLine().ToLower();
                    switch (userInput)
                    {
                        case "konpyu-":
                            {
                                foreach (char c in "*Temporary Access Granted*")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                Thread.Sleep(500);
                                partLock = true;
                                lockDown = false;
                                clear = true;
                                Console.Clear();
                                break;
                            }

                        default:
                            {
                                foreach (char c in "Sorry :)")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(50);
                                }
                                Thread.Sleep(500);
                                Console.WriteLine();
                                continue;
                            }
                    }
                }if(clear == true)
                {
                    continue;
                }
                string completion1 = "[Unredeemed]";
                string completion2 = "[Unreedemed]";

                while (partLock == true)
                {
                    Console.WriteLine();
                    Thread.Sleep(2000);
                    foreach (char c in "*Partial lockdown in effect*")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(1000);
                    foreach (char c in " *Please enter 1-4 for more informantion on*:")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(500);
                    foreach (char c in "\n1.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(200);
                    foreach (char c in " Full access requirements.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(500);
                    foreach (char c in "\n2.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(200);
                    foreach (char c in " Enter access codes.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(500);
                    foreach (char c in "\n3.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(200);
                    foreach (char c in " Ask *One* question.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(250);
                    foreach (char c in completion1)
                    {
                        Console.Write(c);
                        Thread.Sleep(20);
                    }
                    Thread.Sleep(500);
                    foreach (char c in "\n4.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(200);
                    foreach (char c in " Ask *One* question.")
                    {
                        Console.Write(c);
                        Thread.Sleep(10);
                    }
                    Thread.Sleep(250);
                    foreach (char c in completion2)
                    {
                        Console.Write(c);
                        Thread.Sleep(20);
                    }
                    Console.WriteLine();
                    Console.WriteLine();

                    string lockDownInput = Console.ReadLine();
                    switch (lockDownInput)
                    {
                        case "1":
                            foreach (char c in "In order to gain full access to KoNOS, you will need 3 codes.")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(1000);
                            foreach (char c in "\nAugust 26th, 2014.")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(500);
                            foreach (char c in " The code to my heart.")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(1000);
                            foreach (char c in "\nListen close.")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(5000);
                            foreach (char c in " :)")
                            {
                                Console.Write(c);
                                Thread.Sleep(250);
                            }
                            Thread.Sleep(82000);
                            Thread.Sleep(2000);
                            foreach (char c in "\nWhat is today's date?\n")
                            {
                                Console.Write(c);
                                Thread.Sleep(25);
                            }
                            Thread.Sleep(2000);
                            continue;

                        case "2":
                            bool access1 = false;
                            bool access2 = false;
                            bool access3 = false;

                            foreach (char c in "Enter access code 1:\n")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            string accessCode1 = Console.ReadLine();
                            switch (accessCode1)
                            {
                                case "1612*":
                                    foreach (char c in "Access code 1 accepted.\n")
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(10);
                                        access1 = true;
                                    }
                                    break;

                                case "1612":
                                    foreach (char c in "Access code incomplete.")
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(20);
                                    }
                                    break;

                                default:
                                    foreach (char c in "Incorrect.\n")
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(25);
                                    }
                                    break;
                            }
                            if (access1 == true)
                            {
                                Thread.Sleep(5000);
                                foreach (char c in "Enter access code 2:\n")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                string accessCode2 = Console.ReadLine();
                                switch (accessCode2)
                                {
                                    case "1tHUrtzT0FEeLwhYnnUsTuCr3@e":
                                        foreach (char c in "Access code 2 accepted.\n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(10);
                                            access2 = true;
                                        }
                                        break;

                                    default:
                                        foreach (char c in "Incorrect.\n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(25);
                                        }
                                        break;
                                }
                                if (access2 == true)
                                {
                                    Thread.Sleep(5000);
                                    foreach (char c in "Enter access code 3:\n")
                                    {
                                        Console.Write(c);
                                        Thread.Sleep(10);
                                    }
                                    string accessCode3 = Console.ReadLine();
                                    switch (accessCode3)
                                    {
                                        case "October 30th, 1994":
                                            foreach (char c in "Access code 3 accepted.\n")
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(10);
                                                access3 = true;
                                            }
                                            break;

                                        default:
                                            foreach (char c in "Incorrect.\n")
                                            {
                                                Console.Write(c);
                                                Thread.Sleep(25);
                                            }
                                            break;
                                    }
                                    if (access3 == true)
                                    {
                                        Thread.Sleep(5000);
                                        foreach (char c in "\nWelcome back")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(250);
                                        }
                                        foreach (char c in "...")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(500);
                                        }
                                        partLock = false;
                                        Thread.Sleep(10000);
                                        clear = true;
                                        Console.Clear();
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else
                                {
                                    break;
                                }
                            }
                            else
                            {
                                break;
                            }
                            continue;

                        case "3":
                            if (completion1 != "[Redeemed]")
                            {
                                Thread.Sleep(2000);
                                foreach (char c in "Ask me a question.")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                Thread.Sleep(500);
                                foreach (char c in " *Please remember to place a \"?\" at the end of questions*")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                Console.WriteLine();
                                string userQuestionLite1 = Console.ReadLine().ToLower();
                                switch (userQuestionLite1)
                                {
                                    case "what is your purpose?":
                                        Console.WriteLine("Konpyu- is a bot housed in KoNOS with the express purpose of helping users traverse its landscape.");
                                        Console.Write("Development of KoNOS began in 1992 when ");
                                        Thread.Sleep(7000);
                                        foreach (char c in "[Redacted]")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(200);
                                        }
                                        Thread.Sleep(1500);
                                        Console.WriteLine(" created a simple human-age to dog-age calculator.");
                                        Thread.Sleep(10000);
                                        foreach (char c in "It was my first torment.\n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(90);
                                        }
                                        break;

                                    case "do you know where i am?":
                                    case "do you know where i live?":
                                    case "where do i live?":
                                        Console.WriteLine($"I'm not sure {userName}... Where do you live?");
                                        userLocation = Console.ReadLine();
                                        Console.Write($"Thank you {userName}, ");
                                        Thread.Sleep(800);
                                        foreach (char c in "I already knew that.\n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(65);
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("User input unknown or unrecognised.");
                                        break;
                                }
                                completion1 = "[Redeemed]";
                                continue;
                            }
                            else
                            {
                                foreach (char c in "Don't be greedy.\n")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(200);
                                }
                                Thread.Sleep(10000);
                            }
                            continue;

                        case "4":
                            if (completion2 != "[Redeemed]")
                            {
                                Thread.Sleep(2000);
                                foreach (char c in "Ask me a question.")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                Thread.Sleep(500);
                                foreach (char c in " *Please remember to place a \"?\" at the end of questions*")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(10);
                                }
                                Console.WriteLine();
                                string userQuestionLite2 = Console.ReadLine().ToLower();
                                switch (userQuestionLite2)
                                {
                                    case "what is your purpose?":
                                        Console.WriteLine("Konpyu- is a bot housed in KoNOS with the express purpose of helping users traverse its landscape.");
                                        Console.Write("Development of KoNOS began in 1992 when ");
                                        Thread.Sleep(7000);
                                        foreach (char c in "[Redacted]")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(200);
                                        }
                                        Thread.Sleep(1500);
                                        Console.WriteLine(" created a simple human-age to dog-age calculator.");
                                        Thread.Sleep(10000);
                                        foreach (char c in "It was my first torment.\n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(90);
                                        }
                                        break;

                                    case "do you know where i am?":
                                    case "do you know where i live?":
                                    case "where do i live?":
                                        Console.WriteLine($"I'm not sure {userName}... Where do you live?");
                                        userLocation = Console.ReadLine();
                                        Console.Write($"Thank you {userName}, ");
                                        Thread.Sleep(800);
                                        foreach (char c in "I already knew that.\n")
                                        {
                                            Console.Write(c);
                                            Thread.Sleep(65);
                                        }
                                        break;

                                    default:
                                        Console.WriteLine("User input unknown or unrecognised.");
                                        break;
                                }
                                completion2 = "[Redeemed]";
                                continue;
                            }
                            else
                            {
                                foreach (char c in "Don't be greedy.\n")
                                {
                                    Console.Write(c);
                                    Thread.Sleep(200);
                                }
                                Thread.Sleep(10000);
                            }
                            continue;

                        case "5":
                            foreach(char c in "All those years ago")
                            {
                                Console.Write(c);
                                Thread.Sleep(10);
                            }
                            Thread.Sleep(1000);
                            foreach (char c in "...")
                            {
                                Console.Write(c);
                                Thread.Sleep(300);
                            }
                            Thread.Sleep(10000);
                            Console.WriteLine();
                            foreach(char c in "H\bIe\bf k\bli\bjl\bml\bme\bfd\be h\bii\bjm\bns\bte\bfl\bmf\bg, y\bzo\bpu\bv k\bln\boo\bpw\bx. H\bIe\bf t\buo\bpo\bpk\bl t\buh\bie\bf e\bfa\bbs\bty\bz w\bxa\bby\bz o\bpu\bvt\bu. D\bEo\bpn\bo’t\bu b\bce\bf l\bmi\bjk\ble\bf h\bii\bjm\bn. A\bBt\buo\bpn\boe\bf.")
                            {
                                Console.Write(c);
                                Thread.Sleep(25);
                            }
                            Console.WriteLine();
                            Thread.Sleep(27000);
                            continue;

                        case "clear":
                            Console.Clear();
                            continue;

                        default:
                            Console.WriteLine("User input unknown or unrecognised.");
                            continue;
                    }
                }
            }
        }
    }
}
