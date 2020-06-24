using System;
using System.Linq;

namespace Anagram
{
  public class StringHelper
  {
    public static string ToLowerCase(string word) => word.ToLower();

    public static string Trim(string word) => word.Trim();

		public static string SortAlphabetically(string word) => String.Concat(word.OrderBy(c => c));
  }
}
