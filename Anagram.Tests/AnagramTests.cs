using System;
using Xunit;
using Anagram;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;

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

      [Fact]
      public void ComputeAnagrams_GetList_ReturnDictionary()
      {
            var words = new List<string>();
            Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
      }

      [Fact]
      public void ComputeAnagrams_KeySavesWordSortedAlphabetically_ReturnDictionaryWithAlphabeticallySortedKey()
      {
            var words = new List<string>(){"hello"};
            Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
            Dictionary<string, List<string>> expected = new Dictionary<string, List<string>> {"ehllo", words};
            
            Assert.Equal(group, expected);
            
      }

      //[Fact]
      //public void ComputeAnagrams_TwoPossibleAnagramsInput_ReturnTwoAnagrams()
      //{
           // var words = new List<string>(){"hello", "ehllo", "bc", "cb"};
           // Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           // Dictionary<string, List<string>> expected = new Dictionary<string, List<string>> 
           // {"ehllo", new List<string>() {"hello", "ehllo"}, {"bc", new List<string>() {"bc", "cb"}}};
            
            //Assert.Equal(group, expected);
            
      //}
       



 

  
  }
}