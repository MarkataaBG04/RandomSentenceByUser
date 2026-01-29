using System;

namespace RandomSentenceByUser
{
    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names =
                            {
                                "Peter", "Michell", "Jane", "Steve", "Alex", "Daniel",
                                "Maria", "Anna", "George", "Victor", "Elena", "Nikolay",
                                "Ivan", "Martin", "Chris", "Sarah"
                            };

            string[] places =
                            {
                                "Sofia", "Plovdiv", "Varna", "Vratsa", "London", "Paris",
                                "Berlin", "Rome", "Madrid", "New York", "Tokyo", "Barcelona",
                                "Vienna", "Prague", "Amsterdam"
                            };

            string[] verbs =
                            {
                                "eats", "holds", "sees", "plays with", "brings",
                                "throws", "finds", "loses", "admires", "builds",
                                "breaks", "follows", "chases", "fixes", "buys"
                            };

            string[] nouns =
                            {
                                "stones", "cake", "apple", "laptop", "bikes",
                                "a book", "a phone", "a dog", "a cat", "a backpack",
                                "a sandwich", "a ball", "a controller", "a keyboard"
                            };

            string[] adverbs =
                            {
                                "slowly", "diligently", "warmly", "sadly", "rapidly",
                                "happily", "angrily", "carefully", "silently", "loudly",
                                "nervously", "confidently", "curiously", "politely"
                            };

            string[] details =
                            {
                                "near the river", "at home", "in the park", "on the street",
                                "at the beach", "in the office", "during the night",
                                "before sunset", "after work", "in the city center"
                            };


            ConsoleColor[] colors =
                    {
                        ConsoleColor.Red,
                        ConsoleColor.Green,
                        ConsoleColor.Yellow,
                        ConsoleColor.Cyan,
                        ConsoleColor.Magenta,
                        ConsoleColor.Blue,
                        ConsoleColor.White
                    };

            Console.WriteLine($"Hello, this is your first random-generated sentence:");
            Console.WriteLine($"==========================");

            

            while (true)
            {


                string sentence = GenerateSentence(names, places, verbs, nouns, adverbs, details);
                SetRandomColor(colors);
                Console.WriteLine(sentence);
                Console.ResetColor();
                Console.WriteLine("Press [Enter] to generate a new sentence or type 'exit' to quit.");
                

                string input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }
            }

        }

        static string GenerateSentence(
                   string[] names,
                   string[] places,
                   string[] verbs,
                   string[] nouns,
                   string[] adverbs,
                   string[] details)
        {
            string who = $"{GetRandomWord(names)} from {GetRandomWord(places)}";
            string action = $"{GetRandomWord(adverbs)} {GetRandomWord(verbs)} {GetRandomWord(nouns)}";
            string detail = GetRandomWord(details);

            return $"{who} {action} {detail}.";
        }

        static Random random = new Random();
        static string GetRandomWord(string[] words) 
        {
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];

            return word;
        }

        static void SetRandomColor(ConsoleColor[] colors)
        {
            int index = random.Next(colors.Length);
            Console.ForegroundColor = colors[index];
        }
    }
}
