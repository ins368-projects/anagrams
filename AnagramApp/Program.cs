using System;
using static System.Console;
using System.Diagnostics;
using Anagram;

namespace AnagramApp
{
  class Program
  {
    static void Main(string[] args)
    {
			// Watch execution time.
			var watch = System.Diagnostics.Stopwatch.StartNew();

      
			Write("Digite el path del archivo para buscar anagramas: ");
      
			string filePath = ReadLine();
      var fileManager = new FileManager();
      var anagramsList = fileManager.GetAnagrams(filePath);

      foreach (var anagrams in anagramsList)
      {
				foreach (var word in anagrams.Value)
          Write($"{word} ");

        WriteLine("");
			}

			watch.Stop();

			// Print execution time.
			WriteLine($"\n---\nExecution time: {watch.ElapsedMilliseconds}\n---");
    }
  }
}
