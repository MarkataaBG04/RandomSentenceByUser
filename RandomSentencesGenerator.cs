namespace RandomSentenceByUser
{
    internal class RandomSentencesGenerator
    {
        static void Main(string[] args)
        {
            string[] names = { "Peter", "Michell", "Jane", "Steve" };
            string[] places = { "Sofia", "Plovdiv", "Varna", "Vratsa" };
            string[] verbs = { "eats", "holds", "sees", "plays with", "brings" };
            string[] noun = { "stones", "cake", "apple", "laptop", "bikes" };
            string[] adverbs = { "slowly", "diligently", "warmly", "sadly", "rapidly" };
            string[] details = { "near the river", "at home", "in the park" };

            Console.WriteLine($"Hello, this is your first random-generated sentence:");

            while (true)
            {
                string randomName = GetRandomWord(names);
                string randomPlaces = GetRandomWord(places);
                string randomVerb = GetRandomWord(verbs);
                string randomNoun = GetRandomWord(noun);
                string randomAdverb = GetRandomWord(adverbs);
                string randomDetails = GetRandomWord(details);

                string who = $"{randomName} from {randomPlaces}";
                string action = $"{randomAdverb} {randomVerb} {randomNoun}";
                string sentence = $"{who} {action} {randomDetails}";
                Console.WriteLine(sentence);
                Console.WriteLine($"Click [Enter] to generate a new one.");

                Console.ReadLine();
            }

        }

        static string GetRandomWord(string[] words) 
        {
            Random random = new Random();
            int randomIndex = random.Next(words.Length);
            string word = words[randomIndex];

            return word;
        }

    }
}
