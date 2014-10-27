using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.etl {

	public class ETL {

		public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> p_oldValues) {

			var newValues = new Dictionary<string, int>();

			foreach(KeyValuePair<int, IList<string>> oldValues in p_oldValues) {
				var key = oldValues.Key;

				foreach(string value in oldValues.Value) {
					newValues.Add(value.ToLower(), key);
				}
			}

			return newValues;
		}
	}
}
