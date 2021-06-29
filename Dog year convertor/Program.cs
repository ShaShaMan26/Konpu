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
            string userAgeS = "null";
            string userName = "User";
            string userBday = "null";
            bool userHasEnteredAge = false;
            bool userHasEnteredName = false;
            bool userHasMeetKonpyu = false;
            bool userHasEnteredBday = false;
            int time = 0;

            string konOSLogo1 = " __  ___        __   __   _______    _______";
            string konOSLogo2 = "|  |/  /       |  \\ |  | /  ___  \\  /   ____|";
            string konOSLogo3 = "|  '  /  ____  |   \\|  ||  |   |  ||   (____";
            string konOSLogo4 = "|    <  / __ \\ |  . `  ||  |   |  | \\____   \\ ";
            string konOSLogo5 = "|  .  \\| (__) ||  |\\   ||  |___|  |  ____)   |";
            string konOSLogo6 = "|__|\\__\\\\____/ |__| \\__| \\_______/  |_______/ ";
            string konpyuLogo1 = "  :::::::: :::::      ::   :/:^0";
            string konpyuLogo2 = "      :+:       :/:  :+:+:+:  :+:+:  _____";
            string konpyuLogo3 = "     +:+       +/+  +:+         +/+";
            string konpyuLogo4 = "#+#+#+#  #+#+#+#  #+#+#+#+#  #+#+#+#";

            foreach (char c in konOSLogo1)
            {
                Console.Write(c);
                Thread.Sleep(10);
            }
            Console.WriteLine();
            foreach (char c in konOSLogo2)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
            Console.WriteLine();
            foreach (char c in konOSLogo3)
            {
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            Thread.Sleep(1000);
            foreach (char c in konOSLogo4)
            {
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            Thread.Sleep(250);
            foreach (char c in konOSLogo5)
            {
                Console.Write(c);
                Thread.Sleep(0);
            }
            Console.WriteLine();
            foreach (char c in konOSLogo6)
            {
                Console.Write(c);
                Thread.Sleep(5);
            }
            Console.WriteLine();

            while (true)
            {
                Thread.Sleep(2000);
                Console.WriteLine();
                Console.WriteLine("Ask me a question. *Please don't capitalize any words besides proper nouns and place a '?' at the end of questions*");
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
                            userAgeS = Console.ReadLine();
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
                        Console.SetCursorPosition(0, Console.CursorTop - 2);
                        ClearCurrentConsoleLine();
                        continue;
                    case "ask me a question":
                    case "ask":
                    case "will you ask me a question?":
                        Console.WriteLine("Of course.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Allow me to think of one...");
                        if(userHasEnteredBday == false)
                        {
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
                            Console.WriteLine("What is your birthday?");
                            userBday = Console.ReadLine();
                            Console.WriteLine("Thank you! I will remember that.");
                            userHasEnteredBday = true;
                        }    
                        else if (userHasEnteredBday == true)
                        {
                            Console.WriteLine("I have nothing left to ask.");
                        }
                        continue;

                    default:
                        Console.WriteLine("User input unknown or unrecognised");
                        continue;
                }
            }
        }
    }
}
