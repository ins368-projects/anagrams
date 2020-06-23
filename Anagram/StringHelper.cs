using System;
using System.Linq;

namespace Anagram
{
  public class StringHelper
  {
    public string ToLower(string word)
    {
      return word.ToLower();
    }

    public string Trim(string word)
    {
      return word.Trim();
    }

		public string SortAlphabetically(string word)
		{
			return String.Concat(word.OrderBy(c => c));
		}
  }
}
