using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    public Dictionary<int, List<string>> GroupWordsByCharactersQuantity(List<string> words)
    {
      var groups = new Dictionary<int, List<string>>();

      foreach(string word in words)
      {
        if(word.Length == 1)
          continue;
        
        var lowerCaseWord = StringHelper.ToLowerCase(word);

        int quantity = word.Length;
        
        if(groups.ContainsKey(quantity))
          groups[quantity].Add(lowerCaseWord);
        else 
          groups.Add(quantity, new List<string>() { lowerCaseWord});
      }

      return groups; 
      
    }
  }
}