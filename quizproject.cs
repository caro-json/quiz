using System;
using System.Formats.Asn1;
using System.Globalization;
using Microsoft.VisualBasic;

namespace quiz  // Note: actual namespace depends on the project name.
{
    public class StartUI
    {
        public static void Main()
        {
            Program program = new Program();
            program.StartUI();
        }
    }
    internal class Program
    {
        public void StartUI()
        {

            while (true)
            {
            Console.WriteLine("Välkommen till Quiz var vänligen gör ett val");
            Console.WriteLine("[1] Spela Quiz");
            Console.WriteLine("[2] Skapa Quiz");
            Console.WriteLine("[3]Jag ångrar mig vill inte längre spela");
            string choice = Console.ReadLine()+"";

                switch (choice)
            {
                case "1":
                    StartGame();
                    PlayQuiz();
                    break;

                case "2":
                    MyClass.Admin();
                    break;

                case "3":
                    Console.WriteLine("Tack för att du spelade Quiz. Tryck på valfri tangent för att avsluta.");
                    Console.ReadKey();
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Ogiltigt val. Försök igen.");
                    break;
            }
        }
    }

    private static void StartGame()
    {
        Console.WriteLine("Välkommen till Quiz! Var vänlig gör ett val:");
    }

    private static void PlayQuiz()
    {
        Console.WriteLine("Välj ett quizämne:");

        // Skapa frågor för quizet
        List<QuizQuestion> questions = new List<QuizQuestion>
            {
                new QuizQuestion("Vad är huvudstaden i Sverige?", new List<string> { "Oslo", "Stockholm", "Helsingfors", "Köpenhamn" }, "Stockholm"),
                new QuizQuestion("Vilket år grundades Microsoft?", new List<string> { "1975", "1985", "1995", "2005" }, "1975"),
                new QuizQuestion("Vilken färg har en banan?", new List<string> { "Röd", "Blå", "Gul", "Grön" }, "Gul"),
            };

        int score = 0;

        // Visa och besvara varje fråga
        foreach (var question in questions)
        {
            Console.WriteLine($"\nFråga: {question.Question}");
            for (int i = 0; i < question.Options.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {question.Options[i]}");
            }

            Console.Write("Svara (1-4): ");
            int userChoice = int.Parse(Console.ReadLine()+"") - 1;

            if (userChoice >= 0 && userChoice < question.Options.Count && question.Options[userChoice] == question.CorrectAnswer)
            {
                Console.WriteLine("Rätt svar!\n");
                score++;
            }
            else
            {
                Console.WriteLine($"Fel! Rätt svar är: {question.CorrectAnswer}\n");
            }


        }

        // Visa resultat
        Console.WriteLine($"Du fick {score} av {questions.Count} frågor rätt.");
    }


        class QuizQuestion
        {
            public string Question { get; }
            public List<string> Options { get; }
            public string CorrectAnswer { get; }

            public QuizQuestion(string question, List<string> options, string correctAnswer)
            {
                Question = question;
                Options = options;
                CorrectAnswer = correctAnswer;
            }
        }




        public class MyClass
        {
            public static void Admin()
            {
                Program program = new Program();
                program.Admin();

            }
        }

            public class CreatQuiz
            {

            public static void Create()
            {

                    while (true)
                {
                    Console.WriteLine("[1] Skapa ny frågesport");
                    Console.WriteLine("[2] Skriv frågor");
                    Console.WriteLine("[3] Skriv fråga med flervals alternativ");
                    Console.WriteLine("[4] Skriv fråga som ingår ett årtal");
                    Console.WriteLine("[5] Skriv fråga med en skala från 1-10");
                    Console.WriteLine("[6] Skriv fråga med 1, X, 2");
                    Console.WriteLine("[7] Orkar inte skriva frågor. Jag lämnar över till AI");

                    string choice = Console.ReadLine() + "";

                    switch (choice)
                    {
                        case "1":

                            Console.WriteLine("Vad för ämne vill du ha i frågesport?");
                            string topic = Console.ReadLine() + "";

                            Console.WriteLine("Hur många frågor vill du ha?");
                            int number = int.Parse(Console.ReadLine() + "");

                            Topics1();

                            break;

                        case "2":

                            Console.WriteLine("Vad är FRÅGAN, SKRIV IN");
                            string text = Console.ReadLine() + "";

                            Console.WriteLine("Vad är SVARET, SKRIV IN");
                            string svar = Console.ReadLine() + "";

                            Console.WriteLine("Vad är FRÅGAN, SKRIV IN");
                            string text2 = Console.ReadLine() + "";

                            Console.WriteLine("Vad är SVARET, SKRIV IN");
                            string svar2 = Console.ReadLine() + "";

                            break;

                        case "3":

                            Console.WriteLine("SKRIV IN: FRÅGA med FLERA VAL");
                            string text3 = Console.ReadLine() + "";

                            Console.WriteLine("Alternativ 1, SKRIV IN");
                            string svar3 = Console.ReadLine() + "";

                            Console.WriteLine("Alternativ 2, SKRIV IN");
                            string svarA = Console.ReadLine() + "";

                            Console.WriteLine("Alternativ 3, SKRIV IN");
                            string svarB = Console.ReadLine() + "";

                            Console.WriteLine("Alternativ 4, SKRIV IN");
                            string svarC = Console.ReadLine() + "";

                            break;

                        case "4":

                            Console.WriteLine("Vad är frågan med ÅRTAL, SKRIV IN");
                            int yearQuestion = int.Parse(Console.ReadLine() + "");

                            Console.WriteLine("Vad är svaret, SKRIV IN");
                            int yearAnswer = int.Parse(Console.ReadLine() + "");


                            break;

                        case "5":

                            Console.WriteLine("SKRIV IN en fråga med skala 1-10");
                            string scaleQuestion = Console.ReadLine() + "";

                            System.Console.WriteLine("Vad är SIFFRAN från SKALA 1-10");
                            int scaleAnswer = int.Parse(Console.ReadLine() + "");

                            break;

                        case "6":
                            Console.WriteLine("SKRIV IN: Fråga med 1, X, 2");
                            Console.WriteLine("SKRIV IN: Fråga med 1");
                            string text11 = Console.ReadLine() + "";

                            Console.WriteLine("Svar 1, SKRIV IN");
                            string svar11 = Console.ReadLine() + "";

                            Console.WriteLine("Fråga X, SKRIV IN");
                            string textX = Console.ReadLine() + "";

                            Console.WriteLine("Svar X , SKRIV IN");
                            string svarX = Console.ReadLine() + "";

                            Console.WriteLine("Fråga  2, SKRIV IN");
                            string text22 = Console.ReadLine() + "";

                            Console.WriteLine("Svar 2, SKRIV IN");
                            string svar22 = Console.ReadLine() + "";

                            break;

                        case "7":

                            Console.WriteLine("VAD VILL DU GÖRA NU?");
                            Console.WriteLine("Tryck på valfri Tangent för att avsluta");
                            Console.ReadKey();
                            Environment.Exit(0);

                            break;


                    }

                }
            }
                static void Topics1()
                {
                    TopicOfQuiz();
                }
                static void TopicOfQuiz()
                {

                    QuizTopic[] topics = new QuizTopic[]
                    {
                        new QuizTopic("Program code language, 1. C# 2. Python 3. Java 4. JavaScript 5. Numbpy"),
                        new QuizTopic("Popular sport, 1. Fotboll 2. Basket 3. Badminton 4. Tennis  5. Pingis"),
                        new QuizTopic("Popular Cities in Sweden 1. Göteborg 2. Stockholm 3. Jönköping 4. Linköping 5. Halmstad"),
                        new QuizTopic("Popular job 1. Chef 2. Waiter 3. Restaurant manager 4. Chef boss 5. Owner of restaurant ")
                    };

                    foreach (QuizTopic topic in topics)
                    {
                        topic.PrintInfo();
                    }

                }

            



        }
    }

    class QuizTopic
    {
        public string Question { get; set; }
        public QuizTopic(string question)
        {
            Question = question;
        }
        public void PrintInfo()
        {
            Console.WriteLine(Question);
        }
    }
}
