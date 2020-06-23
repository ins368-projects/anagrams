using System;
using Xunit;
using Anagram;

namespace Anagram.Tests
{
  public class SortHelperTests
  {
    [Theory]    
    [InlineData("HELLO", "hello")]    
    [InlineData("OLITA", "olita")]    
    public void IsUpperCase_InputIsAnyWord_ReturnWordToLowerCase(string word, string expected)
    {
      string lowerCaseWord = StringHelper.ToLowerCase(word);
      Assert.Equal(expected, lowerCaseWord);
    }
    
    [Theory]    
    [InlineData("hello world ", "hello world")]    
    [InlineData(" olita", "olita")]
    [InlineData(" ghe ","ghe")]    
    public void Remove_Whitespace(string word, string expected)
    {
      string withoutWhitespace = StringHelper.Trim(word);
      Assert.Equal(withoutWhitespace,expected);
    }
  
    [Theory]    
    [InlineData("hola", "ahlo")]    
    [InlineData("bca", "abc")]
    [InlineData("BCA", "ABC")]
    [InlineData("ab'c", "'abc")]
    public void OrderAlphabetically_AnyString(string word, string expected)
    {
      string sorted = StringHelper.SortAlphabetically(word);
      Assert.Equal(expected, sorted);
    }
  }
}