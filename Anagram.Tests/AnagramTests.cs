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
    public void GroupWordsByCharactersQuantityTest(List<string> words, Dictionary <int, List<string>> expectedResult)
    {
      Dictionary<int, List<string>> grouped = _anagram.GroupWordsByCharactersQuantity(words);
      Assert.Equal(expectedResult, grouped);
    }

    public static IEnumerable<object[]> DataForGroupWordsByCharacteresQuantityTest =>
      new List<object[]> 
      {
        new object[] 
        { 
          new List<string>() { "hello", "hlole", "lleho", "ax", "xa", "a", "b" },
          new Dictionary <int, List<string>>()
          {
            { 5, new List<string>() { "hello", "hlole", "lleho" }},
            { 2, new List<string>() { "ax", "xa" }}
          }
        },

        new object[]
        {
          new List<string>() { "dedo", "odito", "odot", "oded", "jjjjjjj", "kkkkkkk"},
          new Dictionary <int, List<string>>()
          {
              { 4, new List<string>() { "dedo", "odot", "oded" }},
              { 5, new List<string>() { "odito" }},
              { 7, new List<string>() { "jjjjjjj", "kkkkkkk" }}
          }
        }
      };

      /* new List<List<string>>
          {
            new List<string>() { "hello", "hlole", "lleho" },
            new List<string>() { "ax", "xa" }
          }
          */
  }
}