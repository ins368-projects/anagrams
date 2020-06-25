using System;
using System.Collections.Generic;
using System.IO;
using Anagram;
namespace AnagramApp
{
    public class FileManager
    {

        public Dictionary<string, List<string>> GetAnagrams(string filePath)
        {
            List<string> words = ReadFile(filePath);
            Anagram.Anagram anagram = new Anagram.Anagram();
            return FilterDict(anagram.ComputeAnagrams(words));
        }

        private List<string> ReadFile(string filePath)
        {
            List<string> unfilteredWordList = null;
            try{
                unfilteredWordList = new List<string>(File.ReadAllLines(@filePath));
            } catch (Exception e){
                Console.WriteLine(e.StackTrace);
            }
            return unfilteredWordList;
        }

        private Dictionary<string, List<string>> FilterDict(Dictionary<string, List<string>> dict)
        {
            foreach (var anagram in dict)
            {
                bool doesNotHaveAnagrams = anagram.Value.Count == 1;
                if (doesNotHaveAnagrams)
                {
                    dict.Remove(anagram.Key);
                }
            }
            return dict;
        }



    }

}