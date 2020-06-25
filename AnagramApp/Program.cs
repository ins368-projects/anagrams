using System;
using Anagram;

namespace AnagramApp
{
    class Program
    {
        static void Main(string[] args)
        {
            FileManager fileManager = new FileManager();
            Console.Write("Digite el path del archivo para buscar anagramas: ");
            string filePath = Console.ReadLine();

            var wordGroups = fileManager.GetAnagrams(filePath);
            foreach (var wordGroup in wordGroups){
                foreach(var word in wordGroup.Value){
                    Console.Write($"{word} ");
                }
                Console.WriteLine();
            }
        }
    }
}
