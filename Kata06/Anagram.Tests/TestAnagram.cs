using System;
using Xunit;
using Anagram;

namespace Anagram.Tests
{
  public class TestAnagram
  {
    private readonly StringHelper _stringHelper;

    public TestAnagram() => _stringHelper = new StringHelper();

    [Theory]    
    [InlineData("HELLO", "hello")]    
    [InlineData("OLITA", "olita")]    
    public void IsUpperCase_InputIsAnyWord_ReturnWordToLowerCase(string word, string expected)
    {
      string lowerCaseWord = _stringHelper.ToLower(word);
      Assert.Equal(expected, lowerCaseWord);
    }
    
    [Theory]    
    [InlineData("hello world ", "hello world")]    
    [InlineData(" olita", "olita")]    
    public void Remove_Whitespace(string word, string expected)
    {
      string withoutWhitespace = _stringHelper.Trim(word);
      Assert.Equal(withoutWhitespace ,expected);
    }
  
  }
}