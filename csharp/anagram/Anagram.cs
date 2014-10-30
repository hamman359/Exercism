using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Anagram
{
	private readonly string _originalWord;
	private readonly int _wordLength;

	public Anagram(string word)
	{
		_originalWord = word;
		_wordLength = word.Length;
	}

	public object Match(String[] words)
	{
		IList<string> matches = new List<string>();

		foreach (string word in GetMatchableWords(words))
		{
			if (IsAnagram(word))
			{
				matches.Add(word);
			};
		}

		return matches.OrderBy(x => x).ToArray();
	}

	/// <summary>
	/// Returns a string containing the letters of the provided string rearranged
	/// in alphabetical order. This allows for easy comparison of all the letters
	/// in a word to determine if they are the same.
	/// </summary>
	private static string RearrangeLettersAlphatetically(string word)
	{
		var orderedChars = word.ToLower()
								.ToCharArray()
								.OrderBy(x => x)
								.ToArray();

		return new string(orderedChars);
	}

	/// <summary>
	/// Returns a list of words that are possible anagrams for the original word.
	/// A word is not considered a possible match if:
	/// 	- it is not the same length as the word we are looking for anagrams
	/// 	  in since a word cannot be an anagram of another word if both words
	/// 	  are not the same length.
	/// 	- it is the same word (case ignored) as the original word.
	/// </summary>
	private IEnumerable<string> GetMatchableWords(String[] words)
	{
		return words.Where(x => x.Length == _wordLength)
					.Where(x => x.ToLower() != _originalWord);
	}

	private bool IsAnagram(string word)
	{
		return RearrangeLettersAlphatetically(word) == RearrangeLettersAlphatetically(_originalWord);
	}
}

public static class CharExtensions
{
	public static bool ContainsAll(this string value, params char[] values)
	{
		foreach (char one in values)
		{
			if (!value.Contains(one))
			{
				return false;
			}
		}
		return true;
	}
}