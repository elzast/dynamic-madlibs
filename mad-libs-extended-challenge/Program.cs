using System;

namespace mad_libs_extended_challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a first adjective");
            Console.Write("Adjective 1: ");
            string adj1;
            adj1 = Console.ReadLine();

            Console.WriteLine("Give me a second adjective");
            Console.Write("Adjective 2: ");

            string adj2;
            adj2 = Console.ReadLine();


            Console.WriteLine("Give me a third adjective");
            Console.Write("Adjective 3: ");
            string adj3;
            adj3 = Console.ReadLine();


            Console.WriteLine("Give me a fourth adjective");
            Console.Write("Adjective 4: ");
            string adj4;
            adj4 = Console.ReadLine();


            Console.WriteLine("Give me a first noun");
            Console.Write("Noun 1: ");
            string noun1;
            noun1 = Console.ReadLine();

            Console.WriteLine("Give me a second noun");
            Console.Write("Noun 2: ");
            string noun2;
            noun2 = Console.ReadLine();


            Console.WriteLine("Give me a third noun");
            Console.Write("Noun 3: ");
            string noun3;
            noun3 = Console.ReadLine();

            Console.WriteLine("Give me a first past tense verb");
            Console.Write("Verb (Past Tense) 1: ");
            string pastVerb1;
            pastVerb1 = Console.ReadLine();

            Console.WriteLine("Give me a second past tense verb");
            Console.Write("Verb (Past Tense) 2: ");
            string pastVerb2;
            pastVerb2 = Console.ReadLine();


            Console.WriteLine("Give me a first adverb");
            Console.Write("Adverb 1: ");
            string adverb1;
            adverb1 = Console.ReadLine();

            Console.WriteLine("Give me a second adverb");
            Console.Write("Adverb 2: ");
            string adverb2;
            adverb2 = Console.ReadLine();


            Console.WriteLine("Give me a verb");
            Console.Write("Verb: ");
            string verb;
            verb = Console.ReadLine();

            Console.WriteLine($"Today I went to the zoo. I saw a {adj1} {noun1} jumping up and down in its tree. He {pastVerb1} {adverb1} through the large tunnel that lead to its {adj2} {noun2}. I got some peanuts and passed them through the cage to the gigantic gray {noun3} towering above my head. Feeding that animal made me hungry. I went to get a {adj3} scoop of ice cream. It filled my stomach. Afterwards I had to {verb} {adverb2} to catch our bus. When I got home I {pastVerb2} my mom for a {adj4} day at the zoo.");


            //This will keep the Console open.  KEEP THIS OPEN SO IT DOESN'T JUST FLASH!!!
            Console.ReadLine();
        }
    }
}
