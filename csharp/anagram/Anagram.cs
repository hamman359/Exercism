using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Anagram
{
	public char[] Characters { get; private set; }
	public int WordLength { get; private set; }

	public Anagram(string word)
	{
		Characters = word.ToCharArray();
		WordLength = word.Length;
	}

	public object Match(String[] words)
	{
		IList<string> matches = new List<string>();

		foreach (String word in words.Where(x => x.Length == WordLength))
		{
			var chars = word.ToCharArray();

			bool charsAny = chars.Any(x => !Characters.Contains(x));
			if (charsAny)
			{
				continue;
			};

			matches.Add(word);
			//if(word.Length > Characters.Length)
			//{
			//	continue;
			//}
		}

		return matches.OrderBy(x => x).ToArray();
	}
}
