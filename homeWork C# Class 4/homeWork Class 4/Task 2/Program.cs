using System;

namespace Task3
{
    class Program
    {
        public static void WordFinder(string sentence)
        {
            string[] splittedSentence = sentence.Split(" "); // , . : ; primer i drugi simboli kako char[]

            foreach (string word in splittedSentence)
            {
                Console.WriteLine(word);
            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the sentence: ");
            Console.Write("\n");
            string input = Console.ReadLine();

                Console.WriteLine("\n");
                Console.WriteLine("The words are:");
                Console.Write("\n");
                WordFinder(input);
            
        
            Console.ReadLine();
            }
        }
    }
