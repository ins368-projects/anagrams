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
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>(){{"ehllo", words}};
            
           Assert.Equal(group, expected);
      }

      [Fact]
      public void ComputeAnagrams_TwoPossibleAnagramsInput_ReturnTwoAnagrams()
      {
           var words = new List<string>(){"hello", "ehllo", "bc", "cb"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() 
           {{"ehllo", new List<string>() {"hello", "ehllo"}}, {"bc", new List<string>() {"bc", "cb"}}};
            
           Assert.Equal(group, expected);
            
      }

      [Fact]
      public void ComputeAnagrams_TwoPossibleAnagramsWithUpperCaseLetters_ReturnTwoAnagramsInLowerCase()
      {
           var words = new List<string>(){"Hello", "ehLlo", "Bc", "cB"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() {{"ehllo", new List<string>() {"hello", "ehllo"}}, {"bc", new List<string>() {"bc", "cb"}}};
            
           Assert.Equal(group, expected);
            
      }

     [Fact]
      public void ComputeAnagrams_TwoPossibleAnagramsWithSpace_ReturnTwoAnagramsWithoutSpace()
      {
           var words = new List<string>(){"Hello ", "ehLlo", "Bc", " cB"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() 
           {{"ehllo", new List<string>() {"hello", "ehllo"}}, {"bc", new List<string>() {"bc", "cb"}}};
            
           Assert.Equal(group, expected);
      }

     [Fact]
      public void ComputeAnagrams_NoPossibleAnagrams_ReturnDictionaryListLenghtOne()
      {
           var words = new List<string>(){"HEllo", "bc"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() 
           {{"ehllo", new List<string>() {"hello"}}, {"bc", new List<string>() {"bc"}}};

           Assert.Equal(group, expected);
      }

      [Fact]
      public void ComputeAnagrams_3WordsWithSameLeght_ReturnAnagram()
      {
           var words = new List<string>(){"HEllo", "elloh", "pleas"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() 
           {{"ehllo", new List<string>() {"hello", "elloh"}}, {"aelps", new List<string>() {"pleas"}}};

           Assert.Equal(group, expected);
      }

      [Fact]
      public void ComputeAnagrams_2PosibleAnagramsWithApostrophe_ReturnAnagram()
      {
           var words = new List<string>(){"HEll'o", "el'loh", "pleas"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() 
           {{"'ehllo", new List<string>() {"hell'o", "el'loh"}}, {"aelps", new List<string>() {"pleas"}}};

           Assert.Equal(group, expected);
      }
      [Fact]
      public void ComputeAnagrams_3WordsAndPosibleAnagramWithAccent_ReturnOneAnagram()
      {
           var words = new List<string>(){ "ónacci", "acción","camión"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           Dictionary<string, List<string>> expected = new Dictionary<string, List<string>>() 
           {{"accinó", new List<string>() {"ónacci","acción"}}, {"acimnó", new List<string>() {"camión"}}};

           Assert.Equal(group, expected);
      }

      [Fact]
      public void ComputeAnagrams_2WordsDiffersByAnAccent_ReturnTwoDifferentDictionaryList()
      {
           var words = new List<string>(){ "accion", "acción"};
           Dictionary<string, List<string>> group = _anagram.ComputeAnagrams(words);
           
           var dictionaryLenght = group.Keys.Count;

           Assert.Equal(2, dictionaryLenght);
      }
  }
}