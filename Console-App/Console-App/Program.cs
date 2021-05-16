using System;
using System.Collections;

namespace Console_App
{

    class Program
    {
        static void Main(string[] args)
        {

            string[] questions = new string[] { "The unicorn is the national animal of Scotland", "Frogs have to drink a lot of water", "Camels can walk 100 miles in the desert without water", "Japan grows square watermelons", "Chimpanzees are nocturnal" };
            string[] answers = new string[] { "true", "false", "true", "true", "false"};
            Console.WriteLine("Hello, welcome to TRUE OR FALSE 2021! What is your name?");
            var name = Console.ReadLine();
            var currentDate = DateTime.Now;
            Console.WriteLine($"{Environment.NewLine}Hello, {name}, on {currentDate:d} at {currentDate:t}! Are you ready to play? If so, respond with 'Yes'.");
            var YesOrNo = Console.ReadLine();
            if (YesOrNo != "Yes") {
                Console.WriteLine($"{Environment.NewLine}Okay, you may press any key to exit...");
                Console.ReadKey(true);
                System.Environment.Exit(0);
            } else if (YesOrNo == "Yes") {
                Console.WriteLine($"{Environment.NewLine}Okay {name}, let's get started! Reply to each statement with 'true' or 'false'.");
                Console.WriteLine($"{Environment.NewLine}Press any key to start the game...");
                Console.ReadKey(true);
                Console.WriteLine(questions[0]);
                int score = 0;
                var response = Console.ReadLine();
                if (response == answers[0]) {
                    score = score + 1;
                    Console.WriteLine($"You were correct! Your score is {score}! ");
                } else if (response != answers[0])
                {
                    score = score + 0;
                    Console.WriteLine($"Uh oh! You were incorrect! Your score is {score}! ");
                };
                Console.WriteLine(questions[1]);
                response = Console.ReadLine();
                if (response == answers[1]) {
                    score = score + 1;
                    Console.WriteLine($"You were correct! Your score is {score}! ");
                }  else if (response != answers[1]) { 
                    score = score + 0;
                    Console.WriteLine($"Uh oh! You were incorrect! Your score is {score}! ");
                };
                Console.WriteLine(questions[2]);
                response = Console.ReadLine();
                if (response == answers[2])
                {
                    score = score + 1;
                    Console.WriteLine($"You were correct! Your score is {score}! ");
                }
                else if (response != answers[2])
                {
                    score = score + 0;
                    Console.WriteLine($"Uh oh! You were incorrect! Your score is {score}! ");
                };
                Console.WriteLine(questions[3]);
                response = Console.ReadLine();
                if (response == answers[3])
                {
                    score = score + 1;
                    Console.WriteLine($"You were correct! Your score is {score}! ");
                }
                else if (response != answers[3])
                {
                    score = score + 0;
                    Console.WriteLine($"Uh oh! You were incorrect! Your score is {score}! ");
                };
                Console.WriteLine(questions[4]);
                response = Console.ReadLine();
                if (response == answers[4])
                {
                    score = score + 1;
                    Console.WriteLine($"You were correct! Your score is {score}! ");
                }
                else if (response != answers[4])
                {
                    score = score + 0;
                    Console.WriteLine($"Uh oh! You were incorrect! Your score is {score}! ");
                };
                Console.WriteLine($"Game over! Your final score is {score}!");
            }   

        }
    }
}
