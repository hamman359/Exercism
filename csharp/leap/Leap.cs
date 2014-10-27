using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercismCSharp.leap {

	public class Leap {

		// Quick and dirty leap year check
		public static bool IsLeap(int year) {

			return IsEvenlyDivisibleBy4(year)
				&& (IsNotEvenlyDivisibleBy100(year) || (IsEvenlyDivisibleBy400(year)));
		}

		private static bool IsEvenlyDivisibleBy4(int year) {
			return year % 4 == 0;
		}

		private static bool IsNotEvenlyDivisibleBy100(int year) {
			return year % 100 != 0;
		}

		private static bool IsEvenlyDivisibleBy400(int year) {
			return year % 400 == 0;
		}
	}
}
