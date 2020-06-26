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
            return anagram.ComputeAnagrams(words);
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
    }

}