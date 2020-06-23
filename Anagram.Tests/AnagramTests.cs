using System;
using Xunit;
using Anagram;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Anagram.Tests
{
  public class AnagramTests
  {
    readonly Anagram _anagram;

    public AnagramTests() => _anagram = new Anagram();

    [Theory]    
    [MemberData(nameof(DataForGroupWordsByCharacteresQuantityTest))]     
    public void GroupWordsByCharactersQuantityTest(List<string> words, List<List<string>> expectedResult)
    {
      List<List<string>> grouped = _anagram.GroupWordsByCharactersQuantity(words);
      Assert.Equal(expectedResult, grouped);
    }

    public static IEnumerable<object[]> DataForGroupWordsByCharacteresQuantityTest =>
      new List<object[]> 
      {
        new object[] 
        { 
          new List<string>() { "hello", "hlole", "lleho", "ax", "xa", "a", "b" },
          new List<List<string>>
          {
            new List<string>() { "hello", "hlole", "lleho" },
            new List<string>() { "ax", "xa" }
          }
        },

        new object[]
        {
          new List<string>() { "dedo", "odito", "odot", "oded", "jjjjjjj", "kkkkkkk"},
          new List<List<string>>()
          {
              new List<string>() { "dedo", "odot", "oded" },
              new List<string>() { "odito" },
              new List<string>() { "jjjjjjj", "kkkkkkk"}
          }
        }
      };
  }
}