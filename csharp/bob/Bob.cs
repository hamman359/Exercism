using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.bob {

	public class Bob {

		public string Hey(string p_string) {

			if(string.IsNullOrWhiteSpace(p_string)) {
				return "Fine. Be that way!";
			}

			if(IsShouting(p_string)) {
				return "Whoa, chill out!";
			}

			if(IsAQuestion(p_string)) {
				return "Sure.";
			}

			return "Whatever.";
		}

		private static bool IsShouting(string p_string) {

			if(DoesNotContainAnyLetters(p_string)) {
				return false;
			}

			return p_string.ToUpper() == p_string;
		}

		private static bool IsAQuestion(string p_string) {

			return p_string.EndsWith("?");
		}

		private static bool DoesNotContainAnyLetters(string p_string) {

			return !p_string.Any(x => char.IsLetter(x));
		}
	}
}
