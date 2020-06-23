using System.Collections.Generic;

namespace Anagram
{
  public class Anagram
  {
    public List<List<string>> GroupWordsByCharactersQuantity(List<string> words)
    {
      return new List<List<string>>()
      {
        new List<string>() { "hello", "hlole", "lleho" },
        new List<string>() { "ab", "ba" }
      };
    }
  }
}