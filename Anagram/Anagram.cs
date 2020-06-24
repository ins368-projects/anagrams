using System.Collections.Generic;
using System.Linq;
using System;

namespace Anagram
{
  public class Anagram
  {
    public Dictionary<string, List<string>> ComputeAnagrams(List<string> words)
    {
       var anagrams = new Dictionary<string, List<string>>();
       foreach(string word in words)
       {
         var lowerCaseWord= word.ToLower().Trim();
         var ordered = String.Concat(lowerCaseWord.OrderBy(c => c));
         if(anagrams.ContainsKey(ordered)){
           anagrams[ordered].Add(lowerCaseWord);
         }
         else{
           anagrams.Add(ordered, new List<string>{lowerCaseWord});
         }
       }
       return anagrams;
    }
  }
}

